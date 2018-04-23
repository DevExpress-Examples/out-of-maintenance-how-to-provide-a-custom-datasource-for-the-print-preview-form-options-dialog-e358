using System;
using System.Drawing;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.XtraTab;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Frames;
using DevExpress.Utils.Controls;
using DevExpress.XtraGrid.Design;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.Utils.Text;

namespace CustomPrintPreview.Grid {
    public partial class CustomGridViewPrinting :XtraFrame, IPrintDesigner {
        GridControl GridPreview;
        ImageCollection Images;
        int LockApply;
        string[] PrintFlags = new string[] {
            "PrintHeader", "PrintPreview", "PrintFooter", "PrintGroupFooter", "PrintHorzLines", 
            "PrintVertLines", "PrintFilterInfo", "PrintDetails", "AutoWidth", "ExpandAllDetails", 
            "ExpandAllGroups", "UsePrintStyles", "EnableAppearanceEvenRow", "EnableAppearanceOddRow", 
            "PrintBandHeader", "PrintSelectedRowsOnly"
        };
        GridColumn GroupColumn;

        CustomGridViewPrinting() : base(8) {
            InitializeComponent();
        }

        public CustomGridViewPrinting(GridControl grid, GridColumn groupColumn) : this() {
            PanelGridPreview.DockPadding.All = 4;
            GridPreview = grid;
            GridPreview.Dock = DockStyle.Fill;
            GridPreview.Parent = PanelGridPreview;
            Images = ImageHelper.CreateImageCollectionFromResources("DevExpress.XtraGrid.Printing.GridPrintOptions.png",
                typeof(GridViewDesigner).Assembly, new Size(16, 16));
            this.GroupColumn = groupColumn;
        }

        bool fAutoApply = true;
        public bool AutoApply {
            get { return fAutoApply; }
            set { fAutoApply = value; }
        }

        CustomGridView EditingView {
            get { return (CustomGridView)EditingObject; }
        }

        GridView CurrentView {
            get { return (GridView)GridPreview.MainView; }
        }

        public Size UserControlSize {
            get { return TextUtils.GetScaleSize(new Size(560, 345)); }
        }

        void OnTabPageOptionsPaint(object sender, PaintEventArgs e) {
            PaintTabPage(e.Graphics, 0, 8);
            PrintImage(12, e.Graphics);
            PrintImage(13, e.Graphics);
            PrintImage(15, e.Graphics);
        }

        void PrintImage(int index, Graphics graphics) {
            PrintImage(CheckEditByIndex(index), graphics, Images.Images[index]);
        }

        void PrintImage(CheckEdit editor, Graphics graphics, Image image) {
            if (editor == null) return;
            int top = editor.Top + (editor.Height - image.Size.Height) / 2;
            int x = 10;
            if (editor.Checked)
                graphics.DrawImage(image, new Rectangle(x, top, image.Width, image.Height));
            else ControlPaint.DrawImageDisabled(graphics, image, x, top, SystemColors.Control);
        }

        CheckEdit CheckEditByIndex(int index) {
            foreach (XtraTabPage tp in TabControl.TabPages)
                foreach (Control c in tp.Controls)
                    if (c is CheckEdit && Convert.ToInt32(c.Tag) == index)
                        return (CheckEdit)c;
            return null;
        }

        void OnCheckBoxCheckStateChanged(object sender, EventArgs e) {
            InvalidateImage((CheckEdit)sender);
        }

        void InvalidateImage(CheckEdit editor) {
            editor.Parent.Invalidate(new Rectangle(0, editor.Top, 50, editor.Height));
            ApplyOptions();
        }

        void ApplyOptions() {
            ApplyOptions(AutoApply);
        }

        protected virtual void ApplyOptions(bool setOptions) {
            if (LockApply != 0) return;
            for (int i = 0; i < PrintFlags.Length; i++) {
                CheckEdit chb = CheckEditByIndex(i);
                if (chb != null)
                    SetOptions.SetOptionValueByString(PrintFlags[i], setOptions ? EditingView.OptionsPrint :
                        CurrentView.OptionsPrint, chb.Checked);
            }
            EditingView.FireChangedInternal();
        }

        void OnCheckBoxHorzLinesCheckStateChanged(object sender, EventArgs e) {
            CurrentView.OptionsView.ShowHorzLines = CheckBoxHorzLines.Checked;
            InvalidateImage(CheckBoxHorzLines);
        }

        void OnCheckBoxVertLinesCheckStateChanged(object sender, EventArgs e) {
            CurrentView.OptionsView.ShowVertLines = CheckBoxVertLines.Checked;
            InvalidateImage(CheckBoxVertLines);
        }

        void OnCheckBoxFooterCheckStateChanged(object sender, EventArgs e) {
            CurrentView.OptionsView.ShowFooter = CheckBoxFooter.Checked;
            InvalidateImage(CheckBoxFooter);
        }

        void OnCheckBoxPreviewCheckStateChanged(object sender, EventArgs e) {
            CurrentView.OptionsView.ShowPreview = CheckBoxPreview.Checked;
            InvalidateImage(CheckBoxPreview);
        }

        void OnCheckBoxHeaderCheckStateChanged(object sender, EventArgs e) {
            CurrentView.OptionsView.ShowColumnHeaders = CheckBoxHeader.Checked;
            InvalidateImage(CheckBoxHeader);
        }

        void OnCheckBoxGroupFooterCheckStateChanged(object sender, EventArgs e) {
            if (GroupColumn != null) {
                if (CheckBoxGroupFooter.Checked)
                    GroupColumn.GroupIndex = 0;
                else {
                    GroupColumn.GroupIndex = -1;
                    GroupColumn.VisibleIndex = 3;
                }
            }
            CurrentView.ExpandAllGroups();
            CurrentView.FocusedRowHandle = -99;
            InvalidateImage(CheckBoxGroupFooter);
        }

        void OnCheckBoxStylesCheckStateChanged(object sender, EventArgs e) {
            OnCheckBoxCheckStateChanged(sender, e);
            InitViewStyles();
        }

        void OnCheckBoxDefaultStylesCheckStateChanged(object sender, EventArgs e) {
            OnCheckBoxStylesCheckStateChanged(sender, e);
            CheckBoxEvenRow.Enabled = CheckBoxOddRow.Enabled = CheckBoxDefaultStyles.Checked;
        }

        void InitViewStyles() {
            CurrentView.BeginUpdate();
            try {
                CurrentView.Appearance.Reset();
                if (CheckBoxDefaultStyles.Checked) {
                    GridViewPrintAppearances collection = ((BaseViewPrintInfo)typeof(
                        GridView).InvokeMember("CreatePrintInfoCore", BindingFlags.Instance | 
                        BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, 
                        CurrentView, new object[] { 
                            new PrintInfoArgs(CurrentView) })).AppearancePrint as
                            GridViewPrintAppearances;
                    if (collection != null) {
                        CurrentView.Appearance.Assign(collection);
                        CurrentView.Appearance.HorzLine.Assign(collection.Lines);
                        CurrentView.Appearance.VertLine.Assign(collection.Lines);
                    }
                } else CurrentView.Appearance.Assign(EditingView.PaintAppearance);
                CurrentView.Appearance.FooterPanel.BorderColor = CurrentView.Appearance.FooterPanel.BackColor;
                CurrentView.Appearance.HeaderPanel.BorderColor = CurrentView.Appearance.HeaderPanel.BackColor;
                CurrentView.Appearance.GroupFooter.BorderColor = CurrentView.Appearance.GroupFooter.BackColor;
                CurrentView.OptionsView.EnableAppearanceEvenRow = CheckBoxDefaultStyles.Checked ?
                    CheckBoxEvenRow.Checked : EditingView.OptionsView.EnableAppearanceEvenRow;
                CurrentView.OptionsView.EnableAppearanceOddRow = CheckBoxDefaultStyles.Checked ?
                    CheckBoxOddRow.Checked : EditingView.OptionsView.EnableAppearanceOddRow;
                CurrentView.Appearance.Empty.BackColor = CurrentView.Appearance.Empty.BackColor2 =
                    Color.White;
            } finally { CurrentView.EndUpdate(); }
        }

        void PaintTabPage(Graphics graphics, int startIndex, int endIndex) {
            for (int i = startIndex; i < endIndex; i++)
                PrintImage(i, graphics);
        }

        void OnTabPageBehaviorPaint(object sender, PaintEventArgs e) {
            PaintTabPage(e.Graphics, 8, 11);
        }

        void OnCheckBoxAutoWidthCheckStateChanged(object sender, EventArgs e) {
            CurrentView.OptionsView.ColumnAutoWidth = CheckBoxAutoWidth.Checked;
            InvalidateImage(CheckBoxAutoWidth);
        }

        protected override string DescriptionText {
            get { return GridLocalizer.Active.GetLocalizedString(GridStringId.PrintDesignerDescription); }
        }

        public override void InitComponent() {
            LockApply--;
            try {
                for (int i = 0; i < PrintFlags.Length; i++) {
                    CheckEdit chb = CheckEditByIndex(i);
                    if (chb != null) {
                        chb.Checked = SetOptions.OptionValueByString(PrintFlags[i], EditingView.OptionsPrint);
                        if (chb.Checked)
                            chb.Checked = true;
                    }
                }
            } finally { LockApply++; }
            CurrentView.OptionsView.BeginUpdate();
            try {
                OnCheckBoxHeaderCheckStateChanged(CheckBoxHeader, EventArgs.Empty);
                OnCheckBoxPreviewCheckStateChanged(CheckBoxPreview, EventArgs.Empty);
                OnCheckBoxFooterCheckStateChanged(CheckBoxFooter, EventArgs.Empty);
                OnCheckBoxGroupFooterCheckStateChanged(CheckBoxGroupFooter, EventArgs.Empty);
                OnCheckBoxHorzLinesCheckStateChanged(CheckBoxHorzLines, EventArgs.Empty);
                OnCheckBoxVertLinesCheckStateChanged(CheckBoxVertLines, EventArgs.Empty);
                OnCheckBoxAutoWidthCheckStateChanged(CheckBoxAutoWidth, EventArgs.Empty);
                OnCheckBoxDefaultStylesCheckStateChanged(CheckBoxDefaultStyles, EventArgs.Empty);
                OnCheckBoxStylesCheckStateChanged(CheckBoxEvenRow, EventArgs.Empty);
                OnCheckBoxStylesCheckStateChanged(CheckBoxOddRow, EventArgs.Empty);
                OnCheckBoxCheckStateChanged(CheckBoxSelectedRows, EventArgs.Empty);
            } finally { CurrentView.OptionsView.EndUpdate(); }
            CurrentView.AppearancePrint.Assign(EditingView.AppearancePrint);
            CurrentView.OptionsPrint.Assign(EditingView.OptionsPrint);
            InitViewStyles();
            lbCaption.Text = GridLocalizer.Active.GetLocalizedString(GridStringId.PrintDesignerGridView);
            CurrentView.PaintStyleName = "MixedXP";
        }
        
#region IPrintDesigner Members

        void IPrintDesigner.ApplyOptions(bool setOptions) {
            ApplyOptions(setOptions);
        }

        void IPrintDesigner.HideCaption() {
            lbCaption.Visible = horzSplitter.Visible = false;
        }

        #endregion
    }
}

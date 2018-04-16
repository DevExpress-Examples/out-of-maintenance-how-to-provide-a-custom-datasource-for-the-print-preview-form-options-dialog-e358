namespace CustomPrintPreview.Grid {
    public partial class CustomGridViewPrinting {
        void InitializeComponent() {
            this.PanelOptions = new DevExpress.XtraEditors.PanelControl();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.CheckBoxOddRow = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxEvenRow = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxGroupFooter = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxHeader = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CheckBoxPreview = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxFooter = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxVertLines = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxHorzLines = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxSelectedRows = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CheckBoxAutoWidth = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxDefaultStyles = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.PanelGridPreview = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horzSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOptions)).BeginInit();
            this.PanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxOddRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEvenRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxGroupFooter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxPreview.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxFooter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxVertLines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxHorzLines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSelectedRows.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefaultStyles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelGridPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCaption
            // 
            this.lbCaption.Size = new System.Drawing.Size(537, 24);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainerControl1);
            this.pnlMain.Size = new System.Drawing.Size(537, 380);
            // 
            // horzSplitter
            // 
            this.horzSplitter.Size = new System.Drawing.Size(537, 4);
            // 
            // PanelOptions
            // 
            this.PanelOptions.Controls.Add(this.TabControl);
            this.PanelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOptions.Location = new System.Drawing.Point(0, 0);
            this.PanelOptions.Name = "PanelOptions";
            this.PanelOptions.Size = new System.Drawing.Size(157, 380);
            this.PanelOptions.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.xtraTabPage1;
            this.TabControl.Size = new System.Drawing.Size(153, 376);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.CheckBoxOddRow);
            this.xtraTabPage1.Controls.Add(this.CheckBoxEvenRow);
            this.xtraTabPage1.Controls.Add(this.checkEdit2);
            this.xtraTabPage1.Controls.Add(this.CheckBoxGroupFooter);
            this.xtraTabPage1.Controls.Add(this.CheckBoxHeader);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.CheckBoxPreview);
            this.xtraTabPage1.Controls.Add(this.CheckBoxFooter);
            this.xtraTabPage1.Controls.Add(this.checkEdit1);
            this.xtraTabPage1.Controls.Add(this.CheckBoxVertLines);
            this.xtraTabPage1.Controls.Add(this.CheckBoxHorzLines);
            this.xtraTabPage1.Controls.Add(this.CheckBoxSelectedRows);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(147, 350);
            this.xtraTabPage1.Text = "Options";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabPageOptionsPaint);
            // 
            // CheckBoxOddRow
            // 
            this.CheckBoxOddRow.Location = new System.Drawing.Point(33, 270);
            this.CheckBoxOddRow.Name = "CheckBoxOddRow";
            this.CheckBoxOddRow.Properties.Appearance.Options.UseTextOptions = true;
            this.CheckBoxOddRow.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CheckBoxOddRow.Properties.AutoHeight = false;
            this.CheckBoxOddRow.Properties.Caption = "Odd Row Appearance";
            this.CheckBoxOddRow.Size = new System.Drawing.Size(97, 38);
            this.CheckBoxOddRow.TabIndex = 11;
            this.CheckBoxOddRow.Tag = "13";
            this.CheckBoxOddRow.CheckStateChanged += new System.EventHandler(this.OnCheckBoxStylesCheckStateChanged);
            // 
            // CheckBoxEvenRow
            // 
            this.CheckBoxEvenRow.Location = new System.Drawing.Point(33, 226);
            this.CheckBoxEvenRow.Name = "CheckBoxEvenRow";
            this.CheckBoxEvenRow.Properties.Appearance.Options.UseTextOptions = true;
            this.CheckBoxEvenRow.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CheckBoxEvenRow.Properties.AutoHeight = false;
            this.CheckBoxEvenRow.Properties.Caption = "Even Row Appearance";
            this.CheckBoxEvenRow.Size = new System.Drawing.Size(97, 38);
            this.CheckBoxEvenRow.TabIndex = 10;
            this.CheckBoxEvenRow.Tag = "12";
            this.CheckBoxEvenRow.CheckStateChanged += new System.EventHandler(this.OnCheckBoxStylesCheckStateChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(33, 176);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Filter";
            this.checkEdit2.Size = new System.Drawing.Size(75, 19);
            this.checkEdit2.TabIndex = 9;
            this.checkEdit2.Tag = "6";
            this.checkEdit2.CheckStateChanged += new System.EventHandler(this.OnCheckBoxCheckStateChanged);
            // 
            // CheckBoxGroupFooter
            // 
            this.CheckBoxGroupFooter.Location = new System.Drawing.Point(33, 101);
            this.CheckBoxGroupFooter.Name = "CheckBoxGroupFooter";
            this.CheckBoxGroupFooter.Properties.Caption = "Group Footer";
            this.CheckBoxGroupFooter.Size = new System.Drawing.Size(93, 19);
            this.CheckBoxGroupFooter.TabIndex = 8;
            this.CheckBoxGroupFooter.Tag = "3";
            this.CheckBoxGroupFooter.CheckStateChanged += new System.EventHandler(this.OnCheckBoxGroupFooterCheckStateChanged);
            // 
            // CheckBoxHeader
            // 
            this.CheckBoxHeader.Location = new System.Drawing.Point(33, 26);
            this.CheckBoxHeader.Name = "CheckBoxHeader";
            this.CheckBoxHeader.Properties.Caption = "Header";
            this.CheckBoxHeader.Size = new System.Drawing.Size(75, 19);
            this.CheckBoxHeader.TabIndex = 7;
            this.CheckBoxHeader.Tag = "0";
            this.CheckBoxHeader.CheckStateChanged += new System.EventHandler(this.OnCheckBoxHeaderCheckStateChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 20);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Print";
            // 
            // CheckBoxPreview
            // 
            this.CheckBoxPreview.Location = new System.Drawing.Point(33, 51);
            this.CheckBoxPreview.Name = "CheckBoxPreview";
            this.CheckBoxPreview.Properties.Caption = "Preview";
            this.CheckBoxPreview.Size = new System.Drawing.Size(75, 19);
            this.CheckBoxPreview.TabIndex = 5;
            this.CheckBoxPreview.Tag = "1";
            this.CheckBoxPreview.CheckStateChanged += new System.EventHandler(this.OnCheckBoxPreviewCheckStateChanged);
            // 
            // CheckBoxFooter
            // 
            this.CheckBoxFooter.Location = new System.Drawing.Point(33, 76);
            this.CheckBoxFooter.Name = "CheckBoxFooter";
            this.CheckBoxFooter.Properties.Caption = "Footer";
            this.CheckBoxFooter.Size = new System.Drawing.Size(75, 19);
            this.CheckBoxFooter.TabIndex = 4;
            this.CheckBoxFooter.Tag = "2";
            this.CheckBoxFooter.CheckStateChanged += new System.EventHandler(this.OnCheckBoxFooterCheckStateChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(33, 201);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Details";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 3;
            this.checkEdit1.Tag = "7";
            this.checkEdit1.CheckStateChanged += new System.EventHandler(this.OnCheckBoxCheckStateChanged);
            // 
            // CheckBoxVertLines
            // 
            this.CheckBoxVertLines.Location = new System.Drawing.Point(33, 151);
            this.CheckBoxVertLines.Name = "CheckBoxVertLines";
            this.CheckBoxVertLines.Properties.Caption = "Vertical Lines";
            this.CheckBoxVertLines.Size = new System.Drawing.Size(93, 19);
            this.CheckBoxVertLines.TabIndex = 2;
            this.CheckBoxVertLines.Tag = "5";
            this.CheckBoxVertLines.CheckStateChanged += new System.EventHandler(this.OnCheckBoxVertLinesCheckStateChanged);
            // 
            // CheckBoxHorzLines
            // 
            this.CheckBoxHorzLines.Location = new System.Drawing.Point(33, 126);
            this.CheckBoxHorzLines.Name = "CheckBoxHorzLines";
            this.CheckBoxHorzLines.Properties.Caption = "Horizontal Lines";
            this.CheckBoxHorzLines.Size = new System.Drawing.Size(106, 19);
            this.CheckBoxHorzLines.TabIndex = 1;
            this.CheckBoxHorzLines.Tag = "4";
            this.CheckBoxHorzLines.CheckStateChanged += new System.EventHandler(this.OnCheckBoxHorzLinesCheckStateChanged);
            // 
            // CheckBoxSelectedRows
            // 
            this.CheckBoxSelectedRows.Location = new System.Drawing.Point(33, 314);
            this.CheckBoxSelectedRows.Name = "CheckBoxSelectedRows";
            this.CheckBoxSelectedRows.Properties.Caption = "Selected Rows";
            this.CheckBoxSelectedRows.Size = new System.Drawing.Size(97, 19);
            this.CheckBoxSelectedRows.TabIndex = 0;
            this.CheckBoxSelectedRows.Tag = "15";
            this.CheckBoxSelectedRows.CheckStateChanged += new System.EventHandler(this.OnCheckBoxCheckStateChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.checkEdit4);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.checkEdit3);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.CheckBoxAutoWidth);
            this.xtraTabPage2.Controls.Add(this.CheckBoxDefaultStyles);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(147, 333);
            this.xtraTabPage2.Text = "Behavior";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTabPageBehaviorPaint);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(6, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(138, 20);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Use Styles";
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(43, 104);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "All Groups";
            this.checkEdit4.Size = new System.Drawing.Size(75, 19);
            this.checkEdit4.TabIndex = 5;
            this.checkEdit4.Tag = "10";
            this.checkEdit4.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckStateChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(3, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(141, 20);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Expand";
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(43, 79);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "All Details";
            this.checkEdit3.Size = new System.Drawing.Size(75, 19);
            this.checkEdit3.TabIndex = 3;
            this.checkEdit3.Tag = "9";
            this.checkEdit3.CheckStateChanged += new System.EventHandler(this.OnCheckBoxCheckStateChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(141, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Width";
            // 
            // CheckBoxAutoWidth
            // 
            this.CheckBoxAutoWidth.Location = new System.Drawing.Point(43, 29);
            this.CheckBoxAutoWidth.Name = "CheckBoxAutoWidth";
            this.CheckBoxAutoWidth.Properties.Caption = "Auto Width";
            this.CheckBoxAutoWidth.Size = new System.Drawing.Size(75, 19);
            this.CheckBoxAutoWidth.TabIndex = 1;
            this.CheckBoxAutoWidth.Tag = "8";
            this.CheckBoxAutoWidth.CheckStateChanged += new System.EventHandler(this.OnCheckBoxAutoWidthCheckStateChanged);
            // 
            // CheckBoxDefaultStyles
            // 
            this.CheckBoxDefaultStyles.Location = new System.Drawing.Point(43, 155);
            this.CheckBoxDefaultStyles.Name = "CheckBoxDefaultStyles";
            this.CheckBoxDefaultStyles.Properties.Caption = "Use Print Styles";
            this.CheckBoxDefaultStyles.Size = new System.Drawing.Size(98, 19);
            this.CheckBoxDefaultStyles.TabIndex = 0;
            this.CheckBoxDefaultStyles.Tag = "11";
            this.CheckBoxDefaultStyles.CheckStateChanged += new System.EventHandler(this.OnCheckBoxDefaultStylesCheckStateChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.PanelGridPreview);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(375, 380);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Preview:";
            // 
            // PanelGridPreview
            // 
            this.PanelGridPreview.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelGridPreview.Appearance.Options.UseBackColor = true;
            this.PanelGridPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGridPreview.Location = new System.Drawing.Point(2, 22);
            this.PanelGridPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.PanelGridPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PanelGridPreview.Name = "PanelGridPreview";
            this.PanelGridPreview.Size = new System.Drawing.Size(371, 356);
            this.PanelGridPreview.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.PanelOptions);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(537, 380);
            this.splitContainerControl1.SplitterPosition = 157;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // CustomGridViewPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomGridViewPrinting";
            this.Size = new System.Drawing.Size(537, 408);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horzSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOptions)).EndInit();
            this.PanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxOddRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEvenRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxGroupFooter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxPreview.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxFooter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxVertLines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxHorzLines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSelectedRows.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefaultStyles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelGridPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.PanelControl PanelOptions;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.CheckEdit CheckBoxSelectedRows;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl PanelGridPreview;
        private DevExpress.XtraEditors.CheckEdit CheckBoxHorzLines;
        private DevExpress.XtraEditors.CheckEdit CheckBoxVertLines;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit CheckBoxFooter;
        private DevExpress.XtraEditors.CheckEdit CheckBoxPreview;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CheckBoxHeader;
        private DevExpress.XtraEditors.CheckEdit CheckBoxGroupFooter;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit CheckBoxEvenRow;
        private DevExpress.XtraEditors.CheckEdit CheckBoxDefaultStyles;
        private DevExpress.XtraEditors.CheckEdit CheckBoxOddRow;
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoWidth;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}

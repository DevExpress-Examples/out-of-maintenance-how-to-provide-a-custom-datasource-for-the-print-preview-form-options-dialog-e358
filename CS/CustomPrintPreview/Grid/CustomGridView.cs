using System;
using System.Drawing;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace CustomPrintPreview.Grid {
    public class CustomGridView :GridView {
        public CustomGridView(GridControl ownerGrid): base(ownerGrid) { }
        public CustomGridView() { }

        internal const string CustomName = "CustomGridView";
        protected override string ViewName {
            get { return CustomName; }
        }

        protected override UserControl PrintDesigner {
            get {
                UserControl ctrl = new UserControl();
                GetGridPreviewEventArgs args = GetGridPreview();
                CustomGridViewPrinting gvp = new CustomGridViewPrinting(args.GridPreview,
                    args.GroupColumn);
                args.GridPreview = null;
                args.GroupColumn = null;
                gvp.InitFrame(this, "GridView", new Bitmap(16, 16));
                gvp.Dock = DockStyle.Fill;
                ctrl.Controls.Add(gvp);
                ctrl.Visible = true;
                ctrl.Dock = DockStyle.Fill;
                ctrl.Size = gvp.UserControlSize;
                return ctrl;
            }
        }

        GetGridPreviewEventArgs GetGridPreview() {
            EventHandler<GetGridPreviewEventArgs> handler = Events[fGetGridPreview]
                as EventHandler<GetGridPreviewEventArgs>;
            if (handler == null) return null;
            GetGridPreviewEventArgs args = new GetGridPreviewEventArgs();
            handler(this, args);
            return args;
        }

        public override void Assign(BaseView v, bool copyEvents) {
            BeginUpdate();
            try {
                base.Assign(v, copyEvents);
                if (copyEvents)
                    GetCustomGridPreview += (EventHandler<GetGridPreviewEventArgs>)((CustomGridView)v).Events[fGetGridPreview];
            } finally { EndUpdate(); }
        }

        internal void FireChangedInternal() {
            base.FireChanged();
        }

        static readonly object fGetGridPreview = new object();
        public event EventHandler<GetGridPreviewEventArgs> GetCustomGridPreview {
            add { Events.AddHandler(fGetGridPreview, value); }
            remove { Events.RemoveHandler(fGetGridPreview, value); }
        }
    }
}

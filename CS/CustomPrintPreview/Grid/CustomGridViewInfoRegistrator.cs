using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;

namespace CustomPrintPreview.Grid {
    public class CustomGridViewInfoRegistrator :GridInfoRegistrator {
        public override string ViewName {
            get { return CustomGridView.CustomName; }
        }

        public override BaseView CreateView(GridControl grid) {
            return new CustomGridView(grid);
        }
    }
}

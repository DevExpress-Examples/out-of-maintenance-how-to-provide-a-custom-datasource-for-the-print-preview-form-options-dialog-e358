using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;

namespace CustomPrintPreview.Grid {
    public class GetGridPreviewEventArgs :EventArgs {
        GridControl fGridPreview;
        public GridControl GridPreview {
            get { return fGridPreview; }
            set { fGridPreview = value; }
        }

        GridColumn fGroupColumn;
        public GridColumn GroupColumn {
            get { return fGroupColumn; }
            set { fGroupColumn = value; }
        }
    }
}

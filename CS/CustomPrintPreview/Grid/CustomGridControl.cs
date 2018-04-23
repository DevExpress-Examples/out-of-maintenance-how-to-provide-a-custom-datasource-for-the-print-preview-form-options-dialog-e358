using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;

namespace CustomPrintPreview.Grid {
    public class CustomGridControl :GridControl {
        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridViewInfoRegistrator());
        }
    }
}

using System.Drawing;
using NUnit.Framework;
using System.Reflection;
using DevExpress.XtraGrid;
using CustomPrintPreview.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace CustomPrintPreviewTest {
    [TestFixture]
    public class CustomGridViewPrintingTest {
        [Test]
        public void InitViewStylesTest() {
            GridControl gc = new CustomGridControl();
            gc.ForceInitialize();
            gc.MainView = new CustomGridView(gc);
            GridColumn col = ((ColumnView)gc.MainView).Columns.AddField("Column");
            using (CustomGridViewPrinting cgvp = new CustomGridViewPrinting(gc, col)) {
                cgvp.InitFrame(gc.MainView, "GridView", new Bitmap(16, 16));
            typeof(CustomGridViewPrinting).InvokeMember("InitViewStyles", BindingFlags.Instance |
                BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, cgvp, new object[0]);
            }
        }
    }
}

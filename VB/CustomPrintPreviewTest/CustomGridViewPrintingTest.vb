Imports System.Drawing
Imports NUnit.Framework
Imports System.Reflection
Imports DevExpress.XtraGrid
Imports CustomPrintPreview.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Namespace CustomPrintPreviewTest
    <TestFixture> _
    Public Class CustomGridViewPrintingTest
        <Test> _
        Public Sub InitViewStylesTest()
            Dim gc As New CustomGridControl()
            gc.ForceInitialize()
            gc.MainView = New CustomGridView(gc)
            Dim col As GridColumn = CType(gc.MainView, ColumnView).Columns.AddField("Column")
            Using cgvp As New CustomGridViewPrinting(gc, col)
                cgvp.InitFrame(gc.MainView, "GridView", New Bitmap(16, 16))
            GetType(CustomGridViewPrinting).InvokeMember("InitViewStyles", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.InvokeMethod, Nothing, cgvp, New Object(){})
            End Using
        End Sub
    End Class
End Namespace

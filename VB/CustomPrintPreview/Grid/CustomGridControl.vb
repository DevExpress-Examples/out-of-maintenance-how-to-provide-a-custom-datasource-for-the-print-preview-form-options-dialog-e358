Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator

Namespace CustomPrintPreview.Grid
    Public Class CustomGridControl
        Inherits GridControl

        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New CustomGridViewInfoRegistrator())
        End Sub
    End Class
End Namespace

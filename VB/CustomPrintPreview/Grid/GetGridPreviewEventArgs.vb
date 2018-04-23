Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns

Namespace CustomPrintPreview.Grid
	Public Class GetGridPreviewEventArgs
		Inherits EventArgs
		Private fGridPreview As GridControl
		Public Property GridPreview() As GridControl
			Get
				Return fGridPreview
			End Get
			Set(ByVal value As GridControl)
				fGridPreview = value
			End Set
		End Property

		Private fGroupColumn As GridColumn
		Public Property GroupColumn() As GridColumn
			Get
				Return fGroupColumn
			End Get
			Set(ByVal value As GridColumn)
				fGroupColumn = value
			End Set
		End Property
	End Class
End Namespace

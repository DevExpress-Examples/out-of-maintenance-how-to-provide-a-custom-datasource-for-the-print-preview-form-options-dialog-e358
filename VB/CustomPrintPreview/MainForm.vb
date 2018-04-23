Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports CustomPrintPreview.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Base

Namespace CustomPrintPreview
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub CreateData()
			TableUsers.Rows.Add(1, "John")
			TableUsers.Rows.Add(2, "Bob")
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CreateData()
		End Sub

		Private Sub OnButtonPrintClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Grid.ShowPrintPreview()
		End Sub

		Private Sub OnCustomersViewGetCustomGridPreview(ByVal sender As Object, ByVal e As GetGridPreviewEventArgs) Handles customGridView1.GetCustomGridPreview
			Dim gridPreview As GridControl = New CustomGridControl()
			Dim view As ColumnView = New CustomGridView(gridPreview)
			gridPreview.MainView = view
			gridPreview.DataSource = CustomersBindingSource
			e.GridPreview = gridPreview
			view.Columns.AddVisible("ID")
			e.GroupColumn = view.Columns.AddVisible("Name")
		End Sub
	End Class
End Namespace
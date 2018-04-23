Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Namespace CustomPrintPreview.Grid
	Public Class CustomGridView
		Inherits GridView
		Public Sub New(ByVal ownerGrid As GridControl)
			MyBase.New(ownerGrid)
		End Sub
		Public Sub New()
		End Sub

		Friend Const CustomName As String = "CustomGridView"
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return CustomName
			End Get
		End Property

		Protected Overrides ReadOnly Property PrintDesigner() As UserControl
			Get
				Dim ctrl As New UserControl()
				Dim args As GetGridPreviewEventArgs = GetGridPreview()
				Dim gvp As New CustomGridViewPrinting(args.GridPreview, args.GroupColumn)
				args.GridPreview = Nothing
				args.GroupColumn = Nothing
				gvp.InitFrame(Me, "GridView", New Bitmap(16, 16))
				gvp.Dock = DockStyle.Fill
				ctrl.Controls.Add(gvp)
				ctrl.Visible = True
				ctrl.Dock = DockStyle.Fill
				ctrl.Size = gvp.UserControlSize
				Return ctrl
			End Get
		End Property

		Private Function GetGridPreview() As GetGridPreviewEventArgs
			Dim handler As EventHandler(Of GetGridPreviewEventArgs) = TryCast(Events(fGetGridPreview), EventHandler(Of GetGridPreviewEventArgs))
			If handler Is Nothing Then
				Return Nothing
			End If
			Dim args As New GetGridPreviewEventArgs()
			handler(Me, args)
			Return args
		End Function

		Public Overrides Sub Assign(ByVal v As BaseView, ByVal copyEvents As Boolean)
			BeginUpdate()
			Try
				MyBase.Assign(v, copyEvents)
				If copyEvents Then
                    AddHandler GetCustomGridPreview, CType(Events(fGetGridPreview), EventHandler(Of GetGridPreviewEventArgs))
				End If
			Finally
				EndUpdate()
			End Try
		End Sub

		Friend Sub FireChangedInternal()
			MyBase.FireChanged()
		End Sub

		Private Shared ReadOnly fGetGridPreview As Object = New Object()
		Public Custom Event GetCustomGridPreview As EventHandler(Of GetGridPreviewEventArgs)
			AddHandler(ByVal value As EventHandler(Of GetGridPreviewEventArgs))
				Events.AddHandler(fGetGridPreview, value)
			End AddHandler
			RemoveHandler(ByVal value As EventHandler(Of GetGridPreviewEventArgs))
				Events.RemoveHandler(fGetGridPreview, value)
			End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As GetGridPreviewEventArgs)
            End RaiseEvent
		End Event
	End Class
End Namespace

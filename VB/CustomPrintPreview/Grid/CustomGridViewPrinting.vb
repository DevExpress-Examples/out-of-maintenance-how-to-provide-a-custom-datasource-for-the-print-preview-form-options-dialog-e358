Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports System.Reflection
Imports DevExpress.XtraTab
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Frames
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraGrid.Design
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraGrid.Views.Printing
Imports DevExpress.Utils.Text

Namespace CustomPrintPreview.Grid
	Partial Public Class CustomGridViewPrinting
		Inherits XtraFrame
		Implements IPrintDesigner
		Private GridPreview As GridControl
		Private Images As ImageCollection
		Private LockApply As Integer
		Private PrintFlags() As String = { "PrintHeader", "PrintPreview", "PrintFooter", "PrintGroupFooter", "PrintHorzLines", "PrintVertLines", "PrintFilterInfo", "PrintDetails", "AutoWidth", "ExpandAllDetails", "ExpandAllGroups", "UsePrintStyles", "EnableAppearanceEvenRow", "EnableAppearanceOddRow", "PrintBandHeader", "PrintSelectedRowsOnly" }
		Private GroupColumn As GridColumn

		Private Sub New()
			MyBase.New(8)
			InitializeComponent()
		End Sub

		Public Sub New(ByVal grid As GridControl, ByVal groupColumn As GridColumn)
			Me.New()
			PanelGridPreview.DockPadding.All = 4
			GridPreview = grid
			GridPreview.Dock = DockStyle.Fill
			GridPreview.Parent = PanelGridPreview
			Images = ImageHelper.CreateImageCollectionFromResources("DevExpress.XtraGrid.Printing.GridPrintOptions.png", GetType(GridViewDesigner).Assembly, New Size(16, 16))
			Me.GroupColumn = groupColumn
		End Sub

		Private fAutoApply As Boolean = True
		Public Property AutoApply() As Boolean
			Get
				Return fAutoApply
			End Get
			Set(ByVal value As Boolean)
				fAutoApply = value
			End Set
		End Property

		Private ReadOnly Property EditingView() As CustomGridView
			Get
				Return CType(EditingObject, CustomGridView)
			End Get
		End Property

		Private ReadOnly Property CurrentView() As GridView
			Get
				Return CType(GridPreview.MainView, GridView)
			End Get
		End Property

		Public ReadOnly Property UserControlSize() As Size
			Get
				Return TextUtils.GetScaleSize(New Size(560, 345))
			End Get
		End Property

		Private Sub OnTabPageOptionsPaint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles xtraTabPage1.Paint
			PaintTabPage(e.Graphics, 0, 8)
			PrintImage(12, e.Graphics)
			PrintImage(13, e.Graphics)
			PrintImage(15, e.Graphics)
		End Sub

		Private Sub PrintImage(ByVal index As Integer, ByVal graphics As Graphics)
			PrintImage(CheckEditByIndex(index), graphics, Images.Images(index))
		End Sub

		Private Sub PrintImage(ByVal editor As CheckEdit, ByVal graphics As Graphics, ByVal image As Image)
			If editor Is Nothing Then
				Return
			End If
			Dim top As Integer = editor.Top + (editor.Height - image.Size.Height) / 2
			Dim x As Integer = 10
			If editor.Checked Then
				graphics.DrawImage(image, New Rectangle(x, top, image.Width, image.Height))
			Else
				ControlPaint.DrawImageDisabled(graphics, image, x, top, SystemColors.Control)
			End If
		End Sub

		Private Function CheckEditByIndex(ByVal index As Integer) As CheckEdit
			For Each tp As XtraTabPage In TabControl.TabPages
				For Each c As Control In tp.Controls
					If TypeOf c Is CheckEdit AndAlso Convert.ToInt32(c.Tag) = index Then
						Return CType(c, CheckEdit)
					End If
				Next c
			Next tp
			Return Nothing
		End Function

		Private Sub OnCheckBoxCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit2.CheckStateChanged, checkEdit1.CheckStateChanged, CheckBoxSelectedRows.CheckStateChanged, checkEdit4.CheckedChanged, checkEdit3.CheckStateChanged
			InvalidateImage(CType(sender, CheckEdit))
		End Sub

		Private Sub InvalidateImage(ByVal editor As CheckEdit)
			editor.Parent.Invalidate(New Rectangle(0, editor.Top, 50, editor.Height))
			ApplyOptions()
		End Sub

		Private Sub ApplyOptions()
			ApplyOptions(AutoApply)
		End Sub

        Protected Overridable Sub ApplyOptions(ByVal _setOptions As Boolean)
            If LockApply <> 0 Then
                Return
            End If
            For i As Integer = 0 To PrintFlags.Length - 1
                Dim chb As CheckEdit = CheckEditByIndex(i)
                If chb IsNot Nothing Then
                    If _setOptions Then
                        SetOptions.SetOptionValueByString(PrintFlags(i), EditingView.OptionsPrint, chb.Checked)
                    Else
                        SetOptions.SetOptionValueByString(PrintFlags(i), CurrentView.OptionsPrint, chb.Checked)
                    End If
                End If
            Next i
            EditingView.FireChangedInternal()
        End Sub

		Private Sub OnCheckBoxHorzLinesCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxHorzLines.CheckStateChanged
			CurrentView.OptionsView.ShowHorzLines = CheckBoxHorzLines.Checked
			InvalidateImage(CheckBoxHorzLines)
		End Sub

		Private Sub OnCheckBoxVertLinesCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxVertLines.CheckStateChanged
			CurrentView.OptionsView.ShowVertLines = CheckBoxVertLines.Checked
			InvalidateImage(CheckBoxVertLines)
		End Sub

		Private Sub OnCheckBoxFooterCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxFooter.CheckStateChanged
			CurrentView.OptionsView.ShowFooter = CheckBoxFooter.Checked
			InvalidateImage(CheckBoxFooter)
		End Sub

		Private Sub OnCheckBoxPreviewCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxPreview.CheckStateChanged
			CurrentView.OptionsView.ShowPreview = CheckBoxPreview.Checked
			InvalidateImage(CheckBoxPreview)
		End Sub

		Private Sub OnCheckBoxHeaderCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxHeader.CheckStateChanged
			CurrentView.OptionsView.ShowColumnHeaders = CheckBoxHeader.Checked
			InvalidateImage(CheckBoxHeader)
		End Sub

		Private Sub OnCheckBoxGroupFooterCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxGroupFooter.CheckStateChanged
			If GroupColumn IsNot Nothing Then
				If CheckBoxGroupFooter.Checked Then
					GroupColumn.GroupIndex = 0
				Else
					GroupColumn.GroupIndex = -1
					GroupColumn.VisibleIndex = 3
				End If
			End If
			CurrentView.ExpandAllGroups()
			CurrentView.FocusedRowHandle = -99
			InvalidateImage(CheckBoxGroupFooter)
		End Sub

		Private Sub OnCheckBoxStylesCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxOddRow.CheckStateChanged, CheckBoxEvenRow.CheckStateChanged
			OnCheckBoxCheckStateChanged(sender, e)
			InitViewStyles()
		End Sub

		Private Sub OnCheckBoxDefaultStylesCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxDefaultStyles.CheckStateChanged
			OnCheckBoxStylesCheckStateChanged(sender, e)
			CheckBoxOddRow.Enabled = CheckBoxDefaultStyles.Checked
			CheckBoxEvenRow.Enabled = CheckBoxOddRow.Enabled
		End Sub

		Private Sub InitViewStyles()
			CurrentView.BeginUpdate()
			Try
				CurrentView.Appearance.Reset()
				If CheckBoxDefaultStyles.Checked Then
					Dim collection As GridViewPrintAppearances = TryCast((CType(GetType(GridView).InvokeMember("CreatePrintInfoCore", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.InvokeMethod, Nothing, CurrentView, New Object() { New PrintInfoArgs(CurrentView) }), BaseViewPrintInfo)).AppearancePrint, GridViewPrintAppearances)
					If collection IsNot Nothing Then
						CurrentView.Appearance.Assign(collection)
						CurrentView.Appearance.HorzLine.Assign(collection.Lines)
						CurrentView.Appearance.VertLine.Assign(collection.Lines)
					End If
				Else
					CurrentView.Appearance.Assign(EditingView.PaintAppearance)
				End If
				CurrentView.Appearance.FooterPanel.BorderColor = CurrentView.Appearance.FooterPanel.BackColor
				CurrentView.Appearance.HeaderPanel.BorderColor = CurrentView.Appearance.HeaderPanel.BackColor
				CurrentView.Appearance.GroupFooter.BorderColor = CurrentView.Appearance.GroupFooter.BackColor
				If CheckBoxDefaultStyles.Checked Then
					CurrentView.OptionsView.EnableAppearanceEvenRow = CheckBoxEvenRow.Checked
				Else
					CurrentView.OptionsView.EnableAppearanceEvenRow = EditingView.OptionsView.EnableAppearanceEvenRow
				End If
				If CheckBoxDefaultStyles.Checked Then
					CurrentView.OptionsView.EnableAppearanceOddRow = CheckBoxOddRow.Checked
				Else
					CurrentView.OptionsView.EnableAppearanceOddRow = EditingView.OptionsView.EnableAppearanceOddRow
				End If
				CurrentView.Appearance.Empty.BackColor2 = Color.White
				CurrentView.Appearance.Empty.BackColor = CurrentView.Appearance.Empty.BackColor2
			Finally
				CurrentView.EndUpdate()
			End Try
		End Sub

		Private Sub PaintTabPage(ByVal graphics As Graphics, ByVal startIndex As Integer, ByVal endIndex As Integer)
			For i As Integer = startIndex To endIndex - 1
				PrintImage(i, graphics)
			Next i
		End Sub

		Private Sub OnTabPageBehaviorPaint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles xtraTabPage2.Paint
			PaintTabPage(e.Graphics, 8, 11)
		End Sub

		Private Sub OnCheckBoxAutoWidthCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxAutoWidth.CheckStateChanged
			CurrentView.OptionsView.ColumnAutoWidth = CheckBoxAutoWidth.Checked
			InvalidateImage(CheckBoxAutoWidth)
		End Sub

		Protected Overrides ReadOnly Property DescriptionText() As String
			Get
				Return GridLocalizer.Active.GetLocalizedString(GridStringId.PrintDesignerDescription)
			End Get
		End Property

		Public Overrides Sub InitComponent()
			LockApply -= 1
			Try
				For i As Integer = 0 To PrintFlags.Length - 1
					Dim chb As CheckEdit = CheckEditByIndex(i)
					If chb IsNot Nothing Then
						chb.Checked = SetOptions.OptionValueByString(PrintFlags(i), EditingView.OptionsPrint)
						If chb.Checked Then
							chb.Checked = True
						End If
					End If
				Next i
			Finally
				LockApply += 1
			End Try
			CurrentView.OptionsView.BeginUpdate()
			Try
				OnCheckBoxHeaderCheckStateChanged(CheckBoxHeader, EventArgs.Empty)
				OnCheckBoxPreviewCheckStateChanged(CheckBoxPreview, EventArgs.Empty)
				OnCheckBoxFooterCheckStateChanged(CheckBoxFooter, EventArgs.Empty)
				OnCheckBoxGroupFooterCheckStateChanged(CheckBoxGroupFooter, EventArgs.Empty)
				OnCheckBoxHorzLinesCheckStateChanged(CheckBoxHorzLines, EventArgs.Empty)
				OnCheckBoxVertLinesCheckStateChanged(CheckBoxVertLines, EventArgs.Empty)
				OnCheckBoxAutoWidthCheckStateChanged(CheckBoxAutoWidth, EventArgs.Empty)
				OnCheckBoxDefaultStylesCheckStateChanged(CheckBoxDefaultStyles, EventArgs.Empty)
				OnCheckBoxStylesCheckStateChanged(CheckBoxEvenRow, EventArgs.Empty)
				OnCheckBoxStylesCheckStateChanged(CheckBoxOddRow, EventArgs.Empty)
				OnCheckBoxCheckStateChanged(CheckBoxSelectedRows, EventArgs.Empty)
			Finally
				CurrentView.OptionsView.EndUpdate()
			End Try
			CurrentView.AppearancePrint.Assign(EditingView.AppearancePrint)
			CurrentView.OptionsPrint.Assign(EditingView.OptionsPrint)
			InitViewStyles()
			lbCaption.Text = GridLocalizer.Active.GetLocalizedString(GridStringId.PrintDesignerGridView)
			CurrentView.PaintStyleName = "MixedXP"
		End Sub

#Region "IPrintDesigner Members"

		Private Sub IPrintDesigner_ApplyOptions(ByVal setOptions As Boolean) Implements IPrintDesigner.ApplyOptions
			ApplyOptions(setOptions)
		End Sub

		Private Sub HideCaption() Implements IPrintDesigner.HideCaption
			horzSplitter.Visible = False
			lbCaption.Visible = horzSplitter.Visible
		End Sub

		#End Region
	End Class
End Namespace

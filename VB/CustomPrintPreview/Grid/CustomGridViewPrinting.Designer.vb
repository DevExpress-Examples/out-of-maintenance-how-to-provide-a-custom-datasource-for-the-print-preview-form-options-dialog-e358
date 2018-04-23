Imports Microsoft.VisualBasic
Imports System
Namespace CustomPrintPreview.Grid
	Partial Public Class CustomGridViewPrinting
		Private Sub InitializeComponent()
			Me.PanelOptions = New DevExpress.XtraEditors.PanelControl()
			Me.TabControl = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.CheckBoxOddRow = New DevExpress.XtraEditors.CheckEdit()
			Me.CheckBoxEvenRow = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
			Me.CheckBoxGroupFooter = New DevExpress.XtraEditors.CheckEdit()
			Me.CheckBoxHeader = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.CheckBoxPreview = New DevExpress.XtraEditors.CheckEdit()
			Me.CheckBoxFooter = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.CheckBoxVertLines = New DevExpress.XtraEditors.CheckEdit()
			Me.CheckBoxHorzLines = New DevExpress.XtraEditors.CheckEdit()
			Me.CheckBoxSelectedRows = New DevExpress.XtraEditors.CheckEdit()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.checkEdit4 = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.CheckBoxAutoWidth = New DevExpress.XtraEditors.CheckEdit()
			Me.CheckBoxDefaultStyles = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.PanelGridPreview = New DevExpress.XtraEditors.PanelControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlMain.SuspendLayout()
			CType(Me.horzSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PanelOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.PanelOptions.SuspendLayout()
			CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.TabControl.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.CheckBoxOddRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxEvenRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxGroupFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxPreview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxVertLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxHorzLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxSelectedRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxAutoWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CheckBoxDefaultStyles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.PanelGridPreview, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' lbCaption
			' 
			Me.lbCaption.Size = New System.Drawing.Size(537, 24)
			' 
			' pnlMain
			' 
			Me.pnlMain.Controls.Add(Me.splitContainerControl1)
			Me.pnlMain.Size = New System.Drawing.Size(537, 380)
			' 
			' horzSplitter
			' 
			Me.horzSplitter.Size = New System.Drawing.Size(537, 4)
			' 
			' PanelOptions
			' 
			Me.PanelOptions.Controls.Add(Me.TabControl)
			Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Fill
			Me.PanelOptions.Location = New System.Drawing.Point(0, 0)
			Me.PanelOptions.Name = "PanelOptions"
			Me.PanelOptions.Size = New System.Drawing.Size(157, 380)
			Me.PanelOptions.TabIndex = 0
			' 
			' TabControl
			' 
			Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.TabControl.Location = New System.Drawing.Point(2, 2)
			Me.TabControl.Name = "TabControl"
			Me.TabControl.SelectedTabPage = Me.xtraTabPage1
			Me.TabControl.Size = New System.Drawing.Size(153, 376)
			Me.TabControl.TabIndex = 0
			Me.TabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxOddRow)
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxEvenRow)
			Me.xtraTabPage1.Controls.Add(Me.checkEdit2)
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxGroupFooter)
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxHeader)
			Me.xtraTabPage1.Controls.Add(Me.labelControl1)
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxPreview)
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxFooter)
			Me.xtraTabPage1.Controls.Add(Me.checkEdit1)
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxVertLines)
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxHorzLines)
			Me.xtraTabPage1.Controls.Add(Me.CheckBoxSelectedRows)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(147, 350)
			Me.xtraTabPage1.Text = "Options"
'			Me.xtraTabPage1.Paint += New System.Windows.Forms.PaintEventHandler(Me.OnTabPageOptionsPaint);
			' 
			' CheckBoxOddRow
			' 
			Me.CheckBoxOddRow.Location = New System.Drawing.Point(33, 270)
			Me.CheckBoxOddRow.Name = "CheckBoxOddRow"
			Me.CheckBoxOddRow.Properties.Appearance.Options.UseTextOptions = True
			Me.CheckBoxOddRow.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.CheckBoxOddRow.Properties.AutoHeight = False
			Me.CheckBoxOddRow.Properties.Caption = "Odd Row Appearance"
			Me.CheckBoxOddRow.Size = New System.Drawing.Size(97, 38)
			Me.CheckBoxOddRow.TabIndex = 11
			Me.CheckBoxOddRow.Tag = "13"
'			Me.CheckBoxOddRow.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxStylesCheckStateChanged);
			' 
			' CheckBoxEvenRow
			' 
			Me.CheckBoxEvenRow.Location = New System.Drawing.Point(33, 226)
			Me.CheckBoxEvenRow.Name = "CheckBoxEvenRow"
			Me.CheckBoxEvenRow.Properties.Appearance.Options.UseTextOptions = True
			Me.CheckBoxEvenRow.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.CheckBoxEvenRow.Properties.AutoHeight = False
			Me.CheckBoxEvenRow.Properties.Caption = "Even Row Appearance"
			Me.CheckBoxEvenRow.Size = New System.Drawing.Size(97, 38)
			Me.CheckBoxEvenRow.TabIndex = 10
			Me.CheckBoxEvenRow.Tag = "12"
'			Me.CheckBoxEvenRow.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxStylesCheckStateChanged);
			' 
			' checkEdit2
			' 
			Me.checkEdit2.Location = New System.Drawing.Point(33, 176)
			Me.checkEdit2.Name = "checkEdit2"
			Me.checkEdit2.Properties.Caption = "Filter"
			Me.checkEdit2.Size = New System.Drawing.Size(75, 19)
			Me.checkEdit2.TabIndex = 9
			Me.checkEdit2.Tag = "6"
'			Me.checkEdit2.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxCheckStateChanged);
			' 
			' CheckBoxGroupFooter
			' 
			Me.CheckBoxGroupFooter.Location = New System.Drawing.Point(33, 101)
			Me.CheckBoxGroupFooter.Name = "CheckBoxGroupFooter"
			Me.CheckBoxGroupFooter.Properties.Caption = "Group Footer"
			Me.CheckBoxGroupFooter.Size = New System.Drawing.Size(93, 19)
			Me.CheckBoxGroupFooter.TabIndex = 8
			Me.CheckBoxGroupFooter.Tag = "3"
'			Me.CheckBoxGroupFooter.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxGroupFooterCheckStateChanged);
			' 
			' CheckBoxHeader
			' 
			Me.CheckBoxHeader.Location = New System.Drawing.Point(33, 26)
			Me.CheckBoxHeader.Name = "CheckBoxHeader"
			Me.CheckBoxHeader.Properties.Caption = "Header"
			Me.CheckBoxHeader.Size = New System.Drawing.Size(75, 19)
			Me.CheckBoxHeader.TabIndex = 7
			Me.CheckBoxHeader.Tag = "0"
'			Me.CheckBoxHeader.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxHeaderCheckStateChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
			Me.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl1.Location = New System.Drawing.Point(3, 3)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(141, 20)
			Me.labelControl1.TabIndex = 6
			Me.labelControl1.Text = "Print"
			' 
			' CheckBoxPreview
			' 
			Me.CheckBoxPreview.Location = New System.Drawing.Point(33, 51)
			Me.CheckBoxPreview.Name = "CheckBoxPreview"
			Me.CheckBoxPreview.Properties.Caption = "Preview"
			Me.CheckBoxPreview.Size = New System.Drawing.Size(75, 19)
			Me.CheckBoxPreview.TabIndex = 5
			Me.CheckBoxPreview.Tag = "1"
'			Me.CheckBoxPreview.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxPreviewCheckStateChanged);
			' 
			' CheckBoxFooter
			' 
			Me.CheckBoxFooter.Location = New System.Drawing.Point(33, 76)
			Me.CheckBoxFooter.Name = "CheckBoxFooter"
			Me.CheckBoxFooter.Properties.Caption = "Footer"
			Me.CheckBoxFooter.Size = New System.Drawing.Size(75, 19)
			Me.CheckBoxFooter.TabIndex = 4
			Me.CheckBoxFooter.Tag = "2"
'			Me.CheckBoxFooter.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxFooterCheckStateChanged);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(33, 201)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Details"
			Me.checkEdit1.Size = New System.Drawing.Size(75, 19)
			Me.checkEdit1.TabIndex = 3
			Me.checkEdit1.Tag = "7"
'			Me.checkEdit1.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxCheckStateChanged);
			' 
			' CheckBoxVertLines
			' 
			Me.CheckBoxVertLines.Location = New System.Drawing.Point(33, 151)
			Me.CheckBoxVertLines.Name = "CheckBoxVertLines"
			Me.CheckBoxVertLines.Properties.Caption = "Vertical Lines"
			Me.CheckBoxVertLines.Size = New System.Drawing.Size(93, 19)
			Me.CheckBoxVertLines.TabIndex = 2
			Me.CheckBoxVertLines.Tag = "5"
'			Me.CheckBoxVertLines.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxVertLinesCheckStateChanged);
			' 
			' CheckBoxHorzLines
			' 
			Me.CheckBoxHorzLines.Location = New System.Drawing.Point(33, 126)
			Me.CheckBoxHorzLines.Name = "CheckBoxHorzLines"
			Me.CheckBoxHorzLines.Properties.Caption = "Horizontal Lines"
			Me.CheckBoxHorzLines.Size = New System.Drawing.Size(106, 19)
			Me.CheckBoxHorzLines.TabIndex = 1
			Me.CheckBoxHorzLines.Tag = "4"
'			Me.CheckBoxHorzLines.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxHorzLinesCheckStateChanged);
			' 
			' CheckBoxSelectedRows
			' 
			Me.CheckBoxSelectedRows.Location = New System.Drawing.Point(33, 314)
			Me.CheckBoxSelectedRows.Name = "CheckBoxSelectedRows"
			Me.CheckBoxSelectedRows.Properties.Caption = "Selected Rows"
			Me.CheckBoxSelectedRows.Size = New System.Drawing.Size(97, 19)
			Me.CheckBoxSelectedRows.TabIndex = 0
			Me.CheckBoxSelectedRows.Tag = "15"
'			Me.CheckBoxSelectedRows.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxCheckStateChanged);
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.labelControl4)
			Me.xtraTabPage2.Controls.Add(Me.checkEdit4)
			Me.xtraTabPage2.Controls.Add(Me.labelControl3)
			Me.xtraTabPage2.Controls.Add(Me.checkEdit3)
			Me.xtraTabPage2.Controls.Add(Me.labelControl2)
			Me.xtraTabPage2.Controls.Add(Me.CheckBoxAutoWidth)
			Me.xtraTabPage2.Controls.Add(Me.CheckBoxDefaultStyles)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(147, 333)
			Me.xtraTabPage2.Text = "Behavior"
'			Me.xtraTabPage2.Paint += New System.Windows.Forms.PaintEventHandler(Me.OnTabPageBehaviorPaint);
			' 
			' labelControl4
			' 
			Me.labelControl4.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl4.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
			Me.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText
			Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl4.Location = New System.Drawing.Point(6, 129)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(138, 20)
			Me.labelControl4.TabIndex = 6
			Me.labelControl4.Text = "Use Styles"
			' 
			' checkEdit4
			' 
			Me.checkEdit4.Location = New System.Drawing.Point(43, 104)
			Me.checkEdit4.Name = "checkEdit4"
			Me.checkEdit4.Properties.Caption = "All Groups"
			Me.checkEdit4.Size = New System.Drawing.Size(75, 19)
			Me.checkEdit4.TabIndex = 5
			Me.checkEdit4.Tag = "10"
'			Me.checkEdit4.CheckedChanged += New System.EventHandler(Me.OnCheckBoxCheckStateChanged);
			' 
			' labelControl3
			' 
			Me.labelControl3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
			Me.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText
			Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl3.Location = New System.Drawing.Point(3, 54)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(141, 20)
			Me.labelControl3.TabIndex = 4
			Me.labelControl3.Text = "Expand"
			' 
			' checkEdit3
			' 
			Me.checkEdit3.Location = New System.Drawing.Point(43, 79)
			Me.checkEdit3.Name = "checkEdit3"
			Me.checkEdit3.Properties.Caption = "All Details"
			Me.checkEdit3.Size = New System.Drawing.Size(75, 19)
			Me.checkEdit3.TabIndex = 3
			Me.checkEdit3.Tag = "9"
'			Me.checkEdit3.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxCheckStateChanged);
			' 
			' labelControl2
			' 
			Me.labelControl2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
			Me.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText
			Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl2.Location = New System.Drawing.Point(3, 3)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(141, 20)
			Me.labelControl2.TabIndex = 2
			Me.labelControl2.Text = "Width"
			' 
			' CheckBoxAutoWidth
			' 
			Me.CheckBoxAutoWidth.Location = New System.Drawing.Point(43, 29)
			Me.CheckBoxAutoWidth.Name = "CheckBoxAutoWidth"
			Me.CheckBoxAutoWidth.Properties.Caption = "Auto Width"
			Me.CheckBoxAutoWidth.Size = New System.Drawing.Size(75, 19)
			Me.CheckBoxAutoWidth.TabIndex = 1
			Me.CheckBoxAutoWidth.Tag = "8"
'			Me.CheckBoxAutoWidth.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxAutoWidthCheckStateChanged);
			' 
			' CheckBoxDefaultStyles
			' 
			Me.CheckBoxDefaultStyles.Location = New System.Drawing.Point(43, 155)
			Me.CheckBoxDefaultStyles.Name = "CheckBoxDefaultStyles"
			Me.CheckBoxDefaultStyles.Properties.Caption = "Use Print Styles"
			Me.CheckBoxDefaultStyles.Size = New System.Drawing.Size(98, 19)
			Me.CheckBoxDefaultStyles.TabIndex = 0
			Me.CheckBoxDefaultStyles.Tag = "11"
'			Me.CheckBoxDefaultStyles.CheckStateChanged += New System.EventHandler(Me.OnCheckBoxDefaultStylesCheckStateChanged);
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.PanelGridPreview)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(375, 380)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = "Preview:"
			' 
			' PanelGridPreview
			' 
			Me.PanelGridPreview.Appearance.BackColor = System.Drawing.Color.White
			Me.PanelGridPreview.Appearance.Options.UseBackColor = True
			Me.PanelGridPreview.Dock = System.Windows.Forms.DockStyle.Fill
			Me.PanelGridPreview.Location = New System.Drawing.Point(2, 22)
			Me.PanelGridPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.PanelGridPreview.LookAndFeel.UseDefaultLookAndFeel = False
			Me.PanelGridPreview.Name = "PanelGridPreview"
			Me.PanelGridPreview.Size = New System.Drawing.Size(371, 356)
			Me.PanelGridPreview.TabIndex = 0
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.PanelOptions)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.groupControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(537, 380)
			Me.splitContainerControl1.SplitterPosition = 157
			Me.splitContainerControl1.TabIndex = 2
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' CustomGridViewPrinting
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "CustomGridViewPrinting"
			Me.Size = New System.Drawing.Size(537, 408)
			CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlMain.ResumeLayout(False)
			CType(Me.horzSplitter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PanelOptions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.PanelOptions.ResumeLayout(False)
			CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.TabControl.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.CheckBoxOddRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxEvenRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxGroupFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxPreview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxVertLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxHorzLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxSelectedRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxAutoWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CheckBoxDefaultStyles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.PanelGridPreview, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		Private PanelOptions As DevExpress.XtraEditors.PanelControl
		Private TabControl As DevExpress.XtraTab.XtraTabControl
		Private WithEvents xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents CheckBoxSelectedRows As DevExpress.XtraEditors.CheckEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private PanelGridPreview As DevExpress.XtraEditors.PanelControl
		Private WithEvents CheckBoxHorzLines As DevExpress.XtraEditors.CheckEdit
		Private WithEvents CheckBoxVertLines As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents CheckBoxFooter As DevExpress.XtraEditors.CheckEdit
		Private WithEvents CheckBoxPreview As DevExpress.XtraEditors.CheckEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents CheckBoxHeader As DevExpress.XtraEditors.CheckEdit
		Private WithEvents CheckBoxGroupFooter As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents CheckBoxEvenRow As DevExpress.XtraEditors.CheckEdit
		Private WithEvents CheckBoxDefaultStyles As DevExpress.XtraEditors.CheckEdit
		Private WithEvents CheckBoxOddRow As DevExpress.XtraEditors.CheckEdit
		Private WithEvents CheckBoxAutoWidth As DevExpress.XtraEditors.CheckEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit4 As DevExpress.XtraEditors.CheckEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
	End Class
End Namespace

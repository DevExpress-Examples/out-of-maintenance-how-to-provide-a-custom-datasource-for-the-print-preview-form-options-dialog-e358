Namespace CustomPrintPreview
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Grid = New CustomPrintPreview.Grid.CustomGridControl()
            Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet1 = New System.Data.DataSet()
            Me.TableUsers = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.customGridView1 = New CustomPrintPreview.Grid.CustomGridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            DirectCast(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.TableUsers, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.customGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' Grid
            ' 
            Me.Grid.DataSource = Me.CustomersBindingSource
            Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Grid.Location = New System.Drawing.Point(0, 0)
            Me.Grid.MainView = Me.customGridView1
            Me.Grid.Name = "Grid"
            Me.Grid.Size = New System.Drawing.Size(428, 231)
            Me.Grid.TabIndex = 0
            Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.customGridView1})
            ' 
            ' CustomersBindingSource
            ' 
            Me.CustomersBindingSource.DataMember = "Users"
            Me.CustomersBindingSource.DataSource = Me.dataSet1
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.TableUsers})
            ' 
            ' TableUsers
            ' 
            Me.TableUsers.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
            Me.TableUsers.Constraints.AddRange(New System.Data.Constraint() { New System.Data.UniqueConstraint("Constraint1", New String() { "ID"}, True)})
            Me.TableUsers.PrimaryKey = New System.Data.DataColumn() { Me.dataColumn1}
            Me.TableUsers.TableName = "Users"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.AllowDBNull = False
            Me.dataColumn1.AutoIncrement = True
            Me.dataColumn1.ColumnName = "ID"
            Me.dataColumn1.DataType = GetType(Integer)
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Name"
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2})
            Me.gridView1.GridControl = Me.Grid
            Me.gridView1.Name = "gridView1"
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.FieldName = "ID"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.FieldName = "Name"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' customGridView1
            ' 
            Me.customGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colName})
            Me.customGridView1.GridControl = Me.Grid
            Me.customGridView1.Name = "customGridView1"
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 1
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 231)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(428, 37)
            Me.panelControl1.TabIndex = 1
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(6, 6)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Print"
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(428, 268)
            Me.Controls.Add(Me.Grid)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "MainForm"
            Me.Text = "Form1"
            DirectCast(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.TableUsers, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.customGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private Grid As CustomPrintPreview.Grid.CustomGridControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private CustomersBindingSource As System.Windows.Forms.BindingSource
        Private dataSet1 As System.Data.DataSet
        Private TableUsers As System.Data.DataTable
        Private dataColumn1 As System.Data.DataColumn
        Private dataColumn2 As System.Data.DataColumn
        Private WithEvents customGridView1 As CustomPrintPreview.Grid.CustomGridView
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

    End Class
End Namespace


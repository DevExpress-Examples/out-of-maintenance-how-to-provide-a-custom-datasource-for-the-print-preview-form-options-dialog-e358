using System;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using CustomPrintPreview.Grid;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;

namespace CustomPrintPreview {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        void CreateData() {
            TableUsers.Rows.Add(1, "John");
            TableUsers.Rows.Add(2, "Bob");
        }

        private void OnFormLoad(object sender, EventArgs e) {
            CreateData();
        }

        private void OnButtonPrintClick(object sender, EventArgs e) {
            Grid.ShowPrintPreview();
        }

        private void OnCustomersViewGetCustomGridPreview(object sender, GetGridPreviewEventArgs e) {
            GridControl gridPreview = new CustomGridControl();
            ColumnView view = new CustomGridView(gridPreview);
            gridPreview.MainView = view;
            gridPreview.DataSource = CustomersBindingSource;
            e.GridPreview = gridPreview;
            view.Columns.AddVisible("ID");
            e.GroupColumn = view.Columns.AddVisible("Name");
        }
    }
}
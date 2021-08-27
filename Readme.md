<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630847/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3589)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomGridControl.cs](./CS/CustomPrintPreview/Grid/CustomGridControl.cs) (VB: [CustomGridControl.vb](./VB/CustomPrintPreview/Grid/CustomGridControl.vb))
* [CustomGridView.cs](./CS/CustomPrintPreview/Grid/CustomGridView.cs) (VB: [CustomGridViewPrinting.vb](./VB/CustomPrintPreview/Grid/CustomGridViewPrinting.vb))
* [CustomGridViewInfoRegistrator.cs](./CS/CustomPrintPreview/Grid/CustomGridViewInfoRegistrator.cs) (VB: [CustomGridViewInfoRegistrator.vb](./VB/CustomPrintPreview/Grid/CustomGridViewInfoRegistrator.vb))
* **[CustomGridViewPrinting.cs](./CS/CustomPrintPreview/Grid/CustomGridViewPrinting.cs) (VB: [CustomGridViewPrinting.vb](./VB/CustomPrintPreview/Grid/CustomGridViewPrinting.vb))**
* [GetGridPreviewEventArgs.cs](./CS/CustomPrintPreview/Grid/GetGridPreviewEventArgs.cs) (VB: [GetGridPreviewEventArgs.vb](./VB/CustomPrintPreview/Grid/GetGridPreviewEventArgs.vb))
* [MainForm.cs](./CS/CustomPrintPreview/MainForm.cs)
<!-- default file list end -->
# How to provide a custom datasource for the print preview Form options dialog


<p>When executing the "Options" command on the Print Preview Form, the user sees a dialog Form with a GridControl that displays fake data. This example demonstrates how to create a custom PrintOptions dialog allowing programmers to provide fake data for preview.</p>


<h3>Description</h3>

<p>Get rid of using the obsolete property GridOptionsView.ShowHorzLines.</p>

<br/>



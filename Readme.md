<!-- default file list -->
*Files to look at*:

* [CustomGridView.cs](./CS/CustomPrintPreview/Grid/CustomGridView.cs) (VB: [CustomGridView.vb](./VB/CustomPrintPreview/Grid/CustomGridView.vb))
* **[MainForm.cs](./CS/CustomPrintPreview/MainForm.cs) (VB: [MainForm.vb](./VB/CustomPrintPreview/MainForm.vb))**
<!-- default file list end -->
# How to provide a custom datasource for the print preview Form options dialog


<p>When executing the "Options" command on the Print Preview Form, the user sees a dialog Form with a GridControl that displays fake data. This example demonstrates how to create a custom PrintOptions dialog allowing programmers to provide fake data for preview.</p>


<h3>Description</h3>

<p>The method GetScaleSize was moved to the class ScaleUtils due to refactoring.</p>

<br/>



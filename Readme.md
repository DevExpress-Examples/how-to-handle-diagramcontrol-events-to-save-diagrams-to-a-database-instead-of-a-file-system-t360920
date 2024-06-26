<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585415/15.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T360920)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DiagramOpenDialog.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramOpenDialog.cs) (VB: [DiagramOpenDialog.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramOpenDialog.vb))
* [DiagramSaveDialog.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramSaveDialog.cs) (VB: [DiagramSaveDialog.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramSaveDialog.vb))
* [DiagramSelector.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramSelector.cs) (VB: [DiagramSelector.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramSelector.vb))
* [DiagramStorage.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramStorage.cs) (VB: [DiagramStorageInitializer.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramStorageInitializer.vb))
* [DiagramStorageInitializer.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramStorageInitializer.cs) (VB: [DiagramStorageInitializer.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramStorageInitializer.vb))
* [Form1.cs](./CS/XtraDiagram.CustomDiagramStorage/Form1.cs) (VB: [Form1.vb](./VB/XtraDiagram.CustomDiagramStorage/Form1.vb))
* [Program.cs](./CS/XtraDiagram.CustomDiagramStorage/Program.cs) (VB: [Program.vb](./VB/XtraDiagram.CustomDiagramStorage/Program.vb))
<!-- default file list end -->
# How to handle DiagramControl events to save diagrams to a database instead of a file system


This example demonstrates how to open and save diagrams to a custom storage (e.g., a database) instead of a file system. In the example, the following events are used to implement this functionality:<br><br><strong><em>ShowingOpenDialog</em></strong> - This event fires before the standard Open dialog is shown and allows you to customize the dialog options or replace the standard dialog with a custom one. You can also cancel the Open operation by setting the <em>e.Cancel</em> parameter to true.<br><strong><em>ShowingSaveDialog</em></strong> - Similarly to the <em>ShowingOpenDialog</em> event, the <em>ShowingSaveDialog</em> event allows you to customize the standard Save dialog in DiagramControl or replace it with a custom one. Setting the <em>e.Cancel</em> parameter to true will cancel the Save operation.<br><strong><em>CustomLoadDocument</em></strong> - This event fires after a user selected a document in the Open dialog or the <em>DocumentSource</em> property was set in code. The event exposes the selected document source (e.g., a document name or a file stream) through the <em>e.DocumentSource</em> property and allows you to implement your own loading logic. For example, you can retrieve a diagram file from a database and load it into DiagramControl using the <em>LoadDocument</em> property (as demonstrated in the example) or populate the diagram with items manually. After implementing your custom loading logic, set the <em>e.Handled</em> parameter to true, so that DiagramControl does not load the previously selected document source.<br><em><strong>CustomSaveDocument</strong></em> - The <em>CustomSaveDocument</em> event allows you to specify custom saving logic for your diagram. The event fires after the Save operation was initiated and selection was made in the Save dialog (if there was a dialog). The <em>e.DocumentSource</em> property in the event args specifies the default location (file name, stream, etc.) where the diagram will be saved. You can set the<em> e.Handled</em> parameter to true to cancel the standard saving logic and implement your custom one. For example, save the diagram to a stream using the <em>SaveDocument</em> method as demonstrated in the example or iterate through diagram items manually and read required information.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-handle-diagramcontrol-events-to-save-diagrams-to-a-database-instead-of-a-file-system-t360920&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-handle-diagramcontrol-events-to-save-diagrams-to-a-database-instead-of-a-file-system-t360920&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

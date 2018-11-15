<!-- default file list -->
*Files to look at*:

* [DiagramOpenDialog.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramOpenDialog.cs) (VB: [DiagramOpenDialog.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramOpenDialog.vb))
* [DiagramSaveDialog.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramSaveDialog.cs) (VB: [DiagramSaveDialog.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramSaveDialog.vb))
* [DiagramSelector.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramSelector.cs) (VB: [DiagramSelector.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramSelector.vb))
* [DiagramStorage.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramStorage.cs) (VB: [DiagramStorage.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramStorage.vb))
* [DiagramStorageInitializer.cs](./CS/XtraDiagram.CustomDiagramStorage/DiagramStorageInitializer.cs) (VB: [DiagramStorageInitializer.vb](./VB/XtraDiagram.CustomDiagramStorage/DiagramStorageInitializer.vb))
* [Form1.cs](./CS/XtraDiagram.CustomDiagramStorage/Form1.cs) (VB: [Form1.vb](./VB/XtraDiagram.CustomDiagramStorage/Form1.vb))
* [Program.cs](./CS/XtraDiagram.CustomDiagramStorage/Program.cs) (VB: [Program.vb](./VB/XtraDiagram.CustomDiagramStorage/Program.vb))
<!-- default file list end -->
# How to handle DiagramControl events to save diagrams to a database instead of a file system


This example demonstrates how to open and save diagrams to a custom storage (e.g., a database) instead of a file system. In the example, the following events are used to implement this functionality:<br><br><strong><em>ShowingOpenDialog</em></strong> - This event fires before the standard Open dialog is shown and allows you to customize the dialog options or replace the standard dialog with a custom one. You can also cancel the Open operation by setting the <em>e.Cancel</em> parameter to true.<br><strong><em>ShowingSaveDialog</em></strong> - Similarly to the <em>ShowingOpenDialog</em> event, the <em>ShowingSaveDialog</em> event allows you to customize the standard Save dialog in DiagramControl or replace it with a custom one. Setting the <em>e.Cancel</em> parameter to true will cancel the Save operation.<br><strong><em>CustomLoadDocument</em></strong> - This event fires after a user selected a document in the Open dialog or the <em>DocumentSource</em> property was set in code. The event exposes the selected document source (e.g., a document name or a file stream) through the <em>e.DocumentSource</em> property and allows you to implement your own loading logic. For example, you can retrieve a diagram file from a database and load it into DiagramControl using the <em>LoadDocument</em> property (as demonstrated in the example) or populate the diagram with items manually. After implementing your custom loading logic, set the <em>e.Handled</em> parameter to true, so that DiagramControl does not load the previously selected document source.<br><em><strong>CustomSaveDocument</strong></em> - The <em>CustomSaveDocument</em> event allows you to specify custom saving logic for your diagram. The event fires after the Save operation was initiated and selection was made in the Save dialog (if there was a dialog). The <em>e.DocumentSource</em> property in the event args specifies the default location (file name, stream, etc.) where the diagram will be saved. You can set the<em> e.Handled</em> parameter to true to cancel the standard saving logic and implement your custom one. For example, save the diagram to a stream using the <em>SaveDocument</em> method as demonstrated in the example or iterate through diagram items manually and read required information.

<br/>



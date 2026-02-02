Imports System
Imports System.Data.Entity
Imports System.Windows.Forms
Imports DevExpress.Internal

Namespace XtraDiagram.CustomDiagramStorage

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory()
            Call Database.SetInitializer(New DiagramStorageInitializer())
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace

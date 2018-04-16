Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Internal

Namespace XtraDiagram.CustomDiagramStorage
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory()
            Database.SetInitializer(New DiagramStorageInitializer())

            Application.Run(New Form1())
        End Sub
    End Class
End Namespace

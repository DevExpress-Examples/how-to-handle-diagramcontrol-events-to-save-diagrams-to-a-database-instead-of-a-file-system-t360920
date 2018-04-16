Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace XtraDiagram.CustomDiagramStorage
    Public Class DiagramSelector
        Public Shared Function SelectDiagramToOpen() As String
            Dim selector = New DiagramOpenDialog() With {.Text = "Choose a diagram to open"}
            Return ShowDialogCore(selector)
        End Function

        Public Shared Function SelectDiagramToSave() As String
            Dim selector = New DiagramSaveDialog() With {.Text = "Choose a save location"}
            Return ShowDialogCore(selector)
        End Function

        Protected Shared Function ShowDialogCore(ByVal dialog As DiagramOpenDialog) As String
            dialog.ShowDialog()
            Return If(dialog.DialogResult = DialogResult.OK, dialog.SelectedItem, Nothing)
        End Function
    End Class
End Namespace

Imports System.ComponentModel
Imports System.Drawing

Namespace XtraDiagram.CustomDiagramStorage

    Public Partial Class DiagramSaveDialog
        Inherits DiagramOpenDialog

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnSelectedItemChanged()
            MyBase.OnSelectedItemChanged()
            textEdit1.Text = SelectedItem
        End Sub

        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            MyBase.OnClosing(e)
            SelectedItem = textEdit1.Text
        End Sub
    End Class
End Namespace

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace XtraDiagram.CustomDiagramStorage
    Partial Public Class DiagramSaveDialog
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
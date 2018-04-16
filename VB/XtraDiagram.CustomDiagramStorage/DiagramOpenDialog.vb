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
    Partial Public Class DiagramOpenDialog
        Inherits DevExpress.XtraEditors.XtraForm

        Public Property SelectedItem() As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            PopulateListBox()
        End Sub

        Private Sub PopulateListBox()
            If Not DesignMode Then
                listBoxControl1.DataSource = DiagramRepository.GetDiagramNames()
            End If
        End Sub

        Private Sub listBoxControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBoxControl1.MouseDoubleClick
            Dim itemIndex = listBoxControl1.IndexFromPoint(e.Location)
            If itemIndex > -1 Then
                DialogResult = DialogResult.OK
                Close()
            End If
        End Sub

        Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.SelectedIndexChanged
            OnSelectedItemChanged()
        End Sub

        Protected Overridable Sub OnSelectedItemChanged()
            SelectedItem = TryCast(listBoxControl1.SelectedItem, String)
        End Sub
    End Class
End Namespace
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace XtraDiagram.CustomDiagramStorage

    Public Partial Class DiagramOpenDialog
        Inherits XtraForm

        Public Property SelectedItem As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            PopulateListBox()
        End Sub

        Private Sub PopulateListBox()
            If Not DesignMode Then listBoxControl1.DataSource = DiagramRepository.GetDiagramNames()
        End Sub

        Private Sub listBoxControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim itemIndex = listBoxControl1.IndexFromPoint(e.Location)
            If itemIndex > -1 Then
                DialogResult = DialogResult.OK
                Close()
            End If
        End Sub

        Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnSelectedItemChanged()
        End Sub

        Protected Overridable Sub OnSelectedItemChanged()
            SelectedItem = TryCast(listBoxControl1.SelectedItem, String)
        End Sub
    End Class
End Namespace

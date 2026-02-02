Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports DevExpress.Diagram.Core
Imports DevExpress.XtraDiagram

Namespace XtraDiagram.CustomDiagramStorage

    Public Partial Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            diagramControl1.InitializeRibbon(ribbonControl1)
            DiagramFileActions.OpenFile(diagramControl1)
        End Sub

        Private Sub OnShowingOpenDialog(ByVal sender As Object, ByVal e As DiagramShowingOpenDialogEventArgs)
            Dim diagramName = DiagramSelector.SelectDiagramToOpen()
            If Not Equals(diagramName, Nothing) Then
                e.DocumentSourceToOpen = diagramName
            Else
                e.Cancel = True
            End If
        End Sub

        Private Sub OnCustomLoadDocument(ByVal sender As Object, ByVal e As DiagramCustomLoadDocumentEventArgs)
            If e.DocumentSource Is Nothing Then
                diagramControl1.NewDocument()
                Text = "(New Document)"
                Return
            End If

            Dim diagramName = CStr(e.DocumentSource)
            Text = diagramName
            Dim diagramData = DiagramRepository.GetDiagramData(diagramName)
            If diagramData IsNot Nothing Then diagramControl1.LoadDocument(New MemoryStream(diagramData))
            e.Handled = True
        End Sub

        Private Sub OnShowingSaveDialog(ByVal sender As Object, ByVal e As DiagramShowingSaveDialogEventArgs)
            Dim diagramName = DiagramSelector.SelectDiagramToSave()
            If Not Equals(diagramName, Nothing) Then
                e.DocumentSourceToSave = diagramName
            Else
                e.Cancel = True
            End If
        End Sub

        Private Sub OnCustomSaveDocument(ByVal sender As Object, ByVal e As DiagramCustomSaveDocumentEventArgs)
            Dim diagramName = CStr(e.DocumentSource)
            Text = diagramName
            Dim stream = New MemoryStream()
            diagramControl1.SaveDocument(stream)
            Dim diagramData = stream.ToArray()
            DiagramRepository.SaveDiagramData(diagramName, diagramData)
            e.Handled = True
        End Sub
    End Class
End Namespace

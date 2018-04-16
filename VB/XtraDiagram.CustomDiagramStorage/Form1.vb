Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Threading
Imports DevExpress.Diagram.Core
Imports DevExpress.XtraDiagram

Namespace XtraDiagram.CustomDiagramStorage
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            diagramControl1.InitializeRibbon(ribbonControl1)
            diagramControl1.OpenFile()
        End Sub
        Private Sub OnShowingOpenDialog(ByVal sender As Object, ByVal e As DiagramShowingOpenDialogEventArgs) Handles diagramControl1.ShowingOpenDialog
            Dim diagramName = DiagramSelector.SelectDiagramToOpen()
            If diagramName IsNot Nothing Then
                e.DocumentSourceToOpen = diagramName
            Else
                e.Cancel = True
            End If
        End Sub
        Private Sub OnCustomLoadDocument(ByVal sender As Object, ByVal e As DiagramCustomLoadDocumentEventArgs) Handles diagramControl1.CustomLoadDocument
            If e.DocumentSource Is Nothing Then
                diagramControl1.NewDocument()
                Text = "(New Document)"
                Return
            End If
            Dim diagramName = CStr(e.DocumentSource)
            Text = diagramName
            Dim diagramData = DiagramRepository.GetDiagramData(diagramName)
            If diagramData IsNot Nothing Then
                diagramControl1.LoadDocument(New MemoryStream(diagramData))
            End If
            e.Handled = True
        End Sub
        Private Sub OnShowingSaveDialog(ByVal sender As Object, ByVal e As DiagramShowingSaveDialogEventArgs) Handles diagramControl1.ShowingSaveDialog
            Dim diagramName = DiagramSelector.SelectDiagramToSave()
            If diagramName IsNot Nothing Then
                e.DocumentSourceToSave = diagramName
            Else
                e.Cancel = True
            End If
        End Sub
        Private Sub OnCustomSaveDocument(ByVal sender As Object, ByVal e As DiagramCustomSaveDocumentEventArgs) Handles diagramControl1.CustomSaveDocument
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

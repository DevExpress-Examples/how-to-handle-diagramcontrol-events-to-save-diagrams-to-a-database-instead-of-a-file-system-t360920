Imports DevExpress.Diagram.Core
Imports System.Data.Entity
Imports System.IO
Imports System.Linq
Imports DevExpress.XtraDiagram

Namespace XtraDiagram.CustomDiagramStorage

    Friend Class DiagramStorageInitializer
        Inherits DropCreateDatabaseIfModelChanges(Of DiagramStorage)

        Protected Overrides Sub Seed(ByVal storage As DiagramStorage)
            MyBase.Seed(storage)
            Dim diagram = New DiagramControl()
            For i As Integer = 0 To 5 - 1
                diagram.Items.Add(New DiagramShape() With {.Position = New DevExpress.Utils.PointFloat(200, 100 + i * 100), .Width = 100, .Height = 50, .Content = "Item " & (i + 1).ToString()})
                If i = 0 Then Continue For
                diagram.SelectedStencils = New StencilCollection(New String() {Enumerable.ElementAt(DiagramToolboxRegistrator.Stencils, i).Id})
                Using stream = New MemoryStream()
                    diagram.SaveDocument(stream)
                    Dim diagramData = New DiagramData() With {.Name =(i + 1).ToString() & " items", .Data = stream.ToArray()}
                    storage.DiagramData.Add(diagramData)
                End Using
            Next

            storage.SaveChanges()
        End Sub
    End Class
End Namespace

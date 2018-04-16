Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace XtraDiagram.CustomDiagramStorage
    Public Class DiagramStorage
        Inherits DbContext

        Public Property DiagramData() As DbSet(Of DiagramData)
    End Class
    Public Class DiagramData
        Public Property Id() As Integer
        Public Property Name() As String
        Public Property Data() As Byte()
    End Class
    Public Class DiagramRepository
        Public Shared Function GetDiagramNames() As IEnumerable(Of String)
            Dim storage = New DiagramStorage()
            Return storage.DiagramData.Select(Function(x) x.Name).ToList()
        End Function

        Public Shared Function GetDiagramData(ByVal diagramName As String) As Byte()
            Dim storage = New DiagramStorage()
            Return storage.DiagramData.FirstOrDefault(Function(x) x.Name = diagramName).Data
        End Function
        Public Shared Sub SaveDiagramData(ByVal diagramName As String, ByVal diagramData() As Byte)
            Dim storage = New DiagramStorage()
            Dim diagramInfo = storage.DiagramData.FirstOrDefault(Function(x) x.Name = diagramName)
            If diagramInfo Is Nothing Then
                diagramInfo = New DiagramData() With {.Name = diagramName}
                storage.DiagramData.Add(diagramInfo)
            End If
            diagramInfo.Data = diagramData
            storage.SaveChanges()
        End Sub
    End Class
End Namespace

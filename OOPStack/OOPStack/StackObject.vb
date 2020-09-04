Public Class StackObject
    Private data As String
    Private pointer As StackObject

    Public Sub SetData(d As String)
        data = d
    End Sub

    Public Sub SetNextItem(p As StackObject)
        pointer = p
    End Sub


    Public Function GetData()
        Return data
    End Function

    Public Function GetNextItem()
        Return pointer
    End Function
End Class

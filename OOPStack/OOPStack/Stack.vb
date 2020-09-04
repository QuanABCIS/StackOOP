Public Class Stack
    Private topStackItem As StackObject
    Private maxSize As Integer
    Private currentSize As Integer = 0

    Public Sub New(m As Integer)
        maxSize = m
    End Sub
    Public Function Pop()
        If IsNothing(topStackItem) Then
            Return "Stack empty"
        Else
            currentSize -= 1
            Dim valueToReturn = topStackItem.GetData
            topStackItem = topStackItem.GetNextItem
            Return valueToReturn
        End If
    End Function

    Public Sub Push(item As String)
        If Not currentSize.Equals(maxSize) Then
            currentSize += 1
            If IsNothing(topStackItem) Then
                topStackItem = New StackObject
                topStackItem.SetData(item)
            Else
                Dim newItem As StackObject = New StackObject
                newItem.SetData(item)
                newItem.SetNextItem(topStackItem)
                topStackItem = newItem
            End If
        Else
            Console.WriteLine("Stack Overflow")
        End If

    End Sub

End Class

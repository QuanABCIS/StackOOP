Module Module1

    Sub Main()
        Dim stack As Stack = New Stack(5)
        Dim userInput As Integer
        Dim exitCond As Boolean = False
        Do
            Console.WriteLine("1. Push")
            Console.WriteLine("2. Pop")
            Console.WriteLine("3. Exit")
            userInput = Console.ReadLine
            Select Case userInput
                Case 1
                    Console.WriteLine("Enter value to push:")
                    stack.Push(Console.ReadLine)
                Case 2
                    Console.WriteLine(stack.Pop())
                Case Else
                    exitCond = True
            End Select

        Loop Until exitCond
    End Sub

End Module

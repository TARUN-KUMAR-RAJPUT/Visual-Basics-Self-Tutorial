Module VBModule

    Sub Main()
        
        Dim x, y As Integer
        x = 1: y = 5:
        
        While x <= y
            Console.WriteLine(x)
            x = x + 1
        End While
        
        
        For i As Integer = 1 To 5 Step 1
            Console.WriteLine(i)
        Next
        
        
        Dim arr() As Integer = {1, 2, 3, 4, 5}
        
        For Each e As Integer In arr 
            Console.WriteLine(e)
        Next
        
                
        x = 1: y = 5:
        Do 
            Console.WriteLine(x)
            x = x + 1
        Loop While x <= y
        
        
    End Sub
End Module

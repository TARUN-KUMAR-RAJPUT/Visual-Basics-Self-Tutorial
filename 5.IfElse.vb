Module VBModule

    Sub Main()
        
        Dim x , y  As Integer 
        
        x = 10 : y = 10
        
        ' If x > y Then
        '     Console.WriteLine("x is grater ")
        ' End If
        
        
        If x > y Then
            Console.WriteLine("x is greater")
        Elseif y > x Then
            Console.WriteLine("y is greater")
        Else 
            Console.WriteLine("equal")
        End If
        
    
    End Sub
End Module

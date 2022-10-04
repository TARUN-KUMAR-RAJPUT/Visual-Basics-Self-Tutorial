
Module VBModule
    
    Function fun() 
        Console.WriteLine("fun is called ")
    End Function
    
    Function add(ByVal x As Integer, ByVal y As Integer) 
        Console.WriteLine(x + y)
    End Function
    
    Function sum(ByVal x As Integer, ByVal y As Integer) As Integer
        return x + y
    End Function
    
    
    Sub Main()
        fun()
        add(2,3)
        Console.WriteLine(sum(3,4))
    End Sub

    
End Module

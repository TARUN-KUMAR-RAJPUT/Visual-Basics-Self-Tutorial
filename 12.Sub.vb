
Module VBModule
    
    Sub fun() 
        Console.WriteLine("fun is called ")
    End Sub
    
    Sub add(ByVal x as Integer, ByVal y as Integer) 
        Console.WriteLine(x + y)
    End Sub
    
    Sub Main()
        fun()
        add(2,3)
    End Sub

End Module


Module VBModule
    
    Public Class Shape
        
        Public a as Integer
        
        
        'Constructors 
        
        Public Sub New()
            Console.WriteLine("Constructor called")
            a = 0
        End Sub
        
        Public Sub New(ByVal x as Integer)
            Console.WriteLine("Constructor called")
            a = x
        End Sub
        
        
        
        'Destructor
        
        Protected Overrides Sub Finalize()
            Console.WriteLine("Destructor called")
        End Sub
        
    End Class
    
    
    Sub Main()
        Dim obj1 As Shape = New Shape()
        Dim obj2 As Shape = New Shape(10)
        Console.WriteLine(obj1.a)
        Console.WriteLine(obj2.a)
    End Sub

    
End Module

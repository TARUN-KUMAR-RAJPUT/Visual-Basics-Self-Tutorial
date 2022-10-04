
Module VBModule
    
    Interface Shape
        Sub myshape()
    End Interface
    
    Class Circle
        
        Implements Shape
        Public Sub myshape() Implements Shape.myshape
            Console.WriteLine("Circle ")
        End Sub
        
    End Class
    
    Sub Main()
        Dim obj As Circle = New Circle()
        obj.myshape()
    End Sub

End Module


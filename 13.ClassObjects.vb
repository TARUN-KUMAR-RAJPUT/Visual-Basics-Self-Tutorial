
Module VBModule
    
    Public Class Shape
        
        Public a as Integer
        
        Public Function setVal(ByVal x As Integer)
            a = x
        End Function
        
        Public Function getVal() As Integer
            return a
        End Function
        
        
    End Class
    
    
    Sub Main()
        Dim obj As Shape = New Shape()    
        obj.setVal(10)
        Console.WriteLine(obj.getVal())
    End Sub
    
End Module

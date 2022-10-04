Module VBModule

    Sub Main()
        
        For i As Integer = 1 To 5 Step 1
            
            Console.WriteLine(i)
            
            If i = 3 Then
                Exit For
            End If
            
        Next
        
        For i As Integer = 1 To 5 Step 1
            
            
            If i = 3 Then
                Continue For
            End If
            
            Console.WriteLine(i)
            
        Next
    
    End Sub
End Module

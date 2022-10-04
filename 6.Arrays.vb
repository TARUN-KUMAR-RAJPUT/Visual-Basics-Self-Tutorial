Module VBModule

    Sub Main()
        
        Dim arr() As Integer = {1, 2, 3, 4, 5}
        Dim n As Integer = arr.Length
        
        For i As Integer = 0 to n - 1 Step 1
        
            Console.WriteLine(arr(i))
        
        Next        
        
        
        
        Dim arr1(3) As Integer 
        
        arr1(0) = 10
        arr1(1) = 20
        
        
        For i As Integer = 0 to 1 Step 1
            Console.WriteLine(arr1(i))
        Next        
    
    End Sub
End Module

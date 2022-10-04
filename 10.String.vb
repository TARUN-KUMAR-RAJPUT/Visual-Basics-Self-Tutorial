Module VBModule

    Sub Main()
    
        Dim s, t as String
        s = "Uchiha": t = "Itachi"
        
        Console.WriteLine(s)
        Console.WriteLine(s + " " + t)
        
        t = s + t
        Console.WriteLine(t)
        
        For i As Integer = 0 to s.Length - 1 Step 1
            Console.WriteLine(s(i))
        Next
        
    End Sub
End Module

Imports System.IO

Module Module1

    Sub Main()
        ' Machine Environment Variables
        Console.WriteLine("Machine Information")
        Console.WriteLine("======================")
        Console.WriteLine("Machine Name: " + Environment.MachineName)
        Console.WriteLine("OS Version: " & Environment.OSVersion.ToString())
        Console.WriteLine("System Directory: " + Environment.SystemDirectory)
        Console.WriteLine("User Name: " + Environment.UserName)
        Console.WriteLine("Version: " + Environment.Version.ToString())
        Console.WriteLine("Current Directory: " + Environment.CurrentDirectory)
        Console.WriteLine()

        ' Insert Code To Test Here
        '********************************************
        Dim streamreader As StreamReader = New StreamReader("c:\testing.txt")
        Dim streamwriter As StreamWriter = New StreamWriter("c:\testing_TEMPX.txt", False)
        Dim linetoread, linetowrite As String
        While streamreader.Peek <> -1
            linetoread = streamreader.ReadLine
            linetowrite = linetoread & "/rr" & linetoread.Substring(linetoread.Length - 10) & "_preview.avi"
            streamwriter.WriteLine(linetowrite)
        End While
        streamreader.Close()
        streamwriter.Close()

        '********************************************
        ' Simple Readline to ensure console doesn't close automatically
        Console.ReadLine()
    End Sub


End Module

Module Program
    Private server As ChatServer

    Sub Main()
        Try
            server = New ChatServer(5000)
            AddHandler Console.CancelKeyPress, AddressOf OnCtrlC
            Console.WriteLine("Starting Chat Server...")
            server.StartAsync().GetAwaiter().GetResult()
        Catch ex As Exception
            Console.WriteLine($"CRITICAL STARTUP ERROR: {ex.Message}")
            Console.WriteLine($"Stack: {ex.StackTrace}")
            Console.ReadKey()
            Return
        End Try
        Console.WriteLine("Server stopped.")
        Console.ReadKey()

    End Sub

    Private Sub OnCtrlC(sender As Object, e As ConsoleCancelEventArgs)
        Console.WriteLine(vbCrLf + "Ctrl+C - shutting down...")
        e.Cancel = True
        server?.StopServer()
    End Sub
End Module



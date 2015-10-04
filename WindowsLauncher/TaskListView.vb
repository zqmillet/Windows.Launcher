Public Class TaskListView
    Inherits Windows.Forms.ListView

    Private TaskListFullPath As String

    Public Sub New(ByVal TaskListFullPath As String)
        With Me
            .TaskListFullPath = TaskListFullPath

            .Dock = DockStyle.Fill
            .Margin = New Padding(1)
            .View = View.Details
            .GridLines = True
            .FullRowSelect = True
            .MultiSelect = True

            .Columns.Add("序号", 40)
            .Columns.Add("名称", 80)
            .Columns.Add("路径", 340)
            .Columns.Add("参数", 50)
            .Columns.Add("条件", 40)
        End With

        Load()
    End Sub

    Public Sub Load()
        If Not My.Computer.FileSystem.FileExists(TaskListFullPath) Then
            Exit Sub
        End If

        Dim Reader As New IO.StreamReader(TaskListFullPath, System.Text.Encoding.UTF8)
        Dim Line As String = ""
        Dim Index As Integer = 0
        While Not Reader.EndOfStream
            Line = Reader.ReadLine.Trim

            If Line = "" Then
                Continue While
            End If


            If Line.IndexOf("@") = 0 Then
                Index += 1
                Me.Items.Add(Index)
                Me.Items(Index - 1).SubItems.Add(Line.Remove(0, 1))
                Me.Items(Index - 1).SubItems.Add("")
                Me.Items(Index - 1).SubItems.Add("")
                Me.Items(Index - 1).SubItems.Add("")
                Continue While
            End If

            If Not Line.Contains("=") Then
                Exit Sub
            End If

            Dim TempString() = Line.Split("=")
            For i As Integer = 2 To TempString.Count - 1
                TempString(1) &= "=" & TempString(i)
            Next

            Select Case TempString(0).Trim
                Case "FullPath"
                    Me.Items(Index - 1).SubItems(2).Text = TempString(1).Trim
                Case "Parameter"
                    Me.Items(Index - 1).SubItems(3).Text = TempString(1).Trim
                Case "Condition"
                    Me.Items(Index - 1).SubItems(4).Text = TempString(1).Trim
            End Select

        End While
        Reader.Close()
    End Sub
End Class

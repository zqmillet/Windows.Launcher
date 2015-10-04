Public Module TaskCondition
    Public Const None As UInt64 = &H0
    Public Const ConnectInternet As UInt64 = &H1
End Module

Public Class Task
    Public FullPath As String
    Public Parameter As String
    Public Condition As Integer

    Public Sub New()
        FullPath = ""
        Parameter = ""
        Condition = TaskCondition.None
    End Sub

    Public Sub New(ByVal FullPath As String, ByVal Parameter As String, ByVal Condition As Integer)
        With Me
            .FullPath = FullPath
            .Parameter = Parameter
            .Condition = Condition
        End With
    End Sub

    Public Sub New(ByVal ConfigCode As String)

    End Sub

    Public Function GetConfigCode() As String
        Return ""
    End Function
End Class

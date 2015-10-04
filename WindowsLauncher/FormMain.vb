Public Class FormMain
    Private Const FormWidth = 300

    Private TableLayoutPanel As New TableLayoutPanel
    Private LabelFullPath As New Label
    Private TextBoxFullPath As New TextBox
    Private LabelParameter As New Label
    Private TextBoxParameter As New TextBox
    Private ButtonBrowser As New Button

    Public Sub New()

        InitializeComponent()

        InitialInterface()

    End Sub

    Private Sub InitialInterface()
        With LabelFullPath
            .Text = "路径"
            .Dock = DockStyle.Fill
            .TextAlign = ContentAlignment.MiddleLeft
        End With

        With LabelParameter
            .Text = "参数"
            .Dock = DockStyle.Fill
            .TextAlign = ContentAlignment.MiddleLeft
        End With

        With ButtonBrowser
            .Text = "浏览"
            .Dock = DockStyle.Fill
        End With

        With TableLayoutPanel
            '.BorderStyle = BorderStyle.FixedSingle
            .CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            .ColumnCount = 3
            .RowCount = 5
            .Dock = DockStyle.Fill

            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40))
            .ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40))

            'For i As Integer = 0 To .RowCount - 1
            '    .RowStyles.Add(New RowStyle(ContentAlignment))
            'Next

            .Controls.Add(LabelFullPath, 0, 0)
            .Controls.Add(TextBoxFullPath, 1, 0)
            .Controls.Add(ButtonBrowser, 2, 0)

            .Controls.Add(LabelParameter, 0, 1)
            .Controls.Add(TextBoxParameter, 1, 1)
            .SetColumnSpan(TextBoxParameter, 2)
        End With

        With Me
            .Text = "Windows Launcher"
            .Size = New Size(FormWidth, .Height)
            .MaximizeBox = False
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .Icon = New Icon(Application.StartupPath & "\icon\MainIcon.ico")
            .Controls.Add(TableLayoutPanel)
        End With
    End Sub


End Class

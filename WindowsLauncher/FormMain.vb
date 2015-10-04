Public Class FormMain
    Private Const FormWidth = 600
    Private Const FormHeight = 400


    Private TableLayoutPanel As New TableLayoutPanel
    Private LabelName As New Label
    Private TextBoxName As New TextBox
    Private LabelFullPath As New Label
    Private TextBoxFullPath As New TextBox
    Private LabelParameter As New Label
    Private TextBoxParameter As New TextBox
    Private ButtonBrowser As New Button
    Private LabelCondition As New Label
    Private TextBoxCondition As New TextBox

    Private ButtonOption As New Button
    Private ButtonAdd As New Button

    Private TaskListView As TaskListView

    Public Sub New()

        InitializeComponent()
        InitialInterface()

    End Sub

    Private Sub InitialInterface()
        With TableLayoutPanel
            '.BorderStyle = BorderStyle.FixedSingle
            '.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single

            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 35.0F))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.0F))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40.0F))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40.0F))

            .ColumnCount = 4
            .RowCount = 6

            .Dock = DockStyle.Fill
            .Padding = New Padding(2)


            .Controls.Add(LabelName, 0, 0)
            .SetColumnSpan(TextBoxName, 3)
            .Controls.Add(TextBoxName, 1, 0)

            .Controls.Add(LabelFullPath, 0, 1)
            .SetColumnSpan(TextBoxFullPath, 2)
            .Controls.Add(TextBoxFullPath, 1, 1)
            .Controls.Add(ButtonBrowser, 3, 1)

            .Controls.Add(LabelParameter, 0, 2)
            .SetColumnSpan(TextBoxParameter, 3)
            .Controls.Add(TextBoxParameter, 1, 2)

            .Controls.Add(LabelCondition, 0, 3)
            .SetColumnSpan(TextBoxCondition, 3)
            .Controls.Add(TextBoxCondition, 1, 3)

            .Controls.Add(ButtonOption, 2, 4)
            .Controls.Add(ButtonAdd, 3, 4)

            TaskListView = New TaskListView(Application.StartupPath & "\WindowsLauncher.cfg")
            .SetColumnSpan(TaskListView, 4)
            .Controls.Add(TaskListView, 0, 5)
        End With

        With LabelName
            .Text = "名称"
            .Dock = DockStyle.Fill
            .TextAlign = ContentAlignment.MiddleLeft
        End With

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

        With LabelCondition
            .Text = "条件"
            .Dock = DockStyle.Fill
            .TextAlign = ContentAlignment.MiddleLeft
        End With

        With TextBoxName
            .Margin = New Padding(1)
            .Dock = DockStyle.Fill
        End With

        With TextBoxFullPath
            .Margin = New Padding(1)
            .Dock = DockStyle.Fill
        End With

        With TextBoxParameter
            .Margin = New Padding(1)
            .Dock = DockStyle.Fill
        End With

        With TextBoxCondition
            .Margin = New Padding(1)
            .Dock = DockStyle.Fill
        End With

        With ButtonBrowser
            .Text = "浏览"
            .Margin = New Padding(0)
            .Dock = DockStyle.Fill
        End With

        With ButtonAdd
            .Text = "添加"
            .Margin = New Padding(0)
            .Dock = DockStyle.Fill
        End With

        With ButtonOption
            .Text = "设置"
            .Margin = New Padding(0)
            .Dock = DockStyle.Fill
        End With

        With Me
            .Text = "Windows Launcher"
            .Size = New Size(FormWidth, FormHeight)
            .MaximizeBox = False
            .MinimumSize = .Size
            .Icon = New Icon(Application.StartupPath & "\icon\MainIcon.ico")
            .Controls.Add(TableLayoutPanel)
        End With
    End Sub

End Class

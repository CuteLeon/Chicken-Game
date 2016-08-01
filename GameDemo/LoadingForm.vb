Imports System.ComponentModel

Public Class LoadingForm
    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '设置程序窗口的ICON
        Me.Icon = My.Resources.GameResource.ChickIcon
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs)
        '切换界面
        LevelForm.Show()
        Me.Hide()
    End Sub

    Private Sub StartButton_MouseDown(sender As Object, e As MouseEventArgs)
        StartButton.Image = My.Resources.GameResource.Button_2
    End Sub

    Private Sub StartButton_MouseEnter(sender As Object, e As EventArgs)
        StartButton.Image = My.Resources.GameResource.Button_1
    End Sub

    Private Sub StartButton_MouseLeave(sender As Object, e As EventArgs)
        StartButton.Image = My.Resources.GameResource.Button_0
    End Sub

    Private Sub StartButton_MouseUp(sender As Object, e As MouseEventArgs)
        StartButton.Image = My.Resources.GameResource.Button_1
    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        '加载进度条
        Static ProgressIndex As Int16 = 1
        StartButton.Image = My.Resources.GameResource.ResourceManager.GetObject("ProgressBar_" & ProgressIndex)
        ProgressIndex += 1
        If ProgressIndex = 42 Then
            LoadingTimer.Stop()
            StartButton.Image = My.Resources.GameResource.Button_0
            StartButton.Text = "开始游戏"
            '加载进度条完毕后绑定控件事件
            AddHandler StartButton.MouseEnter, AddressOf StartButton_MouseEnter
            AddHandler StartButton.MouseDown, AddressOf StartButton_MouseDown
            AddHandler StartButton.MouseUp, AddressOf StartButton_MouseUp
            AddHandler StartButton.MouseLeave, AddressOf StartButton_MouseLeave
            AddHandler StartButton.Click, AddressOf StartButton_Click
        End If
    End Sub

    Private Sub LoadingForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        '允许鼠标拖动窗口
        MoveWindow(Me.Handle)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        '退出程序
        For Index As Byte = 1 To 10
            Me.Opacity -= 0.1
            Threading.Thread.Sleep(50)
        Next
        Application.Exit()
    End Sub

    Private Sub MinButton_Click(sender As Object, e As EventArgs) Handles MinButton.Click
        '最小化
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown, MinButton.MouseDown
        Dim SenderLabel As Label = CType(sender, Label)
        SenderLabel.Image = CType(My.Resources.GameResource.ResourceManager.GetObject(SenderLabel.Tag), Bitmap).Clone(New Rectangle(2 * SenderLabel.Width, 0, SenderLabel.Width, 21), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles CloseButton.MouseEnter, MinButton.MouseEnter
        Dim SenderLabel As Label = CType(sender, Label)
        SenderLabel.Image = CType(My.Resources.GameResource.ResourceManager.GetObject(SenderLabel.Tag), Bitmap).Clone(New Rectangle(SenderLabel.Width, 0, SenderLabel.Width, 21), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave, MinButton.MouseLeave
        Dim SenderLabel As Label = CType(sender, Label)
        SenderLabel.Image = CType(My.Resources.GameResource.ResourceManager.GetObject(SenderLabel.Tag), Bitmap).Clone(New Rectangle(0, 0, SenderLabel.Width, 21), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub Button_MouseUp(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseUp, MinButton.MouseUp
        Dim SenderLabel As Label = CType(sender, Label)
        SenderLabel.Image = CType(My.Resources.GameResource.ResourceManager.GetObject(SenderLabel.Tag), Bitmap).Clone(New Rectangle(SenderLabel.Width, 0, SenderLabel.Width, 21), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub LoadingForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '关闭程序
        Application.Exit()
    End Sub
End Class

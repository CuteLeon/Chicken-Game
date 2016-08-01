Imports System.ComponentModel

Public Class LevelForm

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

    '高亮显示选中的Level
    Private Sub Level_Index_MouseEnter(sender As Object, e As EventArgs) Handles Level_1.MouseEnter, Level_2.MouseEnter, Level_3.MouseEnter, Level_4.MouseEnter, Level_5.MouseEnter
        Dim LevelObject As PictureBox = CType(sender, PictureBox)
        LevelObject.Image = My.Resources.GameResource._Select
    End Sub

    Private Sub Level_Index_MouseLeave(sender As Object, e As EventArgs) Handles Level_1.MouseLeave, Level_2.MouseLeave, Level_3.MouseLeave, Level_4.MouseLeave, Level_5.MouseLeave
        Dim LevelObject As PictureBox = CType(sender, PictureBox)
        LevelObject.Image = Nothing
    End Sub

    Private Sub Level_Index_Click(sender As Object, e As EventArgs) Handles Level_1.Click, Level_2.Click, Level_3.Click, Level_4.Click, Level_5.Click
        '进入对应的关卡
        Dim LevelObject As PictureBox = CType(sender, PictureBox)
        GlobalData.LevelIndex = LevelObject.Tag

        GameForm.Show()
        Me.Hide()
    End Sub

    Private Sub LevelForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        '允许鼠标拖动
        MoveWindow(Me.Handle)
    End Sub

    Private Sub LevelForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '关闭程序
        Application.Exit()
    End Sub

    Private Sub LevelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '设置ICON
        Me.Icon = My.Resources.GameResource.ChickIcon
    End Sub
End Class
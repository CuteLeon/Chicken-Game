Imports System.ComponentModel

Public Class GameForm
    Dim GameBitmap As Bitmap
    Dim GameGraphics As Graphics
    Dim ChickRect As Rectangle
    Dim HP As Integer = 10

    '敌人类
    Private Structure Enemy
        Dim X As Integer
        Dim Y As Integer
        Dim D As Boolean '移动方向（False:向右）
    End Structure
    Dim Enemys As ArrayList = New ArrayList

    '蔬菜类
    Private Structure Vegetable
        Dim X As Integer
        Dim Y As Integer
        Dim V As Integer
        Dim Index As Byte
    End Structure
    '蔬菜对象集合
    Dim Vegetables As ArrayList = New ArrayList

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '设置ICON
        Me.Icon = My.Resources.GameResource.ChickIcon
        '初始化界面
        Score.Text = 0
        GameBitmap = My.Resources.GameResource.ResourceManager.GetObject("GameBackground_" & GlobalData.LevelIndex)
        Me.BackgroundImage = GameBitmap
    End Sub

    Private Sub GameForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        '允许鼠标拖动窗口
        MoveWindow(Me.Handle)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        '关闭
        Me.Close()
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

    Private Sub GameEngine_Tick(sender As Object, e As EventArgs) Handles GameEngine.Tick
        '初始化
        GameBitmap = Nothing
        GameBitmap = My.Resources.GameResource.ResourceManager.GetObject("GameBackground_" & GlobalData.LevelIndex)
        GameGraphics = Graphics.FromImage(GameBitmap)
        'ChickRect = New Rectangle(MousePosition.X - Me.Left - 40, 520, 80, 121)
        ChickRect = New Rectangle(MousePosition.X - Me.Left - 40, MousePosition.Y - Me.Top - 60, 80, 121)

        '有一定概率抛出新蔬果和敌人
        If VBMath.Rnd < 0.1 Then ThrowVegetable()
        If VBMath.Rnd < 0.02 Then ThrowEnemy()

        Dim VegetableIndex As Integer = 0, VegetablesCount As Integer = Vegetables.Count
        If VegetablesCount > 0 Then

            '遍历蔬果集合
            Do Until VegetableIndex = VegetablesCount
                '更新蔬果状态
                UpdateVegetable(Vegetables.Item(VegetableIndex))
                If Vegetables.Item(VegetableIndex).Y > Me.Height Then
                    '超出窗口范围的移除
                    Vegetables.Item(VegetableIndex) = Nothing
                    Vegetables.RemoveAt(VegetableIndex)
                    VegetablesCount -= 1
                    Continue Do
                End If
                If ChickRect.IntersectsWith(New Rectangle(Vegetables.Item(VegetableIndex).X - 25, Vegetables.Item(VegetableIndex).Y - 25, 50, 50)) Then
                    '被吃掉的移除
                    Vegetables.Item(VegetableIndex) = Nothing
                    Vegetables.RemoveAt(VegetableIndex)
                    VegetablesCount -= 1
                    Score.Text += 1
                    Continue Do
                End If
                '把剩下的蔬果绘制到窗口
                GameGraphics.DrawImage(
                    My.Resources.GameResource.ResourceManager.GetObject("Vegetable_" & CType(Vegetables.Item(VegetableIndex), Vegetable).Index),
                    Vegetables.Item(VegetableIndex).X, Vegetables.Item(VegetableIndex).Y, 50, 50)
                VegetableIndex += 1
            Loop
        End If

        Dim EnemyIndex As Integer, EnemysCount As Integer = Enemys.Count
        If EnemysCount > 0 Then

            Do Until EnemyIndex = EnemysCount
                UpdateEnemy(Enemys.Item(EnemyIndex))
                If Enemys.Item(EnemyIndex).Y > Me.Height Then
                    '超出窗口范围的移除
                    Enemys.Item(EnemyIndex) = Nothing
                    Enemys.RemoveAt(EnemyIndex)
                    EnemysCount -= 1
                    Continue Do
                End If
                If ChickRect.IntersectsWith(New Rectangle(Enemys.Item(EnemyIndex).X - 32, Enemys.Item(EnemyIndex).Y - 32, 64, 64)) Then
                    Enemys.Item(EnemyIndex) = Nothing
                    Enemys.RemoveAt(EnemyIndex)
                    EnemysCount -= 1
                    HP -= 1
                    Continue Do
                End If

                GameGraphics.DrawImage(
                    My.Resources.GameResource.ResourceManager.GetObject("Bee_" & IIf(CType(Enemys.Item(EnemyIndex), Enemy).D, "1", "0")),
                    Enemys.Item(EnemyIndex).X, Enemys.Item(EnemyIndex).Y, 64, 64)
                EnemyIndex += 1
            Loop
        End If

        '绘制小鸡
        'GameGraphics.DrawImage(My.Resources.GameResource.Chick, MousePosition.X - Me.Left - 40, 520, 80, 120)
        GameGraphics.DrawImage(My.Resources.GameResource.Chick, MousePosition.X - Me.Left - 40, MousePosition.Y - Me.Top - 60, 80, 120)
        '绘制土地
        GameGraphics.DrawImage(My.Resources.GameResource.ResourceManager.GetObject("GameGround_" & GlobalData.LevelIndex), 1, 639)
        '绘制血槽
        GameGraphics.FillRectangle(Brushes.Red, New Rectangle(100, 670, 36 * HP, 15))
        GameGraphics.DrawRectangle(Pens.Gold, New Rectangle(100, 670, 360, 15))
        '显示
        Me.BackgroundImage = GameBitmap
        GameGraphics.Dispose()

        If HP = 0 Then GameOver()
    End Sub

    Private Sub ThrowVegetable()
        '抛出蔬果
        Dim TempVegetable As Vegetable
        With TempVegetable
            .X = VBMath.Rnd() * (Me.Width - 50)
            .Y = -50
            .Index = CInt(VBMath.Rnd * 19)
        End With
        Vegetables.Add(TempVegetable)

        'Debug.Print("抛出新蔬菜：" & TempVegetable.X & "," & TempVegetable.Y & "," & TempVegetable.Index)
    End Sub
    Private Sub ThrowEnemy()
        Dim TempEnemy As Enemy
        With TempEnemy
            .X = 5
            .Y = 0
            .D = False
        End With
        Enemys.Add(TempEnemy)
    End Sub

    Private Sub UpdateVegetable(ByRef Vegetable As Vegetable)
        '更新蔬果
        Vegetable.Y += 15
    End Sub

    Private Sub UpdateEnemy(ByRef Enemy As Enemy)
        '更新敌人
        Enemy.Y += 3
        Enemy.X += IIf(Enemy.D, -10, 10)
        If Enemy.X < 5 OrElse Enemy.X > Me.Width - 69 Then Enemy.D = Not Enemy.D
    End Sub

    Private Sub GameForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '关闭时返回关卡窗口
        LevelForm.Show()
    End Sub

    Private Sub GameOver()
        GameEngine.Stop()
        MsgBox("得分：" & Score.Text & vbCrLf & "点击""确定""重新开始游戏！", vbInformation, "游戏结束：")
        '初始化
        My.Resources.GameResource.ResourceManager.GetObject("GameBackground_" & GlobalData.LevelIndex)
        Vegetables.Clear()
        Enemys.Clear()
        Score.Text = 0
        HP = 10
        GameEngine.Start()
    End Sub

    Private Sub PlayPauseButton_Click(sender As Object, e As EventArgs) Handles PlayPauseButton.Click
        GameEngine.Enabled = Not GameEngine.Enabled
    End Sub

    Private Sub PlayPauseButton_MouseEnter(sender As Object, e As EventArgs) Handles PlayPauseButton.MouseEnter
        PlayPauseButton.Image = My.Resources.GameResource.ResourceManager.GetObject(IIf(GameEngine.Enabled, "Pause", "Play") & "_2")
    End Sub

    Private Sub PlayPauseButton_MouseLeave(sender As Object, e As EventArgs) Handles PlayPauseButton.MouseLeave
        PlayPauseButton.Image = My.Resources.GameResource.ResourceManager.GetObject(IIf(GameEngine.Enabled, "Pause", "Play") & "_1")
    End Sub

    Private Sub PlayPauseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles PlayPauseButton.MouseUp
        PlayPauseButton.Image = My.Resources.GameResource.ResourceManager.GetObject(IIf(GameEngine.Enabled, "Pause", "Play") & "_2")
    End Sub

    Private Sub PlayPauseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PlayPauseButton.MouseDown
        PlayPauseButton.Image = My.Resources.GameResource.ResourceManager.GetObject(IIf(GameEngine.Enabled, "Play", "Pause") & "_2")
    End Sub
End Class
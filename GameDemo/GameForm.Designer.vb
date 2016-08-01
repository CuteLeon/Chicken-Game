<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.MinButton = New System.Windows.Forms.Label()
        Me.GameEngine = New System.Windows.Forms.Timer(Me.components)
        Me.TipsLabel = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayPauseButton = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.Image = Global.爱吃蔬果的小鸡.My.Resources.GameResource.Close
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(441, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(39, 21)
        Me.CloseButton.TabIndex = 41
        Me.CloseButton.Tag = "Close"
        '
        'MinButton
        '
        Me.MinButton.BackColor = System.Drawing.Color.Transparent
        Me.MinButton.Image = Global.爱吃蔬果的小鸡.My.Resources.GameResource.Min
        Me.MinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MinButton.Location = New System.Drawing.Point(409, 0)
        Me.MinButton.Name = "MinButton"
        Me.MinButton.Size = New System.Drawing.Size(32, 21)
        Me.MinButton.TabIndex = 40
        Me.MinButton.Tag = "Min"
        '
        'GameEngine
        '
        Me.GameEngine.Enabled = True
        Me.GameEngine.Interval = 50
        '
        'TipsLabel
        '
        Me.TipsLabel.AutoSize = True
        Me.TipsLabel.BackColor = System.Drawing.Color.Transparent
        Me.TipsLabel.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TipsLabel.ForeColor = System.Drawing.Color.White
        Me.TipsLabel.Location = New System.Drawing.Point(12, 690)
        Me.TipsLabel.Name = "TipsLabel"
        Me.TipsLabel.Size = New System.Drawing.Size(326, 21)
        Me.TipsLabel.TabIndex = 42
        Me.TipsLabel.Text = "* 使用鼠标控制小鸡左右移动吃掉水果和蔬菜"
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.BackColor = System.Drawing.Color.Transparent
        Me.Score.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Score.ForeColor = System.Drawing.Color.White
        Me.Score.Location = New System.Drawing.Point(77, 9)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(34, 38)
        Me.Score.TabIndex = 43
        Me.Score.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 28)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "分数:"
        '
        'PlayPauseButton
        '
        Me.PlayPauseButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayPauseButton.Image = Global.爱吃蔬果的小鸡.My.Resources.GameResource.Pause_1
        Me.PlayPauseButton.Location = New System.Drawing.Point(15, 625)
        Me.PlayPauseButton.Name = "PlayPauseButton"
        Me.PlayPauseButton.Size = New System.Drawing.Size(60, 60)
        Me.PlayPauseButton.TabIndex = 47
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(480, 720)
        Me.Controls.Add(Me.PlayPauseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.TipsLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MinButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As Label
    Friend WithEvents MinButton As Label
    Friend WithEvents GameEngine As Timer
    Friend WithEvents TipsLabel As Label
    Friend WithEvents Score As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayPauseButton As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LevelForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LevelForm))
        Me.Level_1 = New System.Windows.Forms.PictureBox()
        Me.Level_2 = New System.Windows.Forms.PictureBox()
        Me.Level_3 = New System.Windows.Forms.PictureBox()
        Me.Level_4 = New System.Windows.Forms.PictureBox()
        Me.Level_5 = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.MinButton = New System.Windows.Forms.Label()
        CType(Me.Level_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level_5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Level_1
        '
        Me.Level_1.BackColor = System.Drawing.Color.Transparent
        Me.Level_1.BackgroundImage = CType(resources.GetObject("Level_1.BackgroundImage"), System.Drawing.Image)
        Me.Level_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Level_1.Location = New System.Drawing.Point(109, 131)
        Me.Level_1.Name = "Level_1"
        Me.Level_1.Size = New System.Drawing.Size(261, 103)
        Me.Level_1.TabIndex = 1
        Me.Level_1.TabStop = False
        Me.Level_1.Tag = "1"
        '
        'Level_2
        '
        Me.Level_2.BackColor = System.Drawing.Color.Transparent
        Me.Level_2.BackgroundImage = CType(resources.GetObject("Level_2.BackgroundImage"), System.Drawing.Image)
        Me.Level_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Level_2.Location = New System.Drawing.Point(109, 235)
        Me.Level_2.Name = "Level_2"
        Me.Level_2.Size = New System.Drawing.Size(261, 103)
        Me.Level_2.TabIndex = 2
        Me.Level_2.TabStop = False
        Me.Level_2.Tag = "2"
        '
        'Level_3
        '
        Me.Level_3.BackColor = System.Drawing.Color.Transparent
        Me.Level_3.BackgroundImage = CType(resources.GetObject("Level_3.BackgroundImage"), System.Drawing.Image)
        Me.Level_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Level_3.Location = New System.Drawing.Point(109, 339)
        Me.Level_3.Name = "Level_3"
        Me.Level_3.Size = New System.Drawing.Size(261, 103)
        Me.Level_3.TabIndex = 3
        Me.Level_3.TabStop = False
        Me.Level_3.Tag = "3"
        '
        'Level_4
        '
        Me.Level_4.BackColor = System.Drawing.Color.Transparent
        Me.Level_4.BackgroundImage = CType(resources.GetObject("Level_4.BackgroundImage"), System.Drawing.Image)
        Me.Level_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Level_4.Location = New System.Drawing.Point(109, 443)
        Me.Level_4.Name = "Level_4"
        Me.Level_4.Size = New System.Drawing.Size(261, 103)
        Me.Level_4.TabIndex = 4
        Me.Level_4.TabStop = False
        Me.Level_4.Tag = "4"
        '
        'Level_5
        '
        Me.Level_5.BackColor = System.Drawing.Color.Transparent
        Me.Level_5.BackgroundImage = CType(resources.GetObject("Level_5.BackgroundImage"), System.Drawing.Image)
        Me.Level_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Level_5.Location = New System.Drawing.Point(109, 547)
        Me.Level_5.Name = "Level_5"
        Me.Level_5.Size = New System.Drawing.Size(261, 103)
        Me.Level_5.TabIndex = 5
        Me.Level_5.TabStop = False
        Me.Level_5.Tag = "5"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.Image = Global.爱吃蔬果的小鸡.My.Resources.GameResource.Close
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(441, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(39, 21)
        Me.CloseButton.TabIndex = 39
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
        Me.MinButton.TabIndex = 32
        Me.MinButton.Tag = "Min"
        '
        'LevelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.爱吃蔬果的小鸡.My.Resources.GameResource.LevelBackground
        Me.ClientSize = New System.Drawing.Size(480, 720)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MinButton)
        Me.Controls.Add(Me.Level_5)
        Me.Controls.Add(Me.Level_4)
        Me.Controls.Add(Me.Level_3)
        Me.Controls.Add(Me.Level_2)
        Me.Controls.Add(Me.Level_1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LevelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "选择关卡"
        CType(Me.Level_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level_5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseButton As Label
    Friend WithEvents MinButton As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Level_1 As PictureBox
    Friend WithEvents Level_2 As PictureBox
    Friend WithEvents Level_3 As PictureBox
    Friend WithEvents Level_4 As PictureBox
    Friend WithEvents Level_5 As PictureBox
End Class

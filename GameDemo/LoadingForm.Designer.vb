<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
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
        Me.StartButton = New System.Windows.Forms.Label()
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MinButton = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StartButton.Image = Global.爱吃蔬果的小鸡.My.Resources.GameResource.ProgressBar_01
        Me.StartButton.Location = New System.Drawing.Point(0, 540)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(480, 52)
        Me.StartButton.TabIndex = 0
        Me.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoadingTimer
        '
        Me.LoadingTimer.Enabled = True
        Me.LoadingTimer.Interval = 50
        '
        'MinButton
        '
        Me.MinButton.BackColor = System.Drawing.Color.Transparent
        Me.MinButton.Image = Global.爱吃蔬果的小鸡.My.Resources.GameResource.Min
        Me.MinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MinButton.Location = New System.Drawing.Point(408, 1)
        Me.MinButton.Name = "MinButton"
        Me.MinButton.Size = New System.Drawing.Size(32, 21)
        Me.MinButton.TabIndex = 32
        Me.MinButton.Tag = "Min"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.Image = Global.爱吃蔬果的小鸡.My.Resources.GameResource.Close
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(440, 1)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(39, 21)
        Me.CloseButton.TabIndex = 39
        Me.CloseButton.Tag = "Close"
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.爱吃蔬果的小鸡.My.Resources.GameResource.HomeBackground
        Me.ClientSize = New System.Drawing.Size(480, 720)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MinButton)
        Me.Controls.Add(Me.StartButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "游戏正在启动"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartButton As Label
    Friend WithEvents LoadingTimer As Timer
    Friend WithEvents MinButton As Label
    Friend WithEvents CloseButton As Label
End Class

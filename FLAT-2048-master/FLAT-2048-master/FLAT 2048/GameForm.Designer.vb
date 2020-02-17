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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.Grid1 = New System.Windows.Forms.PictureBox()
        Me.Grid2 = New System.Windows.Forms.PictureBox()
        Me.Grid3 = New System.Windows.Forms.PictureBox()
        Me.Grid4 = New System.Windows.Forms.PictureBox()
        Me.Grid5 = New System.Windows.Forms.PictureBox()
        Me.Grid6 = New System.Windows.Forms.PictureBox()
        Me.Grid7 = New System.Windows.Forms.PictureBox()
        Me.Grid8 = New System.Windows.Forms.PictureBox()
        Me.Grid9 = New System.Windows.Forms.PictureBox()
        Me.Grid10 = New System.Windows.Forms.PictureBox()
        Me.Grid11 = New System.Windows.Forms.PictureBox()
        Me.Grid12 = New System.Windows.Forms.PictureBox()
        Me.Grid13 = New System.Windows.Forms.PictureBox()
        Me.Grid14 = New System.Windows.Forms.PictureBox()
        Me.Grid15 = New System.Windows.Forms.PictureBox()
        Me.Grid16 = New System.Windows.Forms.PictureBox()
        Me.Panel = New System.Windows.Forms.PictureBox()
        Me.MovePanelTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MovePanelTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PlusScoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RandomTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RollScoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SetOpacityTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SetOpacityTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Location = New System.Drawing.Point(1, 86)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(64, 64)
        Me.Grid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid1.TabIndex = 0
        Me.Grid1.TabStop = False
        '
        'Grid2
        '
        Me.Grid2.Location = New System.Drawing.Point(66, 86)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(64, 64)
        Me.Grid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid2.TabIndex = 1
        Me.Grid2.TabStop = False
        '
        'Grid3
        '
        Me.Grid3.Location = New System.Drawing.Point(131, 86)
        Me.Grid3.Name = "Grid3"
        Me.Grid3.Size = New System.Drawing.Size(64, 64)
        Me.Grid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid3.TabIndex = 2
        Me.Grid3.TabStop = False
        '
        'Grid4
        '
        Me.Grid4.Location = New System.Drawing.Point(196, 86)
        Me.Grid4.Name = "Grid4"
        Me.Grid4.Size = New System.Drawing.Size(64, 64)
        Me.Grid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid4.TabIndex = 3
        Me.Grid4.TabStop = False
        '
        'Grid5
        '
        Me.Grid5.Location = New System.Drawing.Point(1, 157)
        Me.Grid5.Name = "Grid5"
        Me.Grid5.Size = New System.Drawing.Size(64, 64)
        Me.Grid5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid5.TabIndex = 4
        Me.Grid5.TabStop = False
        '
        'Grid6
        '
        Me.Grid6.Location = New System.Drawing.Point(66, 157)
        Me.Grid6.Name = "Grid6"
        Me.Grid6.Size = New System.Drawing.Size(64, 64)
        Me.Grid6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid6.TabIndex = 5
        Me.Grid6.TabStop = False
        '
        'Grid7
        '
        Me.Grid7.Location = New System.Drawing.Point(131, 157)
        Me.Grid7.Name = "Grid7"
        Me.Grid7.Size = New System.Drawing.Size(64, 64)
        Me.Grid7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid7.TabIndex = 6
        Me.Grid7.TabStop = False
        '
        'Grid8
        '
        Me.Grid8.Location = New System.Drawing.Point(196, 157)
        Me.Grid8.Name = "Grid8"
        Me.Grid8.Size = New System.Drawing.Size(64, 64)
        Me.Grid8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid8.TabIndex = 7
        Me.Grid8.TabStop = False
        '
        'Grid9
        '
        Me.Grid9.Location = New System.Drawing.Point(1, 227)
        Me.Grid9.Name = "Grid9"
        Me.Grid9.Size = New System.Drawing.Size(64, 64)
        Me.Grid9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid9.TabIndex = 8
        Me.Grid9.TabStop = False
        '
        'Grid10
        '
        Me.Grid10.Location = New System.Drawing.Point(66, 227)
        Me.Grid10.Name = "Grid10"
        Me.Grid10.Size = New System.Drawing.Size(64, 64)
        Me.Grid10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid10.TabIndex = 9
        Me.Grid10.TabStop = False
        '
        'Grid11
        '
        Me.Grid11.Location = New System.Drawing.Point(131, 227)
        Me.Grid11.Name = "Grid11"
        Me.Grid11.Size = New System.Drawing.Size(64, 64)
        Me.Grid11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid11.TabIndex = 10
        Me.Grid11.TabStop = False
        '
        'Grid12
        '
        Me.Grid12.Location = New System.Drawing.Point(196, 227)
        Me.Grid12.Name = "Grid12"
        Me.Grid12.Size = New System.Drawing.Size(64, 64)
        Me.Grid12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid12.TabIndex = 11
        Me.Grid12.TabStop = False
        '
        'Grid13
        '
        Me.Grid13.Location = New System.Drawing.Point(1, 297)
        Me.Grid13.Name = "Grid13"
        Me.Grid13.Size = New System.Drawing.Size(64, 64)
        Me.Grid13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid13.TabIndex = 12
        Me.Grid13.TabStop = False
        '
        'Grid14
        '
        Me.Grid14.Location = New System.Drawing.Point(66, 297)
        Me.Grid14.Name = "Grid14"
        Me.Grid14.Size = New System.Drawing.Size(64, 64)
        Me.Grid14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid14.TabIndex = 13
        Me.Grid14.TabStop = False
        '
        'Grid15
        '
        Me.Grid15.Location = New System.Drawing.Point(131, 297)
        Me.Grid15.Name = "Grid15"
        Me.Grid15.Size = New System.Drawing.Size(64, 64)
        Me.Grid15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid15.TabIndex = 14
        Me.Grid15.TabStop = False
        '
        'Grid16
        '
        Me.Grid16.Location = New System.Drawing.Point(196, 297)
        Me.Grid16.Name = "Grid16"
        Me.Grid16.Size = New System.Drawing.Size(64, 64)
        Me.Grid16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Grid16.TabIndex = 15
        Me.Grid16.TabStop = False
        '
        'Panel
        '
        Me.Panel.Location = New System.Drawing.Point(0, -130)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(261, 111)
        Me.Panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Panel.TabIndex = 16
        Me.Panel.TabStop = False
        '
        'MovePanelTimer1
        '
        Me.MovePanelTimer1.Interval = 1
        '
        'MovePanelTimer2
        '
        Me.MovePanelTimer2.Interval = 1
        '
        'PlusScoreTimer
        '
        Me.PlusScoreTimer.Interval = 1
        '
        'RandomTimer
        '
        Me.RandomTimer.Interval = 75
        '
        'RollScoreTimer
        '
        Me.RollScoreTimer.Interval = 2500
        '
        'SetOpacityTimer1
        '
        Me.SetOpacityTimer1.Interval = 1
        '
        'SetOpacityTimer2
        '
        Me.SetOpacityTimer2.Interval = 1
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.CausesValidation = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("ArcadeClassic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(21, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 36)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "NEW GAME"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("ArcadeClassic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(155, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 36)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("ArcadeClassic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "SCORE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("ArcadeClassic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "HIGH SCORE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("ArcadeClassic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(17, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 21)
        Me.Label3.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("ArcadeClassic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(130, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 22
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FLAT_2048.My.Resources.Resources.BackGround
        Me.ClientSize = New System.Drawing.Size(261, 490)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Grid16)
        Me.Controls.Add(Me.Grid15)
        Me.Controls.Add(Me.Grid14)
        Me.Controls.Add(Me.Grid13)
        Me.Controls.Add(Me.Grid12)
        Me.Controls.Add(Me.Grid11)
        Me.Controls.Add(Me.Grid10)
        Me.Controls.Add(Me.Grid9)
        Me.Controls.Add(Me.Grid8)
        Me.Controls.Add(Me.Grid7)
        Me.Controls.Add(Me.Grid6)
        Me.Controls.Add(Me.Grid5)
        Me.Controls.Add(Me.Grid4)
        Me.Controls.Add(Me.Grid3)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GameForm"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLAT 2048"
        Me.TopMost = True
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grid1 As PictureBox
    Friend WithEvents Grid2 As PictureBox
    Friend WithEvents Grid3 As PictureBox
    Friend WithEvents Grid4 As PictureBox
    Friend WithEvents Grid5 As PictureBox
    Friend WithEvents Grid6 As PictureBox
    Friend WithEvents Grid7 As PictureBox
    Friend WithEvents Grid8 As PictureBox
    Friend WithEvents Grid9 As PictureBox
    Friend WithEvents Grid10 As PictureBox
    Friend WithEvents Grid11 As PictureBox
    Friend WithEvents Grid12 As PictureBox
    Friend WithEvents Grid13 As PictureBox
    Friend WithEvents Grid14 As PictureBox
    Friend WithEvents Grid15 As PictureBox
    Friend WithEvents Grid16 As PictureBox
    Friend WithEvents Panel As PictureBox
    Friend WithEvents MovePanelTimer1 As Timer
    Friend WithEvents MovePanelTimer2 As Timer
    Friend WithEvents PlusScoreTimer As Timer
    Friend WithEvents RandomTimer As Timer
    Friend WithEvents RollScoreTimer As Timer
    Friend WithEvents SetOpacityTimer1 As Timer
    Friend WithEvents SetOpacityTimer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

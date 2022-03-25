<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loadingbar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.startbtn = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loadingbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.loadingbar)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1344, 729)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AHAKTV_v2._0.My.Resources.Resources.fk_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1344, 487)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'loadingbar
        '
        Me.loadingbar.Controls.Add(Me.startbtn)
        Me.loadingbar.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loadingbar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loadingbar.ForeColor = System.Drawing.Color.White
        Me.loadingbar.Location = New System.Drawing.Point(574, 519)
        Me.loadingbar.Minimum = 0
        Me.loadingbar.Name = "loadingbar"
        Me.loadingbar.ProgressColor = System.Drawing.Color.DarkGoldenrod
        Me.loadingbar.ProgressColor2 = System.Drawing.Color.Khaki
        Me.loadingbar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.loadingbar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.loadingbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.loadingbar.Size = New System.Drawing.Size(197, 197)
        Me.loadingbar.TabIndex = 2
        Me.loadingbar.Text = "Guna2CircleProgressBar1"
        Me.loadingbar.Value = 100
        '
        'startbtn
        '
        Me.startbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.startbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.startbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.startbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.startbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.startbtn.FillColor = System.Drawing.Color.Moccasin
        Me.startbtn.FillColor2 = System.Drawing.Color.DarkGoldenrod
        Me.startbtn.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startbtn.ForeColor = System.Drawing.Color.Black
        Me.startbtn.Location = New System.Drawing.Point(28, 29)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.startbtn.Size = New System.Drawing.Size(140, 138)
        Me.startbtn.TabIndex = 1
        Me.startbtn.Text = "TAP TO START"
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AHAKTV_v2._0.My.Resources.Resources.blur_bg_loading
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loadingbar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loadingbar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents startbtn As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents Timer1 As Timer
End Class

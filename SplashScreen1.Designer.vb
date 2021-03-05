<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AntiVirus Pro System"
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.Label7)
        Me.GunaGradientPanel1.Controls.Add(Me.Label6)
        Me.GunaGradientPanel1.Controls.Add(Me.Label5)
        Me.GunaGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaGradientPanel1.Controls.Add(Me.Label4)
        Me.GunaGradientPanel1.Controls.Add(Me.Label3)
        Me.GunaGradientPanel1.Controls.Add(Me.Label2)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.MediumSeaGreen
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.SteelBlue
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.MediumSeaGreen
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.SteelBlue
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(-4, -4)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(502, 308)
        Me.GunaGradientPanel1.TabIndex = 1
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(16, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Loading system..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Antiivurs_4.My.Resources.Resources.Bez_nazwy_11
        Me.PictureBox1.Location = New System.Drawing.Point(178, -59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(386, 460)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(16, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Best antivirus software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Awards 2026"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(17, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pro 2021"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(16, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Antivirus"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(16, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "by Viral, Inc."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(421, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "nquantum"
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.Panel1)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Red
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.DarkRed
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Red
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.DarkRed
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(1, -2)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(784, 463)
        Me.GunaGradientPanel1.TabIndex = 0
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GunaProgressBar1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(33, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 403)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Threat found!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Severity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(116, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Trojan.VBS.Pico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(116, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(353, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Trojan indicates as system file and stealing data silently. It slows down the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " c" &
    "omputer and stops critical procesess. Removal reccomended" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(116, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "High"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Start action"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Path:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(116, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "C:\Windows\system.vbe"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Remove", "Keep "})
        Me.ComboBox1.Location = New System.Drawing.Point(479, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(476, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Select action:"
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaProgressBar1.Location = New System.Drawing.Point(105, 272)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.Red
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.Red
        Me.GunaProgressBar1.Size = New System.Drawing.Size(478, 23)
        Me.GunaProgressBar1.TabIndex = 13
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 457)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
End Class

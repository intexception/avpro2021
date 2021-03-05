<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.Panel1)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.MediumSeaGreen
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.SteelBlue
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.MediumSeaGreen
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.SteelBlue
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(-1, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(504, 301)
        Me.GunaGradientPanel1.TabIndex = 0
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(42, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 238)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Activate Antivirus Pro 2021 now!"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(131, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 74)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Activate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 295)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form3"
        Me.Text = "Activation"
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

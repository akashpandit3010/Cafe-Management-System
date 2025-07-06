Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Login"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            MsgBox("Enter Username and Password")
        ElseIf TextBox2.Text = "Admin" And TextBox1.Text = "admin123" Then
            Dim obj = New Form3
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
            TextBox2.Text = ""
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj = New Form1
        obj.Show()
        Me.Hide()
    End Sub
End Class
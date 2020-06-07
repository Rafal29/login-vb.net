Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles دخول.Click
        If (TextBox1.Text = "0014") Then
            Label1.Visible = True
            PictureBox2.Visible = True


        ElseIf (TextBox1.Text = "") Then
            Label2.Visible = True
            End If
    End Sub
End Class

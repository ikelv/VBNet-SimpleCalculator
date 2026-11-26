Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click,
        Button4.Click, Button5.Click, Button6.Click, Button7.Click,
        Button8.Click, Button9.Click, Button10.Click

        Dim ButtonValue = CType(sender, System.Windows.Forms.Button)
        TextBox1.Text &= ButtonValue.Text



    End Sub

    Private Sub Button1_Zero(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = String.Empty Then
        Else
            TextBox1.Text &= "0"
        End If
    End Sub

    Private Sub Button11_Decimal(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text = String.Empty Then
            TextBox1.Text = "0."
        ElseIf Not TextBox1.Text.Contains(".") Then
            TextBox1.Text &= "."

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = String.Empty


    End Sub

    Private Sub Operators(sender As Object, e As EventArgs) Handles Button17.Click,
    Button18.Click, Button19.Click, Button20.Click
        TextBox1.Text &= CType(sender, System.Windows.Forms.Button).Text

    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Dim expression As String = TextBox1.Text
            Dim result As Object
            Dim table As New DataTable
            result = table.Compute(expression, String.Empty)
            TextBox1.Text = result.ToString
        Catch ex As Exception
            TextBox1.Text = "ERROR"
        End Try
    End Sub
End Class

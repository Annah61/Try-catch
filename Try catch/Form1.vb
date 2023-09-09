Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNumeric.Click
        Dim value As String
        value = txtInput.Text

        Try
            'Attempt to convert the user input to a numeric value
            Dim numeric As Double
            numeric = CDbl(value)
            'If the conversion succeeds,display the result
            MsgBox(" You entered a valid number:" & value)
        Catch ex As exception
            MsgBox("Error: Please enter a numeric value")
        End Try
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub
End Class

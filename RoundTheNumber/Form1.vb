'Patricia Hanus
'151123
'Round The Number
'_______________________________________________________________________
Public Class Form1

    Private Sub btnRound_Click(sender As Object, e As EventArgs) Handles btnRound.Click
        Dim strNumber As String = Me.txtNum.Text
        Dim strDecimal As String = Me.txtDecimalPlaces.Text
        Dim num As Double = Me.txtNum.Text
        Dim intDecimal As Integer = Me.txtDecimalPlaces.Text

        If IsNumeric(strNumber) And IsNumeric(strDecimal) Then
            Me.lblAns.Text = Math.Round(num, intDecimal)
        Else
            MessageBox.Show("Please enter a numeric value", "Entry Error")
        End If
    End Sub
End Class

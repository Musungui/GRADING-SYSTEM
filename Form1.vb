Public Class Form1
    Private Sub TxtSubject1_TextChanged(sender As Object, e As EventArgs) Handles TxtSubject1.TextChanged

    End Sub

    Private Sub BtnAverage_Click(sender As Object, e As EventArgs) Handles BtnAverage.Click
        Try
            Dim Average, Subject1, Subject2, Subject3 As Double
            Subject1 = CDbl(TxtSubject1.Text)
            Subject2 = CDbl(TxtSubject2.Text)
            Subject3 = CDbl(TxtSubject3.Text)

            Average = (Subject1 + Subject2 + Subject3) / 3
            LblAverage.Text = Average

        Catch ex As Exception
            MessageBox.Show("Please Enter All The Subject Fields")
        End Try
    End Sub

    Private Sub BtnGrade_Click(sender As Object, e As EventArgs) Handles BtnGrade.Click
        Try
            Dim Average As Double
            Average = LblAverage.Text

            If Average >= 0 And Average < 40 Then
                LblGrade.Text = "E"
            ElseIf Average >= 40 And Average < 50 Then
                LblGrade.Text = "D"
            ElseIf Average >= 50 And Average < 60 Then
                LblGrade.Text = "C"
            ElseIf Average >= 60 And Average < 70 Then
                LblGrade.Text = "B"
            ElseIf Average >= 70 And Average < 100 Then
                LblGrade.Text = "A"
            Else
                MessageBox.Show("Invalid Grade")

            End If
        Catch ex As Exception
            MessageBox.Show("Please Enter All The Subject Fields")
        End Try


    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtSubject1.Clear()
        TxtSubject2.Clear()
        TxtSubject3.Clear()

        LblAverage.Text = " "
        LblGrade.Text = " "
    End Sub
End Class

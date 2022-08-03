Public Class Form1
    Dim candidate1 As New Integer
    Dim candidate2 As New Integer
    Dim candidate3 As New Integer
    Dim candidate4 As New Integer
    Dim candidate5 As New Integer
    Dim candidate6 As New Integer
    Dim candidate7 As New Integer
    Dim candidate8 As New Integer




    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click

        candidate1 = candidate1 + Txt1.Text
        lblPoints1.Text = candidate1

        candidate2 = candidate2 + Txt2.Text
        lblPoints2.Text = candidate2

        candidate3 = candidate3 + Txt3.Text
        lblPoints3.Text = candidate3

        candidate4 = candidate4 + Txt4.Text
        lblPoints4.Text = candidate4

        candidate5 = candidate5 + Txt5.Text
        lblPoints5.Text = candidate5

        candidate6 = candidate6 + Txt6.Text
        lblPoints6.Text = candidate6

        candidate7 = candidate7 + Txt7.Text
        lblPoints7.Text = candidate7

        candidate8 = candidate8 + Txt8.Text
        lblPoints8.Text = candidate8



        Txt1.Text = ""
        Txt2.Text = ""
        Txt3.Text = ""
        Txt4.Text = ""
        Txt5.Text = ""
        Txt6.Text = ""
        Txt7.Text = ""
        Txt8.Text = ""



    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If candidate1 > candidate2 And candidate1 > candidate3 And candidate1 > candidate4 And candidate1 > candidate5 And candidate1 > candidate6 And candidate1 > candidate7 And candidate1 > candidate8 Then
            MsgBox(lblName1.Text + "Has won")
        ElseIf candidate2 > candidate1 And candidate2 > candidate3 And candidate2 > candidate4 And candidate2 > candidate5 And candidate2 > candidate6 And candidate2 > candidate7 And candidate2 > candidate8 Then
            MsgBox(lblName2.Text + "Has won")
        ElseIf candidate3 > candidate1 And candidate3 > candidate2 And candidate3 > candidate4 And candidate3 > candidate5 And candidate3 > candidate6 And candidate3 > candidate7 And candidate3 > candidate8 Then
            MsgBox(lblName3.Text + "Has won")
        ElseIf candidate4 > candidate1 And candidate4 > candidate2 And candidate4 > candidate3 And candidate4 > candidate5 And candidate4 > candidate6 And candidate4 > candidate7 And candidate4 > candidate8 Then
            MsgBox(lblName4.Text + "Has won")
        ElseIf candidate5 > candidate1 And candidate5 > candidate2 And candidate5 > candidate4 And candidate5 > candidate5 And candidate5 > candidate6 And candidate5 > candidate7 And candidate5 > candidate8 Then
            MsgBox(lblName5.Text + "Has won")
        ElseIf candidate6 > candidate1 And candidate6 > candidate2 And candidate6 > candidate3 And candidate6 > candidate4 And candidate6 > candidate5 And candidate6 > candidate7 And candidate6 > candidate8 Then
            MsgBox(lblName6.Text + "Has won")
        ElseIf candidate7 > candidate1 And candidate7 > candidate2 And candidate7 > candidate3 And candidate7 > candidate4 And candidate7 > candidate5 And candidate7 > candidate6 And candidate7 > candidate8 Then
            MsgBox(lblName7.Text + "Has won")
        ElseIf candidate8 > candidate1 And candidate8 > candidate2 And candidate8 > candidate3 And candidate8 > candidate4 And candidate8 > candidate5 And candidate8 > candidate6 And candidate8 > candidate7 Then
            MsgBox(lblName8.Text + "Has won")



        End If



    End Sub
End Class

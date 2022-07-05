Public Class Form1
    Private EMPLOYEE As String
    Private HOURS As Integer
    Private NI, NI2, TD, OT, OTF, SSS, PI, PH, TAX, NP As Double

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        EMPLOYEE = tb1.Text

    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        HOURS = Val(tb2.Text)
        If HOURS = 40 Then
            OT = 0
            OTF = 0

            NI = HOURS * 108.33
            tb3.Text = NI
            tb4.Text = ""
            tb5.Text = ""
            SSS = NI * 0.0572
            tb6.Text = SSS
            PI = NI * 0.075
            tb7.Text = PI
            PH = NI * 0.082
            tb8.Text = PH
            TAX = NI * 0.12
            tb9.Text = TAX
            TD = SSS + PI + PH + TAX
            tb10.Text = TD

            NP = NI - TD
            tb11.Text = NP
        End If

        If HOURS > 40 Then
            OT = HOURS - 40
            tb4.Text = OT
            OTF = OT * 162.495
            tb5.Text = OTF

            NI = 40 * 108.33
            tb3.Text = NI

            NI2 = NI + OTF
            SSS = NI2 * 0.0572
            tb6.Text = SSS
            PI = NI2 * 0.075
            tb7.Text = PI
            PH = NI2 * 0.082
            tb8.Text = PH
            TAX = NI2 * 0.12
            tb9.Text = TAX
            TD = SSS + PI + PH + TAX
            tb10.Text = TD

            NP = NI2 - TD
            tb11.Text = NP
        End If
        If HOURS < 40 Then
            tb3.Text = ""
            tb4.Text = ""
            tb5.Text = ""
            tb6.Text = ""
            tb7.Text = ""
            tb8.Text = ""
            tb9.Text = ""
            tb10.Text = ""
            tb11.Text = ""
        End If
    End Sub

    Private Sub tb3_TextChanged(sender As Object, e As EventArgs) Handles tb3.TextChanged
        NI = Val(tb3.Text)


    End Sub

    Private Sub tb4_TextChanged(sender As Object, e As EventArgs) Handles tb4.TextChanged
        OT = Val(tb4.Text)


    End Sub

    Private Sub tb5_TextChanged(sender As Object, e As EventArgs) Handles tb5.TextChanged
        OTF = Val(tb5.Text)


    End Sub

    Private Sub tb6_TextChanged(sender As Object, e As EventArgs) Handles tb6.TextChanged
        SSS = Val(tb6.Text)

    End Sub

    Private Sub tb7_TextChanged(sender As Object, e As EventArgs) Handles tb7.TextChanged
        PI = Val(tb7.Text)


    End Sub

    Private Sub tb8_TextChanged(sender As Object, e As EventArgs) Handles tb8.TextChanged
        PH = Val(tb8.Text)

    End Sub

    Private Sub tb9_TextChanged(sender As Object, e As EventArgs) Handles tb9.TextChanged
        TAX = Val(tb9.Text)

    End Sub

    Private Sub tb10_TextChanged(sender As Object, e As EventArgs) Handles tb10.TextChanged
        TD = Val(tb10.Text)

    End Sub

    Private Sub tb11_TextChanged(sender As Object, e As EventArgs) Handles tb11.TextChanged
        NP = Val(tb11.Text)

    End Sub
End Class

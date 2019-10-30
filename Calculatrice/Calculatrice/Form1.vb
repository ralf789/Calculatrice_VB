Public Class form1

    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim Operator1 As String
    Dim UtiliseEgal As Boolean

    Private Sub cmdChiffre7_Click(sender As Object, e As EventArgs) Handles cmdChiffre7.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre7.TabIndex
    End Sub

    Private Sub cmdChiffre0_Click(sender As Object, e As EventArgs) Handles cmdChiffre0.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre0.TabIndex
    End Sub


    Private Sub cmdChiffre8_Click(sender As Object, e As EventArgs) Handles cmdChiffre8.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre8.TabIndex
    End Sub

    Private Sub cmdChiffre1_Click(sender As Object, e As EventArgs) Handles cmdChiffre1.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre1.TabIndex
    End Sub
    Private Sub cmdChiffre2_Click(sender As Object, e As EventArgs) Handles cmdChiffre2.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre2.TabIndex
    End Sub
    Private Sub cmdChiffre3_Click(sender As Object, e As EventArgs) Handles cmdChiffre3.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre3.TabIndex
    End Sub
    Private Sub cmdChiffre4_Click(sender As Object, e As EventArgs) Handles cmdChiffre4.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre4.TabIndex
    End Sub
    Private Sub cmdChiffre5_Click(sender As Object, e As EventArgs) Handles cmdChiffre5.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre5.TabIndex
    End Sub
    Private Sub cmdChiffre6_Click(sender As Object, e As EventArgs) Handles cmdChiffre6.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre6.TabIndex
    End Sub
    Private Sub cmdChiffre9_Click(sender As Object, e As EventArgs) Handles cmdChiffre9.Click
        'Si la dernièr Opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If
        lblAffichage.Text = lblAffichage.Text & cmdChiffre9.TabIndex
    End Sub


    Private Sub cmdMultiplier_Click(sender As Object, e As EventArgs) Handles cmdMultiplier.Click
        Operator1 = "*"
        Operand1 = Val(lblAffichage.Text)
        lblAffichage.Text = ""
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        Operator1 = "+"
        Operand1 = Val(lblAffichage.Text)
        lblAffichage.Text = ""
    End Sub

    Private Sub cmdMoins_Click(sender As Object, e As EventArgs) Handles cmdMoins.Click
        Operator1 = "-"
        Operand1 = Val(lblAffichage.Text)
        lblAffichage.Text = ""
    End Sub

    Private Sub cmdDecimal_Click(sender As Object, e As EventArgs) Handles cmdDecimal.Click
        'Si la dernier opération est le signe égal on efface l'affichage
        If UtiliseEgal Then
            lblAffichage.Text = ""
            UtiliseEgal = False
        End If

        lblAffichage.Text = lblAffichage.Text + "."
    End Sub

    Private Sub cmdEffacer_Click(sender As Object, e As EventArgs) Handles cmdEffacer.Click
        lblAffichage.Text = ""
    End Sub
    Private Sub cmdEgal_Click(sender As Object, e As EventArgs) Handles cmdEgal.Click
        Dim Result As Double

        Operand2 = Val(lblAffichage.Text)
        If Operator1 = "+" Then
            Result = Operand1 + Operand2
        ElseIf Operator1 = "-" Then
            Result = Operand1 - Operand2
        ElseIf Operator1 = "*" Then
            Result = Operand1 * Operand2
        ElseIf Operator1 = "/" Then
            If Operand2 <> 0 Then
                Result = Operand1 / Operand2

            End If
        End If
        lblAffichage.Text = Result
        'Laisser Savoir qu'on vient juste d'utiliser le signe égal
        UtiliseEgal = True
    End Sub
    Private Sub cmdDiviser_Click(sender As Object, e As EventArgs) Handles cmdDiviser.Click
        Operator1 = "/"
        Operand1 = Val(lblAffichage.Text)
        lblAffichage.Text = ""
    End Sub
End Class
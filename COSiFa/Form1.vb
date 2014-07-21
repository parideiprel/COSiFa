Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = MDIParent1

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        'Select Case e.KeyChar
        '    Case Microsoft.VisualBasic.ChrW(Keys.Back)
        '        If Len(TextBox2.Text) = 0 Then
        '            'se premuto backspace e lunghezza = 0 allora sono a inizio casella
        '            'quindi faccio il focus back alla casella 1 e la svuoto
        '            TextBox1.Text = ""
        '            TextBox1.Focus()
        '        End If
        'End Select

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        Select Case e.KeyCode
            Case 65 To 90
                e.SuppressKeyPress = False
                TextBox2.Focus()
            Case Else
                e.SuppressKeyPress = True

        End Select


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown

        Select Case e.KeyCode
            Case Keys.Back
                If Len(TextBox2.Text) = 0 Then
                    e.SuppressKeyPress = False
                    'se premuto backspace e lunghezza = 0 allora sono a inizio casella
                    'quindi faccio il focus back alla casella 1 e la svuoto
                    TextBox1.Text = ""
                    TextBox1.Focus()
                End If
            Case Keys.A To Keys.Z
                e.SuppressKeyPress = True

            Case Keys.D0 To Keys.D9
                e.SuppressKeyPress = False
                If Len(TextBox2.Text) = 2 Then
                    TextBox3.Focus()
                End If

            Case Keys.NumPad0 To Keys.NumPad9
                e.SuppressKeyPress = False
                If Len(TextBox2.Text) = 2 Then
                    TextBox3.Focus()
                End If

        End Select
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown

        Select Case e.KeyCode

            Case Keys.A To Keys.Z
                e.SuppressKeyPress = True

        End Select

    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown

        Select Case e.KeyCode

            Case Keys.A To Keys.Z
                e.SuppressKeyPress = True

        End Select


    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        'Lasciando il controllo, faccio la verifica di coerenza dei dati inseriti
        'devono essere cifre con 1 decimale
        Select Case (Len(TextBox3.Text)-InStr(TextBox3.Text,".",CompareMethod.Text)

            Case 1
                'dati ok
            Case Else
                'dati NOK - msgbox di errore a utente e ritorno del focus al campo

        End Select

    End Sub
End Class
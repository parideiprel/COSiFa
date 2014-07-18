Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = MDIParent1

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        Select Case Asc(UCase(e.KeyChar))
            Case 65 To 90
                TextBox2.Focus()
            Case Else
                'CAZZO NON FUNZIONA !
                TextBox1.SuspendLayout()
                TextBox1.Text = ""
                TextBox1.ResumeLayout()

        End Select


    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Back)
                If Len(TextBox2.Text) = 0 Then
                    'se premuto backspace e lunghezza = 0 allora sono a inizio casella
                    'quindi faccio il focus back alla casella 1 e la svuoto
                    TextBox1.Text = ""
                    TextBox1.Focus()
                End If
        End Select

    End Sub
End Class
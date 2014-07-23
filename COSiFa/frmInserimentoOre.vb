Public Class frmInserimentoOre
    Dim bCataOk As Boolean
    Dim bOreOk As Boolean


    Private Sub frmInserimentoOre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = MDIParent1
        Button1.Enabled = False


        'carico eventuali dati dal DB relativi alle ore inserite dall'utente
        Dim tabOre As New tOreDataContext()
        Dim result = From r In tabOre.tOre Where r.Utente = System.Environment.UserName Select r
        'Dim result = From r In tabOre.tOre Where r.Utente = "gneppo" Select r
        'tabOre.tOre.DeleteAllOnSubmit(result)
        'tabOre.SubmitChanges()
        If result.Count <> 0 Then
            'ho record e quindi popolo il datagridview
            'MsgBox("Trovati n. " + result.Count.ToString + " Record !")
            'Me.DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, System.Environment.UserName)
            For Each res In result
                Me.DataGridView1.Rows.Add(res.Catalogo.Substring(0, 1), res.Catalogo.Substring(1, 3), res.OreSap.ToString, res.OreDisegno.ToString, res.Utente)
            Next
        Else
            'non ho record
            MsgBox("Nessun record estratto")
        End If

        TextBox1.Focus()
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
                    bCataOk = True
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
        Select Case (Len(TextBox3.Text) - InStr(TextBox3.Text, ".", CompareMethod.Text))

            Case 1
                'dati ok
                'MsgBox("1")
            Case Else
                'dati NOK - msgbox di errore a utente e ritorno del focus al campo
                MsgBox("Formato dati errato!" + vbCrLf + vbCrLf + "Controllare inserimento.", vbOKOnly, "Errore inserimento dati")
                TextBox3.SelectAll()
                TextBox3.Focus()
        End Select

    End Sub


    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        'Lasciando il controllo, faccio la verifica di coerenza dei dati inseriti
        'devono essere cifre con 1 decimale
        Select Case (Len(TextBox4.Text) - InStr(TextBox4.Text, ".", CompareMethod.Text))

            Case 1
                'dati ok
                'MsgBox("1")
                bOreOk = True
                If (bCataOk And bOreOk) = True Then
                    Button1.Enabled = True
                    Button1.Focus()
                End If
            Case Else
                'dati NOK - msgbox di errore a utente e ritorno del focus al campo
                MsgBox("Formato dati errato!" + vbCrLf + vbCrLf + "Controllare inserimento.", vbOKOnly, "Errore inserimento dati")
                TextBox4.SelectAll()
                TextBox4.Focus()
        End Select


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Scrivo i dati nel DB e aggiungo la riga al GridView

        'Aggiungo dati al GridView
        Me.DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, Format(TextBox3.Text, "##.00"), Format(TextBox4.Text, "##.00"), System.Environment.UserName)

        'Scrivo i dati nel DB SQL
        Dim tabOre As New tOreDataContext()
        Dim t As New tOre

        t.Catalogo = TextBox1.Text + TextBox2.Text
        t.OreSap = Val(Format(TextBox3.Text, "##.00"))
        t.OreDisegno = Val(Format(TextBox4.Text, "##.00"))
        t.Utente = System.Environment.UserName

        tabOre.tOre.InsertOnSubmit(t)
        tabOre.SubmitChanges()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Button1.Enabled = False
        TextBox1.Focus()


    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Select Case e.ColumnIndex
            Case 5
                'MsgBox("Colonna 5")
                Dim cata As String = ""
                cata = DataGridView1.Item(0, e.RowIndex).Value.ToString + DataGridView1.Item(1, e.RowIndex).Value.ToString

                Dim tabOre As New tOreDataContext()
                Dim result = From r In tabOre.tOre Where r.Catalogo = cata Select r

                tabOre.tOre.DeleteAllOnSubmit(result)
                tabOre.SubmitChanges()

                'ora cancello la riga anche dal datagriview
                Me.DataGridView1.Rows.RemoveAt(e.RowIndex)

            Case Else
                MsgBox("Non puoi cliccare qui!", vbOKOnly + vbCritical, "ERRORE")
        End Select
    End Sub
End Class
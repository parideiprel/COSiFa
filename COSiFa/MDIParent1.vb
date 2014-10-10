Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports COSiFa.My

Public Class MDIParent1

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Me.Close()
        Dim txt As Byte() = New System.Text.UTF8Encoding(True).GetBytes("=== Arresto Programma " + My.Application.Info.ProductName + " === " + Now.ToString() + vbCrLf)
        gnappo.Write(txt, 0, txt.Length)
        gnappo.Close()
        gnappo = Nothing

        End
    End Sub

    Shared userlevel As Integer = 0
    Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Resources.connectionString)
    Dim gnappo As FileStream

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            gnappo = System.IO.File.Open("c:\temp\LOG.txt", FileMode.Append, FileAccess.Write, FileShare.Read)
            Dim txt As Byte() = New System.Text.UTF8Encoding(True).GetBytes("=== Avvio Programma " + My.Application.Info.ProductName + " === " + Now.ToString() + vbCrLf)
            gnappo.Write(txt, 0, txt.Length)
        Catch ex As Exception
            MsgBox("ERRORE - Impossibile aprire/scrivere file di Log LOG.txt" + vbCrLf + vbCrLf + "-----------------------------" + vbCrLf + ex.Message, vbOKOnly + vbExclamation)
        End Try

        'Try
        '    Dim txt As Byte() = New System.Text.UTF8Encoding(True).GetBytes("=== Avvio Programma " + My.Application.Info.ProductName + " === " + Now.ToString() + vbCrLf)
        '    gnappo.Write(txt, 0, txt.Length)
        'Catch ex As Exception
        '    MsgBox("ERRORE - Impossibile Scrivere file di Log LOG.txt" + vbCrLf + vbCrLf + "-----------------------------" + vbCrLf + ex.Message, vbOKOnly + vbExclamation)
        'End Try

        'Inserire qui le attività da fare al caricamento
        'tipo lettura dei diritti utente e abilitazione varie funzioni

        Dim sqlstring As String = "SELECT userlevel FROM tUser WHERE username='" + System.Environment.UserName + "';"
        cn.Open()
        If cn.State = ConnectionState.Open Then
            Dim sqlcmd As New SqlCommand(sqlstring, cn)
            Dim sqlReader As SqlDataReader = sqlcmd.ExecuteReader()
            While sqlReader.Read()
                userlevel = sqlReader(0)
            End While
            sqlReader.Close()
            cn.Close()
        Else
            MsgBox("ERRORE! Impossibile accedre ad database SQL", vbOKOnly & vbCritical, "ERRORE CONNESSIONE")
            End
        End If
        If userlevel <> 255 Then
            VisualizzaSituazioneCataloghiToolStripMenuItem.Enabled = False
            FatturazioneToolStripMenuItem.Enabled = False
            UtilitàToolStripMenuItem.Enabled = False
        End If
        Try
            If My.Application.CommandLineArgs(0) = "/upload" Then
                ImportaSituazioneToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception
            'MsgBox("Eccezione!" + vbCrLf + vbCrLf + ex.Message)
        End Try
        'SOLO PER DEBUG
        UtilitàToolStripMenuItem.Enabled = True
        ImportaSituazioneToolStripMenuItem.Enabled = True

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub RegistraOreXCatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistraOreXCatalogoToolStripMenuItem.Click
        frmInserimentoOre.Show()
    End Sub

    Private Sub ImportaSituazioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportaSituazioneToolStripMenuItem.Click
        'Carica il file situazione (solo il foglio 1) dentro al DB SQL
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlFile As Microsoft.Office.Interop.Excel.Workbook
        Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim xlRange As Microsoft.Office.Interop.Excel.Range

        'Definisco le variabili per leggere le colonne dal mio file excel
        'Dim xAnno As Integer
        'Dim xProduttore As String
        'Dim xEquipment As String
        'Dim xSettoreCommerciale As String
        'Dim xCanaleDistributivo As String
        'Dim xOdV As String
        'Dim xCodiceCliente As String
        'Dim xAnagraficaCliente As String
        'Dim xNazione As String
        'Dim xPosizione As Integer
        'Dim xCodiceMateriale As String
        'Dim xAnagraficaMateriale As String
        'Dim xSituazioneSpedizione As String
        'Dim xDataSpedizione As Date
        'Dim xDtSped1 As Date
        'Dim xDtSped2 As Date
        'Dim xAutore As String
        'Dim xNote As String
        'Dim xRiferimentoProgramma As String
        'Dim xDataUscita As Date
        'Dim xDataConsegnaPrevista As Date
        'Dim xStudio As String
        'Dim xCdC As String
        'Dim xOdA As String
        'Dim xPosizioneOdA As Integer
        'Dim xCatalogo As String
        'Dim xDataArchiviazione As Date
        'Dim xNumeroArchiviazione As String
        'Dim xNumeroArchiviazioneTavole As String
        'Dim xOreSap As Single
        'Dim xOreDisegno As Single
        'Dim xCostoFatturato As Decimal
        'Dim xCostoPreventivato As Single
        'Dim xScostamento As Single
        'Dim xNoteAgg As String
        'Dim xIsAtm As Boolean
        'Dim xAtmString As String = String.Empty
        'Dim xIsStringBefore As Boolean
        Dim xls As New ClsDatiExcel
        Dim iBottomCell As Integer
        Dim indice As Integer
        Dim colonna As Integer = 0

        Dim tSitu As New tSituazioneDataContext()
        'Dim tSit As New tSituazione

        Dim lstAtmString As New List(Of String)(New String() {"atm", "ate", "atomizzatore"}) 'lista x stringhe ATM

        Dim bIsAList As Boolean = False


        '********************** FINE DEFINIZIONI VARIABILI *********************************************

        'ottengo il file da lavorare con un filedialog
        Dim sFile As String
        OpenFileDialog1.Filter = "File Excel (*.xlsx) | *.xlsx"
        OpenFileDialog1.ShowDialog()
        sFile = OpenFileDialog1.FileName

        'creo oggetto per gestire excel
        xlApp = New Microsoft.Office.Interop.Excel.Application()

        'creo oggetto per aprire cartella di lavoro
        xlFile = xlApp.Workbooks.Open(sFile)
        xlApp.Visible = True
        xlFile.Activate()

        xlSheet = xlFile.Worksheets(1)
        xlRange = xlSheet.Range("A2")
        Dim ret As Object = xlRange.Select()
        'xlRange = xlSheet.Range("A2", "AI10000")
        xlRange = xlRange.End(Microsoft.Office.Interop.Excel.XlDirection.xlDown)
        ret = xlRange.Select()
        iBottomCell = xlRange.Row
        xlRange = xlSheet.Range("A2")
        ret = xlRange.Select()

        '*** visualizzazione form con progressbar ***
        Progress.Show()
        Progress.ProgressBar1.Minimum = 0
        Progress.ProgressBar1.Maximum = iBottomCell - 1


        Dim riga As Integer = 0
        For pippo As Integer = 1 To iBottomCell - 1
            riga = pippo
            Progress.ProgressBar1.Value = pippo
            'riga = 71 '431 5 matricole  'riga 71 corrisponde alla cella 72 di excel

            If xlRange.Cells(riga, 1).value Is Nothing Then
                xls.XAnno = 9999
            Else
                xls.XAnno = xlRange.Cells(riga, 1).value
            End If

            xls.XProduttore = xlRange.Cells(riga, 2).value

            If xlRange.Cells(riga, 3).value Is Nothing Then
                xls.XEquipment = "99999999"
            Else
                xls.XEquipment = xlRange.Cells(riga, 3).value
            End If

            If xlRange.Cells(riga, 4).value Is Nothing Then
                xls.XSettoreCommerciale = "CERA"
            Else
                xls.XSettoreCommerciale = xlRange.Cells(riga, 4).value
            End If


            If xlRange.Cells(riga, 5).value Is Nothing Then
                xls.XCanaleDistributivo = "MP"
            Else
                xls.XCanaleDistributivo = xlRange.Cells(riga, 5).value
            End If

            If xlRange.Cells(riga, 6).value Is Nothing Then
                xls.XOdV = "0000000000"
            Else
                xls.XOdV = xlRange.Cells(riga, 6).value
            End If

            If xlRange.Cells(riga, 7).value Is Nothing Then
                xls.XCodiceCliente = "000000"
            Else
                xls.XCodiceCliente = xlRange.Cells(riga, 7).value
            End If

            If xlRange.Cells(riga, 8).value Is Nothing Then
                xls.XAnagraficaCliente = "+++ CAMPO NON COMPILATO +++"
            Else
                xls.XAnagraficaCliente = xlRange.Cells(riga, 8).value
            End If

            If xlRange.Cells(riga, 9).value Is Nothing Then
                xls.XNazione = "XX"
            Else
                xls.XNazione = xlRange.Cells(riga, 9).value
            End If

            If xlRange.Cells(riga, 10).value Is Nothing Then
                xls.XPosizione = "0"
            Else
                xls.XPosizione = xlRange.Cells(riga, 10).value
            End If

            If xlRange.Cells(riga, 11).value Is Nothing Then
                xls.XCodiceMateriale = "XXXXXXXXXX"
            Else
                xls.XCodiceMateriale = xlRange.Cells(riga, 11).value
            End If

            If xlRange.Cells(riga, 12).value Is Nothing Then
                xls.XAnagraficaMateriale = "XXXXXXXXXX"
            Else
                xls.XAnagraficaMateriale = xlRange.Cells(riga, 12).value
            End If
            xls.XSituazioneSpedizione = xlRange.Cells(riga, 13).value

            xls.XDataSpedizione = ControllaData(xlRange, riga, 14)

            xls.XDtSped1 = ControllaData(xlRange, riga, 15)
            xls.XDtSped2 = ControllaData(xlRange, riga, 16)

            xls.XAutore = xlRange.Cells(riga, 17).value
            xls.XNote = xlRange.Cells(riga, 18).value

            If xlRange.Cells(riga, 19).value Is Nothing Then
                xls.XRiferimentoProgramma = "9999999999"
            Else
                xls.XRiferimentoProgramma = xlRange.Cells(riga, 19).value
            End If

            xls.XDataUscita = ControllaData(xlRange, riga, 20)
            xls.XDataConsegnaPrevista = ControllaData(xlRange, riga, 21)

            xls.XStudio = xlRange.Cells(riga, 22).value
            xls.XCdC = xlRange.Cells(riga, 23).value
            xls.XOdA = xlRange.Cells(riga, 24).value
            xls.XPosizioneOdA = xlRange.Cells(riga, 25).value
            xls.XCatalogo = xlRange.Cells(riga, 26).value

            xls.XDataArchiviazione = ControllaData(xlRange, riga, 27)

            xls.XNumeroArchiviazione = xlRange.Cells(riga, 28).value
            xls.XNumeroArchiviazioneTavole = xlRange.Cells(riga, 29).value
            xls.XOreSap = xlRange.Cells(riga, 30).value
            xls.XOreDisegno = xlRange.Cells(riga, 31).value
            xls.XCostoFatturato = xlRange.Cells(riga, 32).value
            xls.XCostoPreventivato = xlRange.Cells(riga, 33).value
            xls.XScostamento = xlRange.Cells(riga, 34).value
            xls.XNoteAgg = xlRange.Cells(riga, 35).value

            '***** Verifica se matricola è di un ATM ******
            For Each l As String In lstAtmString
                If xls.XEquipment.ToLower.Contains(l) Then
                    xls.XIsAtm = True
                    Exit For
                Else
                    xls.XIsAtm = False
                End If
            Next

            If xls.XIsAtm Then
                Dim resultString As String
                Try
                    Dim regexObj As New Regex("[0-9]{8}")
                    resultString = regexObj.Match(xls.XEquipment).Value
                    Select Case InStr(xls.XEquipment, resultString)
                        Case Is = 0
                            'il numero equipment è all'inizio
                            xls.XAtmString = xls.XEquipment.Substring(8, xls.XEquipment.Length - 1)
                            xls.XEquipment = resultString
                            xls.XIsStringBefore = False
                        Case Is > 0
                            'il numero è dopo l'inizio stringa
                            xls.XAtmString = xls.XEquipment.Substring(0, xls.XEquipment.Length - 8)
                            xls.XEquipment = resultString
                            xls.XIsStringBefore = True
                    End Select
                Catch ex As ArgumentException
                    'Syntax error in the regular expression
                    MsgBox("Stringa non trovata")
                End Try
            End If

            '******** Verifico se matricola è una lista di matricole per produz. di + q.e. identici *********
            If xls.XEquipment.Contains(vbLf) Then
                bIsAList = True
            Else
                bIsAList = False
            End If

            If bIsAList Then
                indice = 0
                Dim lstEqp As New List(Of String)(xls.XEquipment.Split(vbLf))
                For Each a As String In lstEqp
                    ' per ogni stringa di matricola reitero la scrittura sul DB

                    xls.XEquipment = a
                    ScriviDb(tSitu, xls, lstEqp.IndexOf(a), lstEqp.Count)
                    indice += 1

                Next

            End If

            If bIsAList = False Then
                ScriviDb(tSitu, xls, 0, 0)
            End If
        Next pippo
        xlFile.Close(False) 'chiude senza salvare
        xlRange = Nothing
        xlSheet = Nothing
        xlFile = Nothing
        xlApp.Quit()
        xlApp = Nothing
        Dim proc As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        For Each item In proc
            item.Kill()
        Next
        Progress.Hide()
        MsgBox("Importazione Situazione Terminata!")
    End Sub


End Class

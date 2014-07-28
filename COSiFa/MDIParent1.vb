Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class MDIParent1


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Me.Close()

        End
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click



    End Sub
    Shared userlevel As Integer = 0
    Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Resources.connectionString)

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim xAnno As Integer
        Dim xProduttore As String
        Dim xEquipment As String
        Dim xSettoreCommerciale As String
        Dim xCanaleDistributivo As String
        Dim xOdV As String
        Dim xCodiceCliente As String
        Dim xAnagraficaCliente As String
        Dim xNazione As String
        Dim xPosizione As Integer
        Dim xCodiceMateriale As String
        Dim xAnagraficaMateriale As String
        Dim xSituazioneSpedizione As String
        Dim xDataSpedizione As Date
        Dim xDtSped1 As Date
        Dim xDtSped2 As Date
        Dim xAutore As String
        Dim xNote As String
        Dim xOdA As String
        Dim xPosizioneOdA As Integer
        Dim xCatalogo As String
        Dim xDataArchiviazione As Date
        Dim xNumeroArchiviazione As String
        Dim xNumeroArchiviazioneTavole As String
        Dim xOreSap As Single
        Dim xOreDisegno As Single
        Dim xCostoFatturato As Single
        Dim xCostoPreventivato As Single
        Dim xScostamento As Single
        Dim xNoteAgg As String
        Dim xIsAtm As Boolean
        Dim xAtmString As String
        Dim xIsStringBefore As Boolean

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
        xlRange = xlSheet.Range("A2", "AI10000")

        ' TODO: Occorre fare ciclo per leggere tutti i dati !!!

        Dim riga, colonna As Integer
        riga = 2
        colonna = 1
        xAnno = xlRange.Cells(riga, 1).value
        xProduttore = xlRange.Cells(riga, 2).value
        xEquipment = xlRange.Cells(riga, 3).value
        xSettoreCommerciale = xlRange.Cells(riga, 4).value
        xCanaleDistributivo = xlRange.Cells(riga, 5).value
        xOdV = xlRange.Cells(riga, 6).value
        xCodiceCliente = xlRange.Cells(riga, 7).value
        xAnagraficaCliente = xlRange.Cells(riga, 8).value
        xNazione = xlRange.Cells(riga, 9).value
        xPosizione = xlRange.Cells(riga, 10).value
        xCodiceMateriale = xlRange.Cells(riga, 11).value
        xAnagraficaMateriale = xlRange.Cells(riga, 12).value
        xSituazioneSpedizione = xlRange.Cells(riga, 13).value
        xDataSpedizione = xlRange.Cells(riga, 14).value
        xDtSped1 = xlRange.Cells(riga, 15).value
        xDtSped2 = xlRange.Cells(riga, 16).value
        xAutore = xlRange.Cells(riga, 17).value
        xNote = xlRange.Cells(riga, 18).value
        xOdA = xlRange.Cells(riga, 19).value
        xPosizioneOdA = xlRange.Cells(riga, 20).value
        xCatalogo = xlRange.Cells(riga, 21).value
        xDataArchiviazione = xlRange.Cells(riga, 22).value
        xNumeroArchiviazione = xlRange.Cells(riga, 23).value
        xNumeroArchiviazioneTavole = xlRange.Cells(riga, 24).value
        xOreSap = xlRange.Cells(riga, 25).value
        xOreDisegno = xlRange.Cells(riga, 26).value
        xCostoFatturato = xlRange.Cells(riga, 27).value
        xCostoPreventivato = xlRange.Cells(riga, 28).value
        xScostamento = xlRange.Cells(riga, 29).value
        xNoteAgg = xlRange.Cells(riga, 30).value
        'le prossime 3 variabili non sono nel file excel ma sono una rielaborazione di dati presenti
        'necessaria per gestire gli inserimenti manuali di Galli (per gli ATM)
        'xIsAtm
        'xAtmString
        'xIsStringBefore

        If InStr(xEquipment.ToLower, "atm", CompareMethod.Text) <> 0 Then
            'ho trovato la stringa ATM nel campo xEquipment, quindi è un ATM
            'setto xIsAtm a true (visto che è un bool)
            xIsAtm = True
        Else
            xIsAtm = False
        End If

        Dim ResultString As String
        Try
            Dim RegexObj As New Regex("[\d]")
            ResultString = RegexObj.Match(xEquipment).Value
            Select Case InStr(xEquipment, ResultString)
                Case Is = 0
                    'il numero equipment è all'inizio
                    xAtmString = xEquipment.Substring(8, xEquipment.Length - 1)
                    xEquipment = ResultString
                    xIsStringBefore = False
                Case Is > 0
                    'il numero è dopo l'inizio stringa
                    xAtmString = xEquipment.Substring(0, xEquipment.Length - 8)
                    xEquipment = ResultString
                    xIsStringBefore = True
            End Select
        Catch ex As ArgumentException
            'Syntax error in the regular expression
            MsgBox("Stringa non trovata")
        End Try



        xlFile.Close(False) 'chiude senza salvare
        xlRange = Nothing
        xlSheet = Nothing
        xlFile = Nothing
        xlApp.Quit()
        xlApp = Nothing

    End Sub
End Class

Imports System.Windows.Forms
Imports System.Data.SqlClient

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
        xAnno = xlRange.Cells(riga, colonna).value

        xlFile.Close(False) 'chiude senza salvare
        xlRange = Nothing
        xlSheet = Nothing
        xlFile = Nothing
        xlApp.Quit()
        xlApp = Nothing

    End Sub
End Class

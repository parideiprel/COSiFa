Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class MDIParent1


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Me.Close()

        End
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        'MsgBox("System.Environment.UserName = " + System.Environment.UserName.ToString + vbCrLf + "System.Environment.UserDomainName = " + System.Environment.UserDomainName.ToString, vbOKOnly)
        'MsgBox("My.Resources.String1 = " + My.Resources.connectionString, vbOKOnly)
        frmInserimentoOre.Show()

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
                Debug.Print("******************* " + "{0}", sqlReader(0))
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

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class

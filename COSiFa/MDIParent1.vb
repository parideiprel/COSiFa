Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MsgBox("System.Environment.UserName = " + System.Environment.UserName.ToString + vbCrLf + "System.Environment.UserDomainName = " + System.Environment.UserDomainName.ToString, vbOKOnly)
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inserire qui le attività da fare al caricamento
        'tipo lettura dei diritti utente e abilitazione varie funzioni


    End Sub
End Class

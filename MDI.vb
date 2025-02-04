Imports System.Data.SqlClient
Public Class MDI

    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Service.CNX = New SqlClient.SqlConnection
        Service.CNX.ConnectionString = "server=(local);database=bibliothéque;integrated security=true"
        Service.CNX.Open()
    End Sub


    Private Sub AdherentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdherentToolStripMenuItem.Click
        Dim A As New Adherent
        A.MdiParent = Me
        A.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Adherent
    Private DaAdherent As SqlDataAdapter
    Private DtAdherent As New DataTable
    Private Lst As BindingManagerBase
    Private Sub Adherent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand
        cmd.Connection = Service.CNX
        cmd.CommandText = "select * from Adherent"
        Me.DaAdherent = New SqlDataAdapter(cmd)
        Me.DtAdherent.Rows.Clear()
        Me.DaAdherent.Fill(DtAdherent)
        Me.Lst = BindingContext(DtAdherent)
        Me.DataGridView1.DataSource = Me.DtAdherent

        Me.TxtCode.DataBindings.Add("text", DtAdherent, "codeAdh")
        Me.TxtNom.DataBindings.Add("text", DtAdherent, "NomAdh")
        Me.TxtAdresse.DataBindings.Add("text", DtAdherent, "AdrAdh")
        Me.TxtTel.DataBindings.Add("text", DtAdherent, "TelAdh")
        Me.TxtCin.DataBindings.Add("text", DtAdherent, "CinAdh")
        Me.TxtDate.DataBindings.Add("text", DtAdherent, "DnAdh")
        Me.TxtType.DataBindings.Add("text", DtAdherent, "TypAdh")

        Dim Cb As New SqlCommandBuilder(Me.DaAdherent)
        Me.DaAdherent.InsertCommand = Cb.GetInsertCommand
    End Sub

    Private Sub BtnPremier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPremier.Click
        Me.Lst.Position = 0
    End Sub

    Private Sub BtnSuivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuivant.Click
        Me.Lst.Position += 1
    End Sub

    Private Sub BtnDernier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDernier.Click
        Me.Lst.Position = Me.DtAdherent.Rows.Count - 1
    End Sub

    Private Sub BtnPrecedent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrecedent.Click
        Me.Lst.Position -= 1
    End Sub

    Private Sub BtnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouter.Click
        'Me.Lst.Position = 0
        Dim exist As Boolean = False
        For Each R As DataRow In Me.DtAdherent.Rows
            If CType(R.Item(4), String).ToUpper.Equals(Me.TxtCin.Text.ToUpper) Then
                exist = True
                MessageBox.Show("ce code  dejas existe")
                Exit For
            Else
                Me.Lst.AddNew()
                Me.Lst.Position += 1
            End If
        Next

        Me.Lst.Position = 0
    End Sub

    Private Sub RdTout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdTout.CheckedChanged
        Dim cmd As New SqlCommand
        cmd.Connection = Service.CNX
        cmd.CommandText = "select * from Adherent"
        Me.DaAdherent = New SqlDataAdapter(cmd)
        Me.DaAdherent.Fill(DtAdherent)
        Me.DataGridView1.DataSource = Me.DtAdherent
    End Sub

    Private Sub RdNom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdNom.CheckedChanged
        Dim cmd As New SqlCommand
        cmd.Connection = Service.CNX
        cmd.CommandText = "select * from Adherent where Adherent.NomAdh like %"
        'cmd.Parameters.AddWithValue("d
        Me.DtAdherent.Rows.Clear()
        Me.DaAdherent.Fill(DtAdherent)
        Me.DataGridView1.DataSource = Me.DtAdherent
    End Sub
End Class

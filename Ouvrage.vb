Imports System.Data.SqlClient
Public Class Ouvrage
    Private DaOuvrage As SqlDataAdapter
    Private DtOuvrage As New DataTable
    Private Lst As BindingManagerBase
    Private Sub Ouvrage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand
        cmd.Connection = Service.CNX
        cmd.CommandText = "select * from Ouvrage"
        Me.DaOuvrage = New SqlDataAdapter(cmd)
        Me.DtOuvrage.Rows.Clear()
        Me.DaOuvrage.Fill(DtOuvrage)
        Me.DataGridView1.DataSource = Me.DtOuvrage

        Me.Lst = Me.BindingContext(DtOuvrage)

        Dim Cb As New SqlCommandBuilder(Me.DaOuvrage)
        Me.DaOuvrage.InsertCommand = Cb.GetInsertCommand
        Me.DaOuvrage.DeleteCommand = Cb.GetDeleteCommand
        Me.DaOuvrage.UpdateCommand = Cb.GetUpdateCommand
    End Sub

    Private Sub BtnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouter.Click
        Me.Lst.Position = 0
        Dim Exist As Boolean = False
        For Each R As DataRow In Me.DtOuvrage.Rows
            If CType(R.Item(0), String).ToUpper.Equals(Me.TxtCode.Text.ToUpper) Then
                Exist = True
                MessageBox.Show("ce code dejas existe")
            Else
                Me.Lst.Position += 1

            End If
        Next
        Me.Lst.AddNew()
        Me.Lst.Position = 0
    End Sub

    Private Sub BtnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifier.Click
        Me.Lst.Position += 1
        Me.Lst.Position -= 1
        Me.DaOuvrage.Update(DtOuvrage)
    End Sub

    Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click
        Me.Lst.Position = 0
        Dim Exist As Boolean = False
        For Each R As DataRow In Me.DtOuvrage.Rows
            If CType(R.Item(0), String).ToUpper.Equals(Me.TxtCode.Text.ToUpper) Then
                Exist = True
                MessageBox.Show("ce code inconnu")
            Else
                Me.Lst.Position += 1
            End If
        Next
        Me.DtOuvrage.Rows(Me.Lst.Position).Delete()
        Me.Lst.Position = 0
    End Sub
End Class
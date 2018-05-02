Imports System.Data.SqlClient
Imports System.IO

Public Class detail_stg

    Private Sub detail_stg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ds.Tables.Contains("sta") Then
            ds.Tables("sta").Rows.Clear()
        End If
        da = New SqlDataAdapter("select * from stg where code_stg='" & b & "' ", cnx)
        da.Fill(ds, "sta")
        'ComboBox3.DisplayMember = ds.Tables("sal").Columns(0).ToString
        'ComboBox3.DataSource = ds.Tables("sal")


        ComboBox3.DataBindings.Add("text", ds, "sta.code_stg")
        TextBox2.DataBindings.Add("text", ds, "sta.nom")
        TextBox3.DataBindings.Add("text", ds, "sta.prenom")
        ComboBox8.DataBindings.Add("text", ds, "sta.titre")
        TextBox8.DataBindings.Add("text", ds, "sta.adresse")
        TextBox7.DataBindings.Add("text", ds, "sta.ville")
        TextBox9.DataBindings.Add("text", ds, "sta.tel")
        ComboBox7.DataBindings.Add("text", ds, "sta.diplome")
        MaskedTextBox5.DataBindings.Add("text", ds, "sta.date_entree_etablissement")
        MaskedTextBox7.DataBindings.Add("text", ds, "sta.date_sortie")
        '---'
        '---'
        MaskedTextBox1.DataBindings.Add("text", ds, "sta.date_naiss")
        TextBox6.DataBindings.Add("text", ds, "sta.CNSS")
        TextBox5.DataBindings.Add("text", ds, "sta.CIN")
        TextBox13.DataBindings.Add("text", ds, "sta.CIMR")
        ComboBox2.DataBindings.Add("text", ds, "sta.nom_departement")
        ' ComboBox6.DataBindings.Add("text", ds, "sal.nom_contrat")
        TextBox4.DataBindings.Add("text", ds, "sta.nationnalite")
        'TextBox5.DataBindings.Add("text", ds, "sal.CIN")
        ComboBox1.DataBindings.Add("text", ds, "sta.situation_familial")
        TextBox12.DataBindings.Add("text", ds, "sta.nbr_enfant")
        TextBox10.DataBindings.Add("text", ds, "sta.lieu_naiss")
        TextBox1.DataBindings.Add("text", ds, "sta.etablissement")
        Dim ss As String
        If Not IsDBNull(ds.Tables("sta").Rows(0)(22)) Then
            ss = ds.Tables("sta").Rows(0)(22)
            MsgBox(ss)

            ' Dim b As New Bitmap(ss)
            '  PictureBox1.Image = b
            Dim k As New Bitmap(ss)
            PictureBox1.Image = k
            '   PictureBox1.Refresh()
        Else

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
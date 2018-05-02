Imports System.Data.SqlClient

Public Class detail_candidat

    Private Sub detail_candidat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------ departement--------------------------
        If ds.Tables.Contains("dp") Then
            ds.Tables("dp").Rows.Clear()
        End If
        da = New SqlDataAdapter("select * from departement", cnx)
        cn()
        da.Fill(ds, "dp")
        ComboBox2.DisplayMember = ds.Tables("dp").Columns(1).ToString
        ComboBox2.ValueMember = ds.Tables("dp").Columns(0).ToString
        ComboBox2.DataSource = ds.Tables("dp")


        Try
            If ds.Tables.Contains("ca") Then
                ds.Tables("ca").Rows.Clear()
            End If
            da = New SqlDataAdapter("select * from candid where code_stg= '" & c & "'  ", cnx)
            da.Fill(ds, "ca")
            'ComboBox3.DisplayMember = ds.Tables("sal").Columns(0).ToString
            'ComboBox3.DataSource = ds.Tables("sal")


            TextBox16.DataBindings.Add("text", ds, "ca.code_stg")
            TextBox2.DataBindings.Add("text", ds, "ca.nom")
            TextBox3.DataBindings.Add("text", ds, "ca.prenom")
            ComboBox8.DataBindings.Add("text", ds, "ca.titre")
            TextBox8.DataBindings.Add("text", ds, "ca.adresse")
            TextBox7.DataBindings.Add("text", ds, "ca.ville")
            TextBox9.DataBindings.Add("text", ds, "ca.tel")
            ComboBox7.DataBindings.Add("text", ds, "ca.diplome")
            MaskedTextBox5.DataBindings.Add("text", ds, "ca.date_entree_etablissement")
            MaskedTextBox7.DataBindings.Add("text", ds, "ca.date_sortie")
            '---'
            '---'
            MaskedTextBox1.DataBindings.Add("text", ds, "ca.date_naiss")
            TextBox6.DataBindings.Add("text", ds, "ca.CNSS")
            TextBox5.DataBindings.Add("text", ds, "ca.CIN")
            TextBox13.DataBindings.Add("text", ds, "ca.CIMR")
            ComboBox2.DataBindings.Add("text", ds, "ca.nom_departement")
            ' ComboBox6.DataBindings.Add("text", ds, "sal.nom_contrat")
            TextBox4.DataBindings.Add("text", ds, "ca.nationnalite")
            'TextBox5.DataBindings.Add("text", ds, "sal.CIN")
            ComboBox1.DataBindings.Add("text", ds, "ca.situation_familial")
            TextBox12.DataBindings.Add("text", ds, "ca.nbr_enfant")
            TextBox11.DataBindings.Add("text", ds, "ca.experience")
            TextBox14.DataBindings.Add("text", ds, "ca.societe_exp")
            TextBox15.DataBindings.Add("text", ds, "ca.en_qualite_de")
            TextBox10.DataBindings.Add("text", ds, "ca.lieu_naiss")
            TextBox1.DataBindings.Add("text", ds, "ca.etablissement")
            Dim s As String
            If Not IsDBNull(ds.Tables("ca").Rows(0)(25)) Then
                s = ds.Tables("ca").Rows(0)(25)
                ''  MsgBox(s)
                Dim b As New Bitmap(s)
                PictureBox1.Image = b
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '  cmd = New SqlCommand("update candidature set titre='" & ComboBox8.Text & "',nom='" & TextBox2.Text & "',prenom='" & TextBox3.Text & "',CIN='" & TextBox2.Text & "',adresse='" & TextBox8.Text & "',ville='" & TextBox7.Text & "',tel='" & TextBox9.Text & "',,date_entree_etablissement='" & MaskedTextBox5.Text & "',date_sortie='" & MaskedTextBox7.Text & "',date_naiss='" & MaskedTextBox1.Text & "',CNSS='" & TextBox6.Text & "',CIMR='" & TextBox13.Text & "',id_dep='" & ComboBox2.SelectedValue & "',nationnalite='" & TextBox4.Text & "',situation_familial='" & ComboBox1.Text & "',nbr_enfant='" & TextBox12.Text & "',diplome='" & ComboBox7.Text & "',etablissement='" & TextBox1.Text & "',experience='" & TextBox11.Text & "',societe_exp='" & TextBox14.Text & "',en_qualite_de='" & TextBox15.Text & "',observation='" & TextBox17.Text & "',lieu_naiss='" & TextBox10.Text & "' where code_stg= '" & c & "' ", cnx)
        cmd = New SqlCommand("update candidature set titre='" & ComboBox8.Text & "',nom='" & TextBox2.Text & "',prenom='" & TextBox3.Text & "',adresse='" & TextBox8.Text & "',ville='" & TextBox7.Text & "',tel='" & TextBox9.Text & "',date_entree_etablissement='" & MaskedTextBox5.Text & "',date_sortie='" & MaskedTextBox7.Text & "',date_naiss='" & MaskedTextBox1.Text & "',CNSS='" & TextBox6.Text & "',CIMR='" & TextBox13.Text & "',id_dep='" & ComboBox2.SelectedValue & "',nationnalite='" & TextBox4.Text & "',CIN='" & TextBox5.Text & "',situation_familial='" & ComboBox1.Text & "',nbr_enfant='" & TextBox12.Text & "',diplome='" & ComboBox7.Text & "',etablissement='" & TextBox1.Text & "',experience='" & TextBox11.Text & "',societe_exp='" & TextBox14.Text & "',en_qualite_de='" & TextBox15.Text & "',lieu_naiss='" & TextBox10.Text & "',observation='" & TextBox17.Text & "' where code_stg='" & TextBox16.Text & "' ", cnx)

        If MsgBox("voulez-vous vraiment modifer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            cn()
            cmd.ExecuteNonQuery()

            MsgBox("opération réussit")
        End If
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged

    End Sub
End Class
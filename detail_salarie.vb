Imports System.Data.SqlClient

Public Class detail_salarie

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub detail_salarie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ds.Tables.Contains("co") Then
            ds.Tables("co").Rows.Clear()
        End If
        da = New SqlDataAdapter("select * from contrat ", cnx)
        cn()
        da.Fill(ds, "co")
        ComboBox6.DisplayMember = ds.Tables("co").Columns(1).ToString
        ComboBox6.ValueMember = ds.Tables("co").Columns(0).ToString
        ComboBox6.DataSource = ds.Tables("co")
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

        
            If ds.Tables.Contains("sa") Then
                ds.Tables("sa").Rows.Clear()
            End If



            da = New SqlDataAdapter("select * from sal where matricule='" & a & "' ", cnx)
            da.Fill(ds, "sa")

            'ComboBox3.DisplayMember = ds.Tables("sal").Columns(0).ToString
            'ComboBox3.DataSource = ds.Tables("sal")


            TextBox1.DataBindings.Add("text", ds, "sa.matricule")
            TextBox2.DataBindings.Add("text", ds, "sa.nom")
            TextBox3.DataBindings.Add("text", ds, "sa.prenom")
            ComboBox8.DataBindings.Add("text", ds, "sa.titre")
            TextBox8.DataBindings.Add("text", ds, "sa.adresse")
            TextBox7.DataBindings.Add("text", ds, "sa.ville")
            TextBox9.DataBindings.Add("text", ds, "sa.tel")
            ComboBox7.DataBindings.Add("text", ds, "sa.diplome")
            MaskedTextBox6.DataBindings.Add("text", ds, "sa.date_entree_groupe")
            MaskedTextBox5.DataBindings.Add("text", ds, "sa.date_entree_etablissement")
            MaskedTextBox7.DataBindings.Add("text", ds, "sa.date_sortie")
            TextBox15.DataBindings.Add("text", ds, "sa.mode_paiment")
            '---'
            MaskedTextBox8.DataBindings.Add("text", ds, "sa.RIB")
            '---'
            MaskedTextBox1.DataBindings.Add("text", ds, "sa.date_naiss")
            TextBox6.DataBindings.Add("text", ds, "sa.CNSS")
            TextBox5.DataBindings.Add("text", ds, "sa.CIN")
            TextBox13.DataBindings.Add("text", ds, "sa.CIMR")
            'ComboBox2.DataBindings.Add("text", ds, "sal.nom_departement")
            ' ComboBox6.DataBindings.Add("text", ds, "sal.nom_contrat")
            TextBox4.DataBindings.Add("text", ds, "sa.nationnalite")
            'TextBox5.DataBindings.Add("text", ds, "sal.CIN")
            TextBox16.DataBindings.Add("text", ds, "sa.fonction")
            MaskedTextBox2.DataBindings.Add("text", ds, "sa.date_affiliation")
            ComboBox1.DataBindings.Add("text", ds, "sa.situation_familial")
            TextBox12.DataBindings.Add("text", ds, "sa.nbr_enfant")
            'TextBox11.DataBindings.Add("text", ds, "sal.salaire")
            MaskedTextBox3.DataBindings.Add("text", ds, "sa.Date_debut_contrat")
            MaskedTextBox4.DataBindings.Add("text", ds, "sa.Date_fin_contrat")
            TextBox10.DataBindings.Add("text", ds, "sa.lieu_naiss")
            ComboBox2.DataBindings.Add("text", ds, "sa.nom_departement")
            ComboBox6.DataBindings.Add("text", ds, "sa.nom_contrat")
            


            Label32.Text = ComboBox8.Text & Space(5) & TextBox2.Text & Space(5) & TextBox3.Text
            Label33.Text = TextBox16.Text
            Dim s As String
            If Not IsDBNull(ds.Tables("sa").Rows(0)(47)) Then
                s = ds.Tables("sa").Rows(0)(47)
                ''  MsgBox(s)
                Dim b As New Bitmap(s)
                PictureBox1.Image = b
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cmd = New SqlCommand("update salarie set titre='" & ComboBox8.Text & "',nom='" & TextBox2.Text & "',prenom='" & TextBox3.Text & "',CIN='" & TextBox5.Text & "' , adresse='" & TextBox8.Text & "',ville='" & TextBox7.Text & "',tel='" & TextBox9.Text & "',code_contrat='" & ComboBox6.SelectedValue & "',date_entree_groupe='" & MaskedTextBox6.Text & "',date_entree_etablissement='" & MaskedTextBox5.Text & "',date_sortie='" & MaskedTextBox7.Text & "',mode_paiment='" & TextBox15.Text & "' ,RIB='" & MaskedTextBox8.Text & "',date_naiss='" & MaskedTextBox1.Text & "',CNSS='" & TextBox6.Text & "',CIMR='" & TextBox13.Text & "',id_dep='" & ComboBox2.SelectedValue & "',nationnalite='" & TextBox5.Text & "',fonction='" & TextBox16.Text & "' ,date_affiliation='" & MaskedTextBox2.Text & "',situation_familial='" & ComboBox1.Text & "' ,nbr_enfant='" & TextBox12.Text & "',date_Debut_contrat='" & MaskedTextBox3.Text & "',date_fin_contrat='" & MaskedTextBox4.Text & "',observation='" & TextBox14.Text & "',diplome='" & ComboBox7.Text & "',nom_banque='" & TextBox17.Text & "' where matricule='" & TextBox1.Text & "' ", cnx)
            cn()
            If MsgBox("voulez-vous modifier ce salarie?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                cmd.ExecuteNonQuery()
                MsgBox("opération effectuer")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
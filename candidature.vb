Imports System.Data.SqlClient

Public Class candidature

    Private Sub candidature_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        '------------------- candidat----------------------
        If ds.Tables.Contains("sal") Then
            ds.Tables("sal").Rows.Clear()
        End If
        da = New SqlDataAdapter("select * from candidature", cnx)
        da.Fill(ds, "sal")
        'ComboBox3.DisplayMember = ds.Tables("sal").Columns(0).ToString
        'ComboBox3.DataSource = ds.Tables("sal")


        TextBox16.DataBindings.Add("text", ds, "sal.code_stg")
        TextBox2.DataBindings.Add("text", ds, "sal.nom")
        TextBox3.DataBindings.Add("text", ds, "sal.prenom")
        ComboBox8.DataBindings.Add("text", ds, "sal.titre")
        TextBox8.DataBindings.Add("text", ds, "sal.adresse")
        TextBox7.DataBindings.Add("text", ds, "sal.ville")
        TextBox9.DataBindings.Add("text", ds, "sal.tel")
        ComboBox7.DataBindings.Add("text", ds, "sal.diplome")
        TextBox19.DataBindings.Add("text", ds, "sal.date_entree_etablissement")
        TextBox20.DataBindings.Add("text", ds, "sal.date_sortie")
        '---'
        '---'
        TextBox17.DataBindings.Add("text", ds, "sal.date_naiss")
        TextBox6.DataBindings.Add("text", ds, "sal.CNSS")
        TextBox5.DataBindings.Add("text", ds, "sal.CIN")
        TextBox13.DataBindings.Add("text", ds, "sal.CIMR")
        'ComboBox2.DataBindings.Add("text", ds, "sal.nom_departement")
        ' ComboBox6.DataBindings.Add("text", ds, "sal.nom_contrat")
        TextBox4.DataBindings.Add("text", ds, "sal.nationnalite")
        'TextBox5.DataBindings.Add("text", ds, "sal.CIN")
        ComboBox1.DataBindings.Add("text", ds, "sal.situation_familial")
        TextBox12.DataBindings.Add("text", ds, "sal.nbr_enfant")
        TextBox11.DataBindings.Add("text", ds, "sal.experience")
        TextBox14.DataBindings.Add("text", ds, "sal.societe_exp")
        TextBox15.DataBindings.Add("text", ds, "sal.en_qualite_de")
        TextBox10.DataBindings.Add("text", ds, "sal.lieu_naiss")
        TextBox1.DataBindings.Add("text", ds, "sal.etablissement")
        'DataGridView1.DataSource = ds 'ds.Tables("sal")
        'DataGridView1.DataMember = "sal"
        Try
            Dim s As String = ds.Tables("sal").Rows(0)(25)
            Dim a As New Bitmap(s)
            PictureBox1.Image = a
        Catch ex As Exception

        End Try





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cmd = New SqlCommand("insert into candidature (code_stg,titre,nom,prenom,adresse,ville,tel,diplome,date_entree_etablissement,date_sortie,date_naiss,CNSS,CIMR,id_dep,nationnalite,CIN,situation_familial,nbr_enfant,etablissement,experience,societe_exp,en_qualite_de,lieu_naiss,photo) values ( '" & TextBox16.Text & "' , '" & ComboBox8.Text & "'  ,'" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox8.Text & "', '" & TextBox7.Text & "', '" & TextBox9.Text & "', '" & ComboBox7.Text & "' ,'" & TextBox19.Text & "','" & TextBox20.Text & "','" & TextBox17.Text & "','" & TextBox6.Text & "' ,'" & TextBox13.Text & "', '" & ComboBox2.SelectedValue & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox11.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox10.Text & "','" & TextBox18.Text & "' ) ", cnx)
            cn()
            cmd.ExecuteNonQuery()
            MsgBox("ajouter avec succés")
            vider()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub vider()
        TextBox17.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        TextBox16.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox11.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox18.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("voulez-vous vraiment vider les champs", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            vider()
        End If



    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim up As New SqlCommandBuilder(da)
        Try
            da.Update(ds, "sal")
            MsgBox("vos information sont enregistrer avec succes")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Me.BindingContext(ds, "sal").EndCurrentEdit()
        cmd = New SqlCommand("update candidature set titre='" & ComboBox8.Text & "',nom='" & TextBox2.Text & "',prenom='" & TextBox3.Text & "',adresse='" & TextBox8.Text & "',ville='" & TextBox7.Text & "',tel='" & TextBox9.Text & "',date_entree_etablissement='" & TextBox19.Text & "',date_sortie='" & TextBox20.Text & "',date_naiss='" & TextBox17.Text & "',CNSS='" & TextBox6.Text & "',CIMR='" & TextBox13.Text & "',id_dep='" & ComboBox2.SelectedValue & "',nationnalite='" & TextBox4.Text & "',CIN='" & TextBox5.Text & "',situation_familial='" & ComboBox1.Text & "',nbr_enfant='" & TextBox12.Text & "',diplome='" & ComboBox7.Text & "',etablissement='" & TextBox1.Text & "',experience='" & TextBox11.Text & "',societe_exp='" & TextBox14.Text & "',en_qualite_de='" & TextBox15.Text & "',lieu_naiss='" & TextBox10.Text & "',observation='" & TextBox21.Text & "',photo='" & TextBox18.Text & "' where code_stg='" & TextBox16.Text & "' ", cnx)
        If MsgBox("voulez-vous modifier", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            cn()
            cmd.ExecuteNonQuery()
            MsgBox("modifer")
        End If







    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Dim p As Integer
        'p = Me.BindingContext(ds, "sal").Position
        'ds.Tables("sal").Rows(p).Delete()
        Try


            cmd = New SqlCommand("delete from candidature where code_stg='" & TextBox16.Text & "'", cnx)
            If MsgBox("voulez-vous vraiment supprimer!!", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                If MsgBox("êtes_vous vouloir supprimer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    cn()
                    cmd.ExecuteNonQuery()
                    MsgBox("operation reussite")
                End If

            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try

       
            Dim p As Integer
            Me.BindingContext(ds, "sal").Position = 0
            p = Me.BindingContext(ds, "sal").Position
            Dim s As String

            s = ds.Tables("sal").Rows(p)(25)
            '  MsgBox(s)

            PictureBox1.Visible = True
            Dim a As New Bitmap(s)
            PictureBox1.Image = a
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Me.BindingContext(ds, "sal").Position = ds.Tables("sal").Rows.Count - 1
            Dim p As Integer
            p = Me.BindingContext(ds, "sal").Position
            Dim s As String

            s = ds.Tables("sal").Rows(p)(25)
            '  MsgBox(s)

            PictureBox1.Visible = True
            Dim a As New Bitmap(s)
            PictureBox1.Image = a
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try


            Dim p As Integer

            Me.BindingContext(ds, "sal").Position -= 1
            p = Me.BindingContext(ds, "sal").Position
            Dim s As String

            If IsDBNull(ds.Tables("sal").Rows(p)(25)) Then
                PictureBox1.Visible = False
            Else
                s = ds.Tables("sal").Rows(p)(25)
                '  MsgBox(s)

                PictureBox1.Visible = True
                Dim a As New Bitmap(s)
                PictureBox1.Image = a
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try


            Dim p As Integer

            Me.BindingContext(ds, "sal").Position += 1
            p = Me.BindingContext(ds, "sal").Position
            Dim s As String

            If IsDBNull(ds.Tables("sal").Rows(p)(25)) Then
                PictureBox1.Visible = False
            Else
                s = ds.Tables("sal").Rows(p)(25)
                '  MsgBox(s)

                PictureBox1.Visible = True
                Dim a As New Bitmap(s)
                PictureBox1.Image = a
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If MsgBox("enregistrer votre travail avant de fermer", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Me.Close()
        Else
            Dim up As New SqlCommandBuilder(da)
            da.Update(ds, "sal")
            MsgBox("vos information sont enregistrer avec succes")
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Célibataire" Then
            TextBox12.Enabled = False
        Else
            TextBox12.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ofd As New OpenFileDialog()


        ofd.Filter = "jpeg files (*.jpg)|*.jpg| BMP|*.bmp|JPG|*.jpg|GIF|*.gif|PDF|*.pdf|All files (*.*)|*.*"

        If (ofd.ShowDialog = Windows.Forms.DialogResult.OK) Then
            TextBox18.Text = ofd.FileName
            Dim img As Image
            img = New Bitmap(ofd.FileName)
            PictureBox1.Image = CType(img, Image)
            PictureBox1.Tag = ofd.FileName
            Dim a As New Bitmap(ofd.FileName)
            PictureBox1.Image = a
        End If
    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged

    End Sub
End Class

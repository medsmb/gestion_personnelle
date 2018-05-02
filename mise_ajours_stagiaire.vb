Imports System.Data.SqlClient

Public Class mise_ajours_stagiaire

    Private Sub mise_ajours_stagiaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        ' ------------------ stagiaire--------------------
        If ds.Tables.Contains("sall") Then
            ds.Tables("sall").Rows.Clear()
        End If
        da = New SqlDataAdapter("select * from stagiaire", cnx)
        da.Fill(ds, "sall")
        'ComboBox3.DisplayMember = ds.Tables("sal").Columns(0).ToString
        'ComboBox3.DataSource = ds.Tables("sal")


        TextBox11.DataBindings.Add("text", ds, "sall.code_stg")
        TextBox2.DataBindings.Add("text", ds, "sall.nom")
        TextBox3.DataBindings.Add("text", ds, "sall.prenom")
        ComboBox8.DataBindings.Add("text", ds, "sall.titre")
        TextBox8.DataBindings.Add("text", ds, "sall.adresse")
        TextBox7.DataBindings.Add("text", ds, "sall.ville")
        TextBox9.DataBindings.Add("text", ds, "sall.tel")
        ComboBox7.DataBindings.Add("text", ds, "sall.diplome")
        TextBox15.DataBindings.Add("text", ds, "sall.date_entree_etablissement")
        TextBox16.DataBindings.Add("text", ds, "sall.date_sortie")
        '---'
        '---'
        TextBox14.DataBindings.Add("text", ds, "sall.date_naiss")
        TextBox6.DataBindings.Add("text", ds, "sall.CNSS")
        TextBox5.DataBindings.Add("text", ds, "sall.CIN")
        TextBox13.DataBindings.Add("text", ds, "sall.CIMR")
        'ComboBox2.DataBindings.Add("text", ds, "sal.nom_departement")
        ' ComboBox6.DataBindings.Add("text", ds, "sal.nom_contrat")
        TextBox4.DataBindings.Add("text", ds, "sall.nationnalite")
        'TextBox5.DataBindings.Add("text", ds, "sal.CIN")
        ComboBox1.DataBindings.Add("text", ds, "sall.situation_familial")
        TextBox12.DataBindings.Add("text", ds, "sall.nbr_enfant")
        TextBox10.DataBindings.Add("text", ds, "sall.lieu_naiss")

        Dim s As String

        s = ds.Tables("sall").Rows(0)(22)
        '  MsgBox(s)

        PictureBox1.Visible = True
        Dim a As New Bitmap(s)
        PictureBox1.Image = a
        'PictureBox1.Refresh()


      
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Me.BindingContext(ds, "sal").AddNew()
        'MsgBox("ajouter")
        Try
            cmd = New SqlCommand("insert into stagiaire (code_stg,titre,nom,prenom,adresse,ville,tel,diplome,date_entree_etablissement,date_sortie,date_naiss,CNSS,CIMR,id_dep,nationnalite,CIN,situation_familial,nbr_enfant,etablissement,lieu_naiss,photo) values ( '" & TextBox11.Text & "' , '" & ComboBox8.Text & "'  ,'" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox8.Text & "', '" & TextBox7.Text & "', '" & TextBox9.Text & "', '" & ComboBox7.Text & "' ,'" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox14.Text & "','" & TextBox6.Text & "' ,'" & TextBox13.Text & "', '" & ComboBox2.SelectedValue & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox10.Text & "','" & TextBox18.Text & "' ) ", cnx)
            cn()
            cmd.ExecuteNonQuery()
            MsgBox("ajouter")
            vider()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub vider()
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox14.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        TextBox11.Text = ""
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
        TextBox18.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("voulez vous vider les champs", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            vider()
        End If





    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim up As New SqlCommandBuilder(da)
        da.Update(ds, "sall")
        MsgBox("vos information sont enregistrer avec succes")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            cmd = New SqlCommand("update stagiaire set titre='" & ComboBox8.Text & "',nom='" & TextBox2.Text & "',prenom='" & TextBox3.Text & "',adresse='" & TextBox8.Text & "',ville='" & TextBox7.Text & "',tel='" & TextBox9.Text & "',date_entree_etablissement='" & TextBox15.Text & "',date_sortie='" & TextBox16.Text & "',CNSS='" & TextBox6.Text & "',CIMR='" & TextBox13.Text & "',id_dep='" & ComboBox2.SelectedValue & "',nationnalite='" & TextBox4.Text & "',CIN='" & TextBox5.Text & "',situation_familial='" & ComboBox1.Text & "',nbr_enfant='" & TextBox12.Text & "',diplome='" & ComboBox7.Text & "',etablissement='" & TextBox1.Text & "',observation='" & TextBox17.Text & "',lieu_naiss='" & TextBox10.Text & "',photo='" & TextBox18.Text & "' where code_stg='" & TextBox11.Text & "' ", cnx)
            If MsgBox("voulez-vous vraiment modifier", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                cn()
                cmd.ExecuteNonQuery()
                MsgBox("operation reussit")
            End If

        Catch ex As Exception

        End Try





    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Dim p As Integer
        'p = Me.BindingContext(ds, "sall").Position
        'ds.Tables("sall").Rows(p).Delete()
        Try

        
            cmd = New SqlCommand("delete from stagiaire where code_stg='" & TextBox11.Text & "' ", cnx)
            If MsgBox("voulez vous supprimer ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                If MsgBox("voulez vraiment supprimer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    cn()
                    cmd.ExecuteNonQuery()

                    MsgBox("operation reussit ")
                End If
            End If


        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        '  Me.BindingContext(ds, "sall").Position = 0
        Dim p As Integer
        Me.BindingContext(ds, "sall").Position = 0
        p = Me.BindingContext(ds, "sall").Position
        ' salarie = ds.Tables("sall").Rows(p)(0)
        Dim s As String

        s = ds.Tables("sall").Rows(p)(22)
        '  MsgBox(s)

        PictureBox1.Visible = True
        Dim a As New Bitmap(s)
        PictureBox1.Image = a






    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim p As Integer
        Me.BindingContext(ds, "sall").Position = ds.Tables("sall").Rows.Count - 1
        p = Me.BindingContext(ds, "sall").Position
        '  salarie = ds.Tables("sall").Rows(p)(0)
        Dim s As String

        s = ds.Tables("sall").Rows(p)(22)
        '  MsgBox(s)

        PictureBox1.Visible = True
        Dim a As New Bitmap(s)
        PictureBox1.Image = a






    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.BindingContext(ds, "sall").Position -= 1
        Try


            Dim p As Integer

            Me.BindingContext(ds, "sall").Position -= 1
            p = Me.BindingContext(ds, "sall").Position
            salarie = ds.Tables("sall").Rows(p)(0)
            Dim s As String

            If IsDBNull(ds.Tables("sall").Rows(p)(22)) Then
                PictureBox1.Visible = False
            Else
                s = ds.Tables("sall").Rows(p)(22)
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
        ' Me.BindingContext(ds, "sall").Position += 1
        Try
            Dim p As Integer
            Me.BindingContext(ds, "sall").Position += 1

            p = Me.BindingContext(ds, "sall").Position
            salarie = ds.Tables("sall").Rows(p)(0)
            Dim s As String
            If IsDBNull(ds.Tables("sall").Rows(p)(22)) Then
                PictureBox1.Visible = False
            Else
                s = ds.Tables("sall").Rows(p)(22)
                '  MsgBox(s)

                PictureBox1.Visible = True
                Dim a As New Bitmap(s)
                PictureBox1.Image = a
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If MsgBox("enregistrer votre travail avant de fermer", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Me.Close()
        Else
            Dim up As New SqlCommandBuilder(da)
            da.Update(ds, "sall")
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

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'ouvrir OpenFileDialog 
        Dim ofd As New OpenFileDialog()
        'ouvrir OpenFileDialog 
        Try


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
            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
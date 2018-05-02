Imports System.Data.SqlClient
Imports System.IO

Public Class Mise_à_jour_salariés
    Public Sub vider()
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""
        MaskedTextBox8.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        TextBox17.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox1.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        ComboBox3.Text = ""
        TextBox16.Text = ""
        TextBox14.Text = ""
        Button11.Visible = True
        PictureBox1.Visible = True
    End Sub
    'Private Sub Mise_à_jour_salariés_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    da.Fill(ds, "Sl")
    '    TextBox1.DataBindings.Add("text", ds, "Sl.CIN")
    '    TextBox2.DataBindings.Add("text", ds, "Sl.Nom")
    '    TextBox3.DataBindings.Add("text", ds, "Sl.Prenom")
    '    'TextBox4.DataBindings.Add("text", ds, "Sl.Date_naissance")
    '    TextBox5.DataBindings.Add("text", ds, "Sl.Ville")
    '    TextBox6.DataBindings.Add("text", ds, "Sl.Adresse")
    '    TextBox7.DataBindings.Add("text", ds, "Sl.Telephone")
    '    TextBox8.DataBindings.Add("text", ds, "Sl.Fonction")
    '    ComboBox1.DataBindings.Add("text", ds, "Sl.Situation")
    '    '   NumericUpDown1.DataBindings.Add("text", ds, "c.NombreEnfants")
    '    DataGridView1.DataSource = ds
    '    DataGridView1.DataMember = "Sl"
    'End Sub

    'Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    '    Detail_salaire.Show()
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Me.BindingContext(ds, "Sl").AddNew()
    '    ds.Tables("Sl").GetChanges()
    '    DataGridView1.Refresh()
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Dim y As New SqlCommandBuilder(da)
    '    da.Update(ds.Tables("Sl"))
    '    MsgBox("enregistrer avec succés  !!")
    'End Sub

    'Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    'End Sub
    Public Overrides Sub refresh()
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
        '----------------- salarie--------------------------------------
        If ds.Tables.Contains("sal") Then
            ds.Tables("sal").Rows.Clear()
        End If

        '    da = New SqlDataAdapter(" select matricule,nom ,prenom,titre,adresse,ville,tel,diplome,date_entree_groupe,date_entree_etablissement,date_sortie,mode_paiment,RIB,date_naiss,CNSS,CIN,CIMR,nom_departement,nom_contrat,nationnalite,fonction, date_affiliation, situation_familial, nbr_enfant, salaire, Date_debut_contrat, Date_fin_contrat  from salarie inner join contrat on contrat.code_contrat=salarie.code_contrat inner join departement on departement.id_dep=salarie.id_dep", cnx)
        da = New SqlDataAdapter("select * from salarie", cnx)
        da.Fill(ds, "sal")
        'ComboBox3.DisplayMember = ds.Tables("sal").Columns(0).ToString
        'ComboBox3.DataSource = ds.Tables("sal")
        salarie = ds.Tables("sal").Rows(0)(0)

        TextBox17.DataBindings.Add("text", ds, "sal.matricule")

        TextBox2.DataBindings.Add("text", ds, "sal.nom")
        TextBox3.DataBindings.Add("text", ds, "sal.prenom")
        ComboBox8.DataBindings.Add("text", ds, "sal.titre")
        TextBox8.DataBindings.Add("text", ds, "sal.adresse")
        TextBox7.DataBindings.Add("text", ds, "sal.ville")
        TextBox9.DataBindings.Add("text", ds, "sal.tel")
        ComboBox7.DataBindings.Add("text", ds, "sal.diplome")
        TextBox24.DataBindings.Add("text", ds, "sal.date_entree_groupe")
        TextBox22.DataBindings.Add("text", ds, "sal.date_entree_etablissement")
        TextBox25.DataBindings.Add("text", ds, "sal.date_sortie")
        ComboBox3.DataBindings.Add("text", ds, "sal.mode_paiment")
        '---'
        MaskedTextBox8.DataBindings.Add("text", ds, "sal.RIB")
        '---'
        TextBox19.DataBindings.Add("text", ds, "sal.date_naiss")
        TextBox6.DataBindings.Add("text", ds, "sal.CNSS")
        TextBox5.DataBindings.Add("text", ds, "sal.CIN")
        TextBox13.DataBindings.Add("text", ds, "sal.CIMR")
        'ComboBox2.DataBindings.Add("text", ds, "sal.nom_departement")
        ' ComboBox6.DataBindings.Add("text", ds, "sal.nom_contrat")
        TextBox4.DataBindings.Add("text", ds, "sal.nationnalite")
        'TextBox5.DataBindings.Add("text", ds, "sal.CIN")
        TextBox16.DataBindings.Add("text", ds, "sal.fonction")
        TextBox23.DataBindings.Add("text", ds, "sal.date_affiliation")
        ComboBox1.DataBindings.Add("text", ds, "sal.situation_familial")
        TextBox12.DataBindings.Add("text", ds, "sal.nbr_enfant")
        ' TextBox11.DataBindings.Add("text", ds, "sal.salaire_de_base")
        TextBox20.DataBindings.Add("text", ds, "sal.Date_debut_contrat")
        TextBox21.DataBindings.Add("text", ds, "sal.Date_fin_contrat")
        TextBox10.DataBindings.Add("text", ds, "sal.lieu_naiss")
        TextBox1.DataBindings.Add("text", ds, "sal.nom_banque")
        TextBox14.DataBindings.Add("text", ds, "sal.observation")


        ' PictureBox1.DataBindings.Add("
        ' MsgBox(ds.Tables("sal").Rows(0)(47).ToString)

        Dim s As String

        s = ds.Tables("sal").Rows(0)(47)
        '  MsgBox(s)

        PictureBox1.Visible = True
        Dim a As New Bitmap(s)
        PictureBox1.Image = a
        'PictureBox1.Refresh()

    End Sub

    Private Sub Mise_à_jour_salariés_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------contrat---------------------------
      
        refresh()





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If Len(Mid(MaskedTextBox8.Text, 1)) < 35 Then
                MsgBox("veuillez remplire la zone du RIB")
            Else
                cmd = New SqlCommand("insert into salarie (matricule,titre,nom,prenom,adresse,ville,tel,diplome,code_contrat,date_entree_groupe,date_entree_etablissement,date_sortie,mode_paiment,RIB,date_naiss,CNSS,CIMR,id_dep,nationnalite,CIN,fonction,date_affiliation,situation_familial,nbr_enfant,Date_debut_contrat,Date_fin_contrat,lieu_naiss,nom_banque,observation,photo) values ( '" & TextBox14.Text & "' , '" & ComboBox8.Text & "'  ,'" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox8.Text & "', '" & TextBox7.Text & "', '" & TextBox9.Text & "', '" & ComboBox7.Text & "' , '" & ComboBox6.SelectedValue & "','" & TextBox24.Text & "','" & TextBox22.Text & "','" & TextBox25.Text & "','" & ComboBox3.Text & "', '" & MaskedTextBox8.Text & "','" & TextBox19.Text & "','" & TextBox6.Text & "' ,'" & TextBox13.Text & "', '" & ComboBox2.SelectedValue & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox16.Text & "','" & TextBox23.Text & "','" & ComboBox1.Text & "','" & TextBox12.Text & "','" & TextBox20.Text & "','" & TextBox21.Text & "','" & TextBox10.Text & "','" & TextBox1.Text & "','" & TextBox14.Text & "' , '" & nom_pic & "' )", cnx)
                cn()
                cmd.ExecuteNonQuery()
                'Me.BindingContext(ds, "sal").AddNew()

                MsgBox("ajouter")
            End If


            ' DataGridView1.DataSource = ds.Tables("sal")
            '    DataGridView1.Rows.Add(ComboBox3.Text, ComboBox8.Text, TextBox2.Text, TextBox3.Text, TextBox8.Text, TextBox7.Text, TextBox9.Text, ComboBox7.Text, ComboBox6.SelectedValue, MaskedTextBox6.Text, MaskedTextBox5.Text, MaskedTextBox7.Text, TextBox15.Text, MaskedTextBox8.Text, DateTimePicker1.Value, TextBox6.Text, TextBox13.Text, ComboBox2.SelectedValue, TextBox4.Text, TextBox5.Text, TextBox16.Text, MaskedTextBox2.Text, ComboBox1.Text, TextBox12.Text, MaskedTextBox3.Text, MaskedTextBox4.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
     
        If MsgBox("voulez-vous vraiment vider les champs", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            vider()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim p As Integer
        Me.BindingContext(ds, "sal").Position = 0
        p = Me.BindingContext(ds, "sal").Position
        salarie = ds.Tables("sal").Rows(p)(0)
        Dim s As String

        s = ds.Tables("sal").Rows(p)(47)
        '  MsgBox(s)

        PictureBox1.Visible = True
        Dim a As New Bitmap(s)
        PictureBox1.Image = a
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim p As Integer
        Me.BindingContext(ds, "sal").Position = ds.Tables("sal").Rows.Count - 1
        p = Me.BindingContext(ds, "sal").Position
        salarie = ds.Tables("sal").Rows(p)(0)








        'da = New SqlDataAdapter("select * from sal", cnx)
        'cn()
        'da.Fill(ds, "cl")
        'TextBox17.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(0)
        'ComboBox8.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(1)
        'TextBox2.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(2)
        'TextBox3.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(3)
        'TextBox4.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(19)
        'TextBox19.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(14)
        'TextBox8.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(4)
        'TextBox9.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(6)
        'TextBox5.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(18)
        'TextBox7.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(5)
        'TextBox10.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(46)
        'ComboBox1.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(22)
        'TextBox12.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(23)
        'ComboBox7.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(45)
        'ComboBox2.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(48) 'dep
        'TextBox16.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(20)
        'ComboBox6.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(7)
        'TextBox20.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(42)
        'TextBox21.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(43)
        'TextBox22.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(10)
        'TextBox23.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(21)
        'TextBox15.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(12)
        'TextBox1.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(47)
        'MaskedTextBox8.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(13)
        'TextBox6.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(15)
        'TextBox13.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(16)
        'TextBox24.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(9)
        'TextBox25.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(11)
        'TextBox14.Text = ds.Tables("cl").Rows(ds.Tables("cl").Rows.Count - 1)(44)



















        Dim s As String

        s = ds.Tables("sal").Rows(p)(47)
        '  MsgBox(s)

        PictureBox1.Visible = True
        Dim a As New Bitmap(s)
        PictureBox1.Image = a




    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try

        
            Dim p As Integer

            Me.BindingContext(ds, "sal").Position -= 1
            p = Me.BindingContext(ds, "sal").Position
            salarie = ds.Tables("sal").Rows(p)(0)
            Dim s As String

            If IsDBNull(ds.Tables("sal").Rows(p)(47)) Then
                PictureBox1.Visible = False
            Else
                s = ds.Tables("sal").Rows(p)(47)
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
            salarie = ds.Tables("sal").Rows(p)(0)
            Dim s As String
            If IsDBNull(ds.Tables("sal").Rows(p)(47)) Then
                PictureBox1.Visible = False
            Else
                s = ds.Tables("sal").Rows(p)(47)
                '  MsgBox(s)

                PictureBox1.Visible = True
                Dim a As New Bitmap(s)
                PictureBox1.Image = a
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim up As New SqlCommandBuilder(da)
    '    da.Update(ds, "sal")
    '    MsgBox("vos information sont enregistrer avec succes")
    'End Sub




    'Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
    '    Try

    '        cmd = New SqlCommand("update salarie set titre= '" & ComboBox8.Text & "', nom= '" & TextBox2.Text & "', prenom= '" & TextBox3.Text & "',adresse= '" & TextBox8.Text & "',ville = '" & TextBox7.Text & "', tel = '" & TextBox9.Text & "', code_contrat= '" & ComboBox6.SelectedValue & "',salaire= '" & TextBox11.Text & "',date_entree_groupe= '" & MaskedTextBox6.Text & "',date_entree_etablissement= '" & MaskedTextBox5.Text & "',date_sortie= '" & MaskedTextBox7.Text & "',mode_paiment= '" & TextBox15.Text & "', RIB= '" = MaskedTextBox8.Text & "',date_naiss= '" & MaskedTextBox1.Text & "',CNSS= '" & TextBox6.Text & "',CIMR= '" & TextBox13.Text & "',id_dep= '" & ComboBox2.SelectedValue & "',nationnalite= '" & TextBox4.Text & "',CIN= '" & TextBox5.Text & "', fonction= '" & TextBox16.Text & "',date_affiliation= '" & MaskedTextBox2.Text & "',situation_familial= '" & ComboBox1.Text & "',nbr_enfant= '" & TextBox12.Text & "',salaire_de_base= '" & TextBox11.Text & "',diplome= '" & ComboBox6.Text & "',Date_debut_contrat= '" & MaskedTextBox3.Text & "',Date_fin_contrat= '" & MaskedTextBox4.Text & "',lieu_naissance= '" & TextBox10.Text & "' where matricule= '" & ComboBox3.Text & "'", cnx)
    '        cn()
    '        cmd.ExecuteNonQuery()
    '        MsgBox("modification avec succes")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' Me.BindingContext(ds, "sal").EndCurrentEdit()
        Try
            cmd = New SqlCommand("update salarie set titre='" & ComboBox8.Text & "',nom='" & TextBox2.Text & "',prenom='" & TextBox3.Text & "',CIN='" & TextBox5.Text & "' , adresse='" & TextBox8.Text & "',ville='" & TextBox7.Text & "',tel='" & TextBox9.Text & "',code_contrat='" & ComboBox6.SelectedValue & "',date_entree_groupe='" & TextBox24.Text & "',date_entree_etablissement='" & TextBox22.Text & "',date_sortie='" & TextBox25.Text & "',mode_paiment='" & ComboBox3.Text & "' ,RIB='" & MaskedTextBox8.Text & "',date_naiss='" & TextBox19.Text & "',CNSS='" & TextBox6.Text & "',CIMR='" & TextBox13.Text & "',id_dep='" & ComboBox2.SelectedValue & "',nationnalite='" & TextBox5.Text & "',fonction='" & TextBox16.Text & "' ,date_affiliation='" & TextBox23.Text & "',situation_familial='" & ComboBox1.Text & "' ,nbr_enfant='" & TextBox12.Text & "',date_Debut_contrat='" & TextBox20.Text & "',date_fin_contrat='" & TextBox21.Text & "',observation='" & TextBox14.Text & "',diplome='" & ComboBox7.Text & "',nom_banque='" & TextBox1.Text & "',photo='" & TextBox18.Text & "' where matricule='" & TextBox17.Text & "' ", cnx)
            cn()
            If MsgBox("voulez-vous modifier ce salarie?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                cmd.ExecuteNonQuery()
                MsgBox("opération effectuer")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Dim p As Integer
        'p = Me.BindingContext(ds, "sal").Position
        'ds.Tables("sal").Rows(p).Delete()
        Try
            cmd = New SqlCommand("delete from salarie where matricule='" & TextBox17.Text & "' ", cnx)
            cn()
            If MsgBox("voulez-vous vraiment supprimer ce salarié ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                If MsgBox(" voulez vous supprimer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    cmd.ExecuteNonQuery()
                    MsgBox("operation reussite")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' refresh()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If MsgBox("enregistrer votre travail avant de fermer", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Me.Close()
        Else
            '    Dim up As New SqlCommandBuilder(da)
            '    da.Update(ds, "sal")
            '    MsgBox("vos information sont enregistrer avec succes")
            Me.Close()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Detail_salaire.Show()
        calcule_salaire.Show()
        ' MsgBox(salarie)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Célibataire" Then
            TextBox12.Enabled = False
        Else
            TextBox12.Enabled = True
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'ouvrir OpenFileDialog 
        Dim ofd As New OpenFileDialog()
        'ouvrir OpenFileDialog 
        Try


            'ofd.InitialDirectory = Application.StartupPath
            'ofd.Filter = "jpeg files (*.jpg)|*.jpg| BMP|*.bmp|JPG|*.jpg|GIF|*.gif|PDF|*.pdf|All files (*.*)|*.*"
            'ofd.FilterIndex = 1
            'ofd.RestoreDirectory = True
            ''affiche l'image sélectionnée
            'If ofd.ShowDialog() = DialogResult.OK Then
            '    Dim img As Image
            '    img = New Bitmap(ofd.FileName)
            '    PictureBox1.Image = CType(img, Image)
            '    PictureBox1.Tag = ofd.FileName
            'End If
            ''n est le nom du nouveau dossier creer
            'nom_pic = (TextBox17.Text & " " & TextBox2.Text & " " & " " & TextBox3.Text)
            'If File.Exists(nom_pic) Then
            '    TextBox18.Text = "../" & nom_pic & "/" & TextBox2.Text & ".JPG"
            'Else
            '    Directory.CreateDirectory("../" & nom_pic)
            '    'copier l image source au nouveau dossier creer
            '    File.Copy(ofd.FileName, "../" & nom_pic & "/" & TextBox2.Text & ".JPG")
            '    TextBox18.Text = "../" & nom_pic & "/" & TextBox2.Text & ".JPG"
            'End If
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
            'ofd.Dispose()


            '  PictureBox1.Image = Image.FromFile(ofd.FileName)
            '


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'da = New SqlDataAdapter("select ima from test2 where code=2", cnx)
        'cn()
        'da.Fill(ds, "tt")
        'TextBox18.Text = ds.Tables("tt").Rows(0)(0)
        'Dim a As New Bitmap(TextBox18.Text)
        'PictureBox1.Image = a
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        test.Show()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Not ComboBox3.Text = "VIREMENT" Then
            MaskedTextBox8.Enabled = False
        Else
            MaskedTextBox8.Enabled = True


        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "CAD" Then
            TextBox11.Enabled = True
        Else
            TextBox11.Enabled = False
        End If
       

        

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

    End Sub
End Class
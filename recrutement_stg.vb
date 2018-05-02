Imports System.Data.SqlClient

Public Class recrutement_stg
    Public pic As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'If Len(Mid(MaskedTextBox8.Text, 1)) < 35 Then
            ''  If MsgBox("veuillez remplire la zone du RIB", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then


            '  End If
            ' Else



            cmd = New SqlCommand("rec_stg", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@a", SqlDbType.Int).Value = b
            cmd.Parameters.Add("@b", SqlDbType.Int).Value = TextBox14.Text
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = TextBox2.Text
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = TextBox17.Text
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = TextBox8.Text
            cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = TextBox7.Text
            cmd.Parameters.Add("@h", SqlDbType.VarChar).Value = TextBox9.Text
            cmd.Parameters.Add("@i", SqlDbType.Int).Value = ComboBox6.SelectedValue '-------code contrat
            cmd.Parameters.Add("@j", SqlDbType.DateTime).Value = MaskedTextBox6.Text
            cmd.Parameters.Add("@k", SqlDbType.DateTime).Value = MaskedTextBox5.Text
            cmd.Parameters.Add("@l", SqlDbType.DateTime).Value = MaskedTextBox7.Text
            cmd.Parameters.Add("@m", SqlDbType.VarChar).Value = TextBox15.Text
            cmd.Parameters.Add("@n", SqlDbType.VarChar).Value = MaskedTextBox8.Text '-----------
            cmd.Parameters.Add("@o", SqlDbType.DateTime).Value = MaskedTextBox1.Text
            cmd.Parameters.Add("@p", SqlDbType.Int).Value = TextBox6.Text
            cmd.Parameters.Add("@q", SqlDbType.Int).Value = TextBox13.Text
            cmd.Parameters.Add("@r", SqlDbType.VarChar).Value = ComboBox2.SelectedValue '---id departement
            cmd.Parameters.Add("@s", SqlDbType.VarChar).Value = TextBox4.Text
            cmd.Parameters.Add("@t", SqlDbType.VarChar).Value = TextBox5.Text
            cmd.Parameters.Add("@u", SqlDbType.VarChar).Value = TextBox16.Text
            cmd.Parameters.Add("@v", SqlDbType.DateTime).Value = MaskedTextBox2.Text
            cmd.Parameters.Add("@w", SqlDbType.VarChar).Value = ComboBox1.Text ' situation familial
            cmd.Parameters.Add("@x", SqlDbType.Int).Value = TextBox12.Text
            cmd.Parameters.Add("@y", SqlDbType.DateTime).Value = MaskedTextBox3.Text
            cmd.Parameters.Add("@z", SqlDbType.DateTime).Value = MaskedTextBox4.Text
            cmd.Parameters.Add("@aa", SqlDbType.VarChar).Value = TextBox20.Text
            cmd.Parameters.Add("@bb", SqlDbType.VarChar).Value = TextBox19.Text
            cmd.Parameters.Add("@cc", SqlDbType.VarChar).Value = TextBox10.Text
            cmd.Parameters.Add("@dd", SqlDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.Add("@pic", SqlDbType.VarChar).Value = pic
            cn()
            cmd.ExecuteNonQuery()
            MsgBox("le stagiaire est recruté avec succés ")
            ' End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub recrutement_stg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If ds.Tables.Contains("infostg") Then
            ds.Tables("infostg").Clear()
        End If
        Dim req As String = "select * from stg where code_stg= '" & b & "'  "

        da = New SqlDataAdapter(req, cnx)



        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If
        da.Fill(ds, "infostg")

        cnx.Close()

        Dim dt As New DataTable

        dt = ds.Tables("infostg")


        TextBox14.Text = IdSalarie()
        TextBox17.Text = dt.Rows(0)(1)
        MaskedTextBox1.Text = dt.Rows(0)(9)

        TextBox2.Text = dt.Rows(0)(2)
        TextBox3.Text = dt.Rows(0)(3)
        TextBox4.Text = dt.Rows(0)(13)
        TextBox5.Text = dt.Rows(0)(14)
        TextBox7.Text = dt.Rows(0)(5)
        TextBox8.Text = dt.Rows(0)(4)
        TextBox9.Text = dt.Rows(0)(6)
        TextBox19.Text = dt.Rows(0)(18)
        TextBox10.Text = dt.Rows(0)(21)

        ComboBox1.Text = dt.Rows(0)(15)
        TextBox12.Text = dt.Rows(0)(16)
        Label32.Text = ds.Tables("infostg").Rows(0)(22)
        pic = Label32.Text
        '------------------------
        'Remplissage du combo de departement :

        Dim req1 As String = "select * from departement"
        da1 = New SqlDataAdapter(req1, cnx)
        'If ds.Tables.Contains("dep") Then
        '    ds.Tables("emp").Clear()
        'End If

        da1.Fill(ds1, "dep")

        ComboBox2.DisplayMember = "nom_departement"
        ComboBox2.ValueMember = "id_dep"
        ComboBox2.DataSource = ds1.Tables("dep")

        'Contrat
        If ds.Tables.Contains("co") Then
            ds.Tables("co").Rows.Clear()
        End If
        da = New SqlDataAdapter("select * from contrat", cnx)
        cn()
        da.Fill(ds, "co")
        ComboBox6.DisplayMember = ds.Tables("co").Columns(1).ToString
        ComboBox6.ValueMember = ds.Tables("co").Columns(0).ToString
        ComboBox6.DataSource = ds.Tables("co")

        Dim a As String = pic
        Dim s As New Bitmap(pic)
        PictureBox1.Image = s



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
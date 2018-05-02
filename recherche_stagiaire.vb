Imports System.Data.SqlClient

Public Class recherche_stagiaire

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        ComboBox1.Visible = True


        TextBox1.Visible = False

        ComboBox2.Visible = False

        ComboBox3.Visible = False

        DateTimePicker1.Visible = False

        DateTimePicker2.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Visible = True
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox2.Visible = True
        TextBox1.Visible = False
        ComboBox1.Visible = False

        ComboBox3.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        ComboBox3.Visible = True

        TextBox1.Visible = False
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        DateTimePicker1.Visible = True

        TextBox1.Visible = False
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        DateTimePicker2.Visible = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        DateTimePicker2.Visible = True
        TextBox1.Visible = False
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        DateTimePicker1.Visible = False
    End Sub

    Private Sub recherche_stagiaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RadioButton1.Checked = False
        'RadioButton2.Checked = False
        'RadioButton3.Checked = False
        'RadioButton4.Checked = False
        'RadioButton5.Checked = False
        'RadioButton6.Checked = False

        'DateTimePicker2.Visible = False
        'TextBox1.Visible = False
        'ComboBox1.Visible = False
        'ComboBox2.Visible = False
        'ComboBox3.Visible = False
        'DateTimePicker1.Visible = False

        If ds.Tables.Contains("matr") Then
            ds.Tables("matr").Rows.Clear()
        End If
        da = New SqlDataAdapter("select code_stg from stagiaire", cnx)
        da.Fill(ds, "matr")
        ComboBox1.DisplayMember = ds.Tables("matr").Columns(0).ToString
        ComboBox1.DataSource = ds.Tables("matr")
        '----------------------------- 
        If ds.Tables.Contains("cine") Then
            ds.Tables("cine").Rows.Clear()
        End If
        da = New SqlDataAdapter("select CIN from stagiaire", cnx)
        da.Fill(ds, "cine")
        ComboBox2.DisplayMember = ds.Tables("cine").Columns(0).ToString
        ComboBox2.DataSource = ds.Tables("cine")
        '-------------------------
        If ds.Tables.Contains("dpa") Then
            ds.Tables("dpa").Rows.Clear()
        End If
        da = New SqlDataAdapter("select nom_departement from departement", cnx)
        da.Fill(ds, "dpa")
        ComboBox3.Items.Add("TOUS")
        For i = 0 To ds.Tables("dpa").Rows.Count - 1
            ComboBox3.Items.Add(ds.Tables("dpa").Rows(i)(0))
        Next
        ComboBox3.DisplayMember = ds.Tables("dpa").Columns(0).ToString
        ' ComboBox3.DataSource = ds.Tables("dpa")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton6.Checked Then

            da = New SqlDataAdapter("select stagiaire.code_stg,stagiaire.titre,stagiaire.nom,stagiaire.prenom,stagiaire.CIN,nom_departement from stagiaire inner join departement on departement.id_dep=stagiaire.id_dep where stagiaire.code_stg=  '" & ComboBox1.Text & "' ", cnx)
            cn()
            If ds.Tables.Contains("st") Then
                ds.Tables("st").Rows.Clear()

            End If
            DataGridView1.Rows.Clear()
            da.Fill(ds, "st")
            For i = 0 To ds.Tables("st").Rows.Count - 1
                DataGridView1.Rows.Add(ds.Tables("st").Rows(i)(0), ds.Tables("st").Rows(i)(1), ds.Tables("st").Rows(i)(2), ds.Tables("st").Rows(i)(3), ds.Tables("st").Rows(i)(4), ds.Tables("st").Rows(i)(5))
                ' a = DataGridView1.Rows(i).Cells(0).Value
            Next


            '  DataGridView1.DataSource = ds.Tables("tt")
        ElseIf RadioButton1.Checked Then

            da = New SqlDataAdapter("select stagiaire.code_stg,stagiaire.titre,stagiaire.nom,stagiaire.prenom,stagiaire.CIN,nom_departement from stagiaire inner join departement on departement.id_dep=stagiaire.id_dep where stagiaire.nom=  '" & TextBox1.Text & "' ", cnx)
            cn()
            If ds.Tables.Contains("sta") Then
                ds.Tables("sta").Rows.Clear()

            End If
            DataGridView1.Rows.Clear()

            da.Fill(ds, "sta")

            For i = 0 To ds.Tables("sta").Rows.Count - 1
                DataGridView1.Rows.Add(ds.Tables("sta").Rows(i)(0), ds.Tables("sta").Rows(i)(1), ds.Tables("sta").Rows(i)(2), ds.Tables("sta").Rows(i)(3), ds.Tables("sta").Rows(i)(4), ds.Tables("sta").Rows(i)(5))

                '   a = DataGridView1.Rows(i).Cells(0).Value
            Next

        ElseIf RadioButton2.Checked Then
            da = New SqlDataAdapter("select stagiaire.code_stg,stagiaire.titre,stagiaire.nom,stagiaire.prenom,stagiaire.CIN,nom_departement from stagiaire inner join departement on departement.id_dep=stagiaire.id_dep where stagiaire.CIN=  '" & ComboBox2.Text & "' ", cnx)

            cn()
            If ds.Tables.Contains("stb") Then
                ds.Tables("stb").Rows.Clear()

            End If
            DataGridView1.Rows.Clear()

            da.Fill(ds, "stb")
            For i = 0 To ds.Tables("stb").Rows.Count - 1
                DataGridView1.Rows.Add(ds.Tables("stb").Rows(i)(0), ds.Tables("stb").Rows(i)(1), ds.Tables("stb").Rows(i)(2), ds.Tables("stb").Rows(i)(3), ds.Tables("stb").Rows(i)(4), ds.Tables("stb").Rows(i)(5))
                '  a = DataGridView1.Rows(i).Cells(0).Value
            Next

        ElseIf RadioButton3.Checked Then
            If Not ComboBox3.Text = "TOUS" Then
                da = New SqlDataAdapter("select stagiaire.code_stg,stagiaire.titre,stagiaire.nom,stagiaire.prenom,stagiaire.CIN,nom_departement from stagiaire inner join departement on departement.id_dep=stagiaire.id_dep where departement.nom_departement=  '" & ComboBox3.Text & "' ", cnx)

                cn()
                If ds.Tables.Contains("stc") Then
                    ds.Tables("stc").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "stc")
                For i = 0 To ds.Tables("stc").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("stc").Rows(i)(0), ds.Tables("stc").Rows(i)(1), ds.Tables("stc").Rows(i)(2), ds.Tables("stc").Rows(i)(3), ds.Tables("stc").Rows(i)(4), ds.Tables("stc").Rows(i)(5))
                    'a = DataGridView1.Rows(i).Cells(0).Value
                Next
            Else
                If ds.Tables.Contains("rt") Then
                    ds.Tables("rt").Rows.Clear()
                End If
                DataGridView1.Rows.Clear()
                da = New SqlDataAdapter("select code_stg,titre,nom,prenom,CIN,nom_departement from stg ", cnx)
                da.Fill(ds, "rt")
                '  DataGridView1.DataSource = ds.Tables("rt")
                For i = 0 To ds.Tables("rt").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("rt").Rows(i)(0), ds.Tables("rt").Rows(i)(1), ds.Tables("rt").Rows(i)(2), ds.Tables("rt").Rows(i)(3), ds.Tables("rt").Rows(i)(4), ds.Tables("rt").Rows(i)(5))
                    'a = DataGridView1.Rows(i).Cells(0).Value
                Next
            End If


        ElseIf RadioButton4.Checked Then
            da = New SqlDataAdapter("select stagiaire.code_stg,stagiaire.titre,stagiaire.nom,stagiaire.prenom,stagiaire.CIN,nom_departement from stagiaire inner join departement on departement.id_dep=stagiaire.id_dep where stagiaire.date_entree_etablissement=  '" & DateTimePicker1.Value & "' ", cnx)

            cn()
            If ds.Tables.Contains("std") Then
                ds.Tables("std").Rows.Clear()

            End If
            DataGridView1.Rows.Clear()

            da.Fill(ds, "std")
            For i = 0 To ds.Tables("std").Rows.Count - 1
                DataGridView1.Rows.Add(ds.Tables("std").Rows(i)(0), ds.Tables("std").Rows(i)(1), ds.Tables("std").Rows(i)(2), ds.Tables("std").Rows(i)(3), ds.Tables("std").Rows(i)(4), ds.Tables("std").Rows(i)(5))
                ' a = DataGridView1.Rows(i).Cells(0).Value
            Next

        ElseIf RadioButton5.Checked Then
            da = New SqlDataAdapter("select stagiaire.code_stg,stagiaire.titre,stagiaire.nom,stagiaire.prenom,stagiaire.CIN,nom_departement from stagiaire inner join departement on departement.id_dep=stagiaire.id_dep where stagiaire.date_sortie=  '" & DateTimePicker2.Value & "' ", cnx)

            cn()
            If ds.Tables.Contains("stbb") Then
                ds.Tables("stbb").Rows.Clear()

            End If
            DataGridView1.Rows.Clear()

            da.Fill(ds, "stbb")
            For i = 0 To ds.Tables("stbb").Rows.Count - 1
                DataGridView1.Rows.Add(ds.Tables("stbb").Rows(i)(0), ds.Tables("stbb").Rows(i)(1), ds.Tables("stbb").Rows(i)(2), ds.Tables("stbb").Rows(i)(3), ds.Tables("stbb").Rows(i)(4), ds.Tables("stbb").Rows(i)(5))
                'a = DataGridView1.Rows(i).Cells(0).Value
            Next
        Else
            '' da = New SqlDataAdapter("select t_employer.*,dt_debut,dt_fin,duree,type_conge from t_employer inner join t_conge on t_employer.mat_emp=t_conge.mat_emp where t_conge.dt_debut>= '" & DateTimePicker1.Value & "' and t_conge.dt_fin<= '" & DateTimePicker2.Value & "'  ", cnx)

            'If ds.Tables.Contains("dt") Then
            '    ds.Tables("dt").Rows.Clear()

            'End If
            'da.Fill(ds, "dt")
            'DataGridView1.DataSource = ds.Tables("dt")








        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
  b = DataGridView1.CurrentRow.Cells(0).Value
        If b <> Nothing Then

            If e.ColumnIndex = 7 Then
                detail_stg.Show()

            ElseIf e.ColumnIndex = 6 Then

                recrutement_stg.Show()

            End If

        Else
            MsgBox("aucun element")
        End If









        
    End Sub
End Class
Imports System.Data.SqlClient

Public Class recherche_candidat
    Public cod As Integer
    Private Sub recherche_candidat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ds.Tables.Contains("matt") Then
            ds.Tables("matt").Rows.Clear()
        End If
        da = New SqlDataAdapter("select code_stg from candidature", cnx)
        da.Fill(ds, "matt")
        ComboBox1.DisplayMember = ds.Tables("matt").Columns(0).ToString
        ComboBox1.DataSource = ds.Tables("matt")
        '----------------------------- 
        If ds.Tables.Contains("cinn") Then
            ds.Tables("cinn").Rows.Clear()
        End If
        da = New SqlDataAdapter("select CIN from candidature", cnx)
        da.Fill(ds, "cinn")
        ComboBox2.DisplayMember = ds.Tables("cinn").Columns(0).ToString
        ComboBox2.DataSource = ds.Tables("cinn")
        '-------------------------
        If ds.Tables.Contains("dpp") Then
            ds.Tables("dpp").Rows.Clear()
        End If
        da = New SqlDataAdapter("select nom_departement from departement", cnx)
        da.Fill(ds, "dpp")
        ComboBox3.Items.Add("TOUS")
        For i = 0 To ds.Tables("dpp").Rows.Count - 1
            ComboBox3.Items.Add(ds.Tables("dpp").Rows(i)(0))
        Next
        ComboBox3.DisplayMember = ds.Tables("dpp").Columns(0).ToString
        ' ComboBox3.DataSource = ds.Tables("dpp")
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComboBox1.Visible = True


        TextBox1.Visible = False

        ComboBox2.Visible = False

        ComboBox3.Visible = False

        DateTimePicker1.Visible = False

        DateTimePicker2.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try


            If RadioButton6.Checked Then

                da = New SqlDataAdapter("select candidature.code_stg,candidature.titre,candidature.nom,candidature.prenom,candidature.CIN,nom_departement from candidature inner join departement on departement.id_dep=candidature.id_dep where candidature.code_stg=  '" & ComboBox1.Text & "' ", cnx)
                cn()
                If ds.Tables.Contains("can") Then
                    ds.Tables("can").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()
                da.Fill(ds, "can")
                cod = ds.Tables("can").Rows(0)(0)
                For i = 0 To ds.Tables("can").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("can").Rows(i)(0), ds.Tables("can").Rows(i)(1), ds.Tables("can").Rows(i)(2), ds.Tables("can").Rows(i)(3), ds.Tables("can").Rows(i)(4), ds.Tables("can").Rows(i)(5))
                    ' a = DataGridView1.Rows(i).Cells(0).Value
                Next


                '  DataGridView1.DataSource = ds.Tables("tt")
            ElseIf RadioButton1.Checked Then

                da = New SqlDataAdapter("select candidature.code_stg,candidature.titre,candidature.nom,candidature.prenom,candidature.CIN,nom_departement from candidature inner join departement on departement.id_dep=candidature.id_dep where candidature.nom=  '" & TextBox1.Text & "' ", cnx)
                cn()
                If ds.Tables.Contains("cta") Then
                    ds.Tables("cta").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "cta")
                cod = ds.Tables("cta").Rows(0)(0)

                For i = 0 To ds.Tables("cta").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("cta").Rows(i)(0), ds.Tables("cta").Rows(i)(1), ds.Tables("cta").Rows(i)(2), ds.Tables("cta").Rows(i)(3), ds.Tables("cta").Rows(i)(4), ds.Tables("cta").Rows(i)(5))

                    '   a = DataGridView1.Rows(i).Cells(0).Value
                Next

            ElseIf RadioButton2.Checked Then
                da = New SqlDataAdapter("select candidature.code_stg,candidature.titre,candidature.nom,candidature.prenom,candidature.CIN,nom_departement from candidature inner join departement on departement.id_dep=candidature.id_dep where candidature.CIN=  '" & ComboBox2.Text & "' ", cnx)

                cn()
                If ds.Tables.Contains("stbb") Then
                    ds.Tables("stbb").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "stbb")
                cod = ds.Tables("stbb").Rows(0)(0)

                For i = 0 To ds.Tables("stbb").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("stbb").Rows(i)(0), ds.Tables("stbb").Rows(i)(1), ds.Tables("stbb").Rows(i)(2), ds.Tables("stbb").Rows(i)(3), ds.Tables("stbb").Rows(i)(4), ds.Tables("stbb").Rows(i)(5))
                    '  a = DataGridView1.Rows(i).Cells(0).Value
                Next

            ElseIf RadioButton3.Checked Then
                If Not ComboBox3.Text = "TOUS" Then
                    da = New SqlDataAdapter("select candidature.code_stg,candidature.titre,candidature.nom,candidature.prenom,candidature.CIN,nom_departement from candidature inner join departement on departement.id_dep=candidature.id_dep where departement.nom_departement=  '" & ComboBox3.Text & "' ", cnx)

                    cn()
                    If ds.Tables.Contains("sttc") Then
                        ds.Tables("sttc").Rows.Clear()

                    End If
                    DataGridView1.Rows.Clear()

                    da.Fill(ds, "sttc")
                    cod = ds.Tables("sttc").Rows(0)(0)

                    For i = 0 To ds.Tables("sttc").Rows.Count - 1
                        DataGridView1.Rows.Add(ds.Tables("sttc").Rows(i)(0), ds.Tables("sttc").Rows(i)(1), ds.Tables("sttc").Rows(i)(2), ds.Tables("sttc").Rows(i)(3), ds.Tables("sttc").Rows(i)(4), ds.Tables("sttc").Rows(i)(5))
                        'a = DataGridView1.Rows(i).Cells(0).Value
                    Next
                Else
                    If ds.Tables.Contains("rt") Then
                        ds.Tables("rt").Rows.Clear()
                    End If
                    DataGridView1.Rows.Clear()
                    da = New SqlDataAdapter("select code_stg,titre,nom,prenom,CIN,nom_departement from candid ", cnx)
                    da.Fill(ds, "rt")
                    '  DataGridView1.DataSource = ds.Tables("rt")
                    For i = 0 To ds.Tables("rt").Rows.Count - 1
                        DataGridView1.Rows.Add(ds.Tables("rt").Rows(i)(0), ds.Tables("rt").Rows(i)(1), ds.Tables("rt").Rows(i)(2), ds.Tables("rt").Rows(i)(3), ds.Tables("rt").Rows(i)(4), ds.Tables("rt").Rows(i)(5))
                        'a = DataGridView1.Rows(i).Cells(0).Value
                    Next
                End If
                

            ElseIf RadioButton4.Checked Then
                da = New SqlDataAdapter("select candidature.code_stg,candidature.titre,candidature.nom,candidature.prenom,candidature.CIN,nom_departement from candidature inner join departement on departement.id_dep=candidature.id_dep where candidature.date_entree_etablissement=  '" & DateTimePicker1.Value & "' ", cnx)

                cn()
                If ds.Tables.Contains("sttd") Then
                    ds.Tables("sttd").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "sttd")
                cod = ds.Tables("sttd").Rows(0)(0)

                For i = 0 To ds.Tables("sttd").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("sttd").Rows(i)(0), ds.Tables("sttd").Rows(i)(1), ds.Tables("sttd").Rows(i)(2), ds.Tables("sttd").Rows(i)(3), ds.Tables("sttd").Rows(i)(4), ds.Tables("sttd").Rows(i)(5))
                    ' a = DataGridView1.Rows(i).Cells(0).Value
                Next

            ElseIf RadioButton5.Checked Then
                da = New SqlDataAdapter("select candidature.code_stg,candidature.titre,candidature.nom,candidature.prenom,candidature.CIN,nom_departement from candidature inner join departement on departement.id_dep=candidature.id_dep where candidature.date_sortie=  '" & DateTimePicker2.Value & "' ", cnx)

                cn()
                If ds.Tables.Contains("sttbb") Then
                    ds.Tables("sttbb").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "sttbb")
                cod = ds.Tables("sttbb").Rows(0)(0)

                For i = 0 To ds.Tables("sttbb").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("sttbb").Rows(i)(0), ds.Tables("sttbb").Rows(i)(1), ds.Tables("sttbb").Rows(i)(2), ds.Tables("sttbb").Rows(i)(3), ds.Tables("sttbb").Rows(i)(4), ds.Tables("sttbb").Rows(i)(5))
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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        c = DataGridView1.CurrentRow.Cells(0).Value
        If c <> Nothing Then

            If e.ColumnIndex = 7 Then
                detail_candidat.Show()

            ElseIf e.ColumnIndex = 6 Then

                RecrutementCandidat.Show()

            End If
        Else
            MsgBox("aucun element")

        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Visible = True
        ComboBox2.Visible = False
        ComboBox1.Visible = False
        ComboBox3.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False

    End Sub

    Private Sub RadioButton6_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        ComboBox1.Visible = True
        TextBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False

        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
    End Sub
End Class
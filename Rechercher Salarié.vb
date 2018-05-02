Imports System.Data.SqlClient

Public Class Rechercher_Salarié
    Public db As New SqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Résultat_de_la_recherche.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

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

    Private Sub Rechercher_Salarié_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ds.Tables.Contains("mat") Then
            ds.Tables("mat").Rows.Clear()
        End If
        da = New SqlDataAdapter("select matricule from salarie", cnx)
        da.Fill(ds, "mat")
        ComboBox1.DisplayMember = ds.Tables("mat").Columns(0).ToString
        ComboBox1.DataSource = ds.Tables("mat")
        '----------------------------- 
        If ds.Tables.Contains("cin") Then
            ds.Tables("cin").Rows.Clear()
        End If
        da = New SqlDataAdapter("select CIN from salarie", cnx)
        da.Fill(ds, "cin")
        ComboBox2.DisplayMember = ds.Tables("cin").Columns(0).ToString
        ComboBox2.DataSource = ds.Tables("cin")
        '-------------------------
        If ds.Tables.Contains("depa") Then
            ds.Tables("depa").Rows.Clear()
        End If
        da = New SqlDataAdapter("select nom_departement from departement", cnx)
        da.Fill(ds, "depa")
        ComboBox3.Items.Add("TOUS")
        For i = 0 To ds.Tables("depa").Rows.Count - 1
            ComboBox3.Items.Add(ds.Tables("depa").Rows(i)(0))
        Next
        ComboBox3.DisplayMember = ds.Tables("depa").Columns(0).ToString
        ' ComboBox3.DataSource = ds.Tables("depa")

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub
   

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

       
            If RadioButton6.Checked Then

                da = New SqlDataAdapter("select salarie.matricule,salarie.titre,salarie.nom,salarie.prenom,salarie.CIN,nom_departement from salarie inner join departement on departement.id_dep=salarie.id_dep where salarie.matricule=  '" & ComboBox1.Text & "' ", cnx)

                cn()
                If ds.Tables.Contains("tt") Then
                    ds.Tables("tt").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()
                da.Fill(ds, "tt")



                For i = 0 To ds.Tables("tt").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("tt").Rows(i)(0), ds.Tables("tt").Rows(i)(1), ds.Tables("tt").Rows(i)(2), ds.Tables("tt").Rows(i)(3), ds.Tables("tt").Rows(i)(4), ds.Tables("tt").Rows(i)(5))
                    ' a = DataGridView1.Rows(i).Cells(0).Value
                Next



                '  DataGridView1.DataSource = ds.Tables("tt")
            ElseIf RadioButton1.Checked Then

                da = New SqlDataAdapter(" select salarie.matricule,salarie.titre,salarie.nom,salarie.prenom,salarie.CIN,nom_departement from salarie inner join departement on departement.id_dep=salarie.id_dep where salarie.nom=  '" & TextBox1.Text & "' ", cnx)
                cn()
                If ds.Tables.Contains("ta") Then
                    ds.Tables("ta").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "ta")

                For i = 0 To ds.Tables("ta").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("ta").Rows(i)(0), ds.Tables("ta").Rows(i)(1), ds.Tables("ta").Rows(i)(2), ds.Tables("ta").Rows(i)(3), ds.Tables("ta").Rows(i)(4), ds.Tables("ta").Rows(i)(5))

                    '   a = DataGridView1.Rows(i).Cells(0).Value
                Next

            ElseIf RadioButton2.Checked Then
                da = New SqlDataAdapter("select salarie.matricule,salarie.titre,salarie.nom,salarie.prenom,salarie.CIN,nom_departement from salarie inner join departement on departement.id_dep=salarie.id_dep where salarie.CIN=  '" & ComboBox2.Text & "' ", cnx)

                cn()
                If ds.Tables.Contains("tb") Then
                    ds.Tables("tb").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "tb")
                For i = 0 To ds.Tables("tb").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("tb").Rows(i)(0), ds.Tables("tb").Rows(i)(1), ds.Tables("tb").Rows(i)(2), ds.Tables("tb").Rows(i)(3), ds.Tables("tb").Rows(i)(4), ds.Tables("tb").Rows(i)(5))
                    '  a = DataGridView1.Rows(i).Cells(0).Value
                Next

            ElseIf RadioButton3.Checked Then
                If Not ComboBox3.Text = "TOUS" Then
                    da = New SqlDataAdapter("select salarie.matricule,salarie.titre,salarie.nom,salarie.prenom,salarie.CIN,nom_departement from salarie inner join departement on departement.id_dep=salarie.id_dep where departement.nom_departement=  '" & ComboBox3.Text & "' ", cnx)

                    cn()
                    If ds.Tables.Contains("tc") Then
                        ds.Tables("tc").Rows.Clear()

                    End If
                    DataGridView1.Rows.Clear()

                    da.Fill(ds, "tc")
                    For i = 0 To ds.Tables("tc").Rows.Count - 1
                        DataGridView1.Rows.Add(ds.Tables("tc").Rows(i)(0), ds.Tables("tc").Rows(i)(1), ds.Tables("tc").Rows(i)(2), ds.Tables("tc").Rows(i)(3), ds.Tables("tc").Rows(i)(4), ds.Tables("tc").Rows(i)(5))
                        'a = DataGridView1.Rows(i).Cells(0).Value
                    Next
                    cmd = New SqlCommand("select count(*),sum(salaire_brut) from sal where nom_departement='" & ComboBox3.Text & "' ", cnx)
                    cn()
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader
                    While dr.Read
                        If IsDBNull(dr(0)) Then
                            ' MsgBox("aucun element")
                        Else
                            Label2.Text = dr(0)
                        End If

                        If IsDBNull(dr(1)) Then
                            ' MsgBox("aucun element")
                        Else
                            Label4.Text = dr(1)
                        End If
                    End While
                    dr.Close()
                Else
                    If ds.Tables.Contains("rt") Then
                        ds.Tables("rt").Rows.Clear()
                    End If
                    da = New SqlDataAdapter("select matricule,titre,nom,prenom,CIN,nom_departement from sal ", cnx)
                    da.Fill(ds, "rt")
                    DataGridView1.Rows.Clear()
                    '  DataGridView1.DataSource = ds.Tables("rt")
                    For i = 0 To ds.Tables("rt").Rows.Count - 1
                        DataGridView1.Rows.Add(ds.Tables("rt").Rows(i)(0), ds.Tables("rt").Rows(i)(1), ds.Tables("rt").Rows(i)(2), ds.Tables("rt").Rows(i)(3), ds.Tables("rt").Rows(i)(4), ds.Tables("rt").Rows(i)(5))
                        'a = DataGridView1.Rows(i).Cells(0).Value
                    Next

                    cmd = New SqlCommand("select count(*),sum(salaire_brut) from sal ", cnx)
                    cn()
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader
                    While dr.Read
                        If IsDBNull(dr(0)) Then
                            MsgBox("aucun element")
                        Else
                            Label2.Text = dr(0)
                        End If

                        If IsDBNull(dr(1)) Then
                            MsgBox("aucun element")
                        Else
                            Label4.Text = dr(1)
                        End If
                    End While
                    dr.Close()
                End If
                
            ElseIf RadioButton4.Checked Then
                da = New SqlDataAdapter("select salarie.matricule,salarie.titre,salarie.nom,salarie.prenom,salarie.CIN,nom_departement from salarie inner join departement on departement.id_dep=salarie.id_dep where salarie.date_debut_contrat=  '" & DateTimePicker1.Value & "' ", cnx)

                cn()
                If ds.Tables.Contains("td") Then
                    ds.Tables("td").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "td")
                For i = 0 To ds.Tables("td").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("td").Rows(i)(0), ds.Tables("td").Rows(i)(1), ds.Tables("td").Rows(i)(2), ds.Tables("td").Rows(i)(3), ds.Tables("td").Rows(i)(4), ds.Tables("td").Rows(i)(5))
                    ' a = DataGridView1.Rows(i).Cells(0).Value
                Next

            ElseIf RadioButton5.Checked Then
                da = New SqlDataAdapter("select salarie.matricule,salarie.titre,salarie.nom,salarie.prenom,salarie.CIN,nom_departement from salarie inner join departement on departement.id_dep=salarie.id_dep where salarie.date_fin_contrat=  '" & DateTimePicker2.Value & "' ", cnx)

                cn()
                If ds.Tables.Contains("tbb") Then
                    ds.Tables("tbb").Rows.Clear()

                End If
                DataGridView1.Rows.Clear()

                da.Fill(ds, "tbb")
                For i = 0 To ds.Tables("tbb").Rows.Count - 1
                    DataGridView1.Rows.Add(ds.Tables("tbb").Rows(i)(0), ds.Tables("tbb").Rows(i)(1), ds.Tables("tbb").Rows(i)(2), ds.Tables("tbb").Rows(i)(3), ds.Tables("tbb").Rows(i)(4), ds.Tables("tbb").Rows(i)(5))
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        '
        ' For i = 0 To DataGridView1.Rows.Count - 1
        a = DataGridView1.CurrentRow.Cells(0).Value

        ' Next
        If a <> Nothing Then
            If e.ColumnIndex = 6 Then
                detail_salarie.Show()
                '  MsgBox(a)
            End If
        Else
            MsgBox("aucun element n'a selectionner", MsgBoxStyle.Information)
        End If

    End Sub
End Class
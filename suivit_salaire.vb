Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class suivit_salaire

    Private Sub suivit_salaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da = New SqlDataAdapter("select * from departement", cnx)
        da.Fill(ds, "rr")
        ComboBox3.Items.Add("TOUS")
        For i = 0 To ds.Tables("rr").Rows.Count - 1
            ComboBox3.Items.Add(ds.Tables("rr").Rows(i)(1))
        Next
        ComboBox3.DisplayMember = ds.Tables("rr").Columns(1).ToString
        ComboBox3.ValueMember = ds.Tables("rr").Columns(0).ToString

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        'If Not ComboBox3.Text = "TOUS" Then
        '    da = New SqlDataAdapter("select * from sal where nom_departement='" & ComboBox3.Text & "' ", cnx)
        '    If ds.Tables.Contains("rtt") Then
        '        ds.Tables("rtt").Rows.Clear()
        '    End If
        '    da.Fill(ds, "rtt")
        '    DataGridView1.DataSource = ds.Tables("rtt")
        'Else
        '    If ds.Tables.Contains("rt") Then
        '        ds.Tables("rt").Rows.Clear()
        '    End If
        '    da = New SqlDataAdapter("select * from sal ", cnx)
        '    da.Fill(ds, "rt")
        '    DataGridView1.DataSource = ds.Tables("rt")
        'End If
    End Sub
    
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, f, g, h, ii, j, k, l, m, n, o, p, q As New DataGridViewTextBoxColumn
        
        
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        If CheckBox16.Checked Then

            a.Width = 150
            a.Name = CheckBox16.Text
            DataGridView1.Columns.Add(a)
            DataGridView1.Rows.Clear()
          
        End If
        If CheckBox1.Checked Then

            b.Width = 150
            b.Name = CheckBox1.Text
            DataGridView1.Columns.Add(b)
            DataGridView1.Rows.Clear()
            
        End If
        If CheckBox2.Checked Then

            c.Width = 150
            c.Name = CheckBox2.Text
            DataGridView1.Columns.Add(c)
        End If

        If CheckBox3.Checked Then
            d.Width = 150
            d.Name = CheckBox3.Text
            DataGridView1.Columns.Add(d)
        End If
        If CheckBox4.Checked Then
            f.Width = 150
            f.Name = CheckBox4.Text
            DataGridView1.Columns.Add(f)
        End If
        If CheckBox5.Checked Then
            g.Width = 150
            g.Name = CheckBox5.Text
            DataGridView1.Columns.Add(g)
        End If

        If CheckBox6.Checked Then
            h.Width = 150
            h.Name = CheckBox6.Text
            DataGridView1.Columns.Add(h)
        End If

        If CheckBox7.Checked Then
            ii.Width = 150
            ii.Name = CheckBox7.Text
            DataGridView1.Columns.Add(ii)
        End If
        If CheckBox8.Checked Then
            j.Width = 150
            j.Name = CheckBox8.Text
            DataGridView1.Columns.Add(j)
        End If
        If CheckBox9.Checked Then
            k.Width = 150
            k.Name = CheckBox9.Text
            DataGridView1.Columns.Add(k)
        End If
        If CheckBox10.Checked Then
            l.Width = 150
            l.Name = CheckBox10.Text
            DataGridView1.Columns.Add(l)
        End If
        If CheckBox11.Checked Then
            m.Width = 150
            m.Name = CheckBox11.Text
            DataGridView1.Columns.Add(m)
        End If
        If CheckBox12.Checked Then
            n.Width = 150
            n.Name = CheckBox12.Text
            DataGridView1.Columns.Add(n)
        End If
        If CheckBox13.Checked Then
            o.Width = 150
            o.Name = CheckBox13.Text
            DataGridView1.Columns.Add(o)
        End If

        If CheckBox14.Checked Then
            p.Width = 150
            p.Name = CheckBox14.Text
            DataGridView1.Columns.Add(p)
        End If
        If CheckBox15.Checked Then
            q.Width = 150
            q.Name = CheckBox15.Text
            DataGridView1.Columns.Add(q)
        End If

        If Not ComboBox3.Text = "TOUS" Then


            If ds.Tables.Contains("suivit") Then
                ds.Tables("suivit").Rows.Clear()
            End If

            da = New SqlDataAdapter("select * from sal where nom_departement='" & ComboBox3.Text & "'", cnx)
            cn()
            da.Fill(ds, "suivit")
            For i = 0 To ds.Tables("suivit").Rows.Count - 1
                If CheckBox1.Checked = True Or CheckBox2.Checked = True Or CheckBox3.Checked = True Or CheckBox4.Checked = True Or CheckBox5.Checked = True Or CheckBox6.Checked = True Or CheckBox7.Checked = True Or CheckBox8.Checked = True Or CheckBox9.Checked = True Or CheckBox10.Checked = True Or CheckBox11.Checked = True Or CheckBox12.Checked = True Or CheckBox13.Checked = True Or CheckBox14.Checked = True Or CheckBox16.Checked = True Then
                    DataGridView1.Rows.Add(ds.Tables("suivit").Rows(i)(2) & "  " & ds.Tables("suivit").Rows(i)(3), ds.Tables("suivit").Rows(i)(24), ds.Tables("suivit").Rows(i)(34), ds.Tables("suivit").Rows(i)(35), ds.Tables("suivit").Rows(i)(36), ds.Tables("suivit").Rows(i)(37), ds.Tables("suivit").Rows(i)(32), ds.Tables("suivit").Rows(i)(25), ds.Tables("suivit").Rows(i)(26), ds.Tables("suivit").Rows(i)(27), ds.Tables("suivit").Rows(i)(28), ds.Tables("suivit").Rows(i)(29), ds.Tables("suivit").Rows(i)(30), ds.Tables("suivit").Rows(i)(31))
                End If

            Next
        Else
            da.Dispose()
            If ds.Tables.Contains("suivitt") Then
                ds.Tables("suivitt").Rows.Clear()
            End If

            da = New SqlDataAdapter("select * from sal ", cnx)
            cn()
            da.Fill(ds, "suivitt")
            For i = 0 To ds.Tables("suivitt").Rows.Count - 1
                If CheckBox1.Checked = True Or CheckBox2.Checked = True Or CheckBox3.Checked = True Or CheckBox4.Checked = True Or CheckBox5.Checked = True Or CheckBox6.Checked = True Or CheckBox7.Checked = True Or CheckBox8.Checked = True Or CheckBox9.Checked = True Or CheckBox10.Checked = True Or CheckBox11.Checked = True Or CheckBox12.Checked = True Or CheckBox13.Checked = True Or CheckBox14.Checked = True Or CheckBox16.Checked = True Then
                    DataGridView1.Rows.Add(ds.Tables("suivitt").Rows(i)(2) & "  " & ds.Tables("suivitt").Rows(i)(3), ds.Tables("suivitt").Rows(i)(24), ds.Tables("suivitt").Rows(i)(34), ds.Tables("suivitt").Rows(i)(35), ds.Tables("suivitt").Rows(i)(36), ds.Tables("suivitt").Rows(i)(37), ds.Tables("suivitt").Rows(i)(32), ds.Tables("suivitt").Rows(i)(25), ds.Tables("suivitt").Rows(i)(26), ds.Tables("suivitt").Rows(i)(27), ds.Tables("suivitt").Rows(i)(28), ds.Tables("suivitt").Rows(i)(29), ds.Tables("suivitt").Rows(i)(30), ds.Tables("suivitt").Rows(i)(31))
                End If
            Next
        End If





    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c, ligne As Integer
        Dim xl As New Excel.Application
        xl.Visible = True
        xl.Workbooks.Add()
        Try
            For ligne = 0 To DataGridView1.RowCount - 1
                For c = 0 To DataGridView1.ColumnCount - 1
                    xl.Cells(1, c + 1) = DataGridView1.Columns(c).HeaderText
                    xl.Cells(ligne + 2, c + 1) = DataGridView1.Rows(ligne).Cells(c).Value

                Next c
            Next ligne
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
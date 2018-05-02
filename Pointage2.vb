Imports System.Data.SqlClient

Public Class Pointage2

    Private Sub Pointage2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For i = 1989 To Now.Year
            ComboBox2.Items.Add(i)
        Next

        ComboBox2.SelectedItem = Now.Year

        For i = 1 To 12
            ComboBox1.Items.Add(MonthName(i))
        Next
        ComboBox1.SelectedIndex = Now.Month - 1





        'Remplissage du combo de departement :

        Dim req As String = "select * from departement"
        da1 = New SqlDataAdapter(req, cnx)
        'If ds.Tables.Contains("dep") Then
        '    ds.Tables("emp").Clear()
        'End If

        da1.Fill(ds1, "dep")

        ComboBox3.DisplayMember = "nom_departement"
        ComboBox3.ValueMember = "id_dep"
        ComboBox3.DataSource = ds1.Tables("dep")
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        test()
    End Sub
    Public Sub test()
        DataGridView1.Rows.Clear()

        If ComboBox2.SelectedIndex > -1 And ComboBox1.SelectedIndex > -1 Then
            If (ComboBox1.SelectedIndex > Now.Month - 1 And ComboBox2.SelectedItem = Now.Year) Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True

            End If

            ds.Clear()

            DataGridView1.Columns.Clear()



            Dim c As New DataGridViewTextBoxColumn
            c.Width = 150
            c.Name = "Nom"
            DataGridView1.Columns.Add(c)

            Dim k As New DataGridViewTextBoxColumn

            k.Name = "id"
            k.Visible = False
            DataGridView1.Columns.Add(k)
            For i = 1 To Date.DaysInMonth(ComboBox2.SelectedItem, ComboBox1.SelectedIndex + 1)
                Dim a As New DataGridViewComboBoxColumn

                a.Items.Add("P")
                a.Items.Add("CM")
                a.Items.Add("CA")
                a.Items.Add("CR")
                a.Items.Add("CS")
                a.Items.Add("AM")
                a.Items.Add("CF")
                a.Items.Add("CP")
                a.Name = i
                a.Width = 50
                If (i > Now.Date.Day And ComboBox1.SelectedIndex >= Now.Month - 1 And ComboBox2.SelectedItem = Now.Year) Or (ComboBox1.SelectedIndex > Now.Month - 1 And ComboBox2.SelectedItem = Now.Year) Then
                    a.ReadOnly = True
                End If
                If (i = Now.Date.Day + 1 And ComboBox1.SelectedIndex = Now.Month - 1 And ComboBox2.SelectedItem = Now.Year) Then
                    DataGridView1.Columns(i).DefaultCellStyle.BackColor = Color.Red

                End If
                DataGridView1.Columns.Add(a)


            Next

            Dim req As String = "select salarie.matricule,nom + ' ' + prenom as 'np',etat,day(date_p) as 'jour' from salarie left join pointage on salarie.matricule=pointage.code   and month(date_p)='" & ComboBox1.SelectedIndex + 1 & "'  and year(date_p)='" & ComboBox2.SelectedItem & "' where  id_dep ='" & ComboBox3.SelectedValue & "' "

            Dim da As New SqlDataAdapter(req, cnx)
            da.Fill(ds, "emp")

            Dim dt1 As New DataTable
            dt1.Rows.Clear()
            Dim dt2 As DataRow()
            dt1 = ds.Tables("emp").DefaultView.ToTable(True, "matricule", "np")


            For i = 0 To dt1.Rows.Count - 1
                DataGridView1.Rows.Add(dt1.Rows(i).Item(1).ToString, dt1.Rows(i).Item(0).ToString)

                dt2 = ds.Tables("emp").Select("matricule =" & dt1.Rows(i).Item(0))

                For j = 0 To dt2.GetUpperBound(0)
                    If IsDBNull(dt2(j)(2)) = False Then

                        DataGridView1.Rows(i).Cells(dt2(j)(3) + 1).Value = dt2(j)(2)
                    End If

                Next

            Next
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(Now.Day + 1).Value = "" And ComboBox2.SelectedItem = Now.Year And ComboBox1.SelectedIndex = Now.Month - 1 Then
                    DataGridView1.Rows(i).Cells(Now.Day + 1).Value = "P"



                End If
            Next
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        test()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        test()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim dat As String
        Dim dat1 As Date
        cnx.Open()


        For i = 0 To DataGridView1.Rows.Count - 1
            For j = 2 To DataGridView1.ColumnCount - 2

                Dim dt2 As DataRow()
                dt2 = ds.Tables("emp").Select("matricule ='" & CInt(DataGridView1.Rows(i).Cells(1).Value) & "'AND jour = '" & CInt(j - 1) & "'")
                dat = j - 1 & "/" & ComboBox1.SelectedIndex + 1 & "/" & ComboBox2.SelectedItem


                dat1 = CType(dat, Date)
                ' MsgBox(dat1)
                If dt2.Length = 0 Then
                    Dim c As String
                    If (IsDBNull(DataGridView1.Rows(i).Cells(j).Value)) Then
                        c = " "
                    Else
                        c = DataGridView1.Rows(i).Cells(j).Value
                    End If
                    Dim rqInsert As String = ""
                    rqInsert = "insert into pointage values('" & dat1.Date & "','" & c & "','" & CInt(DataGridView1.Rows(i).Cells(1).Value) & "')"
                    ' MsgBox(rqInsert)
                    cmd = New SqlCommand(rqInsert, cnx)
                    cmd.ExecuteNonQuery()


                Else

                    Dim reqUpdate As String = ""
                    reqUpdate = "update pointage set etat='" & DataGridView1.Rows(i).Cells(j).Value & "' where code='" & CInt(DataGridView1.Rows(i).Cells(1).Value) & "' and date_p='" & dat1.Date & "'"

                    cmd = New SqlCommand(reqUpdate, cnx)
                    cmd.ExecuteNonQuery()
                End If

            Next

        Next
        cnx.Close()

        MsgBox("ENREGISTREMENT AVEC SUCCEES")
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
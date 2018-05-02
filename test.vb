Imports System.Data.SqlClient

Public Class test

    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da = New SqlDataAdapter("select * from departement", cnx)
        da.Fill(ds, "rr")
        ComboBox3.Items.Add("TOUS")
        For i = 0 To ds.Tables("rr").Rows.Count - 1
            ComboBox3.Items.Add(ds.Tables("rr").Rows(i)(1))
        Next
        ComboBox3.DisplayMember = ds.Tables("rr").Columns(1).ToString
        ComboBox3.ValueMember = ds.Tables("rr").Columns(0).ToString
        'ComboBox3.DataSource = ds.Tables("rr")

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Not ComboBox3.Text = "TOUS" Then
            da = New SqlDataAdapter("select * from sal where nom_departement='" & ComboBox3.Text & "' ", cnx)
            If ds.Tables.Contains("rtt") Then
                ds.Tables("rtt").Rows.Clear()
            End If
            da.Fill(ds, "rtt")
            DataGridView1.DataSource = ds.Tables("rtt")
        Else
            If ds.Tables.Contains("rt") Then
                ds.Tables("rt").Rows.Clear()
            End If
            da = New SqlDataAdapter("select * from sal ", cnx)
            da.Fill(ds, "rt")
            DataGridView1.DataSource = ds.Tables("rt")
        End If
    End Sub
End Class
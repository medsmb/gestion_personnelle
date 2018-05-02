Imports System.Data.SqlClient

Public Class authentification

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        da = New SqlDataAdapter(" select login,password from authentification", cnx)

        If ds.Tables.Contains("e") Then
            ds.Tables("e").Rows.Clear()
        End If
        da.Fill(ds, "e")
        Dim p As Integer = -1
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            p = 0

        Else
            For i = 0 To ds.Tables("e").Rows.Count - 1
                If TextBox1.Text = ds.Tables("e").Rows(i)(0) And TextBox2.Text = ds.Tables("e").Rows(i)(1) Then
                    p = 1
                    Exit For
                End If

            Next
        End If

        If p = 1 Then

            Acceuil.Show()
            Me.Hide()
        ElseIf p = 0 Then
            MsgBox("veuillez remplire les champs")
        Else
            MsgBox("login ou mot de pass incorrecte", MsgBoxStyle.Exclamation)
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
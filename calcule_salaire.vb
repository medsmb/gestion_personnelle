Imports System.Data.SqlClient

Public Class calcule_salaire

    Private Sub calcule_salaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ds.Tables.Contains("tot") Then
            ds.Tables("tot").Rows.Clear()
        End If

        da = New SqlDataAdapter("select  datediff(year,date_entree_etablissement,getdate()),titre,nom,prenom  from salarie where matricule = '" & salarie & "'", cnx)
        da.Fill(ds, "tot")
        t = ds.Tables("tot").Rows(0)(0)
        Label14.Text = ds.Tables("tot").Rows(0)(1) & Space(5) & ds.Tables("tot").Rows(0)(2) & Space(5) & ds.Tables("tot").Rows(0)(3)

        da.Dispose()
        da = New SqlDataAdapter("select count(*)  from pointage where etat ='p' and code='" & salarie & "'", cnx)
        cn()
        da.Fill(ds, "pointage")
        TextBox16.Text = ds.Tables("pointage").Rows(0)(0)
        'MsgBox(salarie)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '=si(2 année<date d'entre<5 année;+B35*5% et 
        'si 5 année<date d'entre< 10 année;+B35*10% 
        'et si 10 année <date d'entree< 15 année; 15%; 
        'si date d'entree > 15 année; 20 %)
        If t < 5 And t > 2 Then
            TextBox12.Text = Val(TextBox1.Text) * 0.05
        ElseIf t < 10 And t > 5 Then
            TextBox12.Text = Val(TextBox1.Text) * 0.1
        ElseIf t < 15 And t > 10 Then
            TextBox12.Text = Val(TextBox1.Text) * 0.15
        ElseIf t < 20 And t > 10 Then
            TextBox12.Text = Val(TextBox1.Text) * 0.2

        End If

        TextBox24.Text = ((Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox12.Text)) / 26) * Val(TextBox16.Text)
        TextBox15.Text = (Val(TextBox4.Text) / 26) * Val(TextBox16.Text) + Val(TextBox24.Text) ' bas cot
        TextBox13.Text = (Val(TextBox1.Text) / 26) * 1.5 ' dprv
        TextBox23.Text = Val(TextBox15.Text) * 0.0429 ' cnss1
        TextBox22.Text = Val(TextBox15.Text) * 0.086 'cnss2
        TextBox21.Text = Val(TextBox15.Text) * 0.08 'cnss3
        TextBox20.Text = Val(TextBox15.Text) * 0.04 ' amo p
        TextBox14.Text = Val(TextBox15.Text) * 0.015 ' amo s 
        TextBox19.Text = Val(TextBox15.Text) * 0.0125 ' at
        TextBox18.Text = Val(TextBox19.Text) * 0.12 ' tax

        'CHARGE PATRONAL
        TextBox17.Text = Val(TextBox24.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox14.Text) + Val(TextBox20.Text) + Val(TextBox19.Text) + Val(TextBox18.Text) + Val(TextBox13.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)

        MsgBox(t)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd = New SqlCommand(" update salarie set salaire_de_base='" & TextBox1.Text & "',R_S='" & TextBox2.Text & "',recup='" & TextBox3.Text & "',AVANTAGE_EN_NATURE='" & TextBox4.Text & "',PRIME_DE_LOGEMENT='" & TextBox5.Text & "',PRIME_DE_RENDEMENT='" & TextBox6.Text & "',PRIME_DE_REPRESENTATION='" & TextBox7.Text & "',PRIME_DE_BLEUS='" & TextBox8.Text & "',PRIME_DE_LAIT='" & TextBox9.Text & "',PRIME_DE_CAISSE='" & TextBox10.Text & "',PRIME_DE_TRANSPORT='" & TextBox11.Text & "',PRIME_ENCIENNETE='" & TextBox12.Text & "',salaire_brut='" & TextBox24.Text & "',BASE_DE_COTISATION='" & TextBox15.Text & "',jours_travailler='" & TextBox16.Text & "',DPRV_CP='" & TextBox13.Text & "',CNSS_1='" & TextBox23.Text & "',cNSS_2='" & TextBox22.Text & "',CNSS_3='" & TextBox21.Text & "',AMO='" & TextBox20.Text & "',ATP='" & TextBox19.Text & "',T_ATP='" & TextBox14.Text & "',TOTAL_CHARGE='" & TextBox17.Text & "' where matricule= '" & salarie & "' ", cnx)
        cn()
        cmd.ExecuteNonQuery()
        MsgBox("operation reussite")
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
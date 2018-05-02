Imports System.Data.SqlClient

Module Module1
    Public cnx As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=gestion_hotel2013;Integrated Security=True")
    Public ds, ds1 As New DataSet
    Public da, da1 As New SqlDataAdapter
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public a As Integer
    Public b As Integer
    Public c As Integer
    Public t As Integer
    Public salarie As Integer
    Public nom_pic As String
    ' Public dt As New DataTable
    Public Sub cn()
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If
    End Sub


    Public Function IdSalarie() As Integer

        Dim req As String = "select max(matricule) from salarie"
        Dim cmd As New SqlCommand(req, cnx)

        Dim IdSal As Integer
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        IdSal = cmd.ExecuteScalar
        cnx.Close()

        Return IdSal + 1


    End Function
End Module

Imports MySql.Data.MySqlClient
Imports System.Data

Module Module1

    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Public myData As New DataTable
    Dim SQL As String

    Public Sub connectionsql()
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                    "password=;database=movedb"
        Try
            conn.Open()
            MessageBox.Show("Koneksi Berhasil")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error Koneksi: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub showdata()
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=movedb"
        Try
            conn.Open()
            SQL = "SELECT judul, artis, path, voc, xvoc FROM lagu "

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub



End Module

Imports System.Data.OleDb

Public Class BBDD
    Private conex As OleDbConnection

    Public Sub New(connectionString As String)
        conex = New OleDbConnection(connectionString)
    End Sub

    Public Function Conectar() As Boolean
        Try
            If conex.State = ConnectionState.Closed Then
                conex.Open()
            End If
            Return True
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub Desconectar()
        Try
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al desconectar: " & ex.Message)
        End Try
    End Sub
    Public Function GetConex() As OleDbConnection
        Return conex
    End Function

End Class

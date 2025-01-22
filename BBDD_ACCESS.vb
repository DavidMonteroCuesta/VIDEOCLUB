Imports System.Data.OleDb
Module BBDD_Access
    Private bbdd As New BBDD("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CLASE\INTERFACES\2º\EJERCICIOS\2025-01-16\VIDEOCLUB11.accdb")
    Public Adaptador As OleDbDataAdapter
    Public DatosConjuntosPeliculas As DataSet
    Public CadenaConsultar As String = "SELECT * FROM Peliculas"
    Public CadenaInsertar As String = "INSERT INTO Peliculas (titulo, director, genero, calificacion, anyo) VALUES (@Titulo, @Director, @Genero, @Calificacion, @Anyo)"

    Dim campos As List(Of String) = New List(Of String) From {"Id", "titulo", "director", "genero", "calificacion", "anyo"}

    Public Function Conectar() As Boolean
        Return bbdd.Conectar()
    End Function

    Public Sub Desconectar()
        bbdd.Desconectar()
    End Sub

    Public Sub MostrarPeliculasEnListView()
        Try
            Adaptador = New OleDbDataAdapter(CadenaConsultar, bbdd.GetConex)
            DatosConjuntosPeliculas = New DataSet()

            Adaptador.Fill(DatosConjuntosPeliculas, "Peliculas")

            Listado.lstVwPeliculas.Items.Clear()

            For Each fila As DataRow In DatosConjuntosPeliculas.Tables("Peliculas").Rows
                Dim elemento As New ListViewItem(fila(campos(0)).ToString())
                elemento.SubItems.Add(fila(campos(1)).ToString())
                elemento.SubItems.Add(fila(campos(2)).ToString())
                elemento.SubItems.Add(fila(campos(3)).ToString())
                elemento.SubItems.Add(fila(campos(4)).ToString())
                elemento.SubItems.Add(fila(campos(5)).ToString())
                Listado.lstVwPeliculas.Items.Add(elemento)
            Next

        Catch ex As Exception
            MsgBox("Error al mostrar las películas: " & ex.Message)
        End Try
    End Sub


    Public Sub AgregarPeliculaConDataAdapter(pelicula As Pelicula)
        Try
            Dim comando As New OleDbCommand(CadenaInsertar, bbdd.GetConex())

            comando.Parameters.AddWithValue("@Titulo", pelicula.Titulo)
            comando.Parameters.AddWithValue("@Director", pelicula.Director)
            comando.Parameters.AddWithValue("@Genero", pelicula.Genero)
            comando.Parameters.AddWithValue("@Calificacion", pelicula.Calificacion)
            comando.Parameters.AddWithValue("@Anyo", pelicula.Anyo)

            Adaptador.InsertCommand = comando
            Adaptador.UpdateCommand = comando
            Adaptador.Fill(DatosConjuntosPeliculas, "Peliculas")

            MostrarPeliculasEnListView()

        Catch ex As Exception
            MsgBox("Error al añadir la película: " & ex.Message)
        End Try
    End Sub


End Module
Imports System.Data.OleDb
Imports System.IO
Module BBDDAccessPeliculas
    Dim RUTA_BBDD_ACCESS As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\recursos\VIDEOCLUB11.accdb")
    Public bbdd_access As New BBDD($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={RUTA_BBDD_ACCESS}")

    Private Adaptador As OleDbDataAdapter
    Private DatosConjuntosPeliculas As DataSet
    Private consultaMaxID As String = "SELECT MAX(Id) FROM Peliculas"
    Private CadenaConsultar As String = "SELECT * FROM Peliculas"
    Private CadenaInsertar As String = "INSERT INTO Peliculas (titulo, director, genero, calificacion, anyo) VALUES (@Titulo, @Director, @Genero, @Calificacion, @Anyo)"
    Private cadenaEliminar As String = "DELETE FROM Peliculas WHERE Id = @Id"
    Private cadenaConsulta As String = "SELECT * FROM Peliculas WHERE Id = @Id"

    Dim campos As List(Of String) = New List(Of String) From {"Id", "titulo", "director", "genero", "calificacion", "anyo"}

    Public Function Conectar() As Boolean
        Return bbdd_access.Conectar()
    End Function

    Public Sub Desconectar()
        bbdd_access.Desconectar()
    End Sub

    Public Function ObtenerProximoID() As Integer
        Try
            Dim comando As New OleDbCommand(consultaMaxID, bbdd_access.GetConex())
            Dim maxID As Object = comando.ExecuteScalar()

            If IsDBNull(maxID) OrElse maxID Is Nothing Then
                Return 1
            Else
                Return CInt(maxID) + 1
            End If
        Catch ex As Exception
            MsgBox("Error al obtener el próximo ID: " & ex.Message)
            Return -1
        End Try
    End Function

    Public Sub MostrarPeliculasEnListView(Optional ByVal filtroID As String = "", Optional ByVal filtroTitulo As String = "", Optional ByVal filtroGenero As String = "")
        Try
            Dim consulta As String = "SELECT * FROM Peliculas WHERE 1=1"

            If filtroID <> "" Then consulta &= " AND id LIKE '%" & filtroID & "%'"
            If filtroTitulo <> "" Then consulta &= " AND titulo LIKE '%" & filtroTitulo & "%'"
            If filtroGenero <> "" Then consulta &= " AND genero LIKE '%" & filtroGenero & "%'"

            consulta &= " ORDER BY id ASC"

            Adaptador = New OleDbDataAdapter(consulta, bbdd_access.GetConex())
            DatosConjuntosPeliculas = New DataSet()
            Adaptador.Fill(DatosConjuntosPeliculas, "Peliculas")

            ListadoPeliculas.lstVwPeliculas.Items.Clear()

            For Each fila As DataRow In DatosConjuntosPeliculas.Tables("Peliculas").Rows
                Dim elemento As New ListViewItem(fila(campos(0)).ToString())
                elemento.SubItems.Add(fila(campos(1)).ToString())
                elemento.SubItems.Add(fila(campos(2)).ToString())
                elemento.SubItems.Add(fila(campos(3)).ToString())
                elemento.SubItems.Add(fila(campos(4)).ToString())
                elemento.SubItems.Add(fila(campos(5)).ToString())

                ListadoPeliculas.lstVwPeliculas.Items.Add(elemento)
            Next

        Catch ex As Exception
            MsgBox("Error al mostrar las películas: " & ex.Message)
        End Try
    End Sub


    Public Sub AgregarPeliculaConDataAdapter(pelicula As Pelicula)
        Try
            Dim tablaPeliculas As DataTable = DatosConjuntosPeliculas.Tables("Peliculas")
            Dim nuevaFila As DataRow = tablaPeliculas.NewRow()

            nuevaFila("titulo") = pelicula.Titulo
            nuevaFila("director") = pelicula.Director
            nuevaFila("genero") = pelicula.Genero
            nuevaFila("calificacion") = pelicula.Calificacion
            nuevaFila("anyo") = pelicula.Anyo

            tablaPeliculas.Rows.Add(nuevaFila)

            Adaptador.InsertCommand = New OleDbCommand(CadenaInsertar, bbdd_access.GetConex())
            Adaptador.InsertCommand.Parameters.Add("@Titulo", OleDbType.VarChar, 255, campos(1))
            Adaptador.InsertCommand.Parameters.Add("@Director", OleDbType.VarChar, 255, campos(2))
            Adaptador.InsertCommand.Parameters.Add("@Genero", OleDbType.VarChar, 255, campos(3))
            Adaptador.InsertCommand.Parameters.Add("@Calificacion", OleDbType.Integer, 4, campos(4))
            Adaptador.InsertCommand.Parameters.Add("@Anyo", OleDbType.Integer, 4, campos(5))

            Adaptador.Update(DatosConjuntosPeliculas, "Peliculas")

            MostrarPeliculasEnListView()

        Catch ex As Exception
            MsgBox("Error al añadir la película: " & ex.Message)
        End Try
    End Sub

    Public Sub EliminarPeliculaConDataAdapter(idPelicula As Integer)
        Try
            Adaptador.DeleteCommand = New OleDbCommand(cadenaEliminar, bbdd_access.GetConex())
            Adaptador.DeleteCommand.Parameters.Add("@Id", OleDbType.Integer).Value = idPelicula

            Dim filasAfectadas As Integer = Adaptador.DeleteCommand.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MsgBox("Película eliminada correctamente.", MsgBoxStyle.Information)
                MostrarPeliculasEnListView()
            Else
                MsgBox("No se encontró ninguna película con el ID especificado.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Error al eliminar la película: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub ActualizarPeliculaConDataAdapter(idPelicula As Integer, genero As String, calificacion As Integer, anyo As Integer)
        Try
            Dim tablaPeliculas As DataTable = DatosConjuntosPeliculas.Tables("Peliculas")
            Dim filaAActualizar As DataRow = tablaPeliculas.Select("Id = " & idPelicula).FirstOrDefault()

            If filaAActualizar IsNot Nothing Then
                filaAActualizar("calificacion") = calificacion
                filaAActualizar("anyo") = anyo
                filaAActualizar("genero") = genero

                Adaptador.UpdateCommand = New OleDbCommand("UPDATE Peliculas SET calificacion = @Calificacion, anyo = @Anyo, genero = @Genero WHERE Id = @Id", bbdd_access.GetConex())
                Adaptador.UpdateCommand.Parameters.Add("@Calificacion", OleDbType.Integer).Value = calificacion
                Adaptador.UpdateCommand.Parameters.Add("@Anyo", OleDbType.Integer).Value = anyo
                Adaptador.UpdateCommand.Parameters.Add("@Genero", OleDbType.VarChar).Value = genero
                Adaptador.UpdateCommand.Parameters.Add("@Id", OleDbType.Integer).Value = idPelicula

                Adaptador.Update(DatosConjuntosPeliculas, "Peliculas")

                MsgBox("Película actualizada correctamente.", MsgBoxStyle.Information)

                MostrarPeliculasEnListView()
            Else
                MsgBox("No se encontró la película con el ID especificado.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar la película: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function ObtenerPeliculaPorId(idPelicula As Integer) As Pelicula
        Try
            Adaptador.SelectCommand.Parameters.Add("@Id", OleDbType.Integer).Value = idPelicula

            Dim dataSet As New DataSet()
            Adaptador.Fill(dataSet, "Peliculas")

            If dataSet.Tables("Peliculas").Rows.Count > 0 Then
                Dim fila As DataRow = dataSet.Tables("Peliculas").Rows(0)
                Dim pelicula As New Pelicula(fila("titulo").ToString(), fila("director").ToString(), fila("genero").ToString(), CInt(fila("calificacion")), CInt(fila("anyo")))
                Return pelicula
            Else
                MsgBox("No se encontró ninguna película con el ID especificado.", MsgBoxStyle.Exclamation)
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al obtener la película: " & ex.Message, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
End Module
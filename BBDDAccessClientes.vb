Imports System.Data.OleDb
Imports System.IO

Module BBDDAccessClientes
    Public bbdd_access As BBDD = BBDDAccessPeliculas.bbdd_access

    Public Adaptador As OleDbDataAdapter
    Private DatosConjuntosClientes As DataSet
    Private CadenaConsultar As String = "SELECT * FROM Clientes"
    Private CadenaInsertar As String = "INSERT INTO Clientes (nombre, apellido1, apellido2, dni, num_contacto, email, socio) VALUES (@Nombre, @Apellido1, @Apellido2, @DNI, @NumContacto, @Email, @Socio)"
    Private cadenaEliminar As String = "DELETE FROM Clientes WHERE Id = @Id"
    Private cadenaConsulta As String = "SELECT * FROM Clientes WHERE Id = @Id"
    Private consulta As String = "SELECT * FROM Clientes WHERE 1=1"
    Private consultaMaxID As String = "SELECT MAX(Id) FROM Clientes"

    Dim campos As List(Of String) = New List(Of String) From {"Id", "nombre", "apellido1", "apellido2", "dni", "num_contacto", "email", "socio"}

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

    Public Sub MostrarClientesEnListView(Optional ByVal filtroID As String = "", Optional ByVal filtroNombre As String = "", Optional ByVal filtroTelefono As String = "")
        Try

            If filtroID <> "" Then consulta &= " AND id LIKE '%" & filtroID & "%'"
            If filtroNombre <> "" Then consulta &= " AND nombre LIKE '%" & filtroNombre & "%'"
            If filtroTelefono <> "" Then consulta &= " AND telefono LIKE '%" & filtroTelefono & "%'"

            consulta &= " ORDER BY id ASC"

            Adaptador = New OleDbDataAdapter(consulta, bbdd_access.GetConex)
            DatosConjuntosClientes = New DataSet()
            Adaptador.Fill(DatosConjuntosClientes, "Clientes")

            ListadoClientes.lstVwClientes.Items.Clear()

            For Each fila As DataRow In DatosConjuntosClientes.Tables("Clientes").Rows
                Dim elemento As New ListViewItem(fila(campos(0)).ToString())
                elemento.SubItems.Add(fila(campos(1)).ToString())
                elemento.SubItems.Add(fila(campos(2)).ToString())
                elemento.SubItems.Add(fila(campos(3)).ToString())
                elemento.SubItems.Add(fila(campos(4)).ToString())
                elemento.SubItems.Add(fila(campos(5)).ToString())
                elemento.SubItems.Add(fila(campos(6)).ToString())
                elemento.SubItems.Add(fila(campos(7)).ToString())
                'elemento.SubItems.Add(If(Convert.ToBoolean(fila(campos(7))), "Sí", "No"))

                ListadoPeliculas.lstVwPeliculas.Items.Add(elemento)
            Next
        Catch ex As Exception
            MsgBox("Error al mostrar los clientes: " & ex.Message)
        End Try
    End Sub

    Public Sub AgregarClienteConDataAdapter(cliente As Cliente)
        Try
            Dim tablaClientes As DataTable = DatosConjuntosClientes.Tables("Clientes")
            Dim nuevaFila As DataRow = tablaClientes.NewRow()

            nuevaFila("nombre") = cliente.Nombre
            nuevaFila("apellido1") = cliente.Apellido1
            nuevaFila("apellido2") = cliente.Apellido2
            nuevaFila("dni") = cliente.Dni
            nuevaFila("num_contacto") = cliente.Num_contacto
            nuevaFila("email") = cliente.Email
            nuevaFila("socio") = cliente.Socio

            tablaClientes.Rows.Add(nuevaFila)

            Adaptador.InsertCommand = New OleDbCommand(CadenaInsertar, bbdd_access.GetConex())
            Adaptador.InsertCommand.Parameters.Add("@Nombre", OleDbType.VarChar, 255, "nombre")
            Adaptador.InsertCommand.Parameters.Add("@Apellido1", OleDbType.VarChar, 255, "apellido1")
            Adaptador.InsertCommand.Parameters.Add("@Apellido2", OleDbType.VarChar, 255, "apellido2")
            Adaptador.InsertCommand.Parameters.Add("@DNI", OleDbType.VarChar, 255, "dni")
            Adaptador.InsertCommand.Parameters.Add("@NumContacto", OleDbType.VarChar, 255, "num_contacto")
            Adaptador.InsertCommand.Parameters.Add("@Email", OleDbType.VarChar, 255, "email")
            Adaptador.InsertCommand.Parameters.Add("@Socio", OleDbType.Boolean, 1, "socio")

            Adaptador.Update(DatosConjuntosClientes, "Clientes")

            MostrarClientesEnListView()

        Catch ex As Exception
            MsgBox("Error al añadir el cliente: " & ex.Message)
        End Try
    End Sub


    Public Sub EliminarClienteConDataAdapter(idCliente As Integer)
        Try
            Adaptador.DeleteCommand = New OleDbCommand(cadenaEliminar, bbdd_access.GetConex())
            Adaptador.DeleteCommand.Parameters.Add("@Id", OleDbType.Integer).Value = idCliente

            Dim filasAfectadas As Integer = Adaptador.DeleteCommand.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MsgBox("Cliente eliminado correctamente.", MsgBoxStyle.Information)
                MostrarClientesEnListView()
            Else
                MsgBox("No se encontró ningún cliente con el ID especificado.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Error al eliminar el cliente: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub ActualizarClienteConDataAdapter(idCliente As Integer, direccion As String, telefono As String, email As String)
        Try
            Dim tablaClientes As DataTable = DatosConjuntosClientes.Tables("Clientes")
            Dim filaAActualizar As DataRow = tablaClientes.Select("Id = " & idCliente).FirstOrDefault()

            If filaAActualizar IsNot Nothing Then
                filaAActualizar("direccion") = direccion
                filaAActualizar("telefono") = telefono
                filaAActualizar("email") = email

                Adaptador.UpdateCommand = New OleDbCommand("UPDATE Clientes SET direccion = @Direccion, telefono = @Telefono, email = @Email WHERE Id = @Id", bbdd_access.GetConex())
                Adaptador.UpdateCommand.Parameters.Add("@Direccion", OleDbType.VarChar).Value = direccion
                Adaptador.UpdateCommand.Parameters.Add("@Telefono", OleDbType.VarChar).Value = telefono
                Adaptador.UpdateCommand.Parameters.Add("@Email", OleDbType.VarChar).Value = email
                Adaptador.UpdateCommand.Parameters.Add("@Id", OleDbType.Integer).Value = idCliente

                Adaptador.Update(DatosConjuntosClientes, "Clientes")

                MsgBox("Cliente actualizado correctamente.", MsgBoxStyle.Information)

                MostrarClientesEnListView()
            Else
                MsgBox("No se encontró el cliente con el ID especificado.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar el cliente: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function ObtenerClientePorId(idCliente As Integer) As Cliente
        Try
            Adaptador.SelectCommand.Parameters.Add("@Id", OleDbType.Integer).Value = idCliente

            Dim dataSet As New DataSet()
            Adaptador.Fill(dataSet, "Clientes")

            If dataSet.Tables("Clientes").Rows.Count > 0 Then
                Dim fila As DataRow = dataSet.Tables("Clientes").Rows(0)

                Dim cliente As New Cliente(
                    fila("nombre").ToString(),
                    fila("apellido1").ToString(),
                    fila("apellido2").ToString(),
                    fila("dni").ToString(),
                    fila("num_contacto").ToString(),
                    fila("email").ToString(),
                    Convert.ToBoolean(fila("socio"))
                )

                Return cliente
            Else
                MsgBox("No se encontró ningún cliente con el ID especificado.", MsgBoxStyle.Exclamation)
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al obtener el cliente: " & ex.Message, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function

End Module

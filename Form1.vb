Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BBDDAccessPeliculas.Conectar()
        ocultarTodo()
        ListadoPeliculas.Show()
    End Sub

    Private Sub ocultarTodo()
        GroupBoxPeliculas.Enabled = False
        GroupBoxClientes.Enabled = False
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False

        For Each control As Control In GroupBoxPeliculas.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            ElseIf TypeOf control Is ComboBox Then
                CType(control, ComboBox).SelectedIndex = -1
            End If
        Next

        For Each control As Control In GroupBoxClientes.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            ElseIf TypeOf control Is ComboBox Then
                CType(control, ComboBox).SelectedIndex = -1
            End If
        Next
    End Sub


    Private Sub liberarPelicula()
        txtBoxPeliculaID.Enabled = True
        txtBxPeliculaTitulo.Enabled = True
        txtBxPeliculaCalificacion.Enabled = True
        txtBxPeliculaDirector.Enabled = True
        cmbBoxPeliculaAnyo.Enabled = True
        cmbBxPeliculaGenero.Enabled = True
    End Sub

    Private Sub liberarCliente()
        txtBxClienteID.Enabled = True
        txtBxClienteNombre.Enabled = True
        txtBxClienteApellido1.Enabled = True
        txtBxClienteApellido2.Enabled = True
        txtBxClienteDNI.Enabled = True
        txtBxClienteCorreo.Enabled = True
        txtBxClienteNumTel.Enabled = True
        cmbBxClienteSocio.Enabled = True
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem2.Click
        Me.Text = "PELÍCULAS -- AGREGAR"
        ocultarTodo()
        controlarAccesibilidad("AGREGAR_PELICULA")
        txtBoxPeliculaID.Text = BBDDAccessPeliculas.ObtenerProximoID()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        Me.Text = "PELÍCULAS -- ELIMINAR"
        ocultarTodo()
        controlarAccesibilidad("ELIMINAR_PELICULA")
    End Sub

    Private Sub EditarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem1.Click
        Me.Text = "PELÍCULAS -- EDITAR"
        ocultarTodo()
        controlarAccesibilidad("EDITAR_PELICULA")
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        Me.Text = "CLIENTES -- AGREGAR"
        ocultarTodo()
        controlarAccesibilidad("AGREGAR_CLIENTE")
        txtBxClienteID.Text = BBDDAccessClientes.ObtenerProximoID()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Me.Text = "CLIENTES -- ELIMINAR"
        ocultarTodo()
        controlarAccesibilidad("ELIMINAR_CLIENTE")
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Me.Text = "CLIENTES -- EDITAR"
        ocultarTodo()
        controlarAccesibilidad("EDITAR_CLIENTE")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.Text.Contains("AGREGAR") Then
            Agregar()
        ElseIf Me.Text.Contains("EDITAR") Then
            Modificar()
        ElseIf Me.Text.Contains("ELIMINAR") Then
            Eliminar()
        End If

        liberarPelicula()
        liberarCliente()
        ocultarTodo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        liberarPelicula()
        liberarCliente()
        ocultarTodo()
    End Sub

    Private Sub Agregar()
        If Me.Text.Contains("CLIENTES") Then
            Dim cliente As New Cliente(
                txtBxClienteNombre.Text,
                txtBxClienteApellido1.Text,
                txtBxClienteApellido2.Text,
                txtBxClienteDNI.Text,
                txtBxClienteNumTel.Text,
                txtBxClienteCorreo.Text,
                If(cmbBxClienteSocio.SelectedItem.ToString() = "SI", True, False)
                )
            BBDDAccessClientes.AgregarClienteConDataAdapter(cliente)
        Else
            Dim pelicula As New Pelicula(
                txtBxPeliculaTitulo.Text,
                txtBxPeliculaDirector.Text,
                cmbBxPeliculaGenero.SelectedItem.ToString,
                txtBxPeliculaCalificacion.Text,
                cmbBoxPeliculaAnyo.SelectedItem.ToString
            )

            BBDDAccessPeliculas.AgregarPeliculaConDataAdapter(pelicula)
        End If
    End Sub

    Private Sub Modificar()
        If Me.Text.Contains("CLIENTES") Then
            Dim socio As Boolean = If(cmbBxClienteSocio.SelectedItem.ToString() = "SI", True, False)
            BBDDAccessClientes.ActualizarClienteConDataAdapter(txtBxClienteID.Text, txtBxClienteNumTel.Text, txtBxClienteCorreo.Text, socio)
        Else
            BBDDAccessPeliculas.ActualizarPeliculaConDataAdapter(txtBoxPeliculaID.Text, cmbBxPeliculaGenero.Text, txtBxPeliculaCalificacion.Text, cmbBoxPeliculaAnyo.Text)
        End If
    End Sub

    Private Sub Eliminar()
        If Me.Text.Contains("CLIENTES") Then
            BBDDAccessClientes.EliminarClienteConDataAdapter(txtBxClienteID.Text)
        Else
            BBDDAccessPeliculas.EliminarPeliculaConDataAdapter(txtBoxPeliculaID.Text)
        End If
    End Sub

    Private Sub controlarAccesibilidad(tipo As String)
        For Each control As Control In GroupBoxPeliculas.Controls
            control.Enabled = False
        Next

        For Each control As Control In GroupBoxClientes.Controls
            control.Enabled = False
        Next

        Select Case tipo
            Case "AGREGAR_PELICULA"
                GroupBoxPeliculas.Enabled = True
                txtBoxPeliculaID.Enabled = False
                txtBxPeliculaTitulo.Enabled = True
                txtBxPeliculaDirector.Enabled = True
                txtBxPeliculaCalificacion.Enabled = True
                cmbBoxPeliculaAnyo.Enabled = True
                cmbBxPeliculaGenero.Enabled = True
                btnAceptar.Enabled = True
                btnCancelar.Enabled = True

            Case "ELIMINAR_PELICULA"
                GroupBoxPeliculas.Enabled = True
                txtBoxPeliculaID.Enabled = True
                btnAceptar.Enabled = True
                btnCancelar.Enabled = True

            Case "EDITAR_PELICULA"
                GroupBoxPeliculas.Enabled = True
                txtBoxPeliculaID.Enabled = True
                txtBxPeliculaCalificacion.Enabled = True
                cmbBoxPeliculaAnyo.Enabled = True
                cmbBxPeliculaGenero.Enabled = True
                btnAceptar.Enabled = True
                btnCancelar.Enabled = True

            Case "AGREGAR_CLIENTE"
                GroupBoxClientes.Enabled = True
                txtBxClienteID.Enabled = False
                txtBxClienteNombre.Enabled = True
                txtBxClienteApellido1.Enabled = True
                txtBxClienteApellido2.Enabled = True
                txtBxClienteDNI.Enabled = True
                txtBxClienteCorreo.Enabled = True
                txtBxClienteNumTel.Enabled = True
                cmbBxClienteSocio.Enabled = True
                btnAceptar.Enabled = True
                btnCancelar.Enabled = True

            Case "ELIMINAR_CLIENTE"
                GroupBoxClientes.Enabled = True
                txtBxClienteID.Enabled = True
                btnAceptar.Enabled = True
                btnCancelar.Enabled = True

            Case "EDITAR_CLIENTE"
                GroupBoxClientes.Enabled = True
                txtBxClienteID.Enabled = True
                txtBxClienteNumTel.Enabled = True
                txtBxClienteCorreo.Enabled = True
                cmbBxClienteSocio.Enabled = True
                btnAceptar.Enabled = True
                btnCancelar.Enabled = True
        End Select
    End Sub
End Class

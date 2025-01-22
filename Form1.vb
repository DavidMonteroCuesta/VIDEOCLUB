Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BBDD_Access.Conectar()

        ToolStripComboBox2.Text = "Max"
        ToolStripComboBox3.Text = "Min"
        ocultarTodo()
        Listado.Show()
    End Sub

    Private Sub ocultarTodo()
        GroupBoxPeliculas.Enabled = False
        GroupBoxCliente.Enabled = False
        btnAgregar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub liberarPelicula()
        txtBoxID.Enabled = True
        btnEliminar.Enabled = True
        txtBxTitulo.Enabled = True
        txtbxCalificacion.Enabled = True
        txtBxDirector.Enabled = True
        cmbBoxAnyo.Enabled = True
        cmbBxGenero.Enabled = True
    End Sub

    Private Sub liberarCliente()
        txtBxApellidos.Enabled = True
        txtBxCorreo.Enabled = True
        txtBxDireccion.Enabled = True
        txtBxIdCliente.Enabled = True
        txtBxNombreCliente.Enabled = True
        txtBxTelefono.Enabled = True
        cmbBxPeliculas.Enabled = True
        cmbBxSituacion.Enabled = True
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem2.Click
        Me.Text = "PELÍCULAS -- AGREGAR"
        ocultarTodo()
        GroupBoxCliente.Enabled = False
        GroupBoxPeliculas.Enabled = True
        txtBoxID.Enabled = False
        btnAgregar.Enabled = True
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        Me.Text = "PELÍCULAS -- ELIMINAR"
        ocultarTodo()
        GroupBoxCliente.Enabled = False
        GroupBoxPeliculas.Enabled = True
        txtBoxID.Enabled = True
        btnEliminar.Enabled = True
        txtBxTitulo.Enabled = False
        txtbxCalificacion.Enabled = False
        txtBxDirector.Enabled = False
        cmbBoxAnyo.Enabled = False
        cmbBxGenero.Enabled = False
    End Sub

    Private Sub EditarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem1.Click
        Me.Text = "PELÍCULAS -- EDITAR"
        ocultarTodo()
        GroupBoxCliente.Enabled = False
        GroupBoxPeliculas.Enabled = True
        btnModificar.Enabled = True
        txtbxCalificacion.Enabled = True
        txtBxDirector.Enabled = True
        cmbBoxAnyo.Enabled = True
        cmbBxGenero.Enabled = True
        txtBxTitulo.Enabled = False
        txtBoxID.Enabled = False
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        Me.Text = "CLIENTES -- AGREGAR"
        ocultarTodo()
        GroupBoxPeliculas.Enabled = False
        GroupBoxCliente.Enabled = True
        txtBxApellidos.Enabled = True
        txtBxCorreo.Enabled = True
        txtBxDireccion.Enabled = True
        txtBxIdCliente.Enabled = False
        txtBxNombreCliente.Enabled = True
        txtBxTelefono.Enabled = True
        cmbBxPeliculas.Enabled = False
        cmbBxSituacion.Enabled = True
        btnAgregar.Enabled = True
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Me.Text = "CLIENTES -- ELIMINAR"
        ocultarTodo()
        GroupBoxPeliculas.Enabled = False
        GroupBoxCliente.Enabled = True
        txtBxApellidos.Enabled = False
        txtBxCorreo.Enabled = False
        txtBxDireccion.Enabled = False
        txtBxIdCliente.Enabled = True
        txtBxNombreCliente.Enabled = False
        txtBxTelefono.Enabled = False
        cmbBxPeliculas.Enabled = False
        cmbBxSituacion.Enabled = False
        btnEliminar.Enabled = True
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Me.Text = "CLIENTES -- EDITAR"
        ocultarTodo()
        GroupBoxPeliculas.Enabled = False
        GroupBoxCliente.Enabled = True
        txtBxApellidos.Enabled = True
        txtBxCorreo.Enabled = True
        txtBxDireccion.Enabled = True
        txtBxIdCliente.Enabled = False
        txtBxNombreCliente.Enabled = True
        txtBxTelefono.Enabled = True
        cmbBxPeliculas.Enabled = True
        cmbBxSituacion.Enabled = True
        btnModificar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim pelicula As New Pelicula(
            txtBxTitulo.Text,
            txtBxDirector.Text,
            cmbBxGenero.SelectedItem.ToString(),
            txtbxCalificacion.Text,
            cmbBoxAnyo.SelectedItem.ToString()
        )

        BBDD_Access.AgregarPeliculaConDataAdapter(pelicula)
        liberarPelicula()
        ocultarTodo()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        liberarPelicula()
        ocultarTodo()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        liberarPelicula()
        ocultarTodo()
    End Sub
End Class

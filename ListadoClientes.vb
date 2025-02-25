Public Class ListadoClientes
    Private Sub ListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarClientesFiltrados()
    End Sub

    Private Sub txtBxIDListado_TextChanged(sender As Object, e As EventArgs) Handles txtBxIDListado.TextChanged
        MostrarClientesFiltrados()
    End Sub

    Private Sub txtBxNombreListado_TextChanged(sender As Object, e As EventArgs) Handles txtBxNombreListado.TextChanged
        MostrarClientesFiltrados()
    End Sub

    Private Sub txtBxApellido1Listado_TextChanged(sender As Object, e As EventArgs) Handles txtBxApellido1Listado.TextChanged
        MostrarClientesFiltrados()
    End Sub

    Private Sub txtBxApellido2Listado_TextChanged(sender As Object, e As EventArgs) Handles txtBxApellido2Listado.TextChanged
        MostrarClientesFiltrados()
    End Sub

    Private Sub MostrarClientesFiltrados()
        BBDDAccessClientes.MostrarClientesEnListView(txtBxIDListado.Text, txtBxNombreListado.Text, txtBxApellido1Listado.Text, txtBxApellido2Listado.Text)
    End Sub
End Class

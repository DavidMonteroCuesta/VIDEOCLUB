Public Class ListadoPeliculas
    Private Sub Listado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarPeliculasFiltradas()
    End Sub

    Private Sub txtBxTituloListado_TextChanged(sender As Object, e As EventArgs) Handles txtBxTituloListado.TextChanged
        MostrarPeliculasFiltradas()
    End Sub

    Private Sub txtBxGeneroListado_TextChanged(sender As Object, e As EventArgs) Handles txtBxGeneroListado.TextChanged
        MostrarPeliculasFiltradas()
    End Sub

    Private Sub txtBxIDListado_TextChanged(sender As Object, e As EventArgs) Handles txtBxIDListado.TextChanged
        MostrarPeliculasFiltradas()
    End Sub

    Private Sub MostrarPeliculasFiltradas()
        BBDDAccessPeliculas.MostrarPeliculasEnListView(txtBxIDListado.Text, txtBxTituloListado.Text, txtBxGeneroListado.Text)
    End Sub

    Private Sub btnCambioListado_Click(sender As Object, e As EventArgs) Handles btnCambioListado.Click
        ListadoClientes.Show()
        Me.Hide()
    End Sub
End Class

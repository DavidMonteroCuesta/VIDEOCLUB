Public Class Listado
    Private Sub Listado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BBDD_Access.MostrarPeliculasEnListView()
    End Sub

    Private Sub lstVwPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVwPeliculas.SelectedIndexChanged

    End Sub
End Class
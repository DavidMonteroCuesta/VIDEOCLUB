Public Class Pelicula
    Public Property Titulo As String
    Public Property Genero As String
    Public Property Director As String
    Public Property Calificacion As Integer
    Public Property Anyo As Integer

    Public Sub New(titulo As String, genero As String, director As String, anyo As Integer, calificacion As Integer)
        Me.Titulo = titulo
        Me.Genero = genero
        Me.Director = director
        Me.Calificacion = calificacion
        Me.Anyo = anyo
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Titulo} ({Anyo}) - {Genero} - {Director} - {Calificacion}/10"
    End Function
End Class

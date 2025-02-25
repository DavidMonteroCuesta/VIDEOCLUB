Public Class Cliente
    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property Dni As String
    Public Property Num_contacto As Integer
    Public Property Email As String
    Public Property Socio As Boolean

    Public Sub New(nombre As String, apellido1 As String, apellido2 As String, dni As String, num_contacto As Integer, email As String, socio As Boolean)
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.Dni = dni
        Me.Num_contacto = num_contacto
        Me.Email = email
        Me.Socio = socio
    End Sub
End Class

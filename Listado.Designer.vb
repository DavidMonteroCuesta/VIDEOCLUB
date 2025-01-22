<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lstVwPeliculas = New ListView()
        ID = New ColumnHeader()
        TITULO = New ColumnHeader()
        DIRECTOR = New ColumnHeader()
        CALIFICACION = New ColumnHeader()
        ANYO = New ColumnHeader()
        GENERO = New ColumnHeader()
        SuspendLayout()
        ' 
        ' lstVwPeliculas
        ' 
        lstVwPeliculas.Columns.AddRange(New ColumnHeader() {ID, TITULO, DIRECTOR, CALIFICACION, ANYO, GENERO})
        lstVwPeliculas.Location = New Point(16, 13)
        lstVwPeliculas.Margin = New Padding(3, 4, 3, 4)
        lstVwPeliculas.Name = "lstVwPeliculas"
        lstVwPeliculas.Size = New Size(896, 469)
        lstVwPeliculas.TabIndex = 0
        lstVwPeliculas.UseCompatibleStateImageBehavior = False
        lstVwPeliculas.View = View.Details
        ' 
        ' ID
        ' 
        ID.Text = "     ID"
        ' 
        ' TITULO
        ' 
        TITULO.Text = "TITULO"
        TITULO.TextAlign = HorizontalAlignment.Center
        TITULO.Width = 220
        ' 
        ' DIRECTOR
        ' 
        DIRECTOR.Text = "DIRECTOR"
        DIRECTOR.TextAlign = HorizontalAlignment.Center
        DIRECTOR.Width = 165
        ' 
        ' CALIFICACION
        ' 
        CALIFICACION.DisplayIndex = 4
        CALIFICACION.Text = "CALIFICACIÓN"
        CALIFICACION.TextAlign = HorizontalAlignment.Center
        CALIFICACION.Width = 110
        ' 
        ' ANYO
        ' 
        ANYO.DisplayIndex = 5
        ANYO.Text = "AÑO DE PUBLICACIÓN"
        ANYO.TextAlign = HorizontalAlignment.Center
        ANYO.Width = 170
        ' 
        ' GENERO
        ' 
        GENERO.DisplayIndex = 3
        GENERO.Text = "GÉNERO"
        GENERO.TextAlign = HorizontalAlignment.Center
        GENERO.Width = 167
        ' 
        ' Listado
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(924, 503)
        Controls.Add(lstVwPeliculas)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Listado"
        Text = "Listado"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstVwPeliculas As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents TITULO As ColumnHeader
    Friend WithEvents DIRECTOR As ColumnHeader
    Friend WithEvents CALIFICACION As ColumnHeader
    Friend WithEvents ANYO As ColumnHeader
    Friend WithEvents GENERO As ColumnHeader
End Class

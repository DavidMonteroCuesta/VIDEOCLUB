<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoPeliculas
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
        GENERO = New ColumnHeader()
        CALIFICACION = New ColumnHeader()
        ANYO = New ColumnHeader()
        btnFinal = New Button()
        lblIDListado = New Label()
        txtBxIDListado = New TextBox()
        lblTituloListado = New Label()
        txtBxTituloListado = New TextBox()
        lblGeneroListado = New Label()
        txtBxGeneroListado = New TextBox()
        SuspendLayout()
        ' 
        ' lstVwPeliculas
        ' 
        lstVwPeliculas.Columns.AddRange(New ColumnHeader() {ID, TITULO, DIRECTOR, GENERO, CALIFICACION, ANYO})
        lstVwPeliculas.Location = New Point(12, 58)
        lstVwPeliculas.Name = "lstVwPeliculas"
        lstVwPeliculas.Size = New Size(900, 353)
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
        ' GENERO
        ' 
        GENERO.Text = "GÉNERO"
        GENERO.TextAlign = HorizontalAlignment.Center
        GENERO.Width = 167
        ' 
        ' CALIFICACION
        ' 
        CALIFICACION.Text = "CALIFICACIÓN"
        CALIFICACION.TextAlign = HorizontalAlignment.Center
        CALIFICACION.Width = 110
        ' 
        ' ANYO
        ' 
        ANYO.Text = "AÑO DE PUBLICACIÓN"
        ANYO.TextAlign = HorizontalAlignment.Center
        ANYO.Width = 170
        ' 
        ' btnFinal
        ' 
        btnFinal.Font = New Font("Segoe UI Light", 17.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFinal.Location = New Point(813, 11)
        btnFinal.Margin = New Padding(3, 2, 3, 2)
        btnFinal.Name = "btnFinal"
        btnFinal.Size = New Size(99, 40)
        btnFinal.TabIndex = 22
        btnFinal.Text = "⇆"
        btnFinal.UseVisualStyleBackColor = True
        ' 
        ' lblIDListado
        ' 
        lblIDListado.AutoSize = True
        lblIDListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDListado.Location = New Point(25, 24)
        lblIDListado.Name = "lblIDListado"
        lblIDListado.Size = New Size(26, 17)
        lblIDListado.TabIndex = 25
        lblIDListado.Text = "ID:"
        lblIDListado.UseWaitCursor = True
        ' 
        ' txtBxIDListado
        ' 
        txtBxIDListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBxIDListado.Location = New Point(57, 21)
        txtBxIDListado.Margin = New Padding(3, 2, 3, 2)
        txtBxIDListado.Name = "txtBxIDListado"
        txtBxIDListado.Size = New Size(129, 25)
        txtBxIDListado.TabIndex = 24
        txtBxIDListado.UseWaitCursor = True
        ' 
        ' lblTituloListado
        ' 
        lblTituloListado.AutoSize = True
        lblTituloListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloListado.Location = New Point(208, 24)
        lblTituloListado.Name = "lblTituloListado"
        lblTituloListado.Size = New Size(58, 17)
        lblTituloListado.TabIndex = 27
        lblTituloListado.Text = "TÍTULO:"
        lblTituloListado.UseWaitCursor = True
        ' 
        ' txtBxTituloListado
        ' 
        txtBxTituloListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBxTituloListado.Location = New Point(278, 21)
        txtBxTituloListado.Margin = New Padding(3, 2, 3, 2)
        txtBxTituloListado.Name = "txtBxTituloListado"
        txtBxTituloListado.Size = New Size(129, 25)
        txtBxTituloListado.TabIndex = 26
        txtBxTituloListado.UseWaitCursor = True
        ' 
        ' lblGeneroListado
        ' 
        lblGeneroListado.AutoSize = True
        lblGeneroListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGeneroListado.Location = New Point(424, 24)
        lblGeneroListado.Name = "lblGeneroListado"
        lblGeneroListado.Size = New Size(63, 17)
        lblGeneroListado.TabIndex = 29
        lblGeneroListado.Text = "GÉNERO:"
        lblGeneroListado.UseWaitCursor = True
        ' 
        ' txtBxGeneroListado
        ' 
        txtBxGeneroListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBxGeneroListado.Location = New Point(501, 22)
        txtBxGeneroListado.Margin = New Padding(3, 2, 3, 2)
        txtBxGeneroListado.Name = "txtBxGeneroListado"
        txtBxGeneroListado.Size = New Size(129, 25)
        txtBxGeneroListado.TabIndex = 28
        txtBxGeneroListado.UseWaitCursor = True
        ' 
        ' ListadoPeliculas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(926, 423)
        Controls.Add(lblGeneroListado)
        Controls.Add(txtBxGeneroListado)
        Controls.Add(lblTituloListado)
        Controls.Add(txtBxTituloListado)
        Controls.Add(lblIDListado)
        Controls.Add(txtBxIDListado)
        Controls.Add(btnFinal)
        Controls.Add(lstVwPeliculas)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "ListadoPeliculas"
        Text = "Listado de películas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstVwPeliculas As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents TITULO As ColumnHeader
    Friend WithEvents DIRECTOR As ColumnHeader
    Friend WithEvents CALIFICACION As ColumnHeader
    Friend WithEvents ANYO As ColumnHeader
    Friend WithEvents GENERO As ColumnHeader
    Friend WithEvents btnFinal As Button
    Friend WithEvents lblIDListado As Label
    Friend WithEvents txtBxIDListado As TextBox
    Friend WithEvents lblTituloListado As Label
    Friend WithEvents txtBxTituloListado As TextBox
    Friend WithEvents lblGeneroListado As Label
    Friend WithEvents txtBxGeneroListado As TextBox
End Class

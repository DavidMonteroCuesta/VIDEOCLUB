<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogo
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogo))
        ImageList1 = New ImageList(components)
        Label1 = New Label()
        btnAgregar = New Button()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "ICONO AMARILLO.png")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ImageIndex = 0
        Label1.ImageList = ImageList1
        Label1.Location = New Point(54, 23)
        Label1.MinimumSize = New Size(262, 225)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 225)
        Label1.TabIndex = 0
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAgregar.Location = New Point(101, 262)
        btnAgregar.Margin = New Padding(3, 2, 3, 2)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(172, 37)
        btnAgregar.TabIndex = 18
        btnAgregar.Text = "COMENZAR"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' FormLogo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 324)
        Controls.Add(btnAgregar)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormLogo"
        Text = "FormLogo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
End Class

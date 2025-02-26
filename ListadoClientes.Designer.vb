<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoClientes
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
        lblApellido1Listado = New Label()
        txtBxApellido1Listado = New TextBox()
        lblNombreListado = New Label()
        txtBxNombreListado = New TextBox()
        lblIDListado = New Label()
        txtBxIDListado = New TextBox()
        btnCambioListado = New Button()
        lstVwClientes = New ListView()
        ID = New ColumnHeader()
        NOMBRE = New ColumnHeader()
        APELLIDO1 = New ColumnHeader()
        APELLIDO2 = New ColumnHeader()
        DNI = New ColumnHeader()
        CONTACTO = New ColumnHeader()
        EMAIL = New ColumnHeader()
        SOCIO = New ColumnHeader()
        lblApellido2Listado = New Label()
        txtBxApellido2Listado = New TextBox()
        SuspendLayout()
        ' 
        ' lblApellido1Listado
        ' 
        lblApellido1Listado.AutoSize = True
        lblApellido1Listado.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblApellido1Listado.Location = New Point(342, 19)
        lblApellido1Listado.Name = "lblApellido1Listado"
        lblApellido1Listado.Size = New Size(87, 17)
        lblApellido1Listado.TabIndex = 37
        lblApellido1Listado.Text = "1º APELLIDO"
        lblApellido1Listado.UseWaitCursor = True
        ' 
        ' txtBxApellido1Listado
        ' 
        txtBxApellido1Listado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBxApellido1Listado.Location = New Point(435, 16)
        txtBxApellido1Listado.Margin = New Padding(3, 2, 3, 2)
        txtBxApellido1Listado.Name = "txtBxApellido1Listado"
        txtBxApellido1Listado.Size = New Size(129, 25)
        txtBxApellido1Listado.TabIndex = 36
        txtBxApellido1Listado.UseWaitCursor = True
        ' 
        ' lblNombreListado
        ' 
        lblNombreListado.AutoSize = True
        lblNombreListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombreListado.Location = New Point(129, 21)
        lblNombreListado.Name = "lblNombreListado"
        lblNombreListado.Size = New Size(67, 17)
        lblNombreListado.TabIndex = 35
        lblNombreListado.Text = "NOMBRE:"
        lblNombreListado.UseWaitCursor = True
        ' 
        ' txtBxNombreListado
        ' 
        txtBxNombreListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBxNombreListado.Location = New Point(199, 18)
        txtBxNombreListado.Margin = New Padding(3, 2, 3, 2)
        txtBxNombreListado.Name = "txtBxNombreListado"
        txtBxNombreListado.Size = New Size(129, 25)
        txtBxNombreListado.TabIndex = 34
        txtBxNombreListado.UseWaitCursor = True
        ' 
        ' lblIDListado
        ' 
        lblIDListado.AutoSize = True
        lblIDListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDListado.Location = New Point(25, 21)
        lblIDListado.Name = "lblIDListado"
        lblIDListado.Size = New Size(26, 17)
        lblIDListado.TabIndex = 33
        lblIDListado.Text = "ID:"
        lblIDListado.UseWaitCursor = True
        ' 
        ' txtBxIDListado
        ' 
        txtBxIDListado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBxIDListado.Location = New Point(57, 18)
        txtBxIDListado.Margin = New Padding(3, 2, 3, 2)
        txtBxIDListado.Name = "txtBxIDListado"
        txtBxIDListado.Size = New Size(56, 25)
        txtBxIDListado.TabIndex = 32
        txtBxIDListado.UseWaitCursor = True
        ' 
        ' btnCambioListado
        ' 
        btnCambioListado.Font = New Font("Segoe UI Light", 17.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCambioListado.Location = New Point(913, 10)
        btnCambioListado.Margin = New Padding(3, 2, 3, 2)
        btnCambioListado.Name = "btnCambioListado"
        btnCambioListado.Size = New Size(99, 40)
        btnCambioListado.TabIndex = 31
        btnCambioListado.Text = "⇆"
        btnCambioListado.UseVisualStyleBackColor = True
        ' 
        ' lstVwClientes
        ' 
        lstVwClientes.Columns.AddRange(New ColumnHeader() {ID, NOMBRE, APELLIDO1, APELLIDO2, DNI, CONTACTO, EMAIL, SOCIO})
        lstVwClientes.Location = New Point(12, 55)
        lstVwClientes.Name = "lstVwClientes"
        lstVwClientes.Size = New Size(1009, 353)
        lstVwClientes.TabIndex = 30
        lstVwClientes.UseCompatibleStateImageBehavior = False
        lstVwClientes.View = View.Details
        ' 
        ' ID
        ' 
        ID.Text = "     ID"
        ' 
        ' NOMBRE
        ' 
        NOMBRE.Text = "NOMBRE"
        NOMBRE.TextAlign = HorizontalAlignment.Center
        NOMBRE.Width = 165
        ' 
        ' APELLIDO1
        ' 
        APELLIDO1.Text = "PRIMER APELLIDO"
        APELLIDO1.TextAlign = HorizontalAlignment.Center
        APELLIDO1.Width = 165
        ' 
        ' APELLIDO2
        ' 
        APELLIDO2.Text = "SEGUNDO APELLIDO"
        APELLIDO2.TextAlign = HorizontalAlignment.Center
        APELLIDO2.Width = 165
        ' 
        ' DNI
        ' 
        DNI.Text = "DNI"
        DNI.TextAlign = HorizontalAlignment.Center
        DNI.Width = 110
        ' 
        ' CONTACTO
        ' 
        CONTACTO.Text = "CONTACTO"
        CONTACTO.TextAlign = HorizontalAlignment.Center
        CONTACTO.Width = 100
        ' 
        ' EMAIL
        ' 
        EMAIL.Text = "EMAIL"
        EMAIL.TextAlign = HorizontalAlignment.Center
        EMAIL.Width = 180
        ' 
        ' SOCIO
        ' 
        SOCIO.Text = "SOCIO"
        SOCIO.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblApellido2Listado
        ' 
        lblApellido2Listado.AutoSize = True
        lblApellido2Listado.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblApellido2Listado.Location = New Point(577, 18)
        lblApellido2Listado.Name = "lblApellido2Listado"
        lblApellido2Listado.Size = New Size(87, 17)
        lblApellido2Listado.TabIndex = 39
        lblApellido2Listado.Text = "2º APELLIDO"
        lblApellido2Listado.UseWaitCursor = True
        ' 
        ' txtBxApellido2Listado
        ' 
        txtBxApellido2Listado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBxApellido2Listado.Location = New Point(670, 16)
        txtBxApellido2Listado.Margin = New Padding(3, 2, 3, 2)
        txtBxApellido2Listado.Name = "txtBxApellido2Listado"
        txtBxApellido2Listado.Size = New Size(129, 25)
        txtBxApellido2Listado.TabIndex = 38
        txtBxApellido2Listado.UseWaitCursor = True
        ' 
        ' ListadoClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(1037, 424)
        Controls.Add(lblApellido2Listado)
        Controls.Add(txtBxApellido2Listado)
        Controls.Add(lblApellido1Listado)
        Controls.Add(txtBxApellido1Listado)
        Controls.Add(lblNombreListado)
        Controls.Add(txtBxNombreListado)
        Controls.Add(lblIDListado)
        Controls.Add(txtBxIDListado)
        Controls.Add(btnCambioListado)
        Controls.Add(lstVwClientes)
        Name = "ListadoClientes"
        Text = "ListadoClientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblApellido1Listado As Label
    Friend WithEvents txtBxApellido1Listado As TextBox
    Friend WithEvents lblNombreListado As Label
    Friend WithEvents txtBxNombreListado As TextBox
    Friend WithEvents lblIDListado As Label
    Friend WithEvents txtBxIDListado As TextBox
    Friend WithEvents btnCambioListado As Button
    Friend WithEvents lstVwClientes As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents NOMBRE As ColumnHeader
    Friend WithEvents APELLIDO1 As ColumnHeader
    Friend WithEvents APELLIDO2 As ColumnHeader
    Friend WithEvents NUM_CONTACTO As ColumnHeader
    Friend WithEvents EMAIL As ColumnHeader
    Friend WithEvents SOCIO As ColumnHeader
    Friend WithEvents lblApellido2Listado As Label
    Friend WithEvents txtBxApellido2Listado As TextBox
    Friend WithEvents DNI As ColumnHeader
    Friend WithEvents CONTACTO As ColumnHeader
End Class

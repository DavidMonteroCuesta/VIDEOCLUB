<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        AgregarToolStripMenuItem = New ToolStripMenuItem()
        PelículasToolStripMenuItem = New ToolStripMenuItem()
        AgregarToolStripMenuItem2 = New ToolStripMenuItem()
        EliminarToolStripMenuItem1 = New ToolStripMenuItem()
        EditarToolStripMenuItem1 = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AgregarToolStripMenuItem1 = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        txtBoxPeliculaID = New TextBox()
        txtBxPeliculaTitulo = New TextBox()
        txtBxPeliculaDirector = New TextBox()
        txtBxPeliculaCalificacion = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBoxPeliculas = New GroupBox()
        cmbBoxPeliculaAnyo = New ComboBox()
        cmbBxPeliculaGenero = New ComboBox()
        btnAgregar = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        GroupBoxClientes = New GroupBox()
        cmbBxClienteSocio = New ComboBox()
        Label14 = New Label()
        txtBxClienteCorreo = New TextBox()
        txtBxClienteDNI = New TextBox()
        Label13 = New Label()
        txtBxClienteApellido2 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtBxClienteID = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtBxClienteNombre = New TextBox()
        txtBxClienteNumTel = New TextBox()
        Label12 = New Label()
        txtBxClienteApellido1 = New TextBox()
        MenuStrip1.SuspendLayout()
        GroupBoxPeliculas.SuspendLayout()
        GroupBoxClientes.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AgregarToolStripMenuItem, AcercaDeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(860, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AgregarToolStripMenuItem
        ' 
        AgregarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PelículasToolStripMenuItem, ClientesToolStripMenuItem})
        AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        AgregarToolStripMenuItem.Size = New Size(67, 20)
        AgregarToolStripMenuItem.Text = "Acciones"
        ' 
        ' PelículasToolStripMenuItem
        ' 
        PelículasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarToolStripMenuItem2, EliminarToolStripMenuItem1, EditarToolStripMenuItem1})
        PelículasToolStripMenuItem.Name = "PelículasToolStripMenuItem"
        PelículasToolStripMenuItem.Size = New Size(120, 22)
        PelículasToolStripMenuItem.Text = "Películas"
        ' 
        ' AgregarToolStripMenuItem2
        ' 
        AgregarToolStripMenuItem2.Name = "AgregarToolStripMenuItem2"
        AgregarToolStripMenuItem2.Size = New Size(117, 22)
        AgregarToolStripMenuItem2.Text = "Agregar"
        ' 
        ' EliminarToolStripMenuItem1
        ' 
        EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        EliminarToolStripMenuItem1.Size = New Size(117, 22)
        EliminarToolStripMenuItem1.Text = "Eliminar"
        ' 
        ' EditarToolStripMenuItem1
        ' 
        EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        EditarToolStripMenuItem1.Size = New Size(117, 22)
        EditarToolStripMenuItem1.Text = "Editar"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarToolStripMenuItem1, EliminarToolStripMenuItem, EditarToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(120, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' AgregarToolStripMenuItem1
        ' 
        AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        AgregarToolStripMenuItem1.Size = New Size(117, 22)
        AgregarToolStripMenuItem1.Text = "Agregar"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(117, 22)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(117, 22)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(71, 20)
        AcercaDeToolStripMenuItem.Text = "Acerca de"
        ' 
        ' txtBoxPeliculaID
        ' 
        txtBoxPeliculaID.Location = New Point(18, 47)
        txtBoxPeliculaID.Margin = New Padding(3, 2, 3, 2)
        txtBoxPeliculaID.Name = "txtBoxPeliculaID"
        txtBoxPeliculaID.Size = New Size(129, 23)
        txtBoxPeliculaID.TabIndex = 1
        txtBoxPeliculaID.UseWaitCursor = True
        ' 
        ' txtBxPeliculaTitulo
        ' 
        txtBxPeliculaTitulo.Location = New Point(18, 105)
        txtBxPeliculaTitulo.Margin = New Padding(3, 2, 3, 2)
        txtBxPeliculaTitulo.Name = "txtBxPeliculaTitulo"
        txtBxPeliculaTitulo.Size = New Size(218, 23)
        txtBxPeliculaTitulo.TabIndex = 2
        txtBxPeliculaTitulo.UseWaitCursor = True
        ' 
        ' txtBxPeliculaDirector
        ' 
        txtBxPeliculaDirector.Location = New Point(18, 165)
        txtBxPeliculaDirector.Margin = New Padding(3, 2, 3, 2)
        txtBxPeliculaDirector.Name = "txtBxPeliculaDirector"
        txtBxPeliculaDirector.Size = New Size(218, 23)
        txtBxPeliculaDirector.TabIndex = 3
        txtBxPeliculaDirector.UseWaitCursor = True
        ' 
        ' txtBxPeliculaCalificacion
        ' 
        txtBxPeliculaCalificacion.Location = New Point(18, 276)
        txtBxPeliculaCalificacion.Margin = New Padding(3, 2, 3, 2)
        txtBxPeliculaCalificacion.Name = "txtBxPeliculaCalificacion"
        txtBxPeliculaCalificacion.Size = New Size(218, 23)
        txtBxPeliculaCalificacion.TabIndex = 8
        txtBxPeliculaCalificacion.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 10
        Label1.Text = "Número de registro"
        Label1.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 11
        Label2.Text = "Título"
        Label2.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 12
        Label3.Text = "Director"
        Label3.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 13
        Label4.Text = "Género"
        Label4.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 14
        Label5.Text = "Calificación"
        Label5.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 319)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 15)
        Label6.TabIndex = 15
        Label6.Text = "Año de publicación"
        Label6.UseWaitCursor = True
        ' 
        ' GroupBoxPeliculas
        ' 
        GroupBoxPeliculas.Controls.Add(cmbBoxPeliculaAnyo)
        GroupBoxPeliculas.Controls.Add(cmbBxPeliculaGenero)
        GroupBoxPeliculas.Controls.Add(Label1)
        GroupBoxPeliculas.Controls.Add(Label6)
        GroupBoxPeliculas.Controls.Add(txtBoxPeliculaID)
        GroupBoxPeliculas.Controls.Add(Label5)
        GroupBoxPeliculas.Controls.Add(Label2)
        GroupBoxPeliculas.Controls.Add(Label4)
        GroupBoxPeliculas.Controls.Add(txtBxPeliculaTitulo)
        GroupBoxPeliculas.Controls.Add(txtBxPeliculaCalificacion)
        GroupBoxPeliculas.Controls.Add(Label3)
        GroupBoxPeliculas.Controls.Add(txtBxPeliculaDirector)
        GroupBoxPeliculas.Location = New Point(35, 51)
        GroupBoxPeliculas.Margin = New Padding(3, 2, 3, 2)
        GroupBoxPeliculas.Name = "GroupBoxPeliculas"
        GroupBoxPeliculas.Padding = New Padding(3, 2, 3, 2)
        GroupBoxPeliculas.Size = New Size(256, 376)
        GroupBoxPeliculas.TabIndex = 16
        GroupBoxPeliculas.TabStop = False
        GroupBoxPeliculas.Text = "Características de la película"
        GroupBoxPeliculas.UseWaitCursor = True
        ' 
        ' cmbBoxPeliculaAnyo
        ' 
        cmbBoxPeliculaAnyo.DropDownHeight = 200
        cmbBoxPeliculaAnyo.FormattingEnabled = True
        cmbBoxPeliculaAnyo.IntegralHeight = False
        cmbBoxPeliculaAnyo.Items.AddRange(New Object() {"1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        cmbBoxPeliculaAnyo.Location = New Point(18, 336)
        cmbBoxPeliculaAnyo.Margin = New Padding(3, 2, 3, 2)
        cmbBoxPeliculaAnyo.Name = "cmbBoxPeliculaAnyo"
        cmbBoxPeliculaAnyo.Size = New Size(98, 23)
        cmbBoxPeliculaAnyo.TabIndex = 17
        cmbBoxPeliculaAnyo.UseWaitCursor = True
        ' 
        ' cmbBxPeliculaGenero
        ' 
        cmbBxPeliculaGenero.DropDownHeight = 200
        cmbBxPeliculaGenero.FormattingEnabled = True
        cmbBxPeliculaGenero.IntegralHeight = False
        cmbBxPeliculaGenero.Items.AddRange(New Object() {"Acción  ", "Aventura  ", "Animación  ", "Ciencia ficción  ", "Comedia  ", "Crimen  ", "Documental  ", "Drama  ", "Fantasía  ", "Histórica  ", "Musical  ", "Misterio  ", "Romance  ", "Suspenso  ", "Terror  ", "Bélica  ", "Biografía  ", "Deporte  ", "Familia  ", "Western  "})
        cmbBxPeliculaGenero.Location = New Point(18, 218)
        cmbBxPeliculaGenero.Margin = New Padding(3, 2, 3, 2)
        cmbBxPeliculaGenero.Name = "cmbBxPeliculaGenero"
        cmbBxPeliculaGenero.Size = New Size(218, 23)
        cmbBxPeliculaGenero.TabIndex = 16
        cmbBxPeliculaGenero.UseWaitCursor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAgregar.Location = New Point(324, 354)
        btnAgregar.Margin = New Padding(3, 2, 3, 2)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(155, 56)
        btnAgregar.TabIndex = 17
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(485, 354)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(150, 56)
        btnEliminar.TabIndex = 18
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnModificar.Location = New Point(641, 354)
        btnModificar.Margin = New Padding(3, 2, 3, 2)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(169, 56)
        btnModificar.TabIndex = 19
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxClientes
        ' 
        GroupBoxClientes.Controls.Add(cmbBxClienteSocio)
        GroupBoxClientes.Controls.Add(Label14)
        GroupBoxClientes.Controls.Add(txtBxClienteCorreo)
        GroupBoxClientes.Controls.Add(txtBxClienteDNI)
        GroupBoxClientes.Controls.Add(Label13)
        GroupBoxClientes.Controls.Add(txtBxClienteApellido2)
        GroupBoxClientes.Controls.Add(Label7)
        GroupBoxClientes.Controls.Add(Label8)
        GroupBoxClientes.Controls.Add(txtBxClienteID)
        GroupBoxClientes.Controls.Add(Label9)
        GroupBoxClientes.Controls.Add(Label10)
        GroupBoxClientes.Controls.Add(Label11)
        GroupBoxClientes.Controls.Add(txtBxClienteNombre)
        GroupBoxClientes.Controls.Add(txtBxClienteNumTel)
        GroupBoxClientes.Controls.Add(Label12)
        GroupBoxClientes.Controls.Add(txtBxClienteApellido1)
        GroupBoxClientes.Location = New Point(306, 51)
        GroupBoxClientes.Margin = New Padding(3, 2, 3, 2)
        GroupBoxClientes.Name = "GroupBoxClientes"
        GroupBoxClientes.Padding = New Padding(3, 2, 3, 2)
        GroupBoxClientes.Size = New Size(519, 274)
        GroupBoxClientes.TabIndex = 18
        GroupBoxClientes.TabStop = False
        GroupBoxClientes.Text = "Característcas del cliente"
        GroupBoxClientes.UseWaitCursor = True
        ' 
        ' cmbBxClienteSocio
        ' 
        cmbBxClienteSocio.DropDownHeight = 200
        cmbBxClienteSocio.FormattingEnabled = True
        cmbBxClienteSocio.IntegralHeight = False
        cmbBxClienteSocio.Items.AddRange(New Object() {"SI", "NO"})
        cmbBxClienteSocio.Location = New Point(274, 218)
        cmbBxClienteSocio.Margin = New Padding(3, 2, 3, 2)
        cmbBxClienteSocio.Name = "cmbBxClienteSocio"
        cmbBxClienteSocio.Size = New Size(77, 23)
        cmbBxClienteSocio.TabIndex = 18
        cmbBxClienteSocio.UseWaitCursor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(274, 200)
        Label14.Name = "Label14"
        Label14.Size = New Size(36, 15)
        Label14.TabIndex = 23
        Label14.Text = "Socio"
        Label14.UseWaitCursor = True
        ' 
        ' txtBxClienteCorreo
        ' 
        txtBxClienteCorreo.Location = New Point(274, 165)
        txtBxClienteCorreo.Margin = New Padding(3, 2, 3, 2)
        txtBxClienteCorreo.Name = "txtBxClienteCorreo"
        txtBxClienteCorreo.Size = New Size(218, 23)
        txtBxClienteCorreo.TabIndex = 21
        txtBxClienteCorreo.UseWaitCursor = True
        ' 
        ' txtBxClienteDNI
        ' 
        txtBxClienteDNI.Location = New Point(274, 47)
        txtBxClienteDNI.Margin = New Padding(3, 2, 3, 2)
        txtBxClienteDNI.Name = "txtBxClienteDNI"
        txtBxClienteDNI.Size = New Size(218, 23)
        txtBxClienteDNI.TabIndex = 20
        txtBxClienteDNI.UseWaitCursor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(18, 200)
        Label13.Name = "Label13"
        Label13.Size = New Size(99, 15)
        Label13.TabIndex = 19
        Label13.Text = "Segundo apellido"
        Label13.UseWaitCursor = True
        ' 
        ' txtBxClienteApellido2
        ' 
        txtBxClienteApellido2.Location = New Point(18, 218)
        txtBxClienteApellido2.Margin = New Padding(3, 2, 3, 2)
        txtBxClienteApellido2.Name = "txtBxClienteApellido2"
        txtBxClienteApellido2.Size = New Size(218, 23)
        txtBxClienteApellido2.TabIndex = 18
        txtBxClienteApellido2.UseWaitCursor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 15)
        Label7.TabIndex = 10
        Label7.Text = "Número de registro"
        Label7.UseWaitCursor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(274, 147)
        Label8.Name = "Label8"
        Label8.Size = New Size(172, 15)
        Label8.TabIndex = 15
        Label8.Text = "Dirección de correo electrónico"
        Label8.UseWaitCursor = True
        ' 
        ' txtBxClienteID
        ' 
        txtBxClienteID.Location = New Point(18, 47)
        txtBxClienteID.Margin = New Padding(3, 2, 3, 2)
        txtBxClienteID.Name = "txtBxClienteID"
        txtBxClienteID.Size = New Size(129, 23)
        txtBxClienteID.TabIndex = 1
        txtBxClienteID.UseWaitCursor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(274, 87)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 15)
        Label9.TabIndex = 14
        Label9.Text = "Número de contacto"
        Label9.UseWaitCursor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(18, 87)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 15)
        Label10.TabIndex = 11
        Label10.Text = "Nombre"
        Label10.UseWaitCursor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(274, 29)
        Label11.Name = "Label11"
        Label11.Size = New Size(27, 15)
        Label11.TabIndex = 13
        Label11.Text = "DNI"
        Label11.UseWaitCursor = True
        ' 
        ' txtBxClienteNombre
        ' 
        txtBxClienteNombre.Location = New Point(18, 105)
        txtBxClienteNombre.Margin = New Padding(3, 2, 3, 2)
        txtBxClienteNombre.Name = "txtBxClienteNombre"
        txtBxClienteNombre.Size = New Size(218, 23)
        txtBxClienteNombre.TabIndex = 2
        txtBxClienteNombre.UseWaitCursor = True
        ' 
        ' txtBxClienteNumTel
        ' 
        txtBxClienteNumTel.Location = New Point(274, 105)
        txtBxClienteNumTel.Margin = New Padding(3, 2, 3, 2)
        txtBxClienteNumTel.Name = "txtBxClienteNumTel"
        txtBxClienteNumTel.Size = New Size(218, 23)
        txtBxClienteNumTel.TabIndex = 8
        txtBxClienteNumTel.UseWaitCursor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(18, 147)
        Label12.Name = "Label12"
        Label12.Size = New Size(87, 15)
        Label12.TabIndex = 12
        Label12.Text = "Primer apellido"
        Label12.UseWaitCursor = True
        ' 
        ' txtBxClienteApellido1
        ' 
        txtBxClienteApellido1.Location = New Point(18, 165)
        txtBxClienteApellido1.Margin = New Padding(3, 2, 3, 2)
        txtBxClienteApellido1.Name = "txtBxClienteApellido1"
        txtBxClienteApellido1.Size = New Size(218, 23)
        txtBxClienteApellido1.TabIndex = 3
        txtBxClienteApellido1.UseWaitCursor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(860, 442)
        Controls.Add(GroupBoxClientes)
        Controls.Add(btnModificar)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        Controls.Add(GroupBoxPeliculas)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "INICIO"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBoxPeliculas.ResumeLayout(False)
        GroupBoxPeliculas.PerformLayout()
        GroupBoxClientes.ResumeLayout(False)
        GroupBoxClientes.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtBoxPeliculaID As TextBox
    Friend WithEvents txtBxPeliculaTitulo As TextBox
    Friend WithEvents txtBxPeliculaDirector As TextBox
    Friend WithEvents txtBxPeliculaCalificacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBoxPeliculas As GroupBox
    Friend WithEvents cmbBxPeliculaGenero As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbBoxPeliculaAnyo As ComboBox
    Friend WithEvents PelículasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBxClienteApellido2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBxClienteID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBxClienteNombre As TextBox
    Friend WithEvents txtBxClienteNumTel As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBxClienteApellido1 As TextBox
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbBxClienteSocio As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBxClienteCorreo As TextBox
    Friend WithEvents txtBxClienteDNI As TextBox

End Class

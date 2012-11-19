<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capacitadores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim IdcapacitadorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim IdmovLabel As System.Windows.Forms.Label
        Dim IdpaisLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim Fecha_nacLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(capacitadores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Fecha_nacDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.CapacitadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtset = New memorias.dtset
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SexoComboBox = New System.Windows.Forms.ComboBox
        Me.IdcapacitadorTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox
        Me.CedulaTextBox = New System.Windows.Forms.TextBox
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox
        Me.CelularTextBox = New System.Windows.Forms.TextBox
        Me.DireccionTextBox = New System.Windows.Forms.TextBox
        Me.IdmovTextBox = New System.Windows.Forms.TextBox
        Me.IdpaisTextBox = New System.Windows.Forms.TextBox
        Me.CapacitadoresTableAdapter = New memorias.dtsetTableAdapters.capacitadoresTableAdapter
        Me.CapacitadoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.CapacitadoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        IdcapacitadorLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        ApellidoLabel = New System.Windows.Forms.Label
        CedulaLabel = New System.Windows.Forms.Label
        TelefonoLabel = New System.Windows.Forms.Label
        CelularLabel = New System.Windows.Forms.Label
        DireccionLabel = New System.Windows.Forms.Label
        IdmovLabel = New System.Windows.Forms.Label
        IdpaisLabel = New System.Windows.Forms.Label
        SexoLabel = New System.Windows.Forms.Label
        Fecha_nacLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.CapacitadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CapacitadoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CapacitadoresBindingNavigator.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdcapacitadorLabel
        '
        IdcapacitadorLabel.AutoSize = True
        IdcapacitadorLabel.Location = New System.Drawing.Point(34, 25)
        IdcapacitadorLabel.Name = "IdcapacitadorLabel"
        IdcapacitadorLabel.Size = New System.Drawing.Size(43, 13)
        IdcapacitadorLabel.TabIndex = 0
        IdcapacitadorLabel.Text = "Codigo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(30, 51)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(30, 77)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 4
        ApellidoLabel.Text = "Apellido:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(34, 129)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(43, 13)
        CedulaLabel.TabIndex = 8
        CedulaLabel.Text = "Cedula:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(315, 129)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "Telefono:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(325, 155)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 12
        CelularLabel.Text = "Celular:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(40, 207)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 16
        DireccionLabel.Text = "direccion:"
        '
        'IdmovLabel
        '
        IdmovLabel.AutoSize = True
        IdmovLabel.Location = New System.Drawing.Point(51, 181)
        IdmovLabel.Name = "IdmovLabel"
        IdmovLabel.Size = New System.Drawing.Size(38, 13)
        IdmovLabel.TabIndex = 18
        IdmovLabel.Text = "idmov:"
        '
        'IdpaisLabel
        '
        IdpaisLabel.AutoSize = True
        IdpaisLabel.Location = New System.Drawing.Point(40, 155)
        IdpaisLabel.Name = "IdpaisLabel"
        IdpaisLabel.Size = New System.Drawing.Size(37, 13)
        IdpaisLabel.TabIndex = 20
        IdpaisLabel.Text = "idpais:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(335, 103)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(32, 13)
        SexoLabel.TabIndex = 22
        SexoLabel.Text = "sexo:"
        '
        'Fecha_nacLabel
        '
        Fecha_nacLabel.AutoSize = True
        Fecha_nacLabel.Location = New System.Drawing.Point(35, 102)
        Fecha_nacLabel.Name = "Fecha_nacLabel"
        Fecha_nacLabel.Size = New System.Drawing.Size(58, 13)
        Fecha_nacLabel.TabIndex = 27
        Fecha_nacLabel.Text = "fecha nac:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Fecha_nacLabel)
        Me.GroupBox1.Controls.Add(Me.Fecha_nacDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(SexoLabel)
        Me.GroupBox1.Controls.Add(Me.SexoComboBox)
        Me.GroupBox1.Controls.Add(IdcapacitadorLabel)
        Me.GroupBox1.Controls.Add(Me.IdcapacitadorTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(ApellidoLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox1.Controls.Add(CedulaLabel)
        Me.GroupBox1.Controls.Add(Me.CedulaTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(CelularLabel)
        Me.GroupBox1.Controls.Add(Me.CelularTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(IdmovLabel)
        Me.GroupBox1.Controls.Add(Me.IdmovTextBox)
        Me.GroupBox1.Controls.Add(IdpaisLabel)
        Me.GroupBox1.Controls.Add(Me.IdpaisTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 273)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'Fecha_nacDateTimePicker
        '
        Me.Fecha_nacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CapacitadoresBindingSource, "fecha_nac", True))
        Me.Fecha_nacDateTimePicker.Location = New System.Drawing.Point(99, 98)
        Me.Fecha_nacDateTimePicker.Name = "Fecha_nacDateTimePicker"
        Me.Fecha_nacDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_nacDateTimePicker.TabIndex = 28
        '
        'CapacitadoresBindingSource
        '
        Me.CapacitadoresBindingSource.DataMember = "capacitadores"
        Me.CapacitadoresBindingSource.DataSource = Me.Dtset
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(144, 178)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 152)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 24
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "sexo", True))
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Items.AddRange(New Object() {"F", "M"})
        Me.SexoComboBox.Location = New System.Drawing.Point(373, 99)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(151, 21)
        Me.SexoComboBox.TabIndex = 23
        '
        'IdcapacitadorTextBox
        '
        Me.IdcapacitadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "idcapacitador", True))
        Me.IdcapacitadorTextBox.Location = New System.Drawing.Point(99, 22)
        Me.IdcapacitadorTextBox.Name = "IdcapacitadorTextBox"
        Me.IdcapacitadorTextBox.ReadOnly = True
        Me.IdcapacitadorTextBox.Size = New System.Drawing.Size(117, 20)
        Me.IdcapacitadorTextBox.TabIndex = 1
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(99, 48)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(303, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(99, 74)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(303, 20)
        Me.ApellidoTextBox.TabIndex = 5
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(99, 126)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(165, 20)
        Me.CedulaTextBox.TabIndex = 9
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(373, 126)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(151, 20)
        Me.TelefonoTextBox.TabIndex = 11
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(373, 152)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(151, 20)
        Me.CelularTextBox.TabIndex = 13
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(99, 204)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(425, 63)
        Me.DireccionTextBox.TabIndex = 17
        '
        'IdmovTextBox
        '
        Me.IdmovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "idmov", True))
        Me.IdmovTextBox.Location = New System.Drawing.Point(99, 178)
        Me.IdmovTextBox.Name = "IdmovTextBox"
        Me.IdmovTextBox.ReadOnly = True
        Me.IdmovTextBox.Size = New System.Drawing.Size(39, 20)
        Me.IdmovTextBox.TabIndex = 19
        '
        'IdpaisTextBox
        '
        Me.IdpaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CapacitadoresBindingSource, "idpais", True))
        Me.IdpaisTextBox.Location = New System.Drawing.Point(99, 152)
        Me.IdpaisTextBox.Name = "IdpaisTextBox"
        Me.IdpaisTextBox.ReadOnly = True
        Me.IdpaisTextBox.Size = New System.Drawing.Size(39, 20)
        Me.IdpaisTextBox.TabIndex = 21
        '
        'CapacitadoresTableAdapter
        '
        Me.CapacitadoresTableAdapter.ClearBeforeFill = True
        '
        'CapacitadoresBindingNavigator
        '
        Me.CapacitadoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CapacitadoresBindingNavigator.BindingSource = Me.CapacitadoresBindingSource
        Me.CapacitadoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CapacitadoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CapacitadoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CapacitadoresBindingNavigatorSaveItem})
        Me.CapacitadoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CapacitadoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CapacitadoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CapacitadoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CapacitadoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CapacitadoresBindingNavigator.Name = "CapacitadoresBindingNavigator"
        Me.CapacitadoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CapacitadoresBindingNavigator.Size = New System.Drawing.Size(501, 25)
        Me.CapacitadoresBindingNavigator.TabIndex = 1
        Me.CapacitadoresBindingNavigator.Text = "BindingNavigator1"
        Me.CapacitadoresBindingNavigator.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'CapacitadoresBindingNavigatorSaveItem
        '
        Me.CapacitadoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CapacitadoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("CapacitadoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CapacitadoresBindingNavigatorSaveItem.Name = "CapacitadoresBindingNavigatorSaveItem"
        Me.CapacitadoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CapacitadoresBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.memorias.My.Resources.Resources.Brushed_Metal_1
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 285)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(547, 53)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Image = Global.memorias.My.Resources.Resources.archive
        Me.AceptarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(64, 49)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        Me.AceptarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = Global.memorias.My.Resources.Resources.cancel
        Me.CancelarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(68, 49)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        Me.CancelarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.memorias.My.Resources.Resources.lupa
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(270, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 27
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.memorias.My.Resources.Resources.lupa
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(270, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 26
        Me.Button1.UseVisualStyleBackColor = True
        '
        'capacitadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.CapacitadoresBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "capacitadores"
        Me.ShowInTaskbar = False
        Me.Text = "Capacitadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CapacitadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CapacitadoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CapacitadoresBindingNavigator.ResumeLayout(False)
        Me.CapacitadoresBindingNavigator.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents CapacitadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CapacitadoresTableAdapter As memorias.dtsetTableAdapters.capacitadoresTableAdapter
    Friend WithEvents CapacitadoresBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CapacitadoresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdcapacitadorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdmovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdpaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Fecha_nacDateTimePicker As System.Windows.Forms.DateTimePicker
End Class

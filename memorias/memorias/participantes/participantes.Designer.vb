<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class participantes
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
        Dim IdparticipanteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim IdmovLabel As System.Windows.Forms.Label
        Dim Fecha_nacLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(participantes))
        Dim SexoLabel As System.Windows.Forms.Label
        Me.ParticipantesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ParticipantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtset = New memorias.dtset
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ParticipantesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IdparticipanteTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox
        Me.CedulaTextBox = New System.Windows.Forms.TextBox
        Me.TelefonoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CelularMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.DireccionTextBox = New System.Windows.Forms.TextBox
        Me.IdmovTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Fecha_nacDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ParticipantesTableAdapter = New memorias.dtsetTableAdapters.participantesTableAdapter
        Me.SexoComboBox = New System.Windows.Forms.ComboBox
        IdparticipanteLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        ApellidoLabel = New System.Windows.Forms.Label
        CedulaLabel = New System.Windows.Forms.Label
        TelefonoLabel = New System.Windows.Forms.Label
        CelularLabel = New System.Windows.Forms.Label
        DireccionLabel = New System.Windows.Forms.Label
        IdmovLabel = New System.Windows.Forms.Label
        Fecha_nacLabel = New System.Windows.Forms.Label
        SexoLabel = New System.Windows.Forms.Label
        CType(Me.ParticipantesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParticipantesBindingNavigator.SuspendLayout()
        CType(Me.ParticipantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdparticipanteLabel
        '
        IdparticipanteLabel.AutoSize = True
        IdparticipanteLabel.Location = New System.Drawing.Point(42, 31)
        IdparticipanteLabel.Name = "IdparticipanteLabel"
        IdparticipanteLabel.Size = New System.Drawing.Size(43, 13)
        IdparticipanteLabel.TabIndex = 1
        IdparticipanteLabel.Text = "Codigo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(38, 57)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(38, 83)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 5
        ApellidoLabel.Text = "Apellido:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(42, 135)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(43, 13)
        CedulaLabel.TabIndex = 9
        CedulaLabel.Text = "Cedula:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(290, 135)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 13
        TelefonoLabel.Text = "Telefono:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(300, 161)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 15
        CelularLabel.Text = "Celular:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(30, 187)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 19
        DireccionLabel.Text = "Direccion:"
        '
        'IdmovLabel
        '
        IdmovLabel.AutoSize = True
        IdmovLabel.Location = New System.Drawing.Point(14, 161)
        IdmovLabel.Name = "IdmovLabel"
        IdmovLabel.Size = New System.Drawing.Size(71, 13)
        IdmovLabel.TabIndex = 23
        IdmovLabel.Text = "Mov. Politico:"
        '
        'Fecha_nacLabel
        '
        Fecha_nacLabel.AutoSize = True
        Fecha_nacLabel.Location = New System.Drawing.Point(27, 109)
        Fecha_nacLabel.Name = "Fecha_nacLabel"
        Fecha_nacLabel.Size = New System.Drawing.Size(58, 13)
        Fecha_nacLabel.TabIndex = 27
        Fecha_nacLabel.Text = "fecha nac:"
        '
        'ParticipantesBindingNavigator
        '
        Me.ParticipantesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ParticipantesBindingNavigator.BindingSource = Me.ParticipantesBindingSource
        Me.ParticipantesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ParticipantesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ParticipantesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ParticipantesBindingNavigatorSaveItem})
        Me.ParticipantesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParticipantesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ParticipantesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ParticipantesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ParticipantesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ParticipantesBindingNavigator.Name = "ParticipantesBindingNavigator"
        Me.ParticipantesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ParticipantesBindingNavigator.Size = New System.Drawing.Size(570, 25)
        Me.ParticipantesBindingNavigator.TabIndex = 0
        Me.ParticipantesBindingNavigator.Text = "BindingNavigator1"
        Me.ParticipantesBindingNavigator.Visible = False
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
        'ParticipantesBindingSource
        '
        Me.ParticipantesBindingSource.DataMember = "participantes"
        Me.ParticipantesBindingSource.DataSource = Me.Dtset
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ParticipantesBindingNavigatorSaveItem
        '
        Me.ParticipantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ParticipantesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ParticipantesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ParticipantesBindingNavigatorSaveItem.Name = "ParticipantesBindingNavigatorSaveItem"
        Me.ParticipantesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ParticipantesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdparticipanteTextBox
        '
        Me.IdparticipanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "idparticipante", True))
        Me.IdparticipanteTextBox.Location = New System.Drawing.Point(91, 28)
        Me.IdparticipanteTextBox.Name = "IdparticipanteTextBox"
        Me.IdparticipanteTextBox.ReadOnly = True
        Me.IdparticipanteTextBox.Size = New System.Drawing.Size(118, 20)
        Me.IdparticipanteTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(91, 54)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(291, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(91, 80)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(291, 20)
        Me.ApellidoTextBox.TabIndex = 6
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(91, 132)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(177, 20)
        Me.CedulaTextBox.TabIndex = 10
        '
        'TelefonoMaskedTextBox
        '
        Me.TelefonoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "telefono", True))
        Me.TelefonoMaskedTextBox.Location = New System.Drawing.Point(348, 132)
        Me.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox"
        Me.TelefonoMaskedTextBox.Size = New System.Drawing.Size(168, 20)
        Me.TelefonoMaskedTextBox.TabIndex = 14
        '
        'CelularMaskedTextBox
        '
        Me.CelularMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "celular", True))
        Me.CelularMaskedTextBox.Location = New System.Drawing.Point(348, 158)
        Me.CelularMaskedTextBox.Name = "CelularMaskedTextBox"
        Me.CelularMaskedTextBox.Size = New System.Drawing.Size(168, 20)
        Me.CelularMaskedTextBox.TabIndex = 16
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(91, 184)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(463, 80)
        Me.DireccionTextBox.TabIndex = 20
        '
        'IdmovTextBox
        '
        Me.IdmovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "idmov", True))
        Me.IdmovTextBox.Location = New System.Drawing.Point(91, 158)
        Me.IdmovTextBox.Name = "IdmovTextBox"
        Me.IdmovTextBox.ReadOnly = True
        Me.IdmovTextBox.Size = New System.Drawing.Size(40, 20)
        Me.IdmovTextBox.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(SexoLabel)
        Me.GroupBox1.Controls.Add(Me.SexoComboBox)
        Me.GroupBox1.Controls.Add(Fecha_nacLabel)
        Me.GroupBox1.Controls.Add(Me.Fecha_nacDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.IdparticipanteTextBox)
        Me.GroupBox1.Controls.Add(IdparticipanteLabel)
        Me.GroupBox1.Controls.Add(Me.IdmovTextBox)
        Me.GroupBox1.Controls.Add(IdmovLabel)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(ApellidoLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(CedulaLabel)
        Me.GroupBox1.Controls.Add(Me.CelularMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.CedulaTextBox)
        Me.GroupBox1.Controls.Add(CelularLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoMaskedTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 284)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info."
        '
        'Fecha_nacDateTimePicker
        '
        Me.Fecha_nacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParticipantesBindingSource, "fecha_nac", True))
        Me.Fecha_nacDateTimePicker.Location = New System.Drawing.Point(91, 105)
        Me.Fecha_nacDateTimePicker.Name = "Fecha_nacDateTimePicker"
        Me.Fecha_nacDateTimePicker.Size = New System.Drawing.Size(177, 20)
        Me.Fecha_nacDateTimePicker.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.memorias.My.Resources.Resources.plus1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(248, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(105, 20)
        Me.TextBox1.TabIndex = 26
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackgroundImage = Global.memorias.My.Resources.Resources.Brushed_Metal_1
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 295)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(590, 53)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = Global.memorias.My.Resources.Resources.archive
        Me.GuardarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(65, 49)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        Me.GuardarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ParticipantesTableAdapter
        '
        Me.ParticipantesTableAdapter.ClearBeforeFill = True
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(310, 109)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(32, 13)
        SexoLabel.TabIndex = 28
        SexoLabel.Text = "sexo:"
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParticipantesBindingSource, "sexo", True))
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Items.AddRange(New Object() {"F", "M"})
        Me.SexoComboBox.Location = New System.Drawing.Point(348, 106)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SexoComboBox.TabIndex = 29
        '
        'participantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ParticipantesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "participantes"
        Me.ShowInTaskbar = False
        Me.Text = "Participantes"
        CType(Me.ParticipantesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParticipantesBindingNavigator.ResumeLayout(False)
        Me.ParticipantesBindingNavigator.PerformLayout()
        CType(Me.ParticipantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents ParticipantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParticipantesTableAdapter As memorias.dtsetTableAdapters.participantesTableAdapter
    Friend WithEvents ParticipantesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ParticipantesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdparticipanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CelularMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdmovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Fecha_nacDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SexoComboBox As System.Windows.Forms.ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tallerest
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
        Dim IdtallerLabel As System.Windows.Forms.Label
        Dim IdcapacitadorLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim TemaLabel As System.Windows.Forms.Label
        Dim AnioLabel As System.Windows.Forms.Label
        Dim Fecha_inicioLabel As System.Windows.Forms.Label
        Dim Fecha_finalLabel As System.Windows.Forms.Label
        Dim IdmemoriaLabel As System.Windows.Forms.Label
        Dim IdperiodoLabel As System.Windows.Forms.Label
        Dim IdtipotallerLabel As System.Windows.Forms.Label
        Dim IdregionLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tallerest))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox
        Me.TallerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtset = New memorias.dtset
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.IdtallerTextBox = New System.Windows.Forms.TextBox
        Me.IdcapacitadorTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.TemaTextBox = New System.Windows.Forms.TextBox
        Me.AnioTextBox = New System.Windows.Forms.TextBox
        Me.Fecha_inicioDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Fecha_finalDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.IdmemoriaTextBox = New System.Windows.Forms.TextBox
        Me.IdperiodoTextBox = New System.Windows.Forms.TextBox
        Me.IdtipotallerTextBox = New System.Windows.Forms.TextBox
        Me.IdregionTextBox = New System.Windows.Forms.TextBox
        Me.TallerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.TallerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TallerTableAdapter = New memorias.dtsetTableAdapters.tallerTableAdapter
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        IdtallerLabel = New System.Windows.Forms.Label
        IdcapacitadorLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        TemaLabel = New System.Windows.Forms.Label
        AnioLabel = New System.Windows.Forms.Label
        Fecha_inicioLabel = New System.Windows.Forms.Label
        Fecha_finalLabel = New System.Windows.Forms.Label
        IdmemoriaLabel = New System.Windows.Forms.Label
        IdperiodoLabel = New System.Windows.Forms.Label
        IdtipotallerLabel = New System.Windows.Forms.Label
        IdregionLabel = New System.Windows.Forms.Label
        ActivoLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.TallerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TallerBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdtallerLabel
        '
        IdtallerLabel.AutoSize = True
        IdtallerLabel.Location = New System.Drawing.Point(27, 45)
        IdtallerLabel.Name = "IdtallerLabel"
        IdtallerLabel.Size = New System.Drawing.Size(43, 13)
        IdtallerLabel.TabIndex = 0
        IdtallerLabel.Text = "Codigo:"
        '
        'IdcapacitadorLabel
        '
        IdcapacitadorLabel.AutoSize = True
        IdcapacitadorLabel.Location = New System.Drawing.Point(27, 71)
        IdcapacitadorLabel.Name = "IdcapacitadorLabel"
        IdcapacitadorLabel.Size = New System.Drawing.Size(67, 13)
        IdcapacitadorLabel.TabIndex = 2
        IdcapacitadorLabel.Text = "Capacitador:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(27, 97)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.Location = New System.Drawing.Point(233, 45)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(37, 13)
        TemaLabel.TabIndex = 6
        TemaLabel.Text = "Tema:"
        '
        'AnioLabel
        '
        AnioLabel.AutoSize = True
        AnioLabel.Location = New System.Drawing.Point(27, 149)
        AnioLabel.Name = "AnioLabel"
        AnioLabel.Size = New System.Drawing.Size(29, 13)
        AnioLabel.TabIndex = 8
        AnioLabel.Text = "Año:"
        '
        'Fecha_inicioLabel
        '
        Fecha_inicioLabel.AutoSize = True
        Fecha_inicioLabel.Location = New System.Drawing.Point(166, 149)
        Fecha_inicioLabel.Name = "Fecha_inicioLabel"
        Fecha_inicioLabel.Size = New System.Drawing.Size(35, 13)
        Fecha_inicioLabel.TabIndex = 10
        Fecha_inicioLabel.Text = "Inicio:"
        '
        'Fecha_finalLabel
        '
        Fecha_finalLabel.AutoSize = True
        Fecha_finalLabel.Location = New System.Drawing.Point(324, 149)
        Fecha_finalLabel.Name = "Fecha_finalLabel"
        Fecha_finalLabel.Size = New System.Drawing.Size(32, 13)
        Fecha_finalLabel.TabIndex = 12
        Fecha_finalLabel.Text = "Final:"
        '
        'IdmemoriaLabel
        '
        IdmemoriaLabel.AutoSize = True
        IdmemoriaLabel.Location = New System.Drawing.Point(27, 175)
        IdmemoriaLabel.Name = "IdmemoriaLabel"
        IdmemoriaLabel.Size = New System.Drawing.Size(50, 13)
        IdmemoriaLabel.TabIndex = 14
        IdmemoriaLabel.Text = "Memoria:"
        '
        'IdperiodoLabel
        '
        IdperiodoLabel.AutoSize = True
        IdperiodoLabel.Location = New System.Drawing.Point(27, 227)
        IdperiodoLabel.Name = "IdperiodoLabel"
        IdperiodoLabel.Size = New System.Drawing.Size(46, 13)
        IdperiodoLabel.TabIndex = 16
        IdperiodoLabel.Text = "Periodo:"
        '
        'IdtipotallerLabel
        '
        IdtipotallerLabel.AutoSize = True
        IdtipotallerLabel.Location = New System.Drawing.Point(27, 201)
        IdtipotallerLabel.Name = "IdtipotallerLabel"
        IdtipotallerLabel.Size = New System.Drawing.Size(75, 13)
        IdtipotallerLabel.TabIndex = 18
        IdtipotallerLabel.Text = "Tipo de Taller:"
        '
        'IdregionLabel
        '
        IdregionLabel.AutoSize = True
        IdregionLabel.Location = New System.Drawing.Point(27, 253)
        IdregionLabel.Name = "IdregionLabel"
        IdregionLabel.Size = New System.Drawing.Size(44, 13)
        IdregionLabel.TabIndex = 20
        IdregionLabel.Text = "Region:"
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.Location = New System.Drawing.Point(27, 281)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(53, 13)
        ActivoLabel.TabIndex = 28
        ActivoLabel.Text = "En Curso:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(ActivoLabel)
        Me.GroupBox1.Controls.Add(Me.ActivoCheckBox)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(IdtallerLabel)
        Me.GroupBox1.Controls.Add(Me.IdtallerTextBox)
        Me.GroupBox1.Controls.Add(IdcapacitadorLabel)
        Me.GroupBox1.Controls.Add(Me.IdcapacitadorTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(TemaLabel)
        Me.GroupBox1.Controls.Add(Me.TemaTextBox)
        Me.GroupBox1.Controls.Add(AnioLabel)
        Me.GroupBox1.Controls.Add(Me.AnioTextBox)
        Me.GroupBox1.Controls.Add(Fecha_inicioLabel)
        Me.GroupBox1.Controls.Add(Me.Fecha_inicioDateTimePicker)
        Me.GroupBox1.Controls.Add(Fecha_finalLabel)
        Me.GroupBox1.Controls.Add(Me.Fecha_finalDateTimePicker)
        Me.GroupBox1.Controls.Add(IdmemoriaLabel)
        Me.GroupBox1.Controls.Add(Me.IdmemoriaTextBox)
        Me.GroupBox1.Controls.Add(IdperiodoLabel)
        Me.GroupBox1.Controls.Add(Me.IdperiodoTextBox)
        Me.GroupBox1.Controls.Add(IdtipotallerLabel)
        Me.GroupBox1.Controls.Add(Me.IdtipotallerTextBox)
        Me.GroupBox1.Controls.Add(IdregionLabel)
        Me.GroupBox1.Controls.Add(Me.IdregionTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 314)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.memorias.My.Resources.Resources.plus1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(349, 249)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(20, 20)
        Me.Button5.TabIndex = 31
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.memorias.My.Resources.Resources.plus1
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(349, 223)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 33
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.memorias.My.Resources.Resources.plus1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(349, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 20)
        Me.Button3.TabIndex = 32
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.memorias.My.Resources.Resources.plus1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(474, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 31
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.memorias.My.Resources.Resources.plus1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(474, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TallerBindingSource, "activo", True))
        Me.ActivoCheckBox.Location = New System.Drawing.Point(107, 276)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ActivoCheckBox.TabIndex = 29
        '
        'TallerBindingSource
        '
        Me.TallerBindingSource.DataMember = "taller"
        Me.TallerBindingSource.DataSource = Me.Dtset
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(169, 250)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(174, 20)
        Me.TextBox5.TabIndex = 28
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(169, 224)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(174, 20)
        Me.TextBox4.TabIndex = 27
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(169, 198)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(174, 20)
        Me.TextBox3.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(169, 172)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(299, 20)
        Me.TextBox2.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(161, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(307, 20)
        Me.TextBox1.TabIndex = 24
        '
        'IdtallerTextBox
        '
        Me.IdtallerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "idtaller", True))
        Me.IdtallerTextBox.Location = New System.Drawing.Point(107, 42)
        Me.IdtallerTextBox.Name = "IdtallerTextBox"
        Me.IdtallerTextBox.ReadOnly = True
        Me.IdtallerTextBox.Size = New System.Drawing.Size(101, 20)
        Me.IdtallerTextBox.TabIndex = 1
        '
        'IdcapacitadorTextBox
        '
        Me.IdcapacitadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "idcapacitador", True))
        Me.IdcapacitadorTextBox.Location = New System.Drawing.Point(107, 68)
        Me.IdcapacitadorTextBox.Name = "IdcapacitadorTextBox"
        Me.IdcapacitadorTextBox.ReadOnly = True
        Me.IdcapacitadorTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdcapacitadorTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(107, 94)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(361, 46)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'TemaTextBox
        '
        Me.TemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "tema", True))
        Me.TemaTextBox.Location = New System.Drawing.Point(272, 42)
        Me.TemaTextBox.Name = "TemaTextBox"
        Me.TemaTextBox.Size = New System.Drawing.Size(224, 20)
        Me.TemaTextBox.TabIndex = 7
        '
        'AnioTextBox
        '
        Me.AnioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "anio", True))
        Me.AnioTextBox.Location = New System.Drawing.Point(107, 146)
        Me.AnioTextBox.Name = "AnioTextBox"
        Me.AnioTextBox.ReadOnly = True
        Me.AnioTextBox.Size = New System.Drawing.Size(48, 20)
        Me.AnioTextBox.TabIndex = 9
        '
        'Fecha_inicioDateTimePicker
        '
        Me.Fecha_inicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TallerBindingSource, "fecha_inicio", True))
        Me.Fecha_inicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_inicioDateTimePicker.Location = New System.Drawing.Point(208, 145)
        Me.Fecha_inicioDateTimePicker.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.Fecha_inicioDateTimePicker.Name = "Fecha_inicioDateTimePicker"
        Me.Fecha_inicioDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.Fecha_inicioDateTimePicker.TabIndex = 11
        '
        'Fecha_finalDateTimePicker
        '
        Me.Fecha_finalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TallerBindingSource, "fecha_final", True))
        Me.Fecha_finalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_finalDateTimePicker.Location = New System.Drawing.Point(362, 145)
        Me.Fecha_finalDateTimePicker.Name = "Fecha_finalDateTimePicker"
        Me.Fecha_finalDateTimePicker.Size = New System.Drawing.Size(106, 20)
        Me.Fecha_finalDateTimePicker.TabIndex = 13
        '
        'IdmemoriaTextBox
        '
        Me.IdmemoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "idmemoria", True))
        Me.IdmemoriaTextBox.Location = New System.Drawing.Point(107, 172)
        Me.IdmemoriaTextBox.Name = "IdmemoriaTextBox"
        Me.IdmemoriaTextBox.ReadOnly = True
        Me.IdmemoriaTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdmemoriaTextBox.TabIndex = 15
        '
        'IdperiodoTextBox
        '
        Me.IdperiodoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "idperiodo", True))
        Me.IdperiodoTextBox.Location = New System.Drawing.Point(107, 224)
        Me.IdperiodoTextBox.Name = "IdperiodoTextBox"
        Me.IdperiodoTextBox.ReadOnly = True
        Me.IdperiodoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdperiodoTextBox.TabIndex = 17
        '
        'IdtipotallerTextBox
        '
        Me.IdtipotallerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "idtipotaller", True))
        Me.IdtipotallerTextBox.Location = New System.Drawing.Point(107, 198)
        Me.IdtipotallerTextBox.Name = "IdtipotallerTextBox"
        Me.IdtipotallerTextBox.ReadOnly = True
        Me.IdtipotallerTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdtipotallerTextBox.TabIndex = 19
        '
        'IdregionTextBox
        '
        Me.IdregionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "idregion", True))
        Me.IdregionTextBox.Location = New System.Drawing.Point(107, 250)
        Me.IdregionTextBox.Name = "IdregionTextBox"
        Me.IdregionTextBox.ReadOnly = True
        Me.IdregionTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdregionTextBox.TabIndex = 21
        '
        'TallerBindingNavigator
        '
        Me.TallerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TallerBindingNavigator.BindingSource = Me.TallerBindingSource
        Me.TallerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TallerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TallerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TallerBindingNavigatorSaveItem})
        Me.TallerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TallerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TallerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TallerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TallerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TallerBindingNavigator.Name = "TallerBindingNavigator"
        Me.TallerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TallerBindingNavigator.Size = New System.Drawing.Size(533, 25)
        Me.TallerBindingNavigator.TabIndex = 1
        Me.TallerBindingNavigator.Text = "BindingNavigator1"
        Me.TallerBindingNavigator.Visible = False
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
        'TallerBindingNavigatorSaveItem
        '
        Me.TallerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TallerBindingNavigatorSaveItem.Image = CType(resources.GetObject("TallerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TallerBindingNavigatorSaveItem.Name = "TallerBindingNavigatorSaveItem"
        Me.TallerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TallerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 378)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'TallerTableAdapter
        '
        Me.TallerTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'tallerest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.TallerBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "tallerest"
        Me.ShowInTaskbar = False
        Me.Text = "Taller"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TallerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TallerBindingNavigator.ResumeLayout(False)
        Me.TallerBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents TallerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TallerTableAdapter As memorias.dtsetTableAdapters.tallerTableAdapter
    Friend WithEvents TallerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TallerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdtallerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdcapacitadorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_inicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_finalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdmemoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdperiodoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdtipotallerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdregionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class

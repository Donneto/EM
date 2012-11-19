<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detallesregiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detallesregiones))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Pais_region_listListBox = New System.Windows.Forms.ListBox
        Me.Pais_region_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtset = New memorias.dtset
        Me.Button2 = New System.Windows.Forms.Button
        Me.Pais_region_listTableAdapter = New memorias.dtsetTableAdapters.pais_region_listTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Depto_region_listListBox = New System.Windows.Forms.ListBox
        Me.Depto_region_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Municipio_region_listListBox = New System.Windows.Forms.ListBox
        Me.Municipio_region_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.General_region_listListBox = New System.Windows.Forms.ListBox
        Me.General_region_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.VarToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.VarToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.Pais_region_listBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Pais_region_listBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Municipio_region_listTableAdapter = New memorias.dtsetTableAdapters.municipio_region_listTableAdapter
        Me.FillToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.VarToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.VarToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.FillToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.Depto_region_listTableAdapter = New memorias.dtsetTableAdapters.depto_region_listTableAdapter
        Me.FillToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.VarToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.VarToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.FillToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.General_region_listTableAdapter = New memorias.dtsetTableAdapters.general_region_listTableAdapter
        Me.FillToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.VarToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.VarToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox
        Me.FillToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.Pais_region_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Depto_region_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Municipio_region_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.General_region_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.Pais_region_listBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pais_region_listBindingNavigator.SuspendLayout()
        Me.FillToolStrip1.SuspendLayout()
        Me.FillToolStrip2.SuspendLayout()
        Me.FillToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Pais_region_listListBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 423)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paises"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.memorias.My.Resources.Resources.add
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(6, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pais_region_listListBox
        '
        Me.Pais_region_listListBox.DataSource = Me.Pais_region_listBindingSource
        Me.Pais_region_listListBox.DisplayMember = "pais"
        Me.Pais_region_listListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pais_region_listListBox.Location = New System.Drawing.Point(6, 19)
        Me.Pais_region_listListBox.Name = "Pais_region_listListBox"
        Me.Pais_region_listListBox.Size = New System.Drawing.Size(130, 355)
        Me.Pais_region_listListBox.TabIndex = 0
        Me.Pais_region_listListBox.ValueMember = "idpais"
        '
        'Pais_region_listBindingSource
        '
        Me.Pais_region_listBindingSource.DataMember = "pais_region_list"
        Me.Pais_region_listBindingSource.DataSource = Me.Dtset
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.memorias.My.Resources.Resources.delete1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(36, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Pais_region_listTableAdapter
        '
        Me.Pais_region_listTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Depto_region_listListBox)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(152, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 423)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Departamentos"
        '
        'Depto_region_listListBox
        '
        Me.Depto_region_listListBox.DataSource = Me.Depto_region_listBindingSource
        Me.Depto_region_listListBox.DisplayMember = "depto"
        Me.Depto_region_listListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Depto_region_listListBox.Location = New System.Drawing.Point(6, 19)
        Me.Depto_region_listListBox.Name = "Depto_region_listListBox"
        Me.Depto_region_listListBox.Size = New System.Drawing.Size(130, 355)
        Me.Depto_region_listListBox.TabIndex = 0
        Me.Depto_region_listListBox.ValueMember = "iddepto"
        '
        'Depto_region_listBindingSource
        '
        Me.Depto_region_listBindingSource.DataMember = "depto_region_list"
        Me.Depto_region_listBindingSource.DataSource = Me.Dtset
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.memorias.My.Resources.Resources.add
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(6, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.memorias.My.Resources.Resources.delete1
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(36, 377)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 24)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Municipio_region_listListBox
        '
        Me.Municipio_region_listListBox.DataSource = Me.Municipio_region_listBindingSource
        Me.Municipio_region_listListBox.DisplayMember = "municipio"
        Me.Municipio_region_listListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Municipio_region_listListBox.Location = New System.Drawing.Point(6, 19)
        Me.Municipio_region_listListBox.Name = "Municipio_region_listListBox"
        Me.Municipio_region_listListBox.Size = New System.Drawing.Size(130, 355)
        Me.Municipio_region_listListBox.TabIndex = 0
        Me.Municipio_region_listListBox.ValueMember = "idmunicipio"
        '
        'Municipio_region_listBindingSource
        '
        Me.Municipio_region_listBindingSource.DataMember = "municipio_region_list"
        Me.Municipio_region_listBindingSource.DataSource = Me.Dtset
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Municipio_region_listListBox)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(302, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 423)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Municipios"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.memorias.My.Resources.Resources.add
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(6, 377)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 24)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.memorias.My.Resources.Resources.delete1
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(36, 377)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 10
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.General_region_listListBox)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(452, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(144, 423)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Otros"
        '
        'General_region_listListBox
        '
        Me.General_region_listListBox.DataSource = Me.General_region_listBindingSource
        Me.General_region_listListBox.DisplayMember = "general"
        Me.General_region_listListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General_region_listListBox.Location = New System.Drawing.Point(6, 19)
        Me.General_region_listListBox.Name = "General_region_listListBox"
        Me.General_region_listListBox.Size = New System.Drawing.Size(130, 355)
        Me.General_region_listListBox.TabIndex = 0
        Me.General_region_listListBox.ValueMember = "idgeneral"
        '
        'General_region_listBindingSource
        '
        Me.General_region_listBindingSource.DataMember = "general_region_list"
        Me.General_region_listBindingSource.DataSource = Me.Dtset
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.memorias.My.Resources.Resources.add
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(6, 377)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(24, 24)
        Me.Button7.TabIndex = 12
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.memorias.My.Resources.Resources.delete1
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(36, 377)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(24, 24)
        Me.Button8.TabIndex = 13
        Me.Button8.UseVisualStyleBackColor = True
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.memorias.My.Resources.Resources.cancel
        Me.CerrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(55, 49)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        Me.CerrarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackgroundImage = Global.memorias.My.Resources.Resources.Brushed_Metal_1
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 435)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(599, 53)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VarToolStripLabel
        '
        Me.VarToolStripLabel.Name = "VarToolStripLabel"
        Me.VarToolStripLabel.Size = New System.Drawing.Size(26, 22)
        Me.VarToolStripLabel.Text = "var:"
        '
        'VarToolStripTextBox
        '
        Me.VarToolStripTextBox.Name = "VarToolStripTextBox"
        Me.VarToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VarToolStripLabel, Me.VarToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(601, 25)
        Me.FillToolStrip.TabIndex = 2
        Me.FillToolStrip.Text = "FillToolStrip"
        Me.FillToolStrip.Visible = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Pais_region_listBindingNavigatorSaveItem
        '
        Me.Pais_region_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Pais_region_listBindingNavigatorSaveItem.Enabled = False
        Me.Pais_region_listBindingNavigatorSaveItem.Image = CType(resources.GetObject("Pais_region_listBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Pais_region_listBindingNavigatorSaveItem.Name = "Pais_region_listBindingNavigatorSaveItem"
        Me.Pais_region_listBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Pais_region_listBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Pais_region_listBindingNavigator
        '
        Me.Pais_region_listBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Pais_region_listBindingNavigator.BindingSource = Me.Pais_region_listBindingSource
        Me.Pais_region_listBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Pais_region_listBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Pais_region_listBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Pais_region_listBindingNavigatorSaveItem})
        Me.Pais_region_listBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Pais_region_listBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Pais_region_listBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Pais_region_listBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Pais_region_listBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Pais_region_listBindingNavigator.Name = "Pais_region_listBindingNavigator"
        Me.Pais_region_listBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Pais_region_listBindingNavigator.Size = New System.Drawing.Size(601, 25)
        Me.Pais_region_listBindingNavigator.TabIndex = 1
        Me.Pais_region_listBindingNavigator.Text = "BindingNavigator1"
        Me.Pais_region_listBindingNavigator.Visible = False
        '
        'Municipio_region_listTableAdapter
        '
        Me.Municipio_region_listTableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip1
        '
        Me.FillToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VarToolStripLabel1, Me.VarToolStripTextBox1, Me.FillToolStripButton1})
        Me.FillToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip1.Name = "FillToolStrip1"
        Me.FillToolStrip1.Size = New System.Drawing.Size(601, 25)
        Me.FillToolStrip1.TabIndex = 15
        Me.FillToolStrip1.Text = "FillToolStrip1"
        Me.FillToolStrip1.Visible = False
        '
        'VarToolStripLabel1
        '
        Me.VarToolStripLabel1.Name = "VarToolStripLabel1"
        Me.VarToolStripLabel1.Size = New System.Drawing.Size(26, 22)
        Me.VarToolStripLabel1.Text = "var:"
        '
        'VarToolStripTextBox1
        '
        Me.VarToolStripTextBox1.Name = "VarToolStripTextBox1"
        Me.VarToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton1
        '
        Me.FillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton1.Name = "FillToolStripButton1"
        Me.FillToolStripButton1.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton1.Text = "Fill"
        '
        'Depto_region_listTableAdapter
        '
        Me.Depto_region_listTableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip2
        '
        Me.FillToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VarToolStripLabel2, Me.VarToolStripTextBox2, Me.FillToolStripButton2})
        Me.FillToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip2.Name = "FillToolStrip2"
        Me.FillToolStrip2.Size = New System.Drawing.Size(599, 25)
        Me.FillToolStrip2.TabIndex = 16
        Me.FillToolStrip2.Text = "FillToolStrip2"
        Me.FillToolStrip2.Visible = False
        '
        'VarToolStripLabel2
        '
        Me.VarToolStripLabel2.Name = "VarToolStripLabel2"
        Me.VarToolStripLabel2.Size = New System.Drawing.Size(26, 22)
        Me.VarToolStripLabel2.Text = "var:"
        '
        'VarToolStripTextBox2
        '
        Me.VarToolStripTextBox2.Name = "VarToolStripTextBox2"
        Me.VarToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton2
        '
        Me.FillToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton2.Name = "FillToolStripButton2"
        Me.FillToolStripButton2.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton2.Text = "Fill"
        '
        'General_region_listTableAdapter
        '
        Me.General_region_listTableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip3
        '
        Me.FillToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VarToolStripLabel3, Me.VarToolStripTextBox3, Me.FillToolStripButton3})
        Me.FillToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip3.Name = "FillToolStrip3"
        Me.FillToolStrip3.Size = New System.Drawing.Size(798, 25)
        Me.FillToolStrip3.TabIndex = 17
        Me.FillToolStrip3.Text = "FillToolStrip3"
        Me.FillToolStrip3.Visible = False
        '
        'VarToolStripLabel3
        '
        Me.VarToolStripLabel3.Name = "VarToolStripLabel3"
        Me.VarToolStripLabel3.Size = New System.Drawing.Size(26, 22)
        Me.VarToolStripLabel3.Text = "var:"
        '
        'VarToolStripTextBox3
        '
        Me.VarToolStripTextBox3.Name = "VarToolStripTextBox3"
        Me.VarToolStripTextBox3.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton3
        '
        Me.FillToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton3.Name = "FillToolStripButton3"
        Me.FillToolStripButton3.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton3.Text = "Fill"
        '
        'detallesregiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.FillToolStrip1)
        Me.Controls.Add(Me.FillToolStrip2)
        Me.Controls.Add(Me.FillToolStrip3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.Pais_region_listBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "detallesregiones"
        Me.ShowInTaskbar = False
        Me.Text = "Detalle Regiones"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Pais_region_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Depto_region_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Municipio_region_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.General_region_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.Pais_region_listBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pais_region_listBindingNavigator.ResumeLayout(False)
        Me.Pais_region_listBindingNavigator.PerformLayout()
        Me.FillToolStrip1.ResumeLayout(False)
        Me.FillToolStrip1.PerformLayout()
        Me.FillToolStrip2.ResumeLayout(False)
        Me.FillToolStrip2.PerformLayout()
        Me.FillToolStrip3.ResumeLayout(False)
        Me.FillToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents Pais_region_listBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pais_region_listTableAdapter As memorias.dtsetTableAdapters.pais_region_listTableAdapter
    Friend WithEvents Pais_region_listListBox As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VarToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents VarToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Pais_region_listBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Pais_region_listBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Municipio_region_listBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Municipio_region_listTableAdapter As memorias.dtsetTableAdapters.municipio_region_listTableAdapter
    Friend WithEvents FillToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents VarToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents VarToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Municipio_region_listListBox As System.Windows.Forms.ListBox
    Friend WithEvents Depto_region_listBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Depto_region_listTableAdapter As memorias.dtsetTableAdapters.depto_region_listTableAdapter
    Friend WithEvents FillToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents VarToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents VarToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Depto_region_listListBox As System.Windows.Forms.ListBox
    Friend WithEvents General_region_listBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents General_region_listTableAdapter As memorias.dtsetTableAdapters.general_region_listTableAdapter
    Friend WithEvents FillToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents VarToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents VarToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents General_region_listListBox As System.Windows.Forms.ListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iniciopaises
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iniciopaises))
        Me.Dtset = New memorias.dtset
        Me.PaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaisTableAdapter = New memorias.dtsetTableAdapters.paisTableAdapter
        Me.PaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PaisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PaisListBox = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.DeptoListBox = New System.Windows.Forms.ListBox
        Me.DeptoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DeptoTableAdapter = New memorias.dtsetTableAdapters.deptoTableAdapter
        Me.MunicipioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MunicipioTableAdapter = New memorias.dtsetTableAdapters.municipioTableAdapter
        Me.MunicipioListBox = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button12 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.GeneralListBox = New System.Windows.Forms.ListBox
        Me.GeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button14 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.GeneralTableAdapter = New memorias.dtsetTableAdapters.generalTableAdapter
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.rpt_paisToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.rpt_deptosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Rpt_deptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rpt_deptosTableAdapter = New memorias.dtsetTableAdapters.rpt_deptosTableAdapter
        Me.Rpt_municipioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rpt_municipioTableAdapter = New memorias.dtsetTableAdapters.rpt_municipioTableAdapter
        Me.rpt_municipiosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaisBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DeptoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MunicipioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Rpt_deptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rpt_municipioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaisBindingSource
        '
        Me.PaisBindingSource.DataMember = "pais"
        Me.PaisBindingSource.DataSource = Me.Dtset
        '
        'PaisTableAdapter
        '
        Me.PaisTableAdapter.ClearBeforeFill = True
        '
        'PaisBindingNavigator
        '
        Me.PaisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PaisBindingNavigator.BindingSource = Me.PaisBindingSource
        Me.PaisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PaisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PaisBindingNavigatorSaveItem})
        Me.PaisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PaisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PaisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PaisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PaisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PaisBindingNavigator.Name = "PaisBindingNavigator"
        Me.PaisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PaisBindingNavigator.Size = New System.Drawing.Size(730, 25)
        Me.PaisBindingNavigator.TabIndex = 0
        Me.PaisBindingNavigator.Text = "BindingNavigator1"
        Me.PaisBindingNavigator.Visible = False
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
        'PaisBindingNavigatorSaveItem
        '
        Me.PaisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaisBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaisBindingNavigatorSaveItem.Name = "PaisBindingNavigatorSaveItem"
        Me.PaisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PaisBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PaisListBox
        '
        Me.PaisListBox.DataSource = Me.PaisBindingSource
        Me.PaisListBox.DisplayMember = "pais"
        Me.PaisListBox.Location = New System.Drawing.Point(7, 19)
        Me.PaisListBox.Name = "PaisListBox"
        Me.PaisListBox.Size = New System.Drawing.Size(198, 368)
        Me.PaisListBox.TabIndex = 1
        Me.PaisListBox.ValueMember = "idpais"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button17)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.PaisListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 535)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pais"
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(10, 488)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(186, 23)
        Me.Button17.TabIndex = 9
        Me.Button17.Text = "Eliminar"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.memorias.My.Resources.Resources.new_doc
        Me.Button4.Location = New System.Drawing.Point(7, 440)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 42)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Nuevo"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.memorias.My.Resources.Resources.edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(111, 440)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 42)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Editar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.memorias.My.Resources.Resources.search
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(150, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.memorias.My.Resources.Resources.refresh
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(176, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 4
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 414)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button18)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.DeptoListBox)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 535)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Departamentos"
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(8, 488)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(186, 23)
        Me.Button18.TabIndex = 10
        Me.Button18.Text = "Eliminar"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.memorias.My.Resources.Resources.new_doc
        Me.Button7.Location = New System.Drawing.Point(8, 440)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(85, 42)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Nuevo"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.memorias.My.Resources.Resources.edit
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(112, 440)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(85, 42)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Editar"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.memorias.My.Resources.Resources.search
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(151, 415)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(20, 20)
        Me.Button5.TabIndex = 11
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Buscar:"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.memorias.My.Resources.Resources.refresh
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(177, 414)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(20, 20)
        Me.Button6.TabIndex = 10
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DeptoListBox
        '
        Me.DeptoListBox.DataSource = Me.DeptoBindingSource
        Me.DeptoListBox.DisplayMember = "depto"
        Me.DeptoListBox.Location = New System.Drawing.Point(7, 19)
        Me.DeptoListBox.Name = "DeptoListBox"
        Me.DeptoListBox.Size = New System.Drawing.Size(198, 368)
        Me.DeptoListBox.TabIndex = 0
        Me.DeptoListBox.ValueMember = "iddepto"
        '
        'DeptoBindingSource
        '
        Me.DeptoBindingSource.DataMember = "FK_depto_pais"
        Me.DeptoBindingSource.DataSource = Me.PaisBindingSource
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(8, 415)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 20)
        Me.TextBox2.TabIndex = 9
        '
        'DeptoTableAdapter
        '
        Me.DeptoTableAdapter.ClearBeforeFill = True
        '
        'MunicipioBindingSource
        '
        Me.MunicipioBindingSource.DataMember = "FK_municipio_depto"
        Me.MunicipioBindingSource.DataSource = Me.DeptoBindingSource
        '
        'MunicipioTableAdapter
        '
        Me.MunicipioTableAdapter.ClearBeforeFill = True
        '
        'MunicipioListBox
        '
        Me.MunicipioListBox.DataSource = Me.MunicipioBindingSource
        Me.MunicipioListBox.DisplayMember = "municipio"
        Me.MunicipioListBox.Location = New System.Drawing.Point(7, 19)
        Me.MunicipioListBox.Name = "MunicipioListBox"
        Me.MunicipioListBox.Size = New System.Drawing.Size(198, 368)
        Me.MunicipioListBox.TabIndex = 3
        Me.MunicipioListBox.ValueMember = "idmunicipio"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button19)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.MunicipioListBox)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Button12)
        Me.GroupBox3.Location = New System.Drawing.Point(443, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 535)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Municipios"
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(11, 488)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(186, 23)
        Me.Button19.TabIndex = 12
        Me.Button19.Text = "Eliminar"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.memorias.My.Resources.Resources.new_doc
        Me.Button9.Location = New System.Drawing.Point(8, 440)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 42)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "Nuevo"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.memorias.My.Resources.Resources.edit
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(112, 440)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(85, 42)
        Me.Button10.TabIndex = 14
        Me.Button10.Text = "Editar"
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Buscar:"
        '
        'Button11
        '
        Me.Button11.BackgroundImage = Global.memorias.My.Resources.Resources.search
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(151, 415)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(20, 20)
        Me.Button11.TabIndex = 17
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(8, 415)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 20)
        Me.TextBox3.TabIndex = 13
        '
        'Button12
        '
        Me.Button12.BackgroundImage = Global.memorias.My.Resources.Resources.refresh
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(177, 414)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(20, 20)
        Me.Button12.TabIndex = 16
        Me.Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button12.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button20)
        Me.GroupBox4.Controls.Add(Me.Button13)
        Me.GroupBox4.Controls.Add(Me.GeneralListBox)
        Me.GroupBox4.Controls.Add(Me.Button14)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Button16)
        Me.GroupBox4.Controls.Add(Me.Button15)
        Me.GroupBox4.Controls.Add(Me.TextBox4)
        Me.GroupBox4.Location = New System.Drawing.Point(662, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(213, 535)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "General"
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(8, 488)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(186, 23)
        Me.Button20.TabIndex = 18
        Me.Button20.Text = "Eliminar"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = Global.memorias.My.Resources.Resources.new_doc
        Me.Button13.Location = New System.Drawing.Point(8, 440)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(85, 42)
        Me.Button13.TabIndex = 21
        Me.Button13.Text = "Nuevo"
        Me.Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button13.UseVisualStyleBackColor = True
        '
        'GeneralListBox
        '
        Me.GeneralListBox.DataSource = Me.GeneralBindingSource
        Me.GeneralListBox.DisplayMember = "general"
        Me.GeneralListBox.Location = New System.Drawing.Point(7, 19)
        Me.GeneralListBox.Name = "GeneralListBox"
        Me.GeneralListBox.Size = New System.Drawing.Size(198, 368)
        Me.GeneralListBox.TabIndex = 5
        Me.GeneralListBox.ValueMember = "idgeneral"
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "FK_general_municipio"
        Me.GeneralBindingSource.DataSource = Me.MunicipioBindingSource
        '
        'Button14
        '
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Image = Global.memorias.My.Resources.Resources.edit
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button14.Location = New System.Drawing.Point(112, 440)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(85, 42)
        Me.Button14.TabIndex = 20
        Me.Button14.Text = "Editar"
        Me.Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Buscar:"
        '
        'Button16
        '
        Me.Button16.BackgroundImage = Global.memorias.My.Resources.Resources.refresh
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Location = New System.Drawing.Point(177, 414)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(20, 20)
        Me.Button16.TabIndex = 22
        Me.Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.BackgroundImage = Global.memorias.My.Resources.Resources.search
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(151, 415)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(20, 20)
        Me.Button15.TabIndex = 23
        Me.Button15.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(8, 415)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 20)
        Me.TextBox4.TabIndex = 19
        '
        'GeneralTableAdapter
        '
        Me.GeneralTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.rpt_paisToolStripMenuItem1, Me.rpt_deptosToolStripMenuItem1, Me.rpt_municipiosToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 562)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(897, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'rpt_paisToolStripMenuItem1
        '
        Me.rpt_paisToolStripMenuItem1.Name = "rpt_paisToolStripMenuItem1"
        Me.rpt_paisToolStripMenuItem1.Size = New System.Drawing.Size(91, 20)
        Me.rpt_paisToolStripMenuItem1.Text = "Reporte Paises"
        '
        'rpt_deptosToolStripMenuItem1
        '
        Me.rpt_deptosToolStripMenuItem1.Name = "rpt_deptosToolStripMenuItem1"
        Me.rpt_deptosToolStripMenuItem1.Size = New System.Drawing.Size(135, 20)
        Me.rpt_deptosToolStripMenuItem1.Text = "Reporte Departamentos"
        '
        'Rpt_deptosBindingSource
        '
        Me.Rpt_deptosBindingSource.DataMember = "rpt_deptos"
        Me.Rpt_deptosBindingSource.DataSource = Me.Dtset
        '
        'Rpt_deptosTableAdapter
        '
        Me.Rpt_deptosTableAdapter.ClearBeforeFill = True
        '
        'Rpt_municipioBindingSource
        '
        Me.Rpt_municipioBindingSource.DataMember = "rpt_municipio"
        Me.Rpt_municipioBindingSource.DataSource = Me.Dtset
        '
        'Rpt_municipioTableAdapter
        '
        Me.Rpt_municipioTableAdapter.ClearBeforeFill = True
        '
        'rpt_municipiosToolStripMenuItem1
        '
        Me.rpt_municipiosToolStripMenuItem1.Name = "rpt_municipiosToolStripMenuItem1"
        Me.rpt_municipiosToolStripMenuItem1.Size = New System.Drawing.Size(109, 20)
        Me.rpt_municipiosToolStripMenuItem1.Text = "Reporte Municipios"
        '
        'iniciopaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(897, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PaisBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "iniciopaises"
        Me.ShowInTaskbar = False
        Me.Text = "Paises"
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaisBindingNavigator.ResumeLayout(False)
        Me.PaisBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DeptoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MunicipioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Rpt_deptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rpt_municipioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents PaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaisTableAdapter As memorias.dtsetTableAdapters.paisTableAdapter
    Friend WithEvents PaisBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PaisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PaisListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DeptoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeptoTableAdapter As memorias.dtsetTableAdapters.deptoTableAdapter
    Friend WithEvents DeptoListBox As System.Windows.Forms.ListBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents MunicipioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MunicipioTableAdapter As memorias.dtsetTableAdapters.municipioTableAdapter
    Friend WithEvents MunicipioListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GeneralBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralTableAdapter As memorias.dtsetTableAdapters.generalTableAdapter
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents GeneralListBox As System.Windows.Forms.ListBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents rpt_paisToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt_deptosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Rpt_deptosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rpt_deptosTableAdapter As memorias.dtsetTableAdapters.rpt_deptosTableAdapter
    Friend WithEvents Rpt_municipioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rpt_municipioTableAdapter As memorias.dtsetTableAdapters.rpt_municipioTableAdapter
    Friend WithEvents rpt_municipiosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class

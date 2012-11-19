<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantTalleres
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
        Dim TemaLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Fecha_inicioLabel As System.Windows.Forms.Label
        Dim Fecha_finalLabel As System.Windows.Forms.Label
        Dim IdmemoriaLabel As System.Windows.Forms.Label
        Dim IdperiodoLabel As System.Windows.Forms.Label
        Dim IdtipotallerLabel As System.Windows.Forms.Label
        Dim IdregionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MantTalleres))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TemaTextBox = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.Fecha_inicioDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Fecha_finalDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.IdmemoriaTextBox = New System.Windows.Forms.TextBox
        Me.IdperiodoTextBox = New System.Windows.Forms.TextBox
        Me.IdtipotallerTextBox = New System.Windows.Forms.TextBox
        Me.IdregionTextBox = New System.Windows.Forms.TextBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        TemaLabel = New System.Windows.Forms.Label
        ActivoLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        Fecha_inicioLabel = New System.Windows.Forms.Label
        Fecha_finalLabel = New System.Windows.Forms.Label
        IdmemoriaLabel = New System.Windows.Forms.Label
        IdperiodoLabel = New System.Windows.Forms.Label
        IdtipotallerLabel = New System.Windows.Forms.Label
        IdregionLabel = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.Location = New System.Drawing.Point(12, 11)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(37, 13)
        TemaLabel.TabIndex = 8
        TemaLabel.Text = "Tema:"
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.Location = New System.Drawing.Point(12, 230)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(53, 13)
        ActivoLabel.TabIndex = 56
        ActivoLabel.Text = "En Curso:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(12, 37)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 36
        DescripcionLabel.Text = "Descripcion:"
        '
        'Fecha_inicioLabel
        '
        Fecha_inicioLabel.AutoSize = True
        Fecha_inicioLabel.Location = New System.Drawing.Point(112, 93)
        Fecha_inicioLabel.Name = "Fecha_inicioLabel"
        Fecha_inicioLabel.Size = New System.Drawing.Size(35, 13)
        Fecha_inicioLabel.TabIndex = 40
        Fecha_inicioLabel.Text = "Inicio:"
        '
        'Fecha_finalLabel
        '
        Fecha_finalLabel.AutoSize = True
        Fecha_finalLabel.Location = New System.Drawing.Point(335, 92)
        Fecha_finalLabel.Name = "Fecha_finalLabel"
        Fecha_finalLabel.Size = New System.Drawing.Size(32, 13)
        Fecha_finalLabel.TabIndex = 42
        Fecha_finalLabel.Text = "Final:"
        '
        'IdmemoriaLabel
        '
        IdmemoriaLabel.AutoSize = True
        IdmemoriaLabel.Location = New System.Drawing.Point(12, 124)
        IdmemoriaLabel.Name = "IdmemoriaLabel"
        IdmemoriaLabel.Size = New System.Drawing.Size(50, 13)
        IdmemoriaLabel.TabIndex = 44
        IdmemoriaLabel.Text = "Memoria:"
        '
        'IdperiodoLabel
        '
        IdperiodoLabel.AutoSize = True
        IdperiodoLabel.Location = New System.Drawing.Point(12, 176)
        IdperiodoLabel.Name = "IdperiodoLabel"
        IdperiodoLabel.Size = New System.Drawing.Size(46, 13)
        IdperiodoLabel.TabIndex = 46
        IdperiodoLabel.Text = "Periodo:"
        '
        'IdtipotallerLabel
        '
        IdtipotallerLabel.AutoSize = True
        IdtipotallerLabel.Location = New System.Drawing.Point(12, 150)
        IdtipotallerLabel.Name = "IdtipotallerLabel"
        IdtipotallerLabel.Size = New System.Drawing.Size(75, 13)
        IdtipotallerLabel.TabIndex = 48
        IdtipotallerLabel.Text = "Tipo de Taller:"
        '
        'IdregionLabel
        '
        IdregionLabel.AutoSize = True
        IdregionLabel.Location = New System.Drawing.Point(12, 202)
        IdregionLabel.Name = "IdregionLabel"
        IdregionLabel.Size = New System.Drawing.Size(44, 13)
        IdregionLabel.TabIndex = 50
        IdregionLabel.Text = "Region:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 607)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 37)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Image = Global.memorias.My.Resources.Resources.filesave1
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(57, 33)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        Me.AceptarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = Global.memorias.My.Resources.Resources.gtk_cancel
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(61, 33)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        Me.CancelarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TemaTextBox
        '
        Me.TemaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TemaTextBox.Location = New System.Drawing.Point(92, 8)
        Me.TemaTextBox.Name = "TemaTextBox"
        Me.TemaTextBox.Size = New System.Drawing.Size(424, 20)
        Me.TemaTextBox.TabIndex = 9
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackgroundImage = Global.memorias.My.Resources.Resources.lupa
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(344, 198)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(20, 20)
        Me.Button5.TabIndex = 60
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackgroundImage = Global.memorias.My.Resources.Resources.lupa
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(344, 172)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 63
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackgroundImage = Global.memorias.My.Resources.Resources.lupa
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(344, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 20)
        Me.Button3.TabIndex = 62
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = Global.memorias.My.Resources.Resources.lupa
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(469, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 61
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.Location = New System.Drawing.Point(92, 225)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ActivoCheckBox.TabIndex = 58
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(154, 199)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(184, 20)
        Me.TextBox5.TabIndex = 57
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(154, 173)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(184, 20)
        Me.TextBox4.TabIndex = 55
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(154, 147)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(184, 20)
        Me.TextBox3.TabIndex = 54
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(154, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(309, 20)
        Me.TextBox2.TabIndex = 53
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionTextBox.Location = New System.Drawing.Point(92, 34)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(424, 46)
        Me.DescripcionTextBox.TabIndex = 37
        '
        'Fecha_inicioDateTimePicker
        '
        Me.Fecha_inicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_inicioDateTimePicker.Location = New System.Drawing.Point(154, 89)
        Me.Fecha_inicioDateTimePicker.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.Fecha_inicioDateTimePicker.Name = "Fecha_inicioDateTimePicker"
        Me.Fecha_inicioDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.Fecha_inicioDateTimePicker.TabIndex = 41
        Me.Fecha_inicioDateTimePicker.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'Fecha_finalDateTimePicker
        '
        Me.Fecha_finalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_finalDateTimePicker.Location = New System.Drawing.Point(373, 88)
        Me.Fecha_finalDateTimePicker.Name = "Fecha_finalDateTimePicker"
        Me.Fecha_finalDateTimePicker.Size = New System.Drawing.Size(106, 20)
        Me.Fecha_finalDateTimePicker.TabIndex = 43
        '
        'IdmemoriaTextBox
        '
        Me.IdmemoriaTextBox.Location = New System.Drawing.Point(92, 121)
        Me.IdmemoriaTextBox.Name = "IdmemoriaTextBox"
        Me.IdmemoriaTextBox.ReadOnly = True
        Me.IdmemoriaTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdmemoriaTextBox.TabIndex = 45
        '
        'IdperiodoTextBox
        '
        Me.IdperiodoTextBox.Location = New System.Drawing.Point(92, 173)
        Me.IdperiodoTextBox.Name = "IdperiodoTextBox"
        Me.IdperiodoTextBox.ReadOnly = True
        Me.IdperiodoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdperiodoTextBox.TabIndex = 47
        '
        'IdtipotallerTextBox
        '
        Me.IdtipotallerTextBox.Location = New System.Drawing.Point(92, 147)
        Me.IdtipotallerTextBox.Name = "IdtipotallerTextBox"
        Me.IdtipotallerTextBox.ReadOnly = True
        Me.IdtipotallerTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdtipotallerTextBox.TabIndex = 49
        '
        'IdregionTextBox
        '
        Me.IdregionTextBox.Location = New System.Drawing.Point(92, 199)
        Me.IdregionTextBox.Name = "IdregionTextBox"
        Me.IdregionTextBox.ReadOnly = True
        Me.IdregionTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IdregionTextBox.TabIndex = 51
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(3, 41)
        Me.GridControl1.LookAndFeel.SkinName = "Black"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTimeEdit1, Me.RepositoryItemTimeEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(517, 293)
        Me.GridControl1.TabIndex = 64
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "Click para agregar capacitadores"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Capacitador"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn1.FieldName = "idcapacitador"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 249
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Inicio"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemTimeEdit1
        Me.GridColumn2.FieldName = "fecha_inicio"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 110
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Final"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTimeEdit2
        Me.GridColumn3.FieldName = "fecha_final"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 114
        '
        'RepositoryItemTimeEdit2
        '
        Me.RepositoryItemTimeEdit2.AutoHeight = False
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GridControl1)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 337)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capacitadores"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(517, 25)
        Me.ToolStrip1.TabIndex = 65
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.memorias.My.Resources.Resources.add
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Agregar capacitador"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Enabled = False
        Me.ToolStripButton2.Image = Global.memorias.My.Resources.Resources.delete1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MantTalleres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 644)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(ActivoLabel)
        Me.Controls.Add(Me.ActivoCheckBox)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Fecha_inicioLabel)
        Me.Controls.Add(Me.Fecha_inicioDateTimePicker)
        Me.Controls.Add(Fecha_finalLabel)
        Me.Controls.Add(Me.Fecha_finalDateTimePicker)
        Me.Controls.Add(IdmemoriaLabel)
        Me.Controls.Add(Me.IdmemoriaTextBox)
        Me.Controls.Add(IdperiodoLabel)
        Me.Controls.Add(Me.IdperiodoTextBox)
        Me.Controls.Add(IdtipotallerLabel)
        Me.Controls.Add(Me.IdtipotallerTextBox)
        Me.Controls.Add(IdregionLabel)
        Me.Controls.Add(Me.IdregionTextBox)
        Me.Controls.Add(TemaLabel)
        Me.Controls.Add(Me.TemaTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MantTalleres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Talleres"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ActivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_inicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_finalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdmemoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdperiodoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdtipotallerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdregionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class

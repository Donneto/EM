<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class general
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(general))
        Dim IdgeneralLabel As System.Windows.Forms.Label
        Dim GeneralLabel As System.Windows.Forms.Label
        Dim PuebloLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim AldeaLabel As System.Windows.Forms.Label
        Dim IdmunicipioLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Dtset = New memorias.dtset
        Me.GeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralTableAdapter = New memorias.dtsetTableAdapters.generalTableAdapter
        Me.GeneralBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GeneralBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IdgeneralTextBox = New System.Windows.Forms.TextBox
        Me.GeneralTextBox = New System.Windows.Forms.TextBox
        Me.PuebloRadioButton = New System.Windows.Forms.RadioButton
        Me.ColoniaRadioButton = New System.Windows.Forms.RadioButton
        Me.AldeaRadioButton = New System.Windows.Forms.RadioButton
        Me.IdmunicipioTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.AceptaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        IdgeneralLabel = New System.Windows.Forms.Label
        GeneralLabel = New System.Windows.Forms.Label
        PuebloLabel = New System.Windows.Forms.Label
        ColoniaLabel = New System.Windows.Forms.Label
        AldeaLabel = New System.Windows.Forms.Label
        IdmunicipioLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GeneralBindingNavigator.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(IdgeneralLabel)
        Me.GroupBox1.Controls.Add(Me.IdgeneralTextBox)
        Me.GroupBox1.Controls.Add(GeneralLabel)
        Me.GroupBox1.Controls.Add(Me.GeneralTextBox)
        Me.GroupBox1.Controls.Add(PuebloLabel)
        Me.GroupBox1.Controls.Add(Me.PuebloRadioButton)
        Me.GroupBox1.Controls.Add(ColoniaLabel)
        Me.GroupBox1.Controls.Add(Me.ColoniaRadioButton)
        Me.GroupBox1.Controls.Add(AldeaLabel)
        Me.GroupBox1.Controls.Add(Me.AldeaRadioButton)
        Me.GroupBox1.Controls.Add(IdmunicipioLabel)
        Me.GroupBox1.Controls.Add(Me.IdmunicipioTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.memorias.My.Resources.Resources.Brushed_Metal_1
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptaToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 170)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(376, 53)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "general"
        Me.GeneralBindingSource.DataSource = Me.Dtset
        '
        'GeneralTableAdapter
        '
        Me.GeneralTableAdapter.ClearBeforeFill = True
        '
        'GeneralBindingNavigator
        '
        Me.GeneralBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GeneralBindingNavigator.BindingSource = Me.GeneralBindingSource
        Me.GeneralBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GeneralBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GeneralBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GeneralBindingNavigatorSaveItem})
        Me.GeneralBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GeneralBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GeneralBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GeneralBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GeneralBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GeneralBindingNavigator.Name = "GeneralBindingNavigator"
        Me.GeneralBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GeneralBindingNavigator.Size = New System.Drawing.Size(446, 25)
        Me.GeneralBindingNavigator.TabIndex = 2
        Me.GeneralBindingNavigator.Text = "BindingNavigator1"
        Me.GeneralBindingNavigator.Visible = False
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
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
        'GeneralBindingNavigatorSaveItem
        '
        Me.GeneralBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GeneralBindingNavigatorSaveItem.Image = CType(resources.GetObject("GeneralBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GeneralBindingNavigatorSaveItem.Name = "GeneralBindingNavigatorSaveItem"
        Me.GeneralBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GeneralBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdgeneralLabel
        '
        IdgeneralLabel.AutoSize = True
        IdgeneralLabel.Location = New System.Drawing.Point(23, 27)
        IdgeneralLabel.Name = "IdgeneralLabel"
        IdgeneralLabel.Size = New System.Drawing.Size(43, 13)
        IdgeneralLabel.TabIndex = 0
        IdgeneralLabel.Text = "Codigo:"
        '
        'IdgeneralTextBox
        '
        Me.IdgeneralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "idgeneral", True))
        Me.IdgeneralTextBox.Location = New System.Drawing.Point(79, 24)
        Me.IdgeneralTextBox.Name = "IdgeneralTextBox"
        Me.IdgeneralTextBox.ReadOnly = True
        Me.IdgeneralTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IdgeneralTextBox.TabIndex = 1
        '
        'GeneralLabel
        '
        GeneralLabel.AutoSize = True
        GeneralLabel.Location = New System.Drawing.Point(23, 53)
        GeneralLabel.Name = "GeneralLabel"
        GeneralLabel.Size = New System.Drawing.Size(47, 13)
        GeneralLabel.TabIndex = 2
        GeneralLabel.Text = "General:"
        '
        'GeneralTextBox
        '
        Me.GeneralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "general", True))
        Me.GeneralTextBox.Location = New System.Drawing.Point(79, 50)
        Me.GeneralTextBox.Name = "GeneralTextBox"
        Me.GeneralTextBox.Size = New System.Drawing.Size(250, 20)
        Me.GeneralTextBox.TabIndex = 3
        '
        'PuebloLabel
        '
        PuebloLabel.AutoSize = True
        PuebloLabel.Location = New System.Drawing.Point(76, 82)
        PuebloLabel.Name = "PuebloLabel"
        PuebloLabel.Size = New System.Drawing.Size(42, 13)
        PuebloLabel.TabIndex = 4
        PuebloLabel.Text = "pueblo:"
        '
        'PuebloRadioButton
        '
        Me.PuebloRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.GeneralBindingSource, "pueblo", True))
        Me.PuebloRadioButton.Location = New System.Drawing.Point(132, 76)
        Me.PuebloRadioButton.Name = "PuebloRadioButton"
        Me.PuebloRadioButton.Size = New System.Drawing.Size(25, 24)
        Me.PuebloRadioButton.TabIndex = 5
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(167, 82)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(44, 13)
        ColoniaLabel.TabIndex = 6
        ColoniaLabel.Text = "colonia:"
        '
        'ColoniaRadioButton
        '
        Me.ColoniaRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.GeneralBindingSource, "colonia", True))
        Me.ColoniaRadioButton.Location = New System.Drawing.Point(220, 76)
        Me.ColoniaRadioButton.Name = "ColoniaRadioButton"
        Me.ColoniaRadioButton.Size = New System.Drawing.Size(25, 24)
        Me.ColoniaRadioButton.TabIndex = 7
        '
        'AldeaLabel
        '
        AldeaLabel.AutoSize = True
        AldeaLabel.Location = New System.Drawing.Point(257, 82)
        AldeaLabel.Name = "AldeaLabel"
        AldeaLabel.Size = New System.Drawing.Size(36, 13)
        AldeaLabel.TabIndex = 8
        AldeaLabel.Text = "aldea:"
        '
        'AldeaRadioButton
        '
        Me.AldeaRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.GeneralBindingSource, "aldea", True))
        Me.AldeaRadioButton.Location = New System.Drawing.Point(305, 76)
        Me.AldeaRadioButton.Name = "AldeaRadioButton"
        Me.AldeaRadioButton.Size = New System.Drawing.Size(25, 24)
        Me.AldeaRadioButton.TabIndex = 9
        '
        'IdmunicipioLabel
        '
        IdmunicipioLabel.AutoSize = True
        IdmunicipioLabel.Location = New System.Drawing.Point(11, 109)
        IdmunicipioLabel.Name = "IdmunicipioLabel"
        IdmunicipioLabel.Size = New System.Drawing.Size(55, 13)
        IdmunicipioLabel.TabIndex = 10
        IdmunicipioLabel.Text = "Municipio:"
        '
        'IdmunicipioTextBox
        '
        Me.IdmunicipioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "idmunicipio", True))
        Me.IdmunicipioTextBox.Location = New System.Drawing.Point(79, 106)
        Me.IdmunicipioTextBox.Name = "IdmunicipioTextBox"
        Me.IdmunicipioTextBox.ReadOnly = True
        Me.IdmunicipioTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IdmunicipioTextBox.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox1.TabIndex = 12
        '
        'AceptaToolStripMenuItem
        '
        Me.AceptaToolStripMenuItem.Image = Global.memorias.My.Resources.Resources.archive
        Me.AceptaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AceptaToolStripMenuItem.Name = "AceptaToolStripMenuItem"
        Me.AceptaToolStripMenuItem.Size = New System.Drawing.Size(64, 49)
        Me.AceptaToolStripMenuItem.Text = "Aceptar"
        Me.AceptaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'general
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.GeneralBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "general"
        Me.ShowInTaskbar = False
        Me.Text = "General"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GeneralBindingNavigator.ResumeLayout(False)
        Me.GeneralBindingNavigator.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents GeneralBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralTableAdapter As memorias.dtsetTableAdapters.generalTableAdapter
    Friend WithEvents GeneralBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents GeneralBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdgeneralTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GeneralTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PuebloRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ColoniaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AldeaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IdmunicipioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AceptaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class

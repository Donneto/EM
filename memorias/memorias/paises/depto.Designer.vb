<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class depto
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
        Dim IddeptoLabel As System.Windows.Forms.Label
        Dim DeptoLabel As System.Windows.Forms.Label
        Dim IdpaisLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(depto))
        Me.Dtset = New memorias.dtset
        Me.DeptoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptoTableAdapter = New memorias.dtsetTableAdapters.deptoTableAdapter
        Me.DeptoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.IddeptoTextBox = New System.Windows.Forms.TextBox
        Me.DeptoTextBox = New System.Windows.Forms.TextBox
        Me.IdpaisTextBox = New System.Windows.Forms.TextBox
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.DeptoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        IddeptoLabel = New System.Windows.Forms.Label
        DeptoLabel = New System.Windows.Forms.Label
        IdpaisLabel = New System.Windows.Forms.Label
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeptoBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeptoBindingSource
        '
        Me.DeptoBindingSource.DataMember = "depto"
        Me.DeptoBindingSource.DataSource = Me.Dtset
        '
        'DeptoTableAdapter
        '
        Me.DeptoTableAdapter.ClearBeforeFill = True
        '
        'DeptoBindingNavigator
        '
        Me.DeptoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DeptoBindingNavigator.BindingSource = Me.DeptoBindingSource
        Me.DeptoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DeptoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DeptoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DeptoBindingNavigatorSaveItem})
        Me.DeptoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DeptoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DeptoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DeptoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DeptoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DeptoBindingNavigator.Name = "DeptoBindingNavigator"
        Me.DeptoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DeptoBindingNavigator.Size = New System.Drawing.Size(449, 25)
        Me.DeptoBindingNavigator.TabIndex = 0
        Me.DeptoBindingNavigator.Text = "BindingNavigator1"
        Me.DeptoBindingNavigator.Visible = False
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IddeptoLabel
        '
        IddeptoLabel.AutoSize = True
        IddeptoLabel.Location = New System.Drawing.Point(16, 26)
        IddeptoLabel.Name = "IddeptoLabel"
        IddeptoLabel.Size = New System.Drawing.Size(40, 13)
        IddeptoLabel.TabIndex = 1
        IddeptoLabel.Text = "Codigo"
        '
        'IddeptoTextBox
        '
        Me.IddeptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeptoBindingSource, "iddepto", True))
        Me.IddeptoTextBox.Location = New System.Drawing.Point(67, 23)
        Me.IddeptoTextBox.Name = "IddeptoTextBox"
        Me.IddeptoTextBox.ReadOnly = True
        Me.IddeptoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IddeptoTextBox.TabIndex = 2
        '
        'DeptoLabel
        '
        DeptoLabel.AutoSize = True
        DeptoLabel.Location = New System.Drawing.Point(16, 52)
        DeptoLabel.Name = "DeptoLabel"
        DeptoLabel.Size = New System.Drawing.Size(39, 13)
        DeptoLabel.TabIndex = 3
        DeptoLabel.Text = "Depto:"
        '
        'DeptoTextBox
        '
        Me.DeptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeptoBindingSource, "depto", True))
        Me.DeptoTextBox.Location = New System.Drawing.Point(67, 49)
        Me.DeptoTextBox.Name = "DeptoTextBox"
        Me.DeptoTextBox.Size = New System.Drawing.Size(163, 20)
        Me.DeptoTextBox.TabIndex = 4
        '
        'IdpaisLabel
        '
        IdpaisLabel.AutoSize = True
        IdpaisLabel.Location = New System.Drawing.Point(16, 78)
        IdpaisLabel.Name = "IdpaisLabel"
        IdpaisLabel.Size = New System.Drawing.Size(30, 13)
        IdpaisLabel.TabIndex = 5
        IdpaisLabel.Text = "Pais:"
        '
        'IdpaisTextBox
        '
        Me.IdpaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeptoBindingSource, "idpais", True))
        Me.IdpaisTextBox.Location = New System.Drawing.Point(67, 75)
        Me.IdpaisTextBox.Name = "IdpaisTextBox"
        Me.IdpaisTextBox.ReadOnly = True
        Me.IdpaisTextBox.Size = New System.Drawing.Size(42, 20)
        Me.IdpaisTextBox.TabIndex = 6
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
        'DeptoBindingNavigatorSaveItem
        '
        Me.DeptoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeptoBindingNavigatorSaveItem.Image = CType(resources.GetObject("DeptoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DeptoBindingNavigatorSaveItem.Name = "DeptoBindingNavigatorSaveItem"
        Me.DeptoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DeptoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.IddeptoTextBox)
        Me.GroupBox1.Controls.Add(IddeptoLabel)
        Me.GroupBox1.Controls.Add(Me.IdpaisTextBox)
        Me.GroupBox1.Controls.Add(IdpaisLabel)
        Me.GroupBox1.Controls.Add(DeptoLabel)
        Me.GroupBox1.Controls.Add(Me.DeptoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 131)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 143)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(266, 53)
        Me.MenuStrip1.TabIndex = 8
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(115, 20)
        Me.TextBox1.TabIndex = 7
        '
        'depto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DeptoBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "depto"
        Me.ShowInTaskbar = False
        Me.Text = "Departamento"
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeptoBindingNavigator.ResumeLayout(False)
        Me.DeptoBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents DeptoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeptoTableAdapter As memorias.dtsetTableAdapters.deptoTableAdapter
    Friend WithEvents DeptoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DeptoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IddeptoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeptoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdpaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class

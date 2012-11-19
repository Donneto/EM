<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class municipio
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
        Dim IdmunicipioLabel As System.Windows.Forms.Label
        Dim MunicipioLabel As System.Windows.Forms.Label
        Dim IddeptoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(municipio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.IdmunicipioTextBox = New System.Windows.Forms.TextBox
        Me.MunicipioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtset = New memorias.dtset
        Me.MunicipioTextBox = New System.Windows.Forms.TextBox
        Me.IddeptoTextBox = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MunicipioTableAdapter = New memorias.dtsetTableAdapters.municipioTableAdapter
        Me.MunicipioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MunicipioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        IdmunicipioLabel = New System.Windows.Forms.Label
        MunicipioLabel = New System.Windows.Forms.Label
        IddeptoLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.MunicipioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MunicipioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MunicipioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdmunicipioLabel
        '
        IdmunicipioLabel.AutoSize = True
        IdmunicipioLabel.Location = New System.Drawing.Point(10, 28)
        IdmunicipioLabel.Name = "IdmunicipioLabel"
        IdmunicipioLabel.Size = New System.Drawing.Size(43, 13)
        IdmunicipioLabel.TabIndex = 0
        IdmunicipioLabel.Text = "Codigo:"
        '
        'MunicipioLabel
        '
        MunicipioLabel.AutoSize = True
        MunicipioLabel.Location = New System.Drawing.Point(10, 54)
        MunicipioLabel.Name = "MunicipioLabel"
        MunicipioLabel.Size = New System.Drawing.Size(55, 13)
        MunicipioLabel.TabIndex = 2
        MunicipioLabel.Text = "Municipio:"
        '
        'IddeptoLabel
        '
        IddeptoLabel.AutoSize = True
        IddeptoLabel.Location = New System.Drawing.Point(10, 80)
        IddeptoLabel.Name = "IddeptoLabel"
        IddeptoLabel.Size = New System.Drawing.Size(39, 13)
        IddeptoLabel.TabIndex = 4
        IddeptoLabel.Text = "Depto:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(IdmunicipioLabel)
        Me.GroupBox1.Controls.Add(Me.IdmunicipioTextBox)
        Me.GroupBox1.Controls.Add(MunicipioLabel)
        Me.GroupBox1.Controls.Add(Me.MunicipioTextBox)
        Me.GroupBox1.Controls.Add(IddeptoLabel)
        Me.GroupBox1.Controls.Add(Me.IddeptoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(125, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(191, 20)
        Me.TextBox1.TabIndex = 6
        '
        'IdmunicipioTextBox
        '
        Me.IdmunicipioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MunicipioBindingSource, "idmunicipio", True))
        Me.IdmunicipioTextBox.Location = New System.Drawing.Point(78, 25)
        Me.IdmunicipioTextBox.Name = "IdmunicipioTextBox"
        Me.IdmunicipioTextBox.ReadOnly = True
        Me.IdmunicipioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdmunicipioTextBox.TabIndex = 1
        '
        'MunicipioBindingSource
        '
        Me.MunicipioBindingSource.DataMember = "municipio"
        Me.MunicipioBindingSource.DataSource = Me.Dtset
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MunicipioTextBox
        '
        Me.MunicipioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MunicipioBindingSource, "municipio", True))
        Me.MunicipioTextBox.Location = New System.Drawing.Point(78, 51)
        Me.MunicipioTextBox.Name = "MunicipioTextBox"
        Me.MunicipioTextBox.Size = New System.Drawing.Size(238, 20)
        Me.MunicipioTextBox.TabIndex = 3
        '
        'IddeptoTextBox
        '
        Me.IddeptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MunicipioBindingSource, "iddepto", True))
        Me.IddeptoTextBox.Location = New System.Drawing.Point(78, 77)
        Me.IddeptoTextBox.Name = "IddeptoTextBox"
        Me.IddeptoTextBox.ReadOnly = True
        Me.IddeptoTextBox.Size = New System.Drawing.Size(41, 20)
        Me.IddeptoTextBox.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackgroundImage = Global.memorias.My.Resources.Resources.Brushed_Metal_1
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 133)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(381, 53)
        Me.MenuStrip1.TabIndex = 1
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MunicipioTableAdapter
        '
        Me.MunicipioTableAdapter.ClearBeforeFill = True
        '
        'MunicipioBindingNavigator
        '
        Me.MunicipioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MunicipioBindingNavigator.BindingSource = Me.MunicipioBindingSource
        Me.MunicipioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MunicipioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MunicipioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MunicipioBindingNavigatorSaveItem})
        Me.MunicipioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MunicipioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MunicipioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MunicipioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MunicipioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MunicipioBindingNavigator.Name = "MunicipioBindingNavigator"
        Me.MunicipioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MunicipioBindingNavigator.Size = New System.Drawing.Size(386, 25)
        Me.MunicipioBindingNavigator.TabIndex = 2
        Me.MunicipioBindingNavigator.Text = "BindingNavigator1"
        Me.MunicipioBindingNavigator.Visible = False
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
        'MunicipioBindingNavigatorSaveItem
        '
        Me.MunicipioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MunicipioBindingNavigatorSaveItem.Image = CType(resources.GetObject("MunicipioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MunicipioBindingNavigatorSaveItem.Name = "MunicipioBindingNavigatorSaveItem"
        Me.MunicipioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MunicipioBindingNavigatorSaveItem.Text = "Save Data"
        '
        'municipio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.MunicipioBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "municipio"
        Me.ShowInTaskbar = False
        Me.Text = "Municipio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MunicipioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MunicipioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MunicipioBindingNavigator.ResumeLayout(False)
        Me.MunicipioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MunicipioBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MunicipioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dtset As memorias.dtset
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
    Friend WithEvents MunicipioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MunicipioTableAdapter As memorias.dtsetTableAdapters.municipioTableAdapter
    Friend WithEvents IdmunicipioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MunicipioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IddeptoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class

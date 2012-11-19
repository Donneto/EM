<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movpolitico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(movpolitico))
        Dim IdmovLabel As System.Windows.Forms.Label
        Dim MovimientoLabel As System.Windows.Forms.Label
        Dim IdpaisLabel As System.Windows.Forms.Label
        Me.Dtset = New memorias.dtset
        Me.Mov_politicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_politicoTableAdapter = New memorias.dtsetTableAdapters.mov_politicoTableAdapter
        Me.Mov_politicoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Mov_politicoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IdmovTextBox = New System.Windows.Forms.TextBox
        Me.MovimientoTextBox = New System.Windows.Forms.TextBox
        Me.IdpaisTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        IdmovLabel = New System.Windows.Forms.Label
        MovimientoLabel = New System.Windows.Forms.Label
        IdpaisLabel = New System.Windows.Forms.Label
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_politicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_politicoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mov_politicoBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mov_politicoBindingSource
        '
        Me.Mov_politicoBindingSource.DataMember = "mov_politico"
        Me.Mov_politicoBindingSource.DataSource = Me.Dtset
        '
        'Mov_politicoTableAdapter
        '
        Me.Mov_politicoTableAdapter.ClearBeforeFill = True
        '
        'Mov_politicoBindingNavigator
        '
        Me.Mov_politicoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Mov_politicoBindingNavigator.BindingSource = Me.Mov_politicoBindingSource
        Me.Mov_politicoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Mov_politicoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Mov_politicoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Mov_politicoBindingNavigatorSaveItem})
        Me.Mov_politicoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Mov_politicoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Mov_politicoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Mov_politicoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Mov_politicoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Mov_politicoBindingNavigator.Name = "Mov_politicoBindingNavigator"
        Me.Mov_politicoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Mov_politicoBindingNavigator.Size = New System.Drawing.Size(507, 25)
        Me.Mov_politicoBindingNavigator.TabIndex = 0
        Me.Mov_politicoBindingNavigator.Text = "BindingNavigator1"
        Me.Mov_politicoBindingNavigator.Visible = False
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
        'Mov_politicoBindingNavigatorSaveItem
        '
        Me.Mov_politicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Mov_politicoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Mov_politicoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Mov_politicoBindingNavigatorSaveItem.Name = "Mov_politicoBindingNavigatorSaveItem"
        Me.Mov_politicoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Mov_politicoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdmovLabel
        '
        IdmovLabel.AutoSize = True
        IdmovLabel.Location = New System.Drawing.Point(10, 33)
        IdmovLabel.Name = "IdmovLabel"
        IdmovLabel.Size = New System.Drawing.Size(43, 13)
        IdmovLabel.TabIndex = 1
        IdmovLabel.Text = "Codigo:"
        '
        'IdmovTextBox
        '
        Me.IdmovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mov_politicoBindingSource, "idmov", True))
        Me.IdmovTextBox.Location = New System.Drawing.Point(79, 30)
        Me.IdmovTextBox.Name = "IdmovTextBox"
        Me.IdmovTextBox.ReadOnly = True
        Me.IdmovTextBox.Size = New System.Drawing.Size(83, 20)
        Me.IdmovTextBox.TabIndex = 2
        '
        'MovimientoLabel
        '
        MovimientoLabel.AutoSize = True
        MovimientoLabel.Location = New System.Drawing.Point(10, 59)
        MovimientoLabel.Name = "MovimientoLabel"
        MovimientoLabel.Size = New System.Drawing.Size(64, 13)
        MovimientoLabel.TabIndex = 3
        MovimientoLabel.Text = "Movimiento:"
        '
        'MovimientoTextBox
        '
        Me.MovimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mov_politicoBindingSource, "movimiento", True))
        Me.MovimientoTextBox.Location = New System.Drawing.Point(79, 56)
        Me.MovimientoTextBox.Name = "MovimientoTextBox"
        Me.MovimientoTextBox.Size = New System.Drawing.Size(242, 20)
        Me.MovimientoTextBox.TabIndex = 4
        '
        'IdpaisLabel
        '
        IdpaisLabel.AutoSize = True
        IdpaisLabel.Location = New System.Drawing.Point(10, 85)
        IdpaisLabel.Name = "IdpaisLabel"
        IdpaisLabel.Size = New System.Drawing.Size(30, 13)
        IdpaisLabel.TabIndex = 5
        IdpaisLabel.Text = "Pais:"
        '
        'IdpaisTextBox
        '
        Me.IdpaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mov_politicoBindingSource, "idpais", True))
        Me.IdpaisTextBox.Location = New System.Drawing.Point(79, 82)
        Me.IdpaisTextBox.Name = "IdpaisTextBox"
        Me.IdpaisTextBox.ReadOnly = True
        Me.IdpaisTextBox.Size = New System.Drawing.Size(36, 20)
        Me.IdpaisTextBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.MovimientoTextBox)
        Me.GroupBox1.Controls.Add(IdmovLabel)
        Me.GroupBox1.Controls.Add(Me.IdpaisTextBox)
        Me.GroupBox1.Controls.Add(Me.IdmovTextBox)
        Me.GroupBox1.Controls.Add(IdpaisLabel)
        Me.GroupBox1.Controls.Add(MovimientoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 131)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.memorias.My.Resources.Resources.Brushed_Metal_1
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 147)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(365, 53)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.AceptarToolStripMenuItem.Image = Global.memorias.My.Resources.Resources.archive
        Me.AceptarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(64, 49)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        Me.AceptarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.memorias.My.Resources.Resources.plus1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(297, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'movpolitico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Mov_politicoBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "movpolitico"
        Me.ShowInTaskbar = False
        Me.Text = "Movimiento Politico"
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_politicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_politicoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mov_politicoBindingNavigator.ResumeLayout(False)
        Me.Mov_politicoBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents Mov_politicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_politicoTableAdapter As memorias.dtsetTableAdapters.mov_politicoTableAdapter
    Friend WithEvents Mov_politicoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Mov_politicoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdmovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MovimientoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdpaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

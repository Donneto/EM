<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iniciomemorias
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.MemoriasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MemoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtset = New memorias.dtset
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListamemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.rptmemoriaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MemoriasTableAdapter = New memorias.dtsetTableAdapters.memoriasTableAdapter
        Me.Vta_memoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vta_memoriasTableAdapter = New memorias.dtsetTableAdapters.vta_memoriasTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MemoriasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Vta_memoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese un titulo para buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(584, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MemoriasDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 328)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado:"
        '
        'MemoriasDataGridView
        '
        Me.MemoriasDataGridView.AllowUserToAddRows = False
        Me.MemoriasDataGridView.AllowUserToDeleteRows = False
        Me.MemoriasDataGridView.AutoGenerateColumns = False
        Me.MemoriasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MemoriasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MemoriasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MemoriasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.MemoriasDataGridView.DataSource = Me.MemoriasBindingSource
        Me.MemoriasDataGridView.Location = New System.Drawing.Point(7, 19)
        Me.MemoriasDataGridView.MultiSelect = False
        Me.MemoriasDataGridView.Name = "MemoriasDataGridView"
        Me.MemoriasDataGridView.ReadOnly = True
        Me.MemoriasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MemoriasDataGridView.Size = New System.Drawing.Size(584, 298)
        Me.MemoriasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idmemoria"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo:"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 69
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "archivo"
        Me.DataGridViewImageColumn1.HeaderText = "archivo"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tema"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Titulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 59
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 89
        '
        'MemoriasBindingSource
        '
        Me.MemoriasBindingSource.DataMember = "memorias"
        Me.MemoriasBindingSource.DataSource = Me.Dtset
        '
        'Dtset
        '
        Me.Dtset.DataSetName = "dtset"
        Me.Dtset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.CerrarToolStripMenuItem, Me.ListamemToolStripMenuItem1, Me.rptmemoriaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 434)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(620, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ListamemToolStripMenuItem1
        '
        Me.ListamemToolStripMenuItem1.Name = "ListamemToolStripMenuItem1"
        Me.ListamemToolStripMenuItem1.Size = New System.Drawing.Size(104, 20)
        Me.ListamemToolStripMenuItem1.Text = "Lista de memorias"
        '
        'rptmemoriaToolStripMenuItem1
        '
        Me.rptmemoriaToolStripMenuItem1.Name = "rptmemoriaToolStripMenuItem1"
        Me.rptmemoriaToolStripMenuItem1.Size = New System.Drawing.Size(78, 20)
        Me.rptmemoriaToolStripMenuItem1.Text = "Ver memoria"
        '
        'MemoriasTableAdapter
        '
        Me.MemoriasTableAdapter.ClearBeforeFill = True
        '
        'Vta_memoriasBindingSource
        '
        Me.Vta_memoriasBindingSource.DataMember = "vta_memorias"
        Me.Vta_memoriasBindingSource.DataSource = Me.Dtset
        '
        'Vta_memoriasTableAdapter
        '
        Me.Vta_memoriasTableAdapter.ClearBeforeFill = True
        '
        'iniciomemorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "iniciomemorias"
        Me.ShowInTaskbar = False
        Me.Text = "Memorias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.MemoriasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Vta_memoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemoriasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents MemoriasTableAdapter As memorias.dtsetTableAdapters.memoriasTableAdapter
    Friend WithEvents ListamemToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Vta_memoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vta_memoriasTableAdapter As memorias.dtsetTableAdapters.vta_memoriasTableAdapter
    Friend WithEvents rptmemoriaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class

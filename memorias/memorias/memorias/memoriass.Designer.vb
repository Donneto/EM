<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memoriass
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
        Dim IdmemoriaLabel As System.Windows.Forms.Label
        Dim TemaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IdmemoriaTextBox = New System.Windows.Forms.TextBox
        Me.MemoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtset = New memorias.dtset
        Me.TemaTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReporteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MemoriasTableAdapter = New memorias.dtsetTableAdapters.memoriasTableAdapter
        Me.Vta_memoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vta_memoriasTableAdapter = New memorias.dtsetTableAdapters.vta_memoriasTableAdapter
        IdmemoriaLabel = New System.Windows.Forms.Label
        TemaLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.MemoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vta_memoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdmemoriaLabel
        '
        IdmemoriaLabel.AutoSize = True
        IdmemoriaLabel.Location = New System.Drawing.Point(11, 36)
        IdmemoriaLabel.Name = "IdmemoriaLabel"
        IdmemoriaLabel.Size = New System.Drawing.Size(43, 13)
        IdmemoriaLabel.TabIndex = 0
        IdmemoriaLabel.Text = "Codigo:"
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.Location = New System.Drawing.Point(11, 62)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(37, 13)
        TemaLabel.TabIndex = 2
        TemaLabel.Text = "Tema:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(11, 88)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdmemoriaLabel)
        Me.GroupBox1.Controls.Add(Me.IdmemoriaTextBox)
        Me.GroupBox1.Controls.Add(TemaLabel)
        Me.GroupBox1.Controls.Add(Me.TemaTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 425)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Memorias"
        '
        'IdmemoriaTextBox
        '
        Me.IdmemoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemoriasBindingSource, "idmemoria", True))
        Me.IdmemoriaTextBox.Enabled = False
        Me.IdmemoriaTextBox.Location = New System.Drawing.Point(81, 33)
        Me.IdmemoriaTextBox.Name = "IdmemoriaTextBox"
        Me.IdmemoriaTextBox.Size = New System.Drawing.Size(57, 20)
        Me.IdmemoriaTextBox.TabIndex = 1
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
        'TemaTextBox
        '
        Me.TemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemoriasBindingSource, "tema", True))
        Me.TemaTextBox.Location = New System.Drawing.Point(81, 59)
        Me.TemaTextBox.Name = "TemaTextBox"
        Me.TemaTextBox.Size = New System.Drawing.Size(568, 20)
        Me.TemaTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemoriasBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(81, 85)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(568, 327)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.ReporteToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 443)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(673, 24)
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
        'ReporteToolStripMenuItem1
        '
        Me.ReporteToolStripMenuItem1.Name = "ReporteToolStripMenuItem1"
        Me.ReporteToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.ReporteToolStripMenuItem1.Text = "Reporte"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        'memoriass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "memoriass"
        Me.ShowInTaskbar = False
        Me.Text = "Memorias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MemoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vta_memoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MemoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdmemoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Dtset As memorias.dtset
    Friend WithEvents MemoriasTableAdapter As memorias.dtsetTableAdapters.memoriasTableAdapter
    Friend WithEvents ReporteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Vta_memoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vta_memoriasTableAdapter As memorias.dtsetTableAdapters.vta_memoriasTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARTABLAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_tsillon = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_cuero = New System.Windows.Forms.RadioButton()
        Me.rb_cuerina = New System.Windows.Forms.RadioButton()
        Me.txt_nventa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.n_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_tela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_sillon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARTABLAToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(999, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(189, 29)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARTABLAToolStripMenuItem
        '
        Me.LIMPIARTABLAToolStripMenuItem.Name = "LIMPIARTABLAToolStripMenuItem"
        Me.LIMPIARTABLAToolStripMenuItem.Size = New System.Drawing.Size(156, 29)
        Me.LIMPIARTABLAToolStripMenuItem.Text = "LIMPIAR TABLA "
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(183, 29)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_tsillon)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_nventa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(774, 204)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS:"
        '
        'cb_tsillon
        '
        Me.cb_tsillon.FormattingEnabled = True
        Me.cb_tsillon.Items.AddRange(New Object() {"Sofa", "Individual", "Doble"})
        Me.cb_tsillon.Location = New System.Drawing.Point(572, 82)
        Me.cb_tsillon.Name = "cb_tsillon"
        Me.cb_tsillon.Size = New System.Drawing.Size(121, 29)
        Me.cb_tsillon.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(568, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tamaño sillon:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_cuero)
        Me.GroupBox2.Controls.Add(Me.rb_cuerina)
        Me.GroupBox2.Location = New System.Drawing.Point(306, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 125)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tela:"
        '
        'rb_cuero
        '
        Me.rb_cuero.AutoSize = True
        Me.rb_cuero.Location = New System.Drawing.Point(33, 80)
        Me.rb_cuero.Name = "rb_cuero"
        Me.rb_cuero.Size = New System.Drawing.Size(77, 25)
        Me.rb_cuero.TabIndex = 1
        Me.rb_cuero.TabStop = True
        Me.rb_cuero.Text = "Cuero"
        Me.rb_cuero.UseVisualStyleBackColor = True
        '
        'rb_cuerina
        '
        Me.rb_cuerina.AutoSize = True
        Me.rb_cuerina.Location = New System.Drawing.Point(33, 28)
        Me.rb_cuerina.Name = "rb_cuerina"
        Me.rb_cuerina.Size = New System.Drawing.Size(90, 25)
        Me.rb_cuerina.TabIndex = 0
        Me.rb_cuerina.TabStop = True
        Me.rb_cuerina.Text = "Cuerina"
        Me.rb_cuerina.UseVisualStyleBackColor = True
        '
        'txt_nventa
        '
        Me.txt_nventa.Location = New System.Drawing.Point(139, 53)
        Me.txt_nventa.Name = "txt_nventa"
        Me.txt_nventa.Size = New System.Drawing.Size(100, 33)
        Me.txt_nventa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Venta:"
        '
        'tabla
        '
        Me.tabla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.n_venta, Me.t_tela, Me.t_sillon, Me.p_costo, Me.p_venta})
        Me.tabla.Location = New System.Drawing.Point(13, 291)
        Me.tabla.Name = "tabla"
        Me.tabla.RowHeadersWidth = 62
        Me.tabla.RowTemplate.Height = 28
        Me.tabla.Size = New System.Drawing.Size(815, 158)
        Me.tabla.TabIndex = 2
        '
        'n_venta
        '
        Me.n_venta.HeaderText = "No. Venta"
        Me.n_venta.MinimumWidth = 8
        Me.n_venta.Name = "n_venta"
        Me.n_venta.Width = 150
        '
        't_tela
        '
        Me.t_tela.HeaderText = "Tela"
        Me.t_tela.MinimumWidth = 8
        Me.t_tela.Name = "t_tela"
        Me.t_tela.Width = 150
        '
        't_sillon
        '
        Me.t_sillon.HeaderText = "Tamaño sillon"
        Me.t_sillon.MinimumWidth = 8
        Me.t_sillon.Name = "t_sillon"
        Me.t_sillon.Width = 150
        '
        'p_costo
        '
        Me.p_costo.HeaderText = "Precio costo"
        Me.p_costo.MinimumWidth = 8
        Me.p_costo.Name = "p_costo"
        Me.p_costo.Width = 150
        '
        'p_venta
        '
        Me.p_venta.HeaderText = "Precio venta"
        Me.p_venta.MinimumWidth = 8
        Me.p_venta.Name = "p_venta"
        Me.p_venta.Width = 150
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_calcular.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(829, 116)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(139, 79)
        Me.btn_calcular.TabIndex = 3
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global._201800934_SILLONES.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(999, 494)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("MV Boli", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "SISTEMA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LIMPIARTABLAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_tsillon As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_cuero As RadioButton
    Friend WithEvents rb_cuerina As RadioButton
    Friend WithEvents txt_nventa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabla As DataGridView
    Friend WithEvents n_venta As DataGridViewTextBoxColumn
    Friend WithEvents t_tela As DataGridViewTextBoxColumn
    Friend WithEvents t_sillon As DataGridViewTextBoxColumn
    Friend WithEvents p_costo As DataGridViewTextBoxColumn
    Friend WithEvents p_venta As DataGridViewTextBoxColumn
    Friend WithEvents btn_calcular As Button
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class win_tipo_pago
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(win_tipo_pago))
        Me.DGW_Pagos = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WinTittle1 = New PagoNet.CustomControls.WinTittle()
        Me.LblResumenTotalizar1 = New PagoNet.CustomControls.LblResumenTotalizar()
        Me.LblResumenTotalizar2 = New PagoNet.CustomControls.LblResumenTotalizar()
        Me.LblResumenTotalizar3 = New PagoNet.CustomControls.LblResumenTotalizar()
        Me.LblResumenTotalizar4 = New PagoNet.CustomControls.LblResumenTotalizar()
        CType(Me.DGW_Pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW_Pagos
        '
        Me.DGW_Pagos.AllowUserToResizeColumns = False
        Me.DGW_Pagos.AllowUserToResizeRows = False
        Me.DGW_Pagos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGW_Pagos.BackgroundColor = System.Drawing.Color.White
        Me.DGW_Pagos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGW_Pagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Pagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Pagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DGW_Pagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DGW_Pagos.EnableHeadersVisualStyles = False
        Me.DGW_Pagos.GridColor = System.Drawing.Color.Silver
        Me.DGW_Pagos.Location = New System.Drawing.Point(12, 160)
        Me.DGW_Pagos.Name = "DGW_Pagos"
        Me.DGW_Pagos.RowHeadersVisible = False
        Me.DGW_Pagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGW_Pagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGW_Pagos.Size = New System.Drawing.Size(813, 194)
        Me.DGW_Pagos.TabIndex = 1000000109
        '
        'Column5
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column5.HeaderText = "#"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        Me.Column5.Width = 80
        '
        'Column1
        '
        Me.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Column1.HeaderText = "FORMA DE PAGO"
        Me.Column1.Items.AddRange(New Object() {"EFECTIVO", "T. DEBITO"})
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 190
        '
        'Column2
        '
        Me.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Column2.HeaderText = "BANCO"
        Me.Column2.Items.AddRange(New Object() {"BOD - 8537", "BANCO OCCIDENTAL DE DESCUENTO - 1157"})
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Width = 270
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "REFERENCIA"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "MONTO RECIBIDO"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 245
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(21, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 15)
        Me.Label18.TabIndex = 1000000106
        Me.Label18.Text = "Impuesto Acumulado:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 15)
        Me.Label15.TabIndex = 1000000103
        Me.Label15.Text = "(-) Descuentos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 16)
        Me.Label11.TabIndex = 1000000099
        Me.Label11.Text = "TOTAL OPERACION:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 1000000097
        Me.Label7.Text = "Total Bruto:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(434, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(391, 35)
        Me.Label8.TabIndex = 1000000096
        Me.Label8.Text = "0,00 Bs.S."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(738, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 32)
        Me.Button2.TabIndex = 1000000094
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(612, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 32)
        Me.Button1.TabIndex = 1000000093
        Me.Button1.Text = "F11 - Procesar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(434, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 37)
        Me.Label2.TabIndex = 1000000092
        Me.Label2.Text = "0,00 Bs.S."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(430, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 23)
        Me.Label1.TabIndex = 1000000091
        Me.Label1.Text = "Saldo Actual:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 1000000095
        Me.Label4.Text = "Devolucion:"
        '
        'WinTittle1
        '
        Me.WinTittle1.AlingText = System.Drawing.ContentAlignment.MiddleLeft
        Me.WinTittle1.BottomHide = True
        Me.WinTittle1.Color = System.Drawing.Color.SteelBlue
        Me.WinTittle1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinTittle1.FormParent = Me
        Me.WinTittle1.Location = New System.Drawing.Point(0, 0)
        Me.WinTittle1.Name = "WinTittle1"
        Me.WinTittle1.Size = New System.Drawing.Size(837, 30)
        Me.WinTittle1.TabIndex = 1000000110
        Me.WinTittle1.TextColor = System.Drawing.Color.White
        Me.WinTittle1.Titulo = "metodo de pago"
        '
        'LblResumenTotalizar1
        '
        Me.LblResumenTotalizar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LblResumenTotalizar1.Location = New System.Drawing.Point(153, 36)
        Me.LblResumenTotalizar1.Moneda = Nothing
        Me.LblResumenTotalizar1.Monto = 0.0R
        Me.LblResumenTotalizar1.Name = "LblResumenTotalizar1"
        Me.LblResumenTotalizar1.Size = New System.Drawing.Size(275, 25)
        Me.LblResumenTotalizar1.TabIndex = 1000000111
        '
        'LblResumenTotalizar2
        '
        Me.LblResumenTotalizar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LblResumenTotalizar2.Location = New System.Drawing.Point(153, 67)
        Me.LblResumenTotalizar2.Moneda = Nothing
        Me.LblResumenTotalizar2.Monto = 0.0R
        Me.LblResumenTotalizar2.Name = "LblResumenTotalizar2"
        Me.LblResumenTotalizar2.Size = New System.Drawing.Size(275, 25)
        Me.LblResumenTotalizar2.TabIndex = 1000000112
        '
        'LblResumenTotalizar3
        '
        Me.LblResumenTotalizar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LblResumenTotalizar3.Location = New System.Drawing.Point(153, 98)
        Me.LblResumenTotalizar3.Moneda = Nothing
        Me.LblResumenTotalizar3.Monto = 0.0R
        Me.LblResumenTotalizar3.Name = "LblResumenTotalizar3"
        Me.LblResumenTotalizar3.Size = New System.Drawing.Size(275, 25)
        Me.LblResumenTotalizar3.TabIndex = 1000000113
        '
        'LblResumenTotalizar4
        '
        Me.LblResumenTotalizar4.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LblResumenTotalizar4.Location = New System.Drawing.Point(153, 129)
        Me.LblResumenTotalizar4.Moneda = Nothing
        Me.LblResumenTotalizar4.Monto = 0.0R
        Me.LblResumenTotalizar4.Name = "LblResumenTotalizar4"
        Me.LblResumenTotalizar4.Size = New System.Drawing.Size(275, 25)
        Me.LblResumenTotalizar4.TabIndex = 1000000114
        '
        'win_tipo_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(837, 404)
        Me.Controls.Add(Me.LblResumenTotalizar4)
        Me.Controls.Add(Me.LblResumenTotalizar3)
        Me.Controls.Add(Me.LblResumenTotalizar2)
        Me.Controls.Add(Me.LblResumenTotalizar1)
        Me.Controls.Add(Me.WinTittle1)
        Me.Controls.Add(Me.DGW_Pagos)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "win_tipo_pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "win_tipo_pago"
        CType(Me.DGW_Pagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGW_Pagos As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WinTittle1 As PagoNet.CustomControls.WinTittle
    Friend WithEvents LblResumenTotalizar4 As PagoNet.CustomControls.LblResumenTotalizar
    Friend WithEvents LblResumenTotalizar3 As PagoNet.CustomControls.LblResumenTotalizar
    Friend WithEvents LblResumenTotalizar2 As PagoNet.CustomControls.LblResumenTotalizar
    Friend WithEvents LblResumenTotalizar1 As PagoNet.CustomControls.LblResumenTotalizar
End Class

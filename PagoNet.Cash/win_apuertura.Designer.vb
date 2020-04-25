<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class win_apuertura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(win_apuertura))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CombCaja = New System.Windows.Forms.ComboBox()
        Me.CombTurno = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_de = New System.Windows.Forms.Label()
        Me.lbl_hasta = New System.Windows.Forms.Label()
        Me.DTG_Apertura = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_cajero = New System.Windows.Forms.Label()
        Me.WinTittle1 = New PagoNet.CustomControls.WinTittle()
        CType(Me.DTG_Apertura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(369, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 1000000057
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(261, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 32)
        Me.Button1.TabIndex = 1000000056
        Me.Button1.Text = "F2 - Aperturar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 1000000059
        Me.Label1.Text = "Cajero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 1000000061
        Me.Label2.Text = "Caja:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 1000000063
        Me.Label3.Text = "Fondo Inical:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 1000000067
        Me.Label4.Text = "Turno:"
        '
        'CombCaja
        '
        Me.CombCaja.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombCaja.FormattingEnabled = True
        Me.CombCaja.Location = New System.Drawing.Point(64, 68)
        Me.CombCaja.Name = "CombCaja"
        Me.CombCaja.Size = New System.Drawing.Size(258, 24)
        Me.CombCaja.TabIndex = 1000000068
        '
        'CombTurno
        '
        Me.CombTurno.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombTurno.FormattingEnabled = True
        Me.CombTurno.Location = New System.Drawing.Point(64, 97)
        Me.CombTurno.Name = "CombTurno"
        Me.CombTurno.Size = New System.Drawing.Size(258, 24)
        Me.CombTurno.TabIndex = 1000000069
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(328, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 1000000070
        Me.Label6.Text = "Desde:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(386, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 15)
        Me.Label7.TabIndex = 1000000071
        Me.Label7.Text = "Hasta:"
        '
        'lbl_de
        '
        Me.lbl_de.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbl_de.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_de.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_de.Location = New System.Drawing.Point(328, 97)
        Me.lbl_de.Name = "lbl_de"
        Me.lbl_de.Size = New System.Drawing.Size(55, 23)
        Me.lbl_de.TabIndex = 1000000072
        Me.lbl_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbl_hasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_hasta.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.Location = New System.Drawing.Point(389, 97)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(55, 23)
        Me.lbl_hasta.TabIndex = 1000000073
        Me.lbl_hasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTG_Apertura
        '
        Me.DTG_Apertura.AllowUserToDeleteRows = False
        Me.DTG_Apertura.AllowUserToOrderColumns = True
        Me.DTG_Apertura.AllowUserToResizeColumns = False
        Me.DTG_Apertura.AllowUserToResizeRows = False
        Me.DTG_Apertura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTG_Apertura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DTG_Apertura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTG_Apertura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTG_Apertura.DefaultCellStyle = DataGridViewCellStyle3
        Me.DTG_Apertura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DTG_Apertura.EnableHeadersVisualStyles = False
        Me.DTG_Apertura.Location = New System.Drawing.Point(12, 141)
        Me.DTG_Apertura.MultiSelect = False
        Me.DTG_Apertura.Name = "DTG_Apertura"
        Me.DTG_Apertura.RowHeadersVisible = False
        Me.DTG_Apertura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DTG_Apertura.Size = New System.Drawing.Size(432, 85)
        Me.DTG_Apertura.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Column2.HeaderText = "Moneda"
        Me.Column2.Items.AddRange(New Object() {"BOLIVAR", "DOLAR"})
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 165
        '
        'Column3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Monto"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 250
        '
        'lbl_cajero
        '
        Me.lbl_cajero.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbl_cajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cajero.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cajero.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_cajero.Location = New System.Drawing.Point(64, 39)
        Me.lbl_cajero.Name = "lbl_cajero"
        Me.lbl_cajero.Size = New System.Drawing.Size(258, 23)
        Me.lbl_cajero.TabIndex = 1000000075
        Me.lbl_cajero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WinTittle1
        '
        Me.WinTittle1.AlingText = System.Drawing.ContentAlignment.MiddleLeft
        Me.WinTittle1.BottomHide = True
        Me.WinTittle1.Color = System.Drawing.Color.SteelBlue
        Me.WinTittle1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinTittle1.FormParent = Nothing
        Me.WinTittle1.Location = New System.Drawing.Point(0, 0)
        Me.WinTittle1.Name = "WinTittle1"
        Me.WinTittle1.Size = New System.Drawing.Size(455, 30)
        Me.WinTittle1.TabIndex = 1000000076
        Me.WinTittle1.TextColor = System.Drawing.Color.White
        Me.WinTittle1.Titulo = "APERTURA DE CAJA"
        '
        'win_apuertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(455, 279)
        Me.Controls.Add(Me.WinTittle1)
        Me.Controls.Add(Me.lbl_cajero)
        Me.Controls.Add(Me.DTG_Apertura)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_de)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CombTurno)
        Me.Controls.Add(Me.CombCaja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "win_apuertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Starter"
        CType(Me.DTG_Apertura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CombCaja As System.Windows.Forms.ComboBox
    Friend WithEvents CombTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_de As System.Windows.Forms.Label
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents DTG_Apertura As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_cajero As System.Windows.Forms.Label
    Friend WithEvents WinTittle1 As PagoNet.CustomControls.WinTittle
End Class

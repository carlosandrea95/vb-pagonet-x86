<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class win_busqueda
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.lbl_lab_codigo = New System.Windows.Forms.Label()
        Me.WinTittle1 = New PagoNet.CustomControls.WinTittle()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 78)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(989, 357)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CODIGO:"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DESCRIPCIÓN:"
        Me.ColumnHeader3.Width = 500
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PRECIO:"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 200
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(17, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 357)
        Me.Panel1.TabIndex = 1000000022
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_codigo)
        Me.Panel3.Controls.Add(Me.lbl_lab_codigo)
        Me.Panel3.Location = New System.Drawing.Point(12, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(989, 43)
        Me.Panel3.TabIndex = 1000000024
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.White
        Me.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(0, 15)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(509, 21)
        Me.txt_codigo.TabIndex = 0
        '
        'lbl_lab_codigo
        '
        Me.lbl_lab_codigo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lab_codigo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lab_codigo.ForeColor = System.Drawing.Color.White
        Me.lbl_lab_codigo.Location = New System.Drawing.Point(-2, -1)
        Me.lbl_lab_codigo.Name = "lbl_lab_codigo"
        Me.lbl_lab_codigo.Size = New System.Drawing.Size(130, 16)
        Me.lbl_lab_codigo.TabIndex = 101
        Me.lbl_lab_codigo.Text = "PALABRA CLAVE:"
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
        Me.WinTittle1.Size = New System.Drawing.Size(1018, 30)
        Me.WinTittle1.TabIndex = 1000000025
        Me.WinTittle1.TabStop = False
        Me.WinTittle1.TextColor = System.Drawing.Color.White
        Me.WinTittle1.Titulo = "busqueda de producto"
        '
        'win_busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1018, 452)
        Me.Controls.Add(Me.WinTittle1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "win_busqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_lab_codigo As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents WinTittle1 As PagoNet.CustomControls.WinTittle
End Class

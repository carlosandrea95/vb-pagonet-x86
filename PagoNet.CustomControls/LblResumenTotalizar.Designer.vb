<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LblResumenTotalizar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.LblMoneda = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblMonto
        '
        Me.LblMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMonto.BackColor = System.Drawing.Color.LemonChiffon
        Me.LblMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMonto.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonto.Location = New System.Drawing.Point(0, 0)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(183, 25)
        Me.LblMonto.TabIndex = 1000000070
        Me.LblMonto.Text = "75.892,86"
        Me.LblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMoneda
        '
        Me.LblMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMoneda.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblMoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMoneda.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoneda.Location = New System.Drawing.Point(181, 1)
        Me.LblMoneda.Name = "LblMoneda"
        Me.LblMoneda.Size = New System.Drawing.Size(35, 23)
        Me.LblMoneda.TabIndex = 1000000071
        Me.LblMoneda.Text = "Bs.S."
        Me.LblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblResumenTotalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.LblMonto)
        Me.Controls.Add(Me.LblMoneda)
        Me.Name = "LblResumenTotalizar"
        Me.Size = New System.Drawing.Size(218, 25)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblMonto As System.Windows.Forms.Label
    Private WithEvents LblMoneda As System.Windows.Forms.Label

End Class

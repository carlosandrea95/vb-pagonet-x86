<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertBox))
        Me.lblAsunto = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.RichTextBox()
        Me.IsCancel = New System.Windows.Forms.Button()
        Me.IsOk = New System.Windows.Forms.Button()
        Me.WinTittle1 = New PagoNet.CustomControls.WinTittle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAsunto
        '
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsunto.Location = New System.Drawing.Point(120, 33)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(179, 15)
        Me.lblAsunto.TabIndex = 1000000057
        Me.lblAsunto.Text = "Error Encontrado Base de Datos"
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.White
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(123, 51)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.lblMessage.Size = New System.Drawing.Size(234, 75)
        Me.lblMessage.TabIndex = 1000000058
        Me.lblMessage.Text = ""
        '
        'IsCancel
        '
        Me.IsCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsCancel.BackColor = System.Drawing.Color.Firebrick
        Me.IsCancel.FlatAppearance.BorderSize = 0
        Me.IsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IsCancel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsCancel.ForeColor = System.Drawing.Color.White
        Me.IsCancel.Image = CType(resources.GetObject("IsCancel.Image"), System.Drawing.Image)
        Me.IsCancel.Location = New System.Drawing.Point(282, 132)
        Me.IsCancel.Name = "IsCancel"
        Me.IsCancel.Size = New System.Drawing.Size(75, 25)
        Me.IsCancel.TabIndex = 1000000060
        Me.IsCancel.Text = "Cancelar"
        Me.IsCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IsCancel.UseVisualStyleBackColor = False
        '
        'IsOk
        '
        Me.IsOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsOk.BackColor = System.Drawing.Color.ForestGreen
        Me.IsOk.FlatAppearance.BorderSize = 0
        Me.IsOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IsOk.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsOk.ForeColor = System.Drawing.Color.White
        Me.IsOk.Image = CType(resources.GetObject("IsOk.Image"), System.Drawing.Image)
        Me.IsOk.Location = New System.Drawing.Point(174, 132)
        Me.IsOk.Name = "IsOk"
        Me.IsOk.Size = New System.Drawing.Size(102, 25)
        Me.IsOk.TabIndex = 1000000059
        Me.IsOk.Text = "Aceptar"
        Me.IsOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IsOk.UseVisualStyleBackColor = False
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
        Me.WinTittle1.Size = New System.Drawing.Size(366, 30)
        Me.WinTittle1.TabIndex = 1000000061
        Me.WinTittle1.TextColor = System.Drawing.Color.White
        Me.WinTittle1.Titulo = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1000000062
        Me.PictureBox1.TabStop = False
        '
        'AlertBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WinTittle1)
        Me.Controls.Add(Me.IsCancel)
        Me.Controls.Add(Me.IsOk)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblAsunto)
        Me.Name = "AlertBox"
        Me.Size = New System.Drawing.Size(366, 164)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents IsCancel As System.Windows.Forms.Button
    Friend WithEvents IsOk As System.Windows.Forms.Button
    Friend WithEvents WinTittle1 As PagoNet.CustomControls.WinTittle
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

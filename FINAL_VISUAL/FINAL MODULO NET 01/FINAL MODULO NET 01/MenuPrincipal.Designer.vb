<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ADMINISTRACIONDEIMAGENESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRODEPRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINISTRACIONDEARCHIVOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRODENOTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACERCADEMENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADMINISTRACIONDEIMAGENESToolStripMenuItem, Me.REGISTRODEPRODUCTOSToolStripMenuItem, Me.ADMINISTRACIONDEARCHIVOSToolStripMenuItem, Me.REGISTRODENOTASToolStripMenuItem, Me.ACERCADEMENUToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(677, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ADMINISTRACIONDEIMAGENESToolStripMenuItem
        '
        Me.ADMINISTRACIONDEIMAGENESToolStripMenuItem.Name = "ADMINISTRACIONDEIMAGENESToolStripMenuItem"
        Me.ADMINISTRACIONDEIMAGENESToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.ADMINISTRACIONDEIMAGENESToolStripMenuItem.Text = "ADM. DE IMAGENES"
        '
        'REGISTRODEPRODUCTOSToolStripMenuItem
        '
        Me.REGISTRODEPRODUCTOSToolStripMenuItem.Name = "REGISTRODEPRODUCTOSToolStripMenuItem"
        Me.REGISTRODEPRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.REGISTRODEPRODUCTOSToolStripMenuItem.Text = "REGISTRO DE PRODUCTOS"
        '
        'ADMINISTRACIONDEARCHIVOSToolStripMenuItem
        '
        Me.ADMINISTRACIONDEARCHIVOSToolStripMenuItem.Name = "ADMINISTRACIONDEARCHIVOSToolStripMenuItem"
        Me.ADMINISTRACIONDEARCHIVOSToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.ADMINISTRACIONDEARCHIVOSToolStripMenuItem.Text = "ADM. DE ARCHIVOS"
        '
        'REGISTRODENOTASToolStripMenuItem
        '
        Me.REGISTRODENOTASToolStripMenuItem.Name = "REGISTRODENOTASToolStripMenuItem"
        Me.REGISTRODENOTASToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.REGISTRODENOTASToolStripMenuItem.Text = "REGISTRO DE NOTAS"
        '
        'ACERCADEMENUToolStripMenuItem
        '
        Me.ACERCADEMENUToolStripMenuItem.Name = "ACERCADEMENUToolStripMenuItem"
        Me.ACERCADEMENUToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ACERCADEMENUToolStripMenuItem.Text = "ACERCA DE MENU"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 302)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(677, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FINAL_MODULO_NET_01.My.Resources.Resources.Desert
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(665, 351)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FINAL_MODULO_NET_01.My.Resources.Resources.icon
        Me.PictureBox2.Location = New System.Drawing.Point(545, 200)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 324)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ADMINISTRACIONDEIMAGENESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRODEPRODUCTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMINISTRACIONDEARCHIVOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRODENOTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACERCADEMENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class

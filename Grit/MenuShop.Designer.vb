<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuShop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuShop))
        Me.colatext = New System.Windows.Forms.PictureBox()
        Me.BatText = New System.Windows.Forms.PictureBox()
        Me.GunText = New System.Windows.Forms.PictureBox()
        Me.colabutton = New System.Windows.Forms.Label()
        Me.batbutton = New System.Windows.Forms.Label()
        Me.gunbutton = New System.Windows.Forms.Label()
        Me.LabelCashShop = New System.Windows.Forms.Label()
        CType(Me.colatext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colatext
        '
        Me.colatext.BackgroundImage = Global.Grit.My.Resources.Resources.colatext
        Me.colatext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.colatext.Location = New System.Drawing.Point(12, 178)
        Me.colatext.Name = "colatext"
        Me.colatext.Size = New System.Drawing.Size(377, 159)
        Me.colatext.TabIndex = 3
        Me.colatext.TabStop = False
        '
        'BatText
        '
        Me.BatText.BackgroundImage = CType(resources.GetObject("BatText.BackgroundImage"), System.Drawing.Image)
        Me.BatText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BatText.Location = New System.Drawing.Point(12, 178)
        Me.BatText.Name = "BatText"
        Me.BatText.Size = New System.Drawing.Size(377, 159)
        Me.BatText.TabIndex = 4
        Me.BatText.TabStop = False
        '
        'GunText
        '
        Me.GunText.BackgroundImage = CType(resources.GetObject("GunText.BackgroundImage"), System.Drawing.Image)
        Me.GunText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunText.Location = New System.Drawing.Point(12, 178)
        Me.GunText.Name = "GunText"
        Me.GunText.Size = New System.Drawing.Size(377, 159)
        Me.GunText.TabIndex = 6
        Me.GunText.TabStop = False
        '
        'colabutton
        '
        Me.colabutton.BackColor = System.Drawing.Color.Transparent
        Me.colabutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.colabutton.Location = New System.Drawing.Point(78, 710)
        Me.colabutton.Name = "colabutton"
        Me.colabutton.Size = New System.Drawing.Size(293, 233)
        Me.colabutton.TabIndex = 8
        '
        'batbutton
        '
        Me.batbutton.BackColor = System.Drawing.Color.Transparent
        Me.batbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.batbutton.Location = New System.Drawing.Point(495, 785)
        Me.batbutton.Name = "batbutton"
        Me.batbutton.Size = New System.Drawing.Size(293, 188)
        Me.batbutton.TabIndex = 9
        '
        'gunbutton
        '
        Me.gunbutton.BackColor = System.Drawing.Color.Transparent
        Me.gunbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gunbutton.Location = New System.Drawing.Point(899, 710)
        Me.gunbutton.Name = "gunbutton"
        Me.gunbutton.Size = New System.Drawing.Size(322, 233)
        Me.gunbutton.TabIndex = 10
        '
        'LabelCashShop
        '
        Me.LabelCashShop.AutoSize = True
        Me.LabelCashShop.BackColor = System.Drawing.SystemColors.Control
        Me.LabelCashShop.Font = New System.Drawing.Font("Lucida Sans", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCashShop.ForeColor = System.Drawing.Color.Lime
        Me.LabelCashShop.Location = New System.Drawing.Point(927, 231)
        Me.LabelCashShop.Name = "LabelCashShop"
        Me.LabelCashShop.Size = New System.Drawing.Size(128, 39)
        Me.LabelCashShop.TabIndex = 11
        Me.LabelCashShop.Text = "Label1"
        '
        'MenuShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 1006)
        Me.Controls.Add(Me.LabelCashShop)
        Me.Controls.Add(Me.gunbutton)
        Me.Controls.Add(Me.batbutton)
        Me.Controls.Add(Me.colabutton)
        Me.Controls.Add(Me.GunText)
        Me.Controls.Add(Me.BatText)
        Me.Controls.Add(Me.colatext)
        Me.DoubleBuffered = True
        Me.Name = "MenuShop"
        Me.Text = "MenuShop"
        CType(Me.colatext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colatext As PictureBox
    Friend WithEvents BatText As PictureBox
    Friend WithEvents GunText As PictureBox
    Friend WithEvents colabutton As Label
    Friend WithEvents batbutton As Label
    Friend WithEvents gunbutton As Label
    Friend WithEvents LabelCashShop As Label
End Class

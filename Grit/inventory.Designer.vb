<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventory))
        Me.colalabel = New System.Windows.Forms.Label()
        Me.CashLabel = New System.Windows.Forms.Label()
        Me.BatQMark = New System.Windows.Forms.PictureBox()
        Me.GunQMark = New System.Windows.Forms.PictureBox()
        Me.coladrinklabel = New System.Windows.Forms.Label()
        Me.labelfisteqp = New System.Windows.Forms.Label()
        Me.labelguneqp = New System.Windows.Forms.Label()
        Me.labelbateqp = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BatQMark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunQMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colalabel
        '
        Me.colalabel.AutoSize = True
        Me.colalabel.BackColor = System.Drawing.Color.Transparent
        Me.colalabel.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colalabel.Location = New System.Drawing.Point(288, 189)
        Me.colalabel.Name = "colalabel"
        Me.colalabel.Size = New System.Drawing.Size(0, 80)
        Me.colalabel.TabIndex = 4
        '
        'CashLabel
        '
        Me.CashLabel.AutoSize = True
        Me.CashLabel.BackColor = System.Drawing.Color.Transparent
        Me.CashLabel.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashLabel.Location = New System.Drawing.Point(648, 189)
        Me.CashLabel.Name = "CashLabel"
        Me.CashLabel.Size = New System.Drawing.Size(0, 80)
        Me.CashLabel.TabIndex = 5
        '
        'BatQMark
        '
        Me.BatQMark.BackgroundImage = CType(resources.GetObject("BatQMark.BackgroundImage"), System.Drawing.Image)
        Me.BatQMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BatQMark.Location = New System.Drawing.Point(324, 426)
        Me.BatQMark.Name = "BatQMark"
        Me.BatQMark.Size = New System.Drawing.Size(182, 136)
        Me.BatQMark.TabIndex = 6
        Me.BatQMark.TabStop = False
        '
        'GunQMark
        '
        Me.GunQMark.BackgroundImage = CType(resources.GetObject("GunQMark.BackgroundImage"), System.Drawing.Image)
        Me.GunQMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunQMark.Location = New System.Drawing.Point(564, 426)
        Me.GunQMark.Name = "GunQMark"
        Me.GunQMark.Size = New System.Drawing.Size(185, 136)
        Me.GunQMark.TabIndex = 7
        Me.GunQMark.TabStop = False
        '
        'coladrinklabel
        '
        Me.coladrinklabel.BackColor = System.Drawing.Color.Transparent
        Me.coladrinklabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.coladrinklabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coladrinklabel.Location = New System.Drawing.Point(87, 172)
        Me.coladrinklabel.Name = "coladrinklabel"
        Me.coladrinklabel.Size = New System.Drawing.Size(181, 131)
        Me.coladrinklabel.TabIndex = 8
        '
        'labelfisteqp
        '
        Me.labelfisteqp.BackColor = System.Drawing.Color.Transparent
        Me.labelfisteqp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelfisteqp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelfisteqp.Location = New System.Drawing.Point(76, 426)
        Me.labelfisteqp.Name = "labelfisteqp"
        Me.labelfisteqp.Size = New System.Drawing.Size(192, 130)
        Me.labelfisteqp.TabIndex = 9
        '
        'labelguneqp
        '
        Me.labelguneqp.BackColor = System.Drawing.Color.Transparent
        Me.labelguneqp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelguneqp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelguneqp.Location = New System.Drawing.Point(561, 426)
        Me.labelguneqp.Name = "labelguneqp"
        Me.labelguneqp.Size = New System.Drawing.Size(183, 130)
        Me.labelguneqp.TabIndex = 10
        '
        'labelbateqp
        '
        Me.labelbateqp.BackColor = System.Drawing.Color.Transparent
        Me.labelbateqp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelbateqp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelbateqp.Location = New System.Drawing.Point(321, 426)
        Me.labelbateqp.Name = "labelbateqp"
        Me.labelbateqp.Size = New System.Drawing.Size(185, 130)
        Me.labelbateqp.TabIndex = 11
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 604)
        Me.Controls.Add(Me.labelfisteqp)
        Me.Controls.Add(Me.coladrinklabel)
        Me.Controls.Add(Me.GunQMark)
        Me.Controls.Add(Me.BatQMark)
        Me.Controls.Add(Me.CashLabel)
        Me.Controls.Add(Me.colalabel)
        Me.Controls.Add(Me.labelbateqp)
        Me.Controls.Add(Me.labelguneqp)
        Me.DoubleBuffered = True
        Me.Name = "inventory"
        Me.Text = "inventory"
        CType(Me.BatQMark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunQMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colalabel As Label
    Friend WithEvents CashLabel As Label
    Friend WithEvents BatQMark As PictureBox
    Friend WithEvents GunQMark As PictureBox
    Friend WithEvents coladrinklabel As Label
    Friend WithEvents labelfisteqp As Label
    Friend WithEvents labelguneqp As Label
    Friend WithEvents labelbateqp As Label
    Friend WithEvents Timer1 As Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuHowToPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuHowToPlay))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.easybutton = New System.Windows.Forms.Button()
        Me.medbutton = New System.Windows.Forms.Button()
        Me.hardbutton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(395, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1157, 702)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackgroundImage = CType(resources.GetObject("ButtonExit.BackgroundImage"), System.Drawing.Image)
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExit.Location = New System.Drawing.Point(830, 835)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(282, 93)
        Me.ButtonExit.TabIndex = 1
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'easybutton
        '
        Me.easybutton.Location = New System.Drawing.Point(79, 251)
        Me.easybutton.Name = "easybutton"
        Me.easybutton.Size = New System.Drawing.Size(262, 73)
        Me.easybutton.TabIndex = 2
        Me.easybutton.Text = "Difficulty- Easy"
        Me.easybutton.UseVisualStyleBackColor = True
        '
        'medbutton
        '
        Me.medbutton.Location = New System.Drawing.Point(79, 353)
        Me.medbutton.Name = "medbutton"
        Me.medbutton.Size = New System.Drawing.Size(262, 85)
        Me.medbutton.TabIndex = 3
        Me.medbutton.Text = "Difficulty- Medium"
        Me.medbutton.UseVisualStyleBackColor = True
        '
        'hardbutton
        '
        Me.hardbutton.Location = New System.Drawing.Point(79, 466)
        Me.hardbutton.Name = "hardbutton"
        Me.hardbutton.Size = New System.Drawing.Size(262, 85)
        Me.hardbutton.TabIndex = 4
        Me.hardbutton.Text = "Difficulty- Hard"
        Me.hardbutton.UseVisualStyleBackColor = True
        '
        'MenuHowToPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1042)
        Me.Controls.Add(Me.hardbutton)
        Me.Controls.Add(Me.medbutton)
        Me.Controls.Add(Me.easybutton)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuHowToPlay"
        Me.Text = "MenuHowToPlay"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonExit As Button
    Friend WithEvents easybutton As Button
    Friend WithEvents medbutton As Button
    Friend WithEvents hardbutton As Button
End Class

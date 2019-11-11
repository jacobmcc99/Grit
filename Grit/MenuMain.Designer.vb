<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonHowToPlay = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Grit.My.Resources.Resources.Picture2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(392, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(567, 242)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonPlay
        '
        Me.ButtonPlay.BackgroundImage = CType(resources.GetObject("ButtonPlay.BackgroundImage"), System.Drawing.Image)
        Me.ButtonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPlay.Location = New System.Drawing.Point(738, 313)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(508, 137)
        Me.ButtonPlay.TabIndex = 2
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.BackgroundImage = Global.Grit.My.Resources.Resources._exit
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExit.Location = New System.Drawing.Point(738, 789)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(508, 119)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonHowToPlay
        '
        Me.ButtonHowToPlay.BackgroundImage = CType(resources.GetObject("ButtonHowToPlay.BackgroundImage"), System.Drawing.Image)
        Me.ButtonHowToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonHowToPlay.Location = New System.Drawing.Point(738, 551)
        Me.ButtonHowToPlay.Name = "ButtonHowToPlay"
        Me.ButtonHowToPlay.Size = New System.Drawing.Size(508, 137)
        Me.ButtonHowToPlay.TabIndex = 5
        Me.ButtonHowToPlay.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Grit.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 1006)
        Me.Controls.Add(Me.ButtonHowToPlay)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainMenu"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonPlay As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonHowToPlay As Button
    Friend WithEvents Timer1 As Timer
End Class

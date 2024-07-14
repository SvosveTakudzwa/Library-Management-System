<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblusername = New System.Windows.Forms.Label()
        Me.btenter = New System.Windows.Forms.Button()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.btexit = New System.Windows.Forms.Button()
        Me.lblfgpass = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtuserfullname = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtpass = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Beige
        Me.lblusername.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblusername.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblusername.ForeColor = System.Drawing.Color.Black
        Me.lblusername.Location = New System.Drawing.Point(62, 58)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(61, 23)
        Me.lblusername.TabIndex = 0
        Me.lblusername.Text = "Label1"
        '
        'btenter
        '
        Me.btenter.BackColor = System.Drawing.Color.Transparent
        Me.btenter.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btenter.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btenter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btenter.Location = New System.Drawing.Point(16, 190)
        Me.btenter.Name = "btenter"
        Me.btenter.Size = New System.Drawing.Size(275, 43)
        Me.btenter.TabIndex = 3
        Me.btenter.Text = "Button1"
        Me.btenter.UseVisualStyleBackColor = False
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Beige
        Me.lblpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblpassword.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblpassword.ForeColor = System.Drawing.Color.Black
        Me.lblpassword.Location = New System.Drawing.Point(66, 132)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(61, 23)
        Me.lblpassword.TabIndex = 5
        Me.lblpassword.Text = "Label2"
        '
        'btexit
        '
        Me.btexit.BackColor = System.Drawing.Color.Transparent
        Me.btexit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btexit.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btexit.Location = New System.Drawing.Point(16, 248)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(275, 43)
        Me.btexit.TabIndex = 8
        Me.btexit.Text = "Button2"
        Me.btexit.UseVisualStyleBackColor = False
        '
        'lblfgpass
        '
        Me.lblfgpass.AutoSize = True
        Me.lblfgpass.BackColor = System.Drawing.Color.Transparent
        Me.lblfgpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblfgpass.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfgpass.ForeColor = System.Drawing.Color.Black
        Me.lblfgpass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblfgpass.Location = New System.Drawing.Point(13, 312)
        Me.lblfgpass.Name = "lblfgpass"
        Me.lblfgpass.Size = New System.Drawing.Size(57, 20)
        Me.lblfgpass.TabIndex = 9
        Me.lblfgpass.Text = "Label3"
        Me.lblfgpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 128)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(48, 17)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(224, 16)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(250, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Label1"
        '
        'txtuserfullname
        '
        Me.txtuserfullname.Location = New System.Drawing.Point(21, 17)
        Me.txtuserfullname.Name = "txtuserfullname"
        Me.txtuserfullname.Size = New System.Drawing.Size(21, 20)
        Me.txtuserfullname.TabIndex = 22
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.Beige
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Location = New System.Drawing.Point(57, 54)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(231, 33)
        Me.txtusername.TabIndex = 5
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Beige
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(252, 131)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(36, 28)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(249, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 33)
        Me.Label2.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Location = New System.Drawing.Point(18, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(270, 2)
        Me.Panel4.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Location = New System.Drawing.Point(18, 165)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 2)
        Me.Panel1.TabIndex = 30
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Beige
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.Location = New System.Drawing.Point(58, 127)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(234, 34)
        Me.txtpass.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(305, 342)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtuserfullname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblfgpass)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.btenter)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpass)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN INTERFACE"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents btenter As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents btexit As System.Windows.Forms.Button
    Friend WithEvents lblfgpass As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtuserfullname As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtpass As System.Windows.Forms.TextBox

End Class

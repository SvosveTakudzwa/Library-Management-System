<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim MemberIDLabel As System.Windows.Forms.Label
        Dim MemberFullNameLabel As System.Windows.Forms.Label
        Dim MemberGenderLabel As System.Windows.Forms.Label
        Dim MemberDOBLabel As System.Windows.Forms.Label
        Dim MemberMobileNoLabel As System.Windows.Forms.Label
        Dim MemberPhysicalAddressLabel As System.Windows.Forms.Label
        Dim MemberEmailAddressLabel As System.Windows.Forms.Label
        Dim MemberDateRegisteredLabel As System.Windows.Forms.Label
        Dim MemberRegValLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberMobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberPhysicalAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberEmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberDateRegisteredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberTermDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberPictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberTbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDbDataSet = New Library_Management_System.LibraryDbDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbMemberGender = New System.Windows.Forms.ComboBox()
        Me.MemberDOBTextBox = New System.Windows.Forms.DateTimePicker()
        Me.MemberDateRegisteredTextBox = New System.Windows.Forms.DateTimePicker()
        Me.MemberRegValTextBox = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MemberIDTextBox = New System.Windows.Forms.TextBox()
        Me.MemberFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.MemberMobileNoTextBox = New System.Windows.Forms.TextBox()
        Me.MemberPhysicalAddressTextBox = New System.Windows.Forms.TextBox()
        Me.MemberEmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.MemberPictureTextBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MemberTbTableAdapter = New Library_Management_System.LibraryDbDataSetTableAdapters.MemberTbTableAdapter()
        Me.TableAdapterManager = New Library_Management_System.LibraryDbDataSetTableAdapters.TableAdapterManager()
        MemberIDLabel = New System.Windows.Forms.Label()
        MemberFullNameLabel = New System.Windows.Forms.Label()
        MemberGenderLabel = New System.Windows.Forms.Label()
        MemberDOBLabel = New System.Windows.Forms.Label()
        MemberMobileNoLabel = New System.Windows.Forms.Label()
        MemberPhysicalAddressLabel = New System.Windows.Forms.Label()
        MemberEmailAddressLabel = New System.Windows.Forms.Label()
        MemberDateRegisteredLabel = New System.Windows.Forms.Label()
        MemberRegValLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberTbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MemberIDLabel
        '
        MemberIDLabel.AutoSize = True
        MemberIDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberIDLabel.Location = New System.Drawing.Point(29, 32)
        MemberIDLabel.Name = "MemberIDLabel"
        MemberIDLabel.Size = New System.Drawing.Size(81, 16)
        MemberIDLabel.TabIndex = 0
        MemberIDLabel.Text = "Member ID:"
        '
        'MemberFullNameLabel
        '
        MemberFullNameLabel.AutoSize = True
        MemberFullNameLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberFullNameLabel.Location = New System.Drawing.Point(29, 78)
        MemberFullNameLabel.Name = "MemberFullNameLabel"
        MemberFullNameLabel.Size = New System.Drawing.Size(75, 16)
        MemberFullNameLabel.TabIndex = 2
        MemberFullNameLabel.Text = "Full Name:"
        '
        'MemberGenderLabel
        '
        MemberGenderLabel.AutoSize = True
        MemberGenderLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberGenderLabel.Location = New System.Drawing.Point(29, 174)
        MemberGenderLabel.Name = "MemberGenderLabel"
        MemberGenderLabel.Size = New System.Drawing.Size(56, 16)
        MemberGenderLabel.TabIndex = 4
        MemberGenderLabel.Text = "Gender:"
        '
        'MemberDOBLabel
        '
        MemberDOBLabel.AutoSize = True
        MemberDOBLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberDOBLabel.Location = New System.Drawing.Point(29, 127)
        MemberDOBLabel.Name = "MemberDOBLabel"
        MemberDOBLabel.Size = New System.Drawing.Size(94, 16)
        MemberDOBLabel.TabIndex = 6
        MemberDOBLabel.Text = "Date Of Birth:"
        '
        'MemberMobileNoLabel
        '
        MemberMobileNoLabel.AutoSize = True
        MemberMobileNoLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberMobileNoLabel.Location = New System.Drawing.Point(33, 222)
        MemberMobileNoLabel.Name = "MemberMobileNoLabel"
        MemberMobileNoLabel.Size = New System.Drawing.Size(77, 16)
        MemberMobileNoLabel.TabIndex = 8
        MemberMobileNoLabel.Text = "Mobile No:"
        '
        'MemberPhysicalAddressLabel
        '
        MemberPhysicalAddressLabel.AutoSize = True
        MemberPhysicalAddressLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberPhysicalAddressLabel.Location = New System.Drawing.Point(33, 318)
        MemberPhysicalAddressLabel.Name = "MemberPhysicalAddressLabel"
        MemberPhysicalAddressLabel.Size = New System.Drawing.Size(115, 16)
        MemberPhysicalAddressLabel.TabIndex = 10
        MemberPhysicalAddressLabel.Text = "Physical Address:"
        '
        'MemberEmailAddressLabel
        '
        MemberEmailAddressLabel.AutoSize = True
        MemberEmailAddressLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberEmailAddressLabel.Location = New System.Drawing.Point(33, 271)
        MemberEmailAddressLabel.Name = "MemberEmailAddressLabel"
        MemberEmailAddressLabel.Size = New System.Drawing.Size(99, 16)
        MemberEmailAddressLabel.TabIndex = 12
        MemberEmailAddressLabel.Text = "Email Address:"
        '
        'MemberDateRegisteredLabel
        '
        MemberDateRegisteredLabel.AutoSize = True
        MemberDateRegisteredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberDateRegisteredLabel.Location = New System.Drawing.Point(7, 376)
        MemberDateRegisteredLabel.Name = "MemberDateRegisteredLabel"
        MemberDateRegisteredLabel.Size = New System.Drawing.Size(81, 30)
        MemberDateRegisteredLabel.TabIndex = 14
        MemberDateRegisteredLabel.Text = "     Date " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registered:"
        '
        'MemberRegValLabel
        '
        MemberRegValLabel.AutoSize = True
        MemberRegValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberRegValLabel.Location = New System.Drawing.Point(245, 375)
        MemberRegValLabel.Name = "MemberRegValLabel"
        MemberRegValLabel.Size = New System.Drawing.Size(88, 30)
        MemberRegValLabel.TabIndex = 16
        MemberRegValLabel.Text = "Termination " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Date"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 158)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(703, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 52)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 67)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(1, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 44)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 47)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("OCR A Extended", 11.25!)
        Me.Button1.Location = New System.Drawing.Point(219, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("OCR A Extended", 11.25!)
        Me.Button2.Location = New System.Drawing.Point(439, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(891, 430)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 61)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 61)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(201, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 61)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label4"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(7, 239)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(885, 409)
        Me.GroupBox4.TabIndex = 79
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MEMBER INFO"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(70, 364)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(197, 33)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "PREVIOUS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(586, 364)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(197, 33)
        Me.Button9.TabIndex = 45
        Me.Button9.Text = "DELETE"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(328, 364)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(197, 33)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "NEXT"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Label6"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(125, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(698, 29)
        Me.TextBox1.TabIndex = 39
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(828, 26)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(32, 30)
        Me.Button8.TabIndex = 38
        Me.Button8.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberIDDataGridViewTextBoxColumn, Me.MemberFullNameDataGridViewTextBoxColumn, Me.MemberGenderDataGridViewTextBoxColumn, Me.MemberDOBDataGridViewTextBoxColumn, Me.MemberMobileNoDataGridViewTextBoxColumn, Me.MemberPhysicalAddressDataGridViewTextBoxColumn, Me.MemberEmailAddressDataGridViewTextBoxColumn, Me.MemberDateRegisteredDataGridViewTextBoxColumn, Me.MemberTermDateDataGridViewTextBoxColumn, Me.MemberPictureDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MemberTbBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(882, 291)
        Me.DataGridView1.TabIndex = 0
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "Member ID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        Me.MemberIDDataGridViewTextBoxColumn.Width = 129
        '
        'MemberFullNameDataGridViewTextBoxColumn
        '
        Me.MemberFullNameDataGridViewTextBoxColumn.DataPropertyName = "MemberFullName"
        Me.MemberFullNameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.MemberFullNameDataGridViewTextBoxColumn.Name = "MemberFullNameDataGridViewTextBoxColumn"
        Me.MemberFullNameDataGridViewTextBoxColumn.Width = 152
        '
        'MemberGenderDataGridViewTextBoxColumn
        '
        Me.MemberGenderDataGridViewTextBoxColumn.DataPropertyName = "MemberGender"
        Me.MemberGenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.MemberGenderDataGridViewTextBoxColumn.Name = "MemberGenderDataGridViewTextBoxColumn"
        '
        'MemberDOBDataGridViewTextBoxColumn
        '
        Me.MemberDOBDataGridViewTextBoxColumn.DataPropertyName = "MemberDOB"
        Me.MemberDOBDataGridViewTextBoxColumn.HeaderText = "D.O.B"
        Me.MemberDOBDataGridViewTextBoxColumn.Name = "MemberDOBDataGridViewTextBoxColumn"
        Me.MemberDOBDataGridViewTextBoxColumn.Width = 130
        '
        'MemberMobileNoDataGridViewTextBoxColumn
        '
        Me.MemberMobileNoDataGridViewTextBoxColumn.DataPropertyName = "MemberMobileNo"
        Me.MemberMobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No."
        Me.MemberMobileNoDataGridViewTextBoxColumn.Name = "MemberMobileNoDataGridViewTextBoxColumn"
        Me.MemberMobileNoDataGridViewTextBoxColumn.Width = 138
        '
        'MemberPhysicalAddressDataGridViewTextBoxColumn
        '
        Me.MemberPhysicalAddressDataGridViewTextBoxColumn.DataPropertyName = "MemberPhysicalAddress"
        Me.MemberPhysicalAddressDataGridViewTextBoxColumn.HeaderText = "Physical Address"
        Me.MemberPhysicalAddressDataGridViewTextBoxColumn.Name = "MemberPhysicalAddressDataGridViewTextBoxColumn"
        Me.MemberPhysicalAddressDataGridViewTextBoxColumn.Width = 188
        '
        'MemberEmailAddressDataGridViewTextBoxColumn
        '
        Me.MemberEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "MemberEmailAddress"
        Me.MemberEmailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address"
        Me.MemberEmailAddressDataGridViewTextBoxColumn.Name = "MemberEmailAddressDataGridViewTextBoxColumn"
        Me.MemberEmailAddressDataGridViewTextBoxColumn.Width = 169
        '
        'MemberDateRegisteredDataGridViewTextBoxColumn
        '
        Me.MemberDateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "MemberDateRegistered"
        Me.MemberDateRegisteredDataGridViewTextBoxColumn.HeaderText = "Date Registered"
        Me.MemberDateRegisteredDataGridViewTextBoxColumn.Name = "MemberDateRegisteredDataGridViewTextBoxColumn"
        Me.MemberDateRegisteredDataGridViewTextBoxColumn.Width = 180
        '
        'MemberTermDateDataGridViewTextBoxColumn
        '
        Me.MemberTermDateDataGridViewTextBoxColumn.DataPropertyName = "MemberTermDate"
        Me.MemberTermDateDataGridViewTextBoxColumn.HeaderText = "Termination Date"
        Me.MemberTermDateDataGridViewTextBoxColumn.Name = "MemberTermDateDataGridViewTextBoxColumn"
        Me.MemberTermDateDataGridViewTextBoxColumn.Width = 181
        '
        'MemberPictureDataGridViewTextBoxColumn
        '
        Me.MemberPictureDataGridViewTextBoxColumn.DataPropertyName = "MemberPicture"
        Me.MemberPictureDataGridViewTextBoxColumn.HeaderText = "Picture"
        Me.MemberPictureDataGridViewTextBoxColumn.Name = "MemberPictureDataGridViewTextBoxColumn"
        Me.MemberPictureDataGridViewTextBoxColumn.Width = 125
        '
        'MemberTbBindingSource
        '
        Me.MemberTbBindingSource.DataMember = "MemberTb"
        Me.MemberTbBindingSource.DataSource = Me.LibraryDbDataSet
        '
        'LibraryDbDataSet
        '
        Me.LibraryDbDataSet.DataSetName = "LibraryDbDataSet"
        Me.LibraryDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbMemberGender)
        Me.GroupBox3.Controls.Add(Me.MemberDOBTextBox)
        Me.GroupBox3.Controls.Add(Me.MemberDateRegisteredTextBox)
        Me.GroupBox3.Controls.Add(Me.MemberRegValTextBox)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.PictureBox10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(MemberIDLabel)
        Me.GroupBox3.Controls.Add(Me.MemberIDTextBox)
        Me.GroupBox3.Controls.Add(MemberFullNameLabel)
        Me.GroupBox3.Controls.Add(Me.MemberFullNameTextBox)
        Me.GroupBox3.Controls.Add(MemberGenderLabel)
        Me.GroupBox3.Controls.Add(MemberDOBLabel)
        Me.GroupBox3.Controls.Add(MemberMobileNoLabel)
        Me.GroupBox3.Controls.Add(Me.MemberMobileNoTextBox)
        Me.GroupBox3.Controls.Add(MemberPhysicalAddressLabel)
        Me.GroupBox3.Controls.Add(Me.MemberPhysicalAddressTextBox)
        Me.GroupBox3.Controls.Add(MemberEmailAddressLabel)
        Me.GroupBox3.Controls.Add(Me.MemberEmailAddressTextBox)
        Me.GroupBox3.Controls.Add(MemberDateRegisteredLabel)
        Me.GroupBox3.Controls.Add(MemberRegValLabel)
        Me.GroupBox3.Controls.Add(Me.MemberPictureTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(882, 413)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MEMBER REGISTRATION"
        '
        'cmbMemberGender
        '
        Me.cmbMemberGender.FormattingEnabled = True
        Me.cmbMemberGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbMemberGender.Location = New System.Drawing.Point(50, 193)
        Me.cmbMemberGender.Name = "cmbMemberGender"
        Me.cmbMemberGender.Size = New System.Drawing.Size(437, 24)
        Me.cmbMemberGender.TabIndex = 83
        '
        'MemberDOBTextBox
        '
        Me.MemberDOBTextBox.CustomFormat = "dd-MMM-yyyy"
        Me.MemberDOBTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MemberDOBTextBox.Location = New System.Drawing.Point(50, 147)
        Me.MemberDOBTextBox.Name = "MemberDOBTextBox"
        Me.MemberDOBTextBox.Size = New System.Drawing.Size(437, 24)
        Me.MemberDOBTextBox.TabIndex = 82
        '
        'MemberDateRegisteredTextBox
        '
        Me.MemberDateRegisteredTextBox.CustomFormat = "dd-MMM-yyyy"
        Me.MemberDateRegisteredTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MemberDateRegisteredTextBox.Location = New System.Drawing.Point(94, 380)
        Me.MemberDateRegisteredTextBox.Name = "MemberDateRegisteredTextBox"
        Me.MemberDateRegisteredTextBox.Size = New System.Drawing.Size(151, 24)
        Me.MemberDateRegisteredTextBox.TabIndex = 81
        '
        'MemberRegValTextBox
        '
        Me.MemberRegValTextBox.CustomFormat = "dd-MMM-yyyy"
        Me.MemberRegValTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MemberRegValTextBox.Location = New System.Drawing.Point(337, 381)
        Me.MemberRegValTextBox.Name = "MemberRegValTextBox"
        Me.MemberRegValTextBox.Size = New System.Drawing.Size(150, 24)
        Me.MemberRegValTextBox.TabIndex = 80
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(752, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 36)
        Me.Button3.TabIndex = 79
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(627, 369)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 37)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "UPDATE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(512, 368)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 37)
        Me.Button5.TabIndex = 77
        Me.Button5.Text = "SAVE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(498, 30)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(38, 30)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 75
        Me.PictureBox10.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(553, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(50)
        Me.Label9.Size = New System.Drawing.Size(281, 146)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "NO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PHOTO AVAILABLE"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(498, 71)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(378, 290)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 73
        Me.PictureBox3.TabStop = False
        '
        'MemberIDTextBox
        '
        Me.MemberIDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberIDTextBox.Location = New System.Drawing.Point(50, 51)
        Me.MemberIDTextBox.Name = "MemberIDTextBox"
        Me.MemberIDTextBox.ReadOnly = True
        Me.MemberIDTextBox.Size = New System.Drawing.Size(437, 24)
        Me.MemberIDTextBox.TabIndex = 1
        '
        'MemberFullNameTextBox
        '
        Me.MemberFullNameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberFullNameTextBox.Location = New System.Drawing.Point(50, 97)
        Me.MemberFullNameTextBox.Name = "MemberFullNameTextBox"
        Me.MemberFullNameTextBox.Size = New System.Drawing.Size(437, 24)
        Me.MemberFullNameTextBox.TabIndex = 3
        '
        'MemberMobileNoTextBox
        '
        Me.MemberMobileNoTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberMobileNoTextBox.Location = New System.Drawing.Point(50, 243)
        Me.MemberMobileNoTextBox.Name = "MemberMobileNoTextBox"
        Me.MemberMobileNoTextBox.Size = New System.Drawing.Size(437, 24)
        Me.MemberMobileNoTextBox.TabIndex = 9
        '
        'MemberPhysicalAddressTextBox
        '
        Me.MemberPhysicalAddressTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberPhysicalAddressTextBox.Location = New System.Drawing.Point(50, 339)
        Me.MemberPhysicalAddressTextBox.Name = "MemberPhysicalAddressTextBox"
        Me.MemberPhysicalAddressTextBox.Size = New System.Drawing.Size(437, 24)
        Me.MemberPhysicalAddressTextBox.TabIndex = 11
        '
        'MemberEmailAddressTextBox
        '
        Me.MemberEmailAddressTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberEmailAddressTextBox.Location = New System.Drawing.Point(50, 291)
        Me.MemberEmailAddressTextBox.Name = "MemberEmailAddressTextBox"
        Me.MemberEmailAddressTextBox.Size = New System.Drawing.Size(437, 24)
        Me.MemberEmailAddressTextBox.TabIndex = 13
        '
        'MemberPictureTextBox
        '
        Me.MemberPictureTextBox.Location = New System.Drawing.Point(538, 33)
        Me.MemberPictureTextBox.Name = "MemberPictureTextBox"
        Me.MemberPictureTextBox.ReadOnly = True
        Me.MemberPictureTextBox.Size = New System.Drawing.Size(334, 24)
        Me.MemberPictureTextBox.TabIndex = 19
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MemberTbTableAdapter
        '
        Me.MemberTbTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookInventryTbTableAdapter = Nothing
        Me.TableAdapterManager.BookIssueTbTableAdapter = Nothing
        Me.TableAdapterManager.BookReturnTbTableAdapter = Nothing
        Me.TableAdapterManager.FinePaymentTbTableAdapter = Nothing
        Me.TableAdapterManager.MemberTbTableAdapter = Me.MemberTbTableAdapter
        Me.TableAdapterManager.StaffTbTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTbTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library_Management_System.LibraryDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTbTableAdapter = Nothing
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 653)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEMBER RECORDS INTERFACE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberTbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMemberGender As System.Windows.Forms.ComboBox
    Friend WithEvents MemberDOBTextBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents MemberDateRegisteredTextBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents MemberRegValTextBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents MemberIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemberFullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemberMobileNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemberPhysicalAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemberEmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemberPictureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LibraryDbDataSet As Library_Management_System.LibraryDbDataSet
    Friend WithEvents MemberTbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemberTbTableAdapter As Library_Management_System.LibraryDbDataSetTableAdapters.MemberTbTableAdapter
    Friend WithEvents TableAdapterManager As Library_Management_System.LibraryDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberFullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberGenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberDOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberMobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberPhysicalAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberEmailAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberDateRegisteredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberTermDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberPictureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel As System.Windows.Forms.Label
        Dim TypeOfSuppliesLabel As System.Windows.Forms.Label
        Dim SupplierEmailAddressLabel As System.Windows.Forms.Label
        Dim SupplierPhysicalAddressLabel As System.Windows.Forms.Label
        Dim SupplierMobileNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfSuppliesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierEmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPhysicalAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierMobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierTbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDbDataSet = New Library_Management_System.LibraryDbDataSet()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmbTypeOfSupplies = New System.Windows.Forms.ComboBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierEmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierPhysicalAddressTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierMobileNoTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierPictureTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SupplierTbTableAdapter = New Library_Management_System.LibraryDbDataSetTableAdapters.SupplierTbTableAdapter()
        Me.TableAdapterManager = New Library_Management_System.LibraryDbDataSetTableAdapters.TableAdapterManager()
        SupplierIDLabel = New System.Windows.Forms.Label()
        SupplierNameLabel = New System.Windows.Forms.Label()
        TypeOfSuppliesLabel = New System.Windows.Forms.Label()
        SupplierEmailAddressLabel = New System.Windows.Forms.Label()
        SupplierPhysicalAddressLabel = New System.Windows.Forms.Label()
        SupplierMobileNoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(49, 46)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(107, 24)
        SupplierIDLabel.TabIndex = 0
        SupplierIDLabel.Text = "Supplier ID:"
        '
        'SupplierNameLabel
        '
        SupplierNameLabel.AutoSize = True
        SupplierNameLabel.Location = New System.Drawing.Point(49, 106)
        SupplierNameLabel.Name = "SupplierNameLabel"
        SupplierNameLabel.Size = New System.Drawing.Size(141, 24)
        SupplierNameLabel.TabIndex = 2
        SupplierNameLabel.Text = "Supplier Name:"
        '
        'TypeOfSuppliesLabel
        '
        TypeOfSuppliesLabel.AutoSize = True
        TypeOfSuppliesLabel.Location = New System.Drawing.Point(49, 167)
        TypeOfSuppliesLabel.Name = "TypeOfSuppliesLabel"
        TypeOfSuppliesLabel.Size = New System.Drawing.Size(160, 24)
        TypeOfSuppliesLabel.TabIndex = 4
        TypeOfSuppliesLabel.Text = "Type Of Supplies:"
        '
        'SupplierEmailAddressLabel
        '
        SupplierEmailAddressLabel.AutoSize = True
        SupplierEmailAddressLabel.Location = New System.Drawing.Point(50, 229)
        SupplierEmailAddressLabel.Name = "SupplierEmailAddressLabel"
        SupplierEmailAddressLabel.Size = New System.Drawing.Size(212, 24)
        SupplierEmailAddressLabel.TabIndex = 6
        SupplierEmailAddressLabel.Text = "Supplier Email Address:"
        '
        'SupplierPhysicalAddressLabel
        '
        SupplierPhysicalAddressLabel.AutoSize = True
        SupplierPhysicalAddressLabel.Location = New System.Drawing.Point(50, 291)
        SupplierPhysicalAddressLabel.Name = "SupplierPhysicalAddressLabel"
        SupplierPhysicalAddressLabel.Size = New System.Drawing.Size(234, 24)
        SupplierPhysicalAddressLabel.TabIndex = 8
        SupplierPhysicalAddressLabel.Text = "Supplier Physical Address:"
        '
        'SupplierMobileNoLabel
        '
        SupplierMobileNoLabel.AutoSize = True
        SupplierMobileNoLabel.Location = New System.Drawing.Point(49, 353)
        SupplierMobileNoLabel.Name = "SupplierMobileNoLabel"
        SupplierMobileNoLabel.Size = New System.Drawing.Size(177, 24)
        SupplierMobileNoLabel.TabIndex = 10
        SupplierMobileNoLabel.Text = "Supplier Mobile No:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 158)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 145)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(706, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 54)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
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
        Me.GroupBox1.TabIndex = 3
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
        Me.GroupBox2.Location = New System.Drawing.Point(1, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(891, 459)
        Me.GroupBox2.TabIndex = 4
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
        Me.Label3.Location = New System.Drawing.Point(276, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 61)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 61)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label4"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1, 222)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(891, 425)
        Me.GroupBox4.TabIndex = 77
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SUPPLIER INFO"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.TypeOfSuppliesDataGridViewTextBoxColumn, Me.SupplierEmailAddressDataGridViewTextBoxColumn, Me.SupplierPhysicalAddressDataGridViewTextBoxColumn, Me.SupplierMobileNoDataGridViewTextBoxColumn, Me.SupplierPictureDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SupplierTbBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(8, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(873, 316)
        Me.DataGridView1.TabIndex = 0
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.Width = 130
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.Width = 265
        '
        'TypeOfSuppliesDataGridViewTextBoxColumn
        '
        Me.TypeOfSuppliesDataGridViewTextBoxColumn.DataPropertyName = "TypeOfSupplies"
        Me.TypeOfSuppliesDataGridViewTextBoxColumn.HeaderText = "Supplies"
        Me.TypeOfSuppliesDataGridViewTextBoxColumn.Name = "TypeOfSuppliesDataGridViewTextBoxColumn"
        Me.TypeOfSuppliesDataGridViewTextBoxColumn.Width = 170
        '
        'SupplierEmailAddressDataGridViewTextBoxColumn
        '
        Me.SupplierEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "SupplierEmailAddress"
        Me.SupplierEmailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address"
        Me.SupplierEmailAddressDataGridViewTextBoxColumn.Name = "SupplierEmailAddressDataGridViewTextBoxColumn"
        Me.SupplierEmailAddressDataGridViewTextBoxColumn.Width = 265
        '
        'SupplierPhysicalAddressDataGridViewTextBoxColumn
        '
        Me.SupplierPhysicalAddressDataGridViewTextBoxColumn.DataPropertyName = "SupplierPhysicalAddress"
        Me.SupplierPhysicalAddressDataGridViewTextBoxColumn.HeaderText = "Physical Address"
        Me.SupplierPhysicalAddressDataGridViewTextBoxColumn.Name = "SupplierPhysicalAddressDataGridViewTextBoxColumn"
        Me.SupplierPhysicalAddressDataGridViewTextBoxColumn.Width = 225
        '
        'SupplierMobileNoDataGridViewTextBoxColumn
        '
        Me.SupplierMobileNoDataGridViewTextBoxColumn.DataPropertyName = "SupplierMobileNo"
        Me.SupplierMobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No"
        Me.SupplierMobileNoDataGridViewTextBoxColumn.Name = "SupplierMobileNoDataGridViewTextBoxColumn"
        Me.SupplierMobileNoDataGridViewTextBoxColumn.Width = 170
        '
        'SupplierPictureDataGridViewTextBoxColumn
        '
        Me.SupplierPictureDataGridViewTextBoxColumn.DataPropertyName = "SupplierPicture"
        Me.SupplierPictureDataGridViewTextBoxColumn.HeaderText = "Supplier Picture"
        Me.SupplierPictureDataGridViewTextBoxColumn.Name = "SupplierPictureDataGridViewTextBoxColumn"
        Me.SupplierPictureDataGridViewTextBoxColumn.Width = 175
        '
        'SupplierTbBindingSource
        '
        Me.SupplierTbBindingSource.DataMember = "SupplierTb"
        Me.SupplierTbBindingSource.DataSource = Me.LibraryDbDataSet
        '
        'LibraryDbDataSet
        '
        Me.LibraryDbDataSet.DataSetName = "LibraryDbDataSet"
        Me.LibraryDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(532, 386)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(167, 33)
        Me.Button10.TabIndex = 48
        Me.Button10.Text = "DELETE"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(146, 386)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(167, 33)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "PREVIOUS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(339, 386)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(167, 33)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.cmbTypeOfSupplies)
        Me.GroupBox3.Controls.Add(Me.PictureBox10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(SupplierIDLabel)
        Me.GroupBox3.Controls.Add(Me.SupplierIDTextBox)
        Me.GroupBox3.Controls.Add(SupplierNameLabel)
        Me.GroupBox3.Controls.Add(Me.SupplierNameTextBox)
        Me.GroupBox3.Controls.Add(TypeOfSuppliesLabel)
        Me.GroupBox3.Controls.Add(SupplierEmailAddressLabel)
        Me.GroupBox3.Controls.Add(Me.SupplierEmailAddressTextBox)
        Me.GroupBox3.Controls.Add(SupplierPhysicalAddressLabel)
        Me.GroupBox3.Controls.Add(Me.SupplierPhysicalAddressTextBox)
        Me.GroupBox3.Controls.Add(SupplierMobileNoLabel)
        Me.GroupBox3.Controls.Add(Me.SupplierMobileNoTextBox)
        Me.GroupBox3.Controls.Add(Me.SupplierPictureTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 222)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(879, 435)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SUPPLIER REGISTRY"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(741, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 36)
        Me.Button3.TabIndex = 76
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(479, 378)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 37)
        Me.Button4.TabIndex = 75
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(610, 378)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 37)
        Me.Button5.TabIndex = 74
        Me.Button5.Text = "UPDATE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmbTypeOfSupplies
        '
        Me.cmbTypeOfSupplies.FormattingEnabled = True
        Me.cmbTypeOfSupplies.Items.AddRange(New Object() {"Novel", "TextBook"})
        Me.cmbTypeOfSupplies.Location = New System.Drawing.Point(76, 196)
        Me.cmbTypeOfSupplies.Name = "cmbTypeOfSupplies"
        Me.cmbTypeOfSupplies.Size = New System.Drawing.Size(348, 32)
        Me.cmbTypeOfSupplies.TabIndex = 73
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(445, 34)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(38, 30)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 72
        Me.PictureBox10.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(503, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(50)
        Me.Label9.Size = New System.Drawing.Size(305, 150)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "NO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PHOTO AVAILABLE"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(448, 75)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(413, 297)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(76, 74)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.ReadOnly = True
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(348, 29)
        Me.SupplierIDTextBox.TabIndex = 1
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(76, 135)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(348, 29)
        Me.SupplierNameTextBox.TabIndex = 3
        '
        'SupplierEmailAddressTextBox
        '
        Me.SupplierEmailAddressTextBox.Location = New System.Drawing.Point(76, 257)
        Me.SupplierEmailAddressTextBox.Name = "SupplierEmailAddressTextBox"
        Me.SupplierEmailAddressTextBox.Size = New System.Drawing.Size(348, 29)
        Me.SupplierEmailAddressTextBox.TabIndex = 7
        '
        'SupplierPhysicalAddressTextBox
        '
        Me.SupplierPhysicalAddressTextBox.Location = New System.Drawing.Point(76, 319)
        Me.SupplierPhysicalAddressTextBox.Name = "SupplierPhysicalAddressTextBox"
        Me.SupplierPhysicalAddressTextBox.Size = New System.Drawing.Size(348, 29)
        Me.SupplierPhysicalAddressTextBox.TabIndex = 9
        '
        'SupplierMobileNoTextBox
        '
        Me.SupplierMobileNoTextBox.Location = New System.Drawing.Point(76, 381)
        Me.SupplierMobileNoTextBox.Name = "SupplierMobileNoTextBox"
        Me.SupplierMobileNoTextBox.Size = New System.Drawing.Size(348, 29)
        Me.SupplierMobileNoTextBox.TabIndex = 11
        '
        'SupplierPictureTextBox
        '
        Me.SupplierPictureTextBox.Location = New System.Drawing.Point(486, 34)
        Me.SupplierPictureTextBox.Name = "SupplierPictureTextBox"
        Me.SupplierPictureTextBox.ReadOnly = True
        Me.SupplierPictureTextBox.Size = New System.Drawing.Size(375, 29)
        Me.SupplierPictureTextBox.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SupplierTbTableAdapter
        '
        Me.SupplierTbTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookInventryTbTableAdapter = Nothing
        Me.TableAdapterManager.BookIssueTbTableAdapter = Nothing
        Me.TableAdapterManager.BookReturnTbTableAdapter = Nothing
        Me.TableAdapterManager.FinePaymentTbTableAdapter = Nothing
        Me.TableAdapterManager.MemberTbTableAdapter = Nothing
        Me.TableAdapterManager.StaffTbTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTbTableAdapter = Me.SupplierTbTableAdapter
        Me.TableAdapterManager.UpdateOrder = Library_Management_System.LibraryDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTbTableAdapter = Nothing
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 657)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUPPLIER RECORDS INTERFACE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cmbTypeOfSupplies As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents SupplierIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierEmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierPhysicalAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierMobileNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierPictureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents LibraryDbDataSet As Library_Management_System.LibraryDbDataSet
    Friend WithEvents SupplierTbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTbTableAdapter As Library_Management_System.LibraryDbDataSetTableAdapters.SupplierTbTableAdapter
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TableAdapterManager As Library_Management_System.LibraryDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeOfSuppliesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmailAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierPhysicalAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierMobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierPictureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

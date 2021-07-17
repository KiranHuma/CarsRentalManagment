<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cars
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cars))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RegNumTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ModelTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PriceTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ColorTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BrandCb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AvailableCb = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Cardgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cardgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1382, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(1112, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "UserName"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1033, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(78, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Car Rental Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RegNumTb
        '
        Me.RegNumTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RegNumTb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegNumTb.ForeColor = System.Drawing.Color.Crimson
        Me.RegNumTb.HintForeColor = System.Drawing.Color.Empty
        Me.RegNumTb.HintText = ""
        Me.RegNumTb.isPassword = False
        Me.RegNumTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.RegNumTb.LineIdleColor = System.Drawing.Color.MidnightBlue
        Me.RegNumTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.RegNumTb.LineThickness = 4
        Me.RegNumTb.Location = New System.Drawing.Point(175, 238)
        Me.RegNumTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.RegNumTb.Name = "RegNumTb"
        Me.RegNumTb.Size = New System.Drawing.Size(211, 39)
        Me.RegNumTb.TabIndex = 1
        Me.RegNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(180, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Reg Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(1015, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Model"
        '
        'ModelTb
        '
        Me.ModelTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ModelTb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModelTb.ForeColor = System.Drawing.Color.Crimson
        Me.ModelTb.HintForeColor = System.Drawing.Color.Empty
        Me.ModelTb.HintText = ""
        Me.ModelTb.isPassword = False
        Me.ModelTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.ModelTb.LineIdleColor = System.Drawing.Color.MidnightBlue
        Me.ModelTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.ModelTb.LineThickness = 4
        Me.ModelTb.Location = New System.Drawing.Point(1011, 227)
        Me.ModelTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ModelTb.Name = "ModelTb"
        Me.ModelTb.Size = New System.Drawing.Size(211, 39)
        Me.ModelTb.TabIndex = 6
        Me.ModelTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(175, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Price"
        '
        'PriceTb
        '
        Me.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceTb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTb.ForeColor = System.Drawing.Color.Crimson
        Me.PriceTb.HintForeColor = System.Drawing.Color.Empty
        Me.PriceTb.HintText = ""
        Me.PriceTb.isPassword = False
        Me.PriceTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.PriceTb.LineIdleColor = System.Drawing.Color.MidnightBlue
        Me.PriceTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.PriceTb.LineThickness = 4
        Me.PriceTb.Location = New System.Drawing.Point(171, 360)
        Me.PriceTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PriceTb.Name = "PriceTb"
        Me.PriceTb.Size = New System.Drawing.Size(211, 39)
        Me.PriceTb.TabIndex = 8
        Me.PriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(573, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Color"
        '
        'ColorTb
        '
        Me.ColorTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ColorTb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTb.ForeColor = System.Drawing.Color.Crimson
        Me.ColorTb.HintForeColor = System.Drawing.Color.Empty
        Me.ColorTb.HintText = ""
        Me.ColorTb.isPassword = False
        Me.ColorTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.ColorTb.LineIdleColor = System.Drawing.Color.MidnightBlue
        Me.ColorTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.ColorTb.LineThickness = 4
        Me.ColorTb.Location = New System.Drawing.Point(569, 360)
        Me.ColorTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ColorTb.Name = "ColorTb"
        Me.ColorTb.Size = New System.Drawing.Size(211, 39)
        Me.ColorTb.TabIndex = 10
        Me.ColorTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BrandCb
        '
        Me.BrandCb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BrandCb.ForeColor = System.Drawing.Color.Crimson
        Me.BrandCb.FormattingEnabled = True
        Me.BrandCb.Items.AddRange(New Object() {"Audi", "Mercedes", "Toyota", "Yundai", "Chevrolet", "Ford"})
        Me.BrandCb.Location = New System.Drawing.Point(578, 243)
        Me.BrandCb.Name = "BrandCb"
        Me.BrandCb.Size = New System.Drawing.Size(211, 34)
        Me.BrandCb.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(587, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Brand"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(1015, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Available"
        '
        'AvailableCb
        '
        Me.AvailableCb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.AvailableCb.ForeColor = System.Drawing.Color.Crimson
        Me.AvailableCb.FormattingEnabled = True
        Me.AvailableCb.Items.AddRange(New Object() {"Yes", "No"})
        Me.AvailableCb.Location = New System.Drawing.Point(1010, 358)
        Me.AvailableCb.Name = "AvailableCb"
        Me.AvailableCb.Size = New System.Drawing.Size(211, 34)
        Me.AvailableCb.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(629, 476)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 38)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cars List"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1382, 68)
        Me.Panel2.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Crimson
        Me.Label13.Location = New System.Drawing.Point(950, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 29)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Return"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(896, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 22
        Me.PictureBox6.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Crimson
        Me.Label12.Location = New System.Drawing.Point(746, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 29)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Rent"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(692, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Crimson
        Me.Label11.Location = New System.Drawing.Point(500, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 29)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Customers"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(222, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(120, 6)
        Me.Panel3.TabIndex = 18
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(432, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Crimson
        Me.Label10.Location = New System.Drawing.Point(290, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 29)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cars "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(222, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Cardgv
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.Cardgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Cardgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cardgv.BackgroundColor = System.Drawing.Color.White
        Me.Cardgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cardgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Cardgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cardgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Cardgv.ColumnHeadersHeight = 26
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cardgv.DefaultCellStyle = DataGridViewCellStyle9
        Me.Cardgv.EnableHeadersVisualStyles = False
        Me.Cardgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cardgv.Location = New System.Drawing.Point(84, 517)
        Me.Cardgv.Name = "Cardgv"
        Me.Cardgv.RowHeadersVisible = False
        Me.Cardgv.RowHeadersWidth = 51
        Me.Cardgv.RowTemplate.Height = 24
        Me.Cardgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Cardgv.Size = New System.Drawing.Size(1214, 269)
        Me.Cardgv.TabIndex = 18
        Me.Cardgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Cardgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Cardgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Cardgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Cardgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Cardgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Cardgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cardgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson
        Me.Cardgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Cardgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cardgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Cardgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Cardgv.ThemeStyle.HeaderStyle.Height = 26
        Me.Cardgv.ThemeStyle.ReadOnly = False
        Me.Cardgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Cardgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Cardgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Cardgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Cardgv.ThemeStyle.RowsStyle.Height = 24
        Me.Cardgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cardgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(407, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 42)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(600, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 42)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(793, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 42)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(986, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 42)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1382, 833)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cardgv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AvailableCb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BrandCb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ColorTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PriceTb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ModelTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RegNumTb)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cars"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cardgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RegNumTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ModelTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents PriceTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents ColorTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BrandCb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AvailableCb As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Cardgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class

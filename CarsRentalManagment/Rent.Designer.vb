﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rent
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rent))
        Me.rentdgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RegNumCb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustnameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FeesTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CustIdCb = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RentDate = New System.Windows.Forms.DateTimePicker()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.rentdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rentdgv
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.rentdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.rentdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.rentdgv.BackgroundColor = System.Drawing.Color.White
        Me.rentdgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rentdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.rentdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rentdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.rentdgv.ColumnHeadersHeight = 4
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rentdgv.DefaultCellStyle = DataGridViewCellStyle15
        Me.rentdgv.EnableHeadersVisualStyles = False
        Me.rentdgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rentdgv.Location = New System.Drawing.Point(84, 504)
        Me.rentdgv.Name = "rentdgv"
        Me.rentdgv.RowHeadersVisible = False
        Me.rentdgv.RowHeadersWidth = 51
        Me.rentdgv.RowTemplate.Height = 24
        Me.rentdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.rentdgv.Size = New System.Drawing.Size(1214, 244)
        Me.rentdgv.TabIndex = 34
        Me.rentdgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.rentdgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.rentdgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.rentdgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.rentdgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.rentdgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.rentdgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rentdgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rentdgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.rentdgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.rentdgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.rentdgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.rentdgv.ThemeStyle.HeaderStyle.Height = 4
        Me.rentdgv.ThemeStyle.ReadOnly = False
        Me.rentdgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.rentdgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.rentdgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.rentdgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.rentdgv.ThemeStyle.RowsStyle.Height = 24
        Me.rentdgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rentdgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Panel5.Location = New System.Drawing.Point(692, 58)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(120, 6)
        Me.Panel5.TabIndex = 21
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1364, 68)
        Me.Panel2.TabIndex = 33
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(585, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 38)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Rentals List"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(1015, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 29)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Fees"
        '
        'RegNumCb
        '
        Me.RegNumCb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.RegNumCb.ForeColor = System.Drawing.Color.Crimson
        Me.RegNumCb.FormattingEnabled = True
        Me.RegNumCb.Location = New System.Drawing.Point(171, 250)
        Me.RegNumCb.Name = "RegNumCb"
        Me.RegNumCb.Size = New System.Drawing.Size(211, 34)
        Me.RegNumCb.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(573, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 29)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Return Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(175, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Rent Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(1015, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 29)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cutomer Name"
        '
        'CustnameTb
        '
        Me.CustnameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustnameTb.Enabled = False
        Me.CustnameTb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustnameTb.ForeColor = System.Drawing.Color.Crimson
        Me.CustnameTb.HintForeColor = System.Drawing.Color.Empty
        Me.CustnameTb.HintText = ""
        Me.CustnameTb.isPassword = False
        Me.CustnameTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.CustnameTb.LineIdleColor = System.Drawing.Color.MidnightBlue
        Me.CustnameTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.CustnameTb.LineThickness = 4
        Me.CustnameTb.Location = New System.Drawing.Point(1011, 227)
        Me.CustnameTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CustnameTb.Name = "CustnameTb"
        Me.CustnameTb.Size = New System.Drawing.Size(211, 39)
        Me.CustnameTb.TabIndex = 22
        Me.CustnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(180, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 29)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Reg Number"
        '
        'FeesTb
        '
        Me.FeesTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FeesTb.Enabled = False
        Me.FeesTb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeesTb.ForeColor = System.Drawing.Color.Crimson
        Me.FeesTb.HintForeColor = System.Drawing.Color.Empty
        Me.FeesTb.HintText = ""
        Me.FeesTb.isPassword = False
        Me.FeesTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.FeesTb.LineIdleColor = System.Drawing.Color.MidnightBlue
        Me.FeesTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.FeesTb.LineThickness = 4
        Me.FeesTb.Location = New System.Drawing.Point(1011, 336)
        Me.FeesTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FeesTb.Name = "FeesTb"
        Me.FeesTb.Size = New System.Drawing.Size(211, 39)
        Me.FeesTb.TabIndex = 20
        Me.FeesTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(587, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 29)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Customer Id"
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
        Me.Panel1.Size = New System.Drawing.Size(1364, 100)
        Me.Panel1.TabIndex = 19
        '
        'CustIdCb
        '
        Me.CustIdCb.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.CustIdCb.ForeColor = System.Drawing.Color.Crimson
        Me.CustIdCb.FormattingEnabled = True
        Me.CustIdCb.Location = New System.Drawing.Point(569, 250)
        Me.CustIdCb.Name = "CustIdCb"
        Me.CustIdCb.Size = New System.Drawing.Size(211, 34)
        Me.CustIdCb.TabIndex = 35
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(901, 403)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 42)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(707, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 42)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RentDate
        '
        Me.RentDate.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.RentDate.Location = New System.Drawing.Point(172, 354)
        Me.RentDate.Name = "RentDate"
        Me.RentDate.Size = New System.Drawing.Size(200, 31)
        Me.RentDate.TabIndex = 43
        '
        'ReturnDate
        '
        Me.ReturnDate.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.ReturnDate.Location = New System.Drawing.Point(569, 354)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(211, 31)
        Me.ReturnDate.TabIndex = 44
        '
        'Rent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1364, 786)
        Me.Controls.Add(Me.ReturnDate)
        Me.Controls.Add(Me.RentDate)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustIdCb)
        Me.Controls.Add(Me.rentdgv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RegNumCb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CustnameTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FeesTb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rent"
        CType(Me.rentdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rentdgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RegNumCb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CustnameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents FeesTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CustIdCb As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RentDate As DateTimePicker
    Friend WithEvents ReturnDate As DateTimePicker
End Class

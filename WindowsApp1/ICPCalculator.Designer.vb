<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ICPCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ICPCalculator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TotWeiTB = New System.Windows.Forms.TextBox()
        Me.SamWeiTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ppmZnTB = New System.Windows.Forms.TextBox()
        Me.ppmSTB = New System.Windows.Forms.TextBox()
        Me.ppmPTB = New System.Windows.Forms.TextBox()
        Me.ppmMoTB = New System.Windows.Forms.TextBox()
        Me.ppmMgTB = New System.Windows.Forms.TextBox()
        Me.ppmCuTB = New System.Windows.Forms.TextBox()
        Me.ppmCaTB = New System.Windows.Forms.TextBox()
        Me.ppmBTB = New System.Windows.Forms.TextBox()
        Me.ppmBaTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.wtBaL = New System.Windows.Forms.Label()
        Me.wtBL = New System.Windows.Forms.Label()
        Me.wtCaL = New System.Windows.Forms.Label()
        Me.wtCuL = New System.Windows.Forms.Label()
        Me.wtMgL = New System.Windows.Forms.Label()
        Me.wtMoL = New System.Windows.Forms.Label()
        Me.wtPL = New System.Windows.Forms.Label()
        Me.wtSL = New System.Windows.Forms.Label()
        Me.wtZnL = New System.Windows.Forms.Label()
        Me.ppmBaL = New System.Windows.Forms.Label()
        Me.ppmBL = New System.Windows.Forms.Label()
        Me.ppmCaL = New System.Windows.Forms.Label()
        Me.ppmCuL = New System.Windows.Forms.Label()
        Me.ppmMgL = New System.Windows.Forms.Label()
        Me.ppmMoL = New System.Windows.Forms.Label()
        Me.ppmPL = New System.Windows.Forms.Label()
        Me.ppmSL = New System.Windows.Forms.Label()
        Me.ppmZnL = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CommandButton1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ICP Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TotWeiTB)
        Me.GroupBox1.Controls.Add(Me.SamWeiTB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 103)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sample Data"
        '
        'TotWeiTB
        '
        Me.TotWeiTB.Location = New System.Drawing.Point(144, 65)
        Me.TotWeiTB.Name = "TotWeiTB"
        Me.TotWeiTB.Size = New System.Drawing.Size(100, 24)
        Me.TotWeiTB.TabIndex = 3
        '
        'SamWeiTB
        '
        Me.SamWeiTB.Location = New System.Drawing.Point(144, 35)
        Me.SamWeiTB.Name = "SamWeiTB"
        Me.SamWeiTB.Size = New System.Drawing.Size(100, 24)
        Me.SamWeiTB.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Weight (g)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sample Weight (g)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ppmZnTB)
        Me.GroupBox2.Controls.Add(Me.ppmSTB)
        Me.GroupBox2.Controls.Add(Me.ppmPTB)
        Me.GroupBox2.Controls.Add(Me.ppmMoTB)
        Me.GroupBox2.Controls.Add(Me.ppmMgTB)
        Me.GroupBox2.Controls.Add(Me.ppmCuTB)
        Me.GroupBox2.Controls.Add(Me.ppmCaTB)
        Me.GroupBox2.Controls.Add(Me.ppmBTB)
        Me.GroupBox2.Controls.Add(Me.ppmBaTB)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(34, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 323)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Instrument Results (ppm)"
        '
        'ppmZnTB
        '
        Me.ppmZnTB.Location = New System.Drawing.Point(144, 278)
        Me.ppmZnTB.Name = "ppmZnTB"
        Me.ppmZnTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmZnTB.TabIndex = 17
        '
        'ppmSTB
        '
        Me.ppmSTB.Location = New System.Drawing.Point(143, 248)
        Me.ppmSTB.Name = "ppmSTB"
        Me.ppmSTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmSTB.TabIndex = 16
        '
        'ppmPTB
        '
        Me.ppmPTB.Location = New System.Drawing.Point(143, 218)
        Me.ppmPTB.Name = "ppmPTB"
        Me.ppmPTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmPTB.TabIndex = 15
        '
        'ppmMoTB
        '
        Me.ppmMoTB.Location = New System.Drawing.Point(144, 188)
        Me.ppmMoTB.Name = "ppmMoTB"
        Me.ppmMoTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmMoTB.TabIndex = 14
        '
        'ppmMgTB
        '
        Me.ppmMgTB.Location = New System.Drawing.Point(144, 158)
        Me.ppmMgTB.Name = "ppmMgTB"
        Me.ppmMgTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmMgTB.TabIndex = 13
        '
        'ppmCuTB
        '
        Me.ppmCuTB.Location = New System.Drawing.Point(144, 128)
        Me.ppmCuTB.Name = "ppmCuTB"
        Me.ppmCuTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmCuTB.TabIndex = 12
        '
        'ppmCaTB
        '
        Me.ppmCaTB.Location = New System.Drawing.Point(144, 98)
        Me.ppmCaTB.Name = "ppmCaTB"
        Me.ppmCaTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmCaTB.TabIndex = 11
        '
        'ppmBTB
        '
        Me.ppmBTB.Location = New System.Drawing.Point(143, 68)
        Me.ppmBTB.Name = "ppmBTB"
        Me.ppmBTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmBTB.TabIndex = 10
        '
        'ppmBaTB
        '
        Me.ppmBaTB.Location = New System.Drawing.Point(144, 38)
        Me.ppmBaTB.Name = "ppmBaTB"
        Me.ppmBaTB.Size = New System.Drawing.Size(100, 24)
        Me.ppmBaTB.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Zinc (Zn)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Sulfur (S)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Phosphorus (P)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Molybdenum (Mo)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Magnesium (Mg)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Copper (Cu)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Calcium (Ca)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Boron (B)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Barium (Ba)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(322, 261)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Sample Results (%wt)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(520, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Sample Results (ppm)"
        '
        'wtBaL
        '
        Me.wtBaL.AutoSize = True
        Me.wtBaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtBaL.Location = New System.Drawing.Point(322, 289)
        Me.wtBaL.Name = "wtBaL"
        Me.wtBaL.Size = New System.Drawing.Size(0, 18)
        Me.wtBaL.TabIndex = 5
        '
        'wtBL
        '
        Me.wtBL.AutoSize = True
        Me.wtBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtBL.Location = New System.Drawing.Point(322, 319)
        Me.wtBL.Name = "wtBL"
        Me.wtBL.Size = New System.Drawing.Size(0, 18)
        Me.wtBL.TabIndex = 6
        '
        'wtCaL
        '
        Me.wtCaL.AutoSize = True
        Me.wtCaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtCaL.Location = New System.Drawing.Point(322, 349)
        Me.wtCaL.Name = "wtCaL"
        Me.wtCaL.Size = New System.Drawing.Size(0, 18)
        Me.wtCaL.TabIndex = 7
        '
        'wtCuL
        '
        Me.wtCuL.AutoSize = True
        Me.wtCuL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtCuL.Location = New System.Drawing.Point(322, 379)
        Me.wtCuL.Name = "wtCuL"
        Me.wtCuL.Size = New System.Drawing.Size(0, 18)
        Me.wtCuL.TabIndex = 8
        '
        'wtMgL
        '
        Me.wtMgL.AutoSize = True
        Me.wtMgL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtMgL.Location = New System.Drawing.Point(322, 409)
        Me.wtMgL.Name = "wtMgL"
        Me.wtMgL.Size = New System.Drawing.Size(0, 18)
        Me.wtMgL.TabIndex = 9
        '
        'wtMoL
        '
        Me.wtMoL.AutoSize = True
        Me.wtMoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtMoL.Location = New System.Drawing.Point(322, 439)
        Me.wtMoL.Name = "wtMoL"
        Me.wtMoL.Size = New System.Drawing.Size(0, 18)
        Me.wtMoL.TabIndex = 10
        '
        'wtPL
        '
        Me.wtPL.AutoSize = True
        Me.wtPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtPL.Location = New System.Drawing.Point(322, 469)
        Me.wtPL.Name = "wtPL"
        Me.wtPL.Size = New System.Drawing.Size(0, 18)
        Me.wtPL.TabIndex = 11
        '
        'wtSL
        '
        Me.wtSL.AutoSize = True
        Me.wtSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtSL.Location = New System.Drawing.Point(322, 499)
        Me.wtSL.Name = "wtSL"
        Me.wtSL.Size = New System.Drawing.Size(0, 18)
        Me.wtSL.TabIndex = 12
        '
        'wtZnL
        '
        Me.wtZnL.AutoSize = True
        Me.wtZnL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtZnL.Location = New System.Drawing.Point(322, 529)
        Me.wtZnL.Name = "wtZnL"
        Me.wtZnL.Size = New System.Drawing.Size(0, 18)
        Me.wtZnL.TabIndex = 13
        '
        'ppmBaL
        '
        Me.ppmBaL.AutoSize = True
        Me.ppmBaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmBaL.Location = New System.Drawing.Point(520, 289)
        Me.ppmBaL.Name = "ppmBaL"
        Me.ppmBaL.Size = New System.Drawing.Size(0, 18)
        Me.ppmBaL.TabIndex = 14
        '
        'ppmBL
        '
        Me.ppmBL.AutoSize = True
        Me.ppmBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmBL.Location = New System.Drawing.Point(520, 319)
        Me.ppmBL.Name = "ppmBL"
        Me.ppmBL.Size = New System.Drawing.Size(0, 18)
        Me.ppmBL.TabIndex = 15
        '
        'ppmCaL
        '
        Me.ppmCaL.AutoSize = True
        Me.ppmCaL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmCaL.Location = New System.Drawing.Point(520, 349)
        Me.ppmCaL.Name = "ppmCaL"
        Me.ppmCaL.Size = New System.Drawing.Size(0, 18)
        Me.ppmCaL.TabIndex = 16
        '
        'ppmCuL
        '
        Me.ppmCuL.AutoSize = True
        Me.ppmCuL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmCuL.Location = New System.Drawing.Point(520, 379)
        Me.ppmCuL.Name = "ppmCuL"
        Me.ppmCuL.Size = New System.Drawing.Size(0, 18)
        Me.ppmCuL.TabIndex = 17
        '
        'ppmMgL
        '
        Me.ppmMgL.AutoSize = True
        Me.ppmMgL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmMgL.Location = New System.Drawing.Point(520, 409)
        Me.ppmMgL.Name = "ppmMgL"
        Me.ppmMgL.Size = New System.Drawing.Size(0, 18)
        Me.ppmMgL.TabIndex = 18
        '
        'ppmMoL
        '
        Me.ppmMoL.AutoSize = True
        Me.ppmMoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmMoL.Location = New System.Drawing.Point(520, 439)
        Me.ppmMoL.Name = "ppmMoL"
        Me.ppmMoL.Size = New System.Drawing.Size(0, 18)
        Me.ppmMoL.TabIndex = 19
        '
        'ppmPL
        '
        Me.ppmPL.AutoSize = True
        Me.ppmPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmPL.Location = New System.Drawing.Point(520, 469)
        Me.ppmPL.Name = "ppmPL"
        Me.ppmPL.Size = New System.Drawing.Size(0, 18)
        Me.ppmPL.TabIndex = 20
        '
        'ppmSL
        '
        Me.ppmSL.AutoSize = True
        Me.ppmSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmSL.Location = New System.Drawing.Point(520, 499)
        Me.ppmSL.Name = "ppmSL"
        Me.ppmSL.Size = New System.Drawing.Size(0, 18)
        Me.ppmSL.TabIndex = 21
        '
        'ppmZnL
        '
        Me.ppmZnL.AutoSize = True
        Me.ppmZnL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppmZnL.Location = New System.Drawing.Point(520, 529)
        Me.ppmZnL.Name = "ppmZnL"
        Me.ppmZnL.Size = New System.Drawing.Size(0, 18)
        Me.ppmZnL.TabIndex = 22
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClearButton.Location = New System.Drawing.Point(251, 599)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 23
        Me.ClearButton.Text = "Clean All"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CommandButton1
        '
        Me.CommandButton1.AutoSize = True
        Me.CommandButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandButton1.Location = New System.Drawing.Point(469, 599)
        Me.CommandButton1.Name = "CommandButton1"
        Me.CommandButton1.Size = New System.Drawing.Size(75, 26)
        Me.CommandButton1.TabIndex = 24
        Me.CommandButton1.Text = "Close"
        Me.CommandButton1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(555, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 15)
        Me.Label15.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(251, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 0)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(41, 196)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(0, 16)
        Me.Label33.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(256, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'ICPCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 644)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CommandButton1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ppmZnL)
        Me.Controls.Add(Me.ppmSL)
        Me.Controls.Add(Me.ppmPL)
        Me.Controls.Add(Me.ppmMoL)
        Me.Controls.Add(Me.ppmMgL)
        Me.Controls.Add(Me.ppmCuL)
        Me.Controls.Add(Me.ppmCaL)
        Me.Controls.Add(Me.ppmBL)
        Me.Controls.Add(Me.ppmBaL)
        Me.Controls.Add(Me.wtZnL)
        Me.Controls.Add(Me.wtSL)
        Me.Controls.Add(Me.wtPL)
        Me.Controls.Add(Me.wtMoL)
        Me.Controls.Add(Me.wtMgL)
        Me.Controls.Add(Me.wtCuL)
        Me.Controls.Add(Me.wtCaL)
        Me.Controls.Add(Me.wtBL)
        Me.Controls.Add(Me.wtBaL)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ICPCalculator"
        Me.Text = "ICP Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TotWeiTB As TextBox
    Friend WithEvents SamWeiTB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ppmZnTB As TextBox
    Friend WithEvents ppmSTB As TextBox
    Friend WithEvents ppmPTB As TextBox
    Friend WithEvents ppmMoTB As TextBox
    Friend WithEvents ppmMgTB As TextBox
    Friend WithEvents ppmCuTB As TextBox
    Friend WithEvents ppmCaTB As TextBox
    Friend WithEvents ppmBTB As TextBox
    Friend WithEvents ppmBaTB As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents wtBaL As Label
    Friend WithEvents wtBL As Label
    Friend WithEvents wtCaL As Label
    Friend WithEvents wtCuL As Label
    Friend WithEvents wtMgL As Label
    Friend WithEvents wtMoL As Label
    Friend WithEvents wtPL As Label
    Friend WithEvents wtSL As Label
    Friend WithEvents wtZnL As Label
    Friend WithEvents ppmBaL As Label
    Friend WithEvents ppmBL As Label
    Friend WithEvents ppmCaL As Label
    Friend WithEvents ppmCuL As Label
    Friend WithEvents ppmMgL As Label
    Friend WithEvents ppmMoL As Label
    Friend WithEvents ppmPL As Label
    Friend WithEvents ppmSL As Label
    Friend WithEvents ppmZnL As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents CommandButton1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label33 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents PictureBox2 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_AUDITORIA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dGridTabla = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.richComandos = New System.Windows.Forms.RichTextBox()
        Me.timerAuditoria = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dGridTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(843, 584)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(837, 110)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTiempo)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 49)
        Me.Panel1.TabIndex = 0
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTiempo.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTiempo.Location = New System.Drawing.Point(0, 0)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(232, 56)
        Me.lblTiempo.TabIndex = 2
        Me.lblTiempo.Text = "00:00:00"
        Me.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Lime
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(831, 49)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "QC SIMULATE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(831, 49)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(831, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "F1 NEW    F2 END    F10 BACK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dGridTabla, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 119)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(837, 462)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'dGridTabla
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridTabla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dGridTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dGridTabla.BackgroundColor = System.Drawing.Color.Black
        Me.dGridTabla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dGridTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dGridTabla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dGridTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dGridTabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dGridTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dGridTabla.DefaultCellStyle = DataGridViewCellStyle3
        Me.dGridTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dGridTabla.EnableHeadersVisualStyles = False
        Me.dGridTabla.GridColor = System.Drawing.Color.Black
        Me.dGridTabla.Location = New System.Drawing.Point(337, 3)
        Me.dGridTabla.MultiSelect = False
        Me.dGridTabla.Name = "dGridTabla"
        Me.dGridTabla.ReadOnly = True
        Me.dGridTabla.RowHeadersVisible = False
        Me.dGridTabla.ShowCellToolTips = False
        Me.dGridTabla.ShowEditingIcon = False
        Me.dGridTabla.ShowRowErrors = False
        Me.dGridTabla.Size = New System.Drawing.Size(497, 456)
        Me.dGridTabla.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel11, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel9, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel6, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel7, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel8, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel10, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel14, 1, 4)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(328, 456)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.txt4)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(101, 93)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(224, 24)
        Me.Panel11.TabIndex = 7
        '
        'txt4
        '
        Me.txt4.BackColor = System.Drawing.Color.Black
        Me.txt4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.ForeColor = System.Drawing.Color.Lime
        Me.txt4.Location = New System.Drawing.Point(0, 0)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(224, 23)
        Me.txt4.TabIndex = 3
        Me.txt4.Visible = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txt3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(101, 63)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(224, 24)
        Me.Panel9.TabIndex = 5
        '
        'txt3
        '
        Me.txt3.BackColor = System.Drawing.Color.Black
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.ForeColor = System.Drawing.Color.Lime
        Me.txt3.Location = New System.Drawing.Point(0, 0)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(224, 23)
        Me.txt3.TabIndex = 2
        Me.txt3.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(92, 24)
        Me.Panel4.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Lime
        Me.lbl1.Location = New System.Drawing.Point(0, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(92, 24)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "LABEL 1"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl1.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txt1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(101, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(224, 24)
        Me.Panel5.TabIndex = 1
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.Black
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.Color.Lime
        Me.txt1.Location = New System.Drawing.Point(0, 0)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(224, 23)
        Me.txt1.TabIndex = 0
        Me.txt1.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lbl2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 33)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(92, 24)
        Me.Panel6.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Lime
        Me.lbl2.Location = New System.Drawing.Point(0, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(92, 24)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "LABEL 2"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl2.Visible = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txt2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(101, 33)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(224, 24)
        Me.Panel7.TabIndex = 3
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.Color.Black
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.Color.Lime
        Me.txt2.Location = New System.Drawing.Point(0, 0)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(224, 23)
        Me.txt2.TabIndex = 1
        Me.txt2.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lbl3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 63)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(92, 24)
        Me.Panel8.TabIndex = 4
        '
        'lbl3
        '
        Me.lbl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Lime
        Me.lbl3.Location = New System.Drawing.Point(0, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(92, 24)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Text = "LABEL 3"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl3.Visible = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.lbl4)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 93)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(92, 24)
        Me.Panel10.TabIndex = 6
        '
        'lbl4
        '
        Me.lbl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Lime
        Me.lbl4.Location = New System.Drawing.Point(0, 0)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(92, 24)
        Me.lbl4.TabIndex = 4
        Me.lbl4.Text = "LABEL 4"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl4.Visible = False
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.richComandos)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(101, 123)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(224, 330)
        Me.Panel14.TabIndex = 8
        '
        'richComandos
        '
        Me.richComandos.BackColor = System.Drawing.Color.Black
        Me.richComandos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richComandos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richComandos.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richComandos.ForeColor = System.Drawing.Color.Lime
        Me.richComandos.Location = New System.Drawing.Point(0, 0)
        Me.richComandos.Name = "richComandos"
        Me.richComandos.ReadOnly = True
        Me.richComandos.Size = New System.Drawing.Size(224, 330)
        Me.richComandos.TabIndex = 1
        Me.richComandos.Text = ""
        '
        'timerAuditoria
        '
        Me.timerAuditoria.Enabled = True
        Me.timerAuditoria.Interval = 1000
        '
        'FORM_AUDITORIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(843, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FORM_AUDITORIA"
        Me.Text = "CRT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dGridTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt3 As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl3 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txt4 As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lbl4 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents richComandos As RichTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt1 As TextBox
    Friend WithEvents timerAuditoria As Timer
    Friend WithEvents lblTiempo As Label
    Friend WithEvents dGridTabla As DataGridView
End Class

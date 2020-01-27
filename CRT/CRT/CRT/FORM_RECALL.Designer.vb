<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_RECALL
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStore = New System.Windows.Forms.Label()
        Me.txtStore = New System.Windows.Forms.TextBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.dGridTabla = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dGridTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTitle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMenu, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1333, 762)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1327, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "RECALL"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblStore, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtStore, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 123)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1327, 32)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblStore
        '
        Me.lblStore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStore.Location = New System.Drawing.Point(3, 0)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(657, 32)
        Me.lblStore.TabIndex = 0
        Me.lblStore.Text = "STORE:"
        Me.lblStore.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblStore.Visible = False
        '
        'txtStore
        '
        Me.txtStore.BackColor = System.Drawing.Color.Black
        Me.txtStore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStore.ForeColor = System.Drawing.Color.Lime
        Me.txtStore.Location = New System.Drawing.Point(666, 3)
        Me.txtStore.Name = "txtStore"
        Me.txtStore.Size = New System.Drawing.Size(658, 23)
        Me.txtStore.TabIndex = 1
        Me.txtStore.Visible = False
        '
        'lblMenu
        '
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMenu.Location = New System.Drawing.Point(3, 60)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(1327, 60)
        Me.lblMenu.TabIndex = 6
        Me.lblMenu.Text = "F1 NEW   F2 END   F3 VIEW CREDIT   F4 ALL CREDITS   F10 BACK"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtQty, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblItem, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblQty, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtItem, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 161)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1327, 32)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Black
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQty.ForeColor = System.Drawing.Color.Lime
        Me.txtQty.Location = New System.Drawing.Point(603, 3)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(194, 23)
        Me.txtQty.TabIndex = 3
        Me.txtQty.Visible = False
        '
        'lblItem
        '
        Me.lblItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblItem.Location = New System.Drawing.Point(3, 0)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(194, 32)
        Me.lblItem.TabIndex = 0
        Me.lblItem.Text = "ITEM:"
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblItem.Visible = False
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQty.Location = New System.Drawing.Point(403, 0)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(194, 32)
        Me.lblQty.TabIndex = 1
        Me.lblQty.Text = "QTY:"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblQty.Visible = False
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.Black
        Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtItem.ForeColor = System.Drawing.Color.Lime
        Me.txtItem.Location = New System.Drawing.Point(203, 3)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(194, 23)
        Me.txtItem.TabIndex = 2
        Me.txtItem.WordWrap = False
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
        Me.dGridTabla.Location = New System.Drawing.Point(3, 3)
        Me.dGridTabla.MultiSelect = False
        Me.dGridTabla.Name = "dGridTabla"
        Me.dGridTabla.ReadOnly = True
        Me.dGridTabla.RowHeadersVisible = False
        Me.dGridTabla.ShowCellToolTips = False
        Me.dGridTabla.ShowEditingIcon = False
        Me.dGridTabla.ShowRowErrors = False
        Me.dGridTabla.Size = New System.Drawing.Size(1321, 554)
        Me.dGridTabla.TabIndex = 6
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dGridTabla, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 199)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1327, 560)
        Me.TableLayoutPanel4.TabIndex = 8
        '
        'FORM_RECALL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1333, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FORM_RECALL"
        Me.Text = "RECALL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.dGridTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblStore As Label
    Friend WithEvents txtStore As TextBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblItem As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dGridTabla As DataGridView
End Class

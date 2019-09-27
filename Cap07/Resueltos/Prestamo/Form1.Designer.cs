namespace Prestamo
{
  partial class Prestamo
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.lsdIncremento = new System.Windows.Forms.ComboBox();
      this.etLabel6 = new System.Windows.Forms.Label();
      this.ctPeriodoMin = new System.Windows.Forms.TextBox();
      this.etLabel3 = new System.Windows.Forms.Label();
      this.ctPeriodoMax = new System.Windows.Forms.TextBox();
      this.etLabel2 = new System.Windows.Forms.Label();
      this.btCalculoAmort = new System.Windows.Forms.Button();
      this.btCalculoPagos = new System.Windows.Forms.Button();
      this.cgTiposDeInteres = new System.Windows.Forms.GroupBox();
      this.ctInteresMin = new System.Windows.Forms.TextBox();
      this.etLabel5 = new System.Windows.Forms.Label();
      this.ctInteresMax = new System.Windows.Forms.TextBox();
      this.etLabel4 = new System.Windows.Forms.Label();
      this.cgDuracionPrestamo = new System.Windows.Forms.GroupBox();
      this.OpcionesSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.menuPrestamoEn = new System.Windows.Forms.ToolStripMenuItem();
      this.PrestamoEnAños = new System.Windows.Forms.ToolStripMenuItem();
      this.PrestamoEnMeses = new System.Windows.Forms.ToolStripMenuItem();
      this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesInstruc = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesSeparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.ctCredito = new System.Windows.Forms.TextBox();
      this.etLabel1 = new System.Windows.Forms.Label();
      this.msBarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
      this.AyudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
      this.tablaPrestamo = new System.Windows.Forms.DataGridView();
      this.cgTiposDeInteres.SuspendLayout();
      this.cgDuracionPrestamo.SuspendLayout();
      this.msBarraDeMenus.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tablaPrestamo)).BeginInit();
      this.SuspendLayout();
      // 
      // lsdIncremento
      // 
      this.lsdIncremento.FormattingEnabled = true;
      this.lsdIncremento.Items.AddRange(new object[] {
            "0,10",
            "0,25",
            "0,50",
            "1,00"});
      this.lsdIncremento.Location = new System.Drawing.Point(78, 74);
      this.lsdIncremento.Name = "lsdIncremento";
      this.lsdIncremento.Size = new System.Drawing.Size(70, 21);
      this.lsdIncremento.TabIndex = 2;
      // 
      // etLabel6
      // 
      this.etLabel6.AutoSize = true;
      this.etLabel6.Location = new System.Drawing.Point(6, 77);
      this.etLabel6.Name = "etLabel6";
      this.etLabel6.Size = new System.Drawing.Size(63, 13);
      this.etLabel6.TabIndex = 5;
      this.etLabel6.Text = "Incremento:";
      // 
      // ctPeriodoMin
      // 
      this.ctPeriodoMin.Location = new System.Drawing.Point(56, 47);
      this.ctPeriodoMin.Name = "ctPeriodoMin";
      this.ctPeriodoMin.Size = new System.Drawing.Size(93, 20);
      this.ctPeriodoMin.TabIndex = 1;
      this.ctPeriodoMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // etLabel3
      // 
      this.etLabel3.AutoSize = true;
      this.etLabel3.Location = new System.Drawing.Point(5, 50);
      this.etLabel3.Name = "etLabel3";
      this.etLabel3.Size = new System.Drawing.Size(45, 13);
      this.etLabel3.TabIndex = 3;
      this.etLabel3.Text = "Mínimo:";
      // 
      // ctPeriodoMax
      // 
      this.ctPeriodoMax.Location = new System.Drawing.Point(56, 20);
      this.ctPeriodoMax.Name = "ctPeriodoMax";
      this.ctPeriodoMax.Size = new System.Drawing.Size(93, 20);
      this.ctPeriodoMax.TabIndex = 0;
      this.ctPeriodoMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // etLabel2
      // 
      this.etLabel2.AutoSize = true;
      this.etLabel2.Location = new System.Drawing.Point(6, 23);
      this.etLabel2.Name = "etLabel2";
      this.etLabel2.Size = new System.Drawing.Size(46, 13);
      this.etLabel2.TabIndex = 2;
      this.etLabel2.Text = "Máximo:";
      // 
      // btCalculoAmort
      // 
      this.btCalculoAmort.Enabled = false;
      this.btCalculoAmort.Location = new System.Drawing.Point(14, 316);
      this.btCalculoAmort.Name = "btCalculoAmort";
      this.btCalculoAmort.Size = new System.Drawing.Size(149, 23);
      this.btCalculoAmort.TabIndex = 4;
      this.btCalculoAmort.Text = "Amortización";
      this.btCalculoAmort.Click += new System.EventHandler(this.btCalculoAmort_Click);
      // 
      // btCalculoPagos
      // 
      this.btCalculoPagos.Location = new System.Drawing.Point(14, 282);
      this.btCalculoPagos.Name = "btCalculoPagos";
      this.btCalculoPagos.Size = new System.Drawing.Size(149, 23);
      this.btCalculoPagos.TabIndex = 3;
      this.btCalculoPagos.Text = "Pagos";
      this.btCalculoPagos.Click += new System.EventHandler(this.btCalculoPagos_Click);
      // 
      // cgTiposDeInteres
      // 
      this.cgTiposDeInteres.Controls.Add(this.lsdIncremento);
      this.cgTiposDeInteres.Controls.Add(this.etLabel6);
      this.cgTiposDeInteres.Controls.Add(this.ctInteresMin);
      this.cgTiposDeInteres.Controls.Add(this.etLabel5);
      this.cgTiposDeInteres.Controls.Add(this.ctInteresMax);
      this.cgTiposDeInteres.Controls.Add(this.etLabel4);
      this.cgTiposDeInteres.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cgTiposDeInteres.Location = new System.Drawing.Point(8, 159);
      this.cgTiposDeInteres.Name = "cgTiposDeInteres";
      this.cgTiposDeInteres.Size = new System.Drawing.Size(155, 109);
      this.cgTiposDeInteres.TabIndex = 2;
      this.cgTiposDeInteres.TabStop = false;
      this.cgTiposDeInteres.Text = "Tipos de interés";
      // 
      // ctInteresMin
      // 
      this.ctInteresMin.Location = new System.Drawing.Point(78, 47);
      this.ctInteresMin.Name = "ctInteresMin";
      this.ctInteresMin.Size = new System.Drawing.Size(71, 20);
      this.ctInteresMin.TabIndex = 1;
      this.ctInteresMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // etLabel5
      // 
      this.etLabel5.AutoSize = true;
      this.etLabel5.Location = new System.Drawing.Point(5, 50);
      this.etLabel5.Name = "etLabel5";
      this.etLabel5.Size = new System.Drawing.Size(55, 13);
      this.etLabel5.TabIndex = 4;
      this.etLabel5.Text = "% mínimo:";
      // 
      // ctInteresMax
      // 
      this.ctInteresMax.Location = new System.Drawing.Point(78, 20);
      this.ctInteresMax.Name = "ctInteresMax";
      this.ctInteresMax.Size = new System.Drawing.Size(71, 20);
      this.ctInteresMax.TabIndex = 0;
      this.ctInteresMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // etLabel4
      // 
      this.etLabel4.AutoSize = true;
      this.etLabel4.Location = new System.Drawing.Point(6, 23);
      this.etLabel4.Name = "etLabel4";
      this.etLabel4.Size = new System.Drawing.Size(56, 13);
      this.etLabel4.TabIndex = 3;
      this.etLabel4.Text = "% máximo:";
      // 
      // cgDuracionPrestamo
      // 
      this.cgDuracionPrestamo.Controls.Add(this.ctPeriodoMin);
      this.cgDuracionPrestamo.Controls.Add(this.etLabel3);
      this.cgDuracionPrestamo.Controls.Add(this.ctPeriodoMax);
      this.cgDuracionPrestamo.Controls.Add(this.etLabel2);
      this.cgDuracionPrestamo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cgDuracionPrestamo.Location = new System.Drawing.Point(8, 72);
      this.cgDuracionPrestamo.Name = "cgDuracionPrestamo";
      this.cgDuracionPrestamo.Size = new System.Drawing.Size(155, 81);
      this.cgDuracionPrestamo.TabIndex = 1;
      this.cgDuracionPrestamo.TabStop = false;
      this.cgDuracionPrestamo.Text = "Duración del préstamo";
      // 
      // OpcionesSalir
      // 
      this.OpcionesSalir.Name = "OpcionesSalir";
      this.OpcionesSalir.Size = new System.Drawing.Size(152, 22);
      this.OpcionesSalir.Text = "&Salir";
      this.OpcionesSalir.Click += new System.EventHandler(this.OpcionesSalir_Click);
      // 
      // menuPrestamoEn
      // 
      this.menuPrestamoEn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrestamoEnAños,
            this.PrestamoEnMeses});
      this.menuPrestamoEn.Name = "menuPrestamoEn";
      this.menuPrestamoEn.Size = new System.Drawing.Size(91, 20);
      this.menuPrestamoEn.Text = "&Préstamo en...";
      // 
      // PrestamoEnAños
      // 
      this.PrestamoEnAños.Name = "PrestamoEnAños";
      this.PrestamoEnAños.Size = new System.Drawing.Size(152, 22);
      this.PrestamoEnAños.Text = "&Años";
      this.PrestamoEnAños.Click += new System.EventHandler(this.PrestamoEnAñosMeses_Click);
      // 
      // PrestamoEnMeses
      // 
      this.PrestamoEnMeses.Name = "PrestamoEnMeses";
      this.PrestamoEnMeses.Size = new System.Drawing.Size(152, 22);
      this.PrestamoEnMeses.Text = "&Meses";
      this.PrestamoEnMeses.Click += new System.EventHandler(this.PrestamoEnAñosMeses_Click);
      // 
      // menuOpciones
      // 
      this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesInstruc,
            this.OpcionesSeparador1,
            this.OpcionesSalir});
      this.menuOpciones.Name = "menuOpciones";
      this.menuOpciones.Size = new System.Drawing.Size(63, 20);
      this.menuOpciones.Text = "&Opciones";
      // 
      // OpcionesInstruc
      // 
      this.OpcionesInstruc.Name = "OpcionesInstruc";
      this.OpcionesInstruc.Size = new System.Drawing.Size(152, 22);
      this.OpcionesInstruc.Text = "&Instrucciones";
      this.OpcionesInstruc.Click += new System.EventHandler(this.OpcionesInstruc_Click);
      // 
      // OpcionesSeparador1
      // 
      this.OpcionesSeparador1.Name = "OpcionesSeparador1";
      this.OpcionesSeparador1.Size = new System.Drawing.Size(149, 6);
      // 
      // ctCredito
      // 
      this.ctCredito.Location = new System.Drawing.Point(63, 37);
      this.ctCredito.Name = "ctCredito";
      this.ctCredito.Size = new System.Drawing.Size(100, 20);
      this.ctCredito.TabIndex = 0;
      this.ctCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // etLabel1
      // 
      this.etLabel1.AutoSize = true;
      this.etLabel1.Location = new System.Drawing.Point(13, 37);
      this.etLabel1.Name = "etLabel1";
      this.etLabel1.Size = new System.Drawing.Size(43, 13);
      this.etLabel1.TabIndex = 6;
      this.etLabel1.Text = "Crédito:";
      // 
      // msBarraDeMenus
      // 
      this.msBarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpciones,
            this.menuPrestamoEn,
            this.menuAyuda});
      this.msBarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.msBarraDeMenus.Name = "msBarraDeMenus";
      this.msBarraDeMenus.Size = new System.Drawing.Size(477, 24);
      this.msBarraDeMenus.TabIndex = 7;
      this.msBarraDeMenus.Text = "MenuStrip1";
      // 
      // menuAyuda
      // 
      this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaAcercaDe});
      this.menuAyuda.Name = "menuAyuda";
      this.menuAyuda.Size = new System.Drawing.Size(50, 20);
      this.menuAyuda.Text = "&Ayuda";
      // 
      // AyudaAcercaDe
      // 
      this.AyudaAcercaDe.Name = "AyudaAcercaDe";
      this.AyudaAcercaDe.Size = new System.Drawing.Size(193, 22);
      this.AyudaAcercaDe.Text = "&Acerca de Préstamo...";
      this.AyudaAcercaDe.Click += new System.EventHandler(this.AyudaAcercaDe_Click);
      // 
      // tablaPrestamo
      // 
      this.tablaPrestamo.AllowUserToAddRows = false;
      this.tablaPrestamo.AllowUserToDeleteRows = false;
      this.tablaPrestamo.AllowUserToResizeRows = false;
      this.tablaPrestamo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.tablaPrestamo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.tablaPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.tablaPrestamo.DefaultCellStyle = dataGridViewCellStyle4;
      this.tablaPrestamo.Location = new System.Drawing.Point(171, 37);
      this.tablaPrestamo.Name = "tablaPrestamo";
      this.tablaPrestamo.ReadOnly = true;
      this.tablaPrestamo.RowHeadersWidth = 90;
      this.tablaPrestamo.Size = new System.Drawing.Size(294, 302);
      this.tablaPrestamo.TabIndex = 5;
      this.tablaPrestamo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPrestamo_CellClick);
      // 
      // Prestamo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(477, 351);
      this.Controls.Add(this.btCalculoAmort);
      this.Controls.Add(this.btCalculoPagos);
      this.Controls.Add(this.cgTiposDeInteres);
      this.Controls.Add(this.cgDuracionPrestamo);
      this.Controls.Add(this.ctCredito);
      this.Controls.Add(this.etLabel1);
      this.Controls.Add(this.msBarraDeMenus);
      this.Controls.Add(this.tablaPrestamo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = "Prestamo";
      this.Text = "Préstamo bancario";
      this.Load += new System.EventHandler(this.Prestamo_Load);
      this.cgTiposDeInteres.ResumeLayout(false);
      this.cgTiposDeInteres.PerformLayout();
      this.cgDuracionPrestamo.ResumeLayout(false);
      this.cgDuracionPrestamo.PerformLayout();
      this.msBarraDeMenus.ResumeLayout(false);
      this.msBarraDeMenus.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tablaPrestamo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox lsdIncremento;
    private System.Windows.Forms.Label etLabel6;
    private System.Windows.Forms.TextBox ctPeriodoMin;
    private System.Windows.Forms.Label etLabel3;
    private System.Windows.Forms.TextBox ctPeriodoMax;
    private System.Windows.Forms.Label etLabel2;
    private System.Windows.Forms.Button btCalculoAmort;
    private System.Windows.Forms.Button btCalculoPagos;
    private System.Windows.Forms.GroupBox cgTiposDeInteres;
    private System.Windows.Forms.TextBox ctInteresMin;
    private System.Windows.Forms.Label etLabel5;
    private System.Windows.Forms.TextBox ctInteresMax;
    private System.Windows.Forms.Label etLabel4;
    private System.Windows.Forms.GroupBox cgDuracionPrestamo;
    private System.Windows.Forms.ToolStripMenuItem OpcionesSalir;
    private System.Windows.Forms.ToolStripMenuItem menuPrestamoEn;
    private System.Windows.Forms.ToolStripMenuItem PrestamoEnAños;
    private System.Windows.Forms.ToolStripMenuItem PrestamoEnMeses;
    private System.Windows.Forms.ToolStripMenuItem menuOpciones;
    private System.Windows.Forms.ToolStripMenuItem OpcionesInstruc;
    private System.Windows.Forms.ToolStripSeparator OpcionesSeparador1;
    private System.Windows.Forms.TextBox ctCredito;
    private System.Windows.Forms.Label etLabel1;
    private System.Windows.Forms.MenuStrip msBarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuAyuda;
    private System.Windows.Forms.ToolStripMenuItem AyudaAcercaDe;
    private System.Windows.Forms.DataGridView tablaPrestamo;
  }
}


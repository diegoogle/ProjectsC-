namespace EditorMDI
{
  partial class FormDocumento
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocumento));
      this.rtbText = new System.Windows.Forms.RichTextBox();
      this.btbarCortar = new System.Windows.Forms.ToolStripButton();
      this.btbarPegar = new System.Windows.Forms.ToolStripButton();
      this.btbarCopiar = new System.Windows.Forms.ToolStripButton();
      this.barSeparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
      this.btbarGuardar = new System.Windows.Forms.ToolStripButton();
      this.btbarImprimir = new System.Windows.Forms.ToolStripButton();
      this.barSeparador2 = new System.Windows.Forms.ToolStripSeparator();
      this.btbarNegrita = new System.Windows.Forms.ToolStripButton();
      this.btbarCursiva = new System.Windows.Forms.ToolStripButton();
      this.btbarSubrayado = new System.Windows.Forms.ToolStripButton();
      this.barSeparador3 = new System.Windows.Forms.ToolStripSeparator();
      this.btbarAlinIzda = new System.Windows.Forms.ToolStripButton();
      this.btbarAlinCentrada = new System.Windows.Forms.ToolStripButton();
      this.btbarAlinDcha = new System.Windows.Forms.ToolStripButton();
      this.ArchivoImprimir = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionDeshacer = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionRehacer = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionSeparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.EdicionCortar = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionPegar = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoGuardarcomo = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
      this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
      this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
      this.BarraDeHerramientas.SuspendLayout();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // rtbText
      // 
      this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbText.EnableAutoDragDrop = true;
      this.rtbText.Location = new System.Drawing.Point(0, 25);
      this.rtbText.Name = "rtbText";
      this.rtbText.Size = new System.Drawing.Size(392, 241);
      this.rtbText.TabIndex = 1;
      this.rtbText.Text = "";
      this.rtbText.SelectionChanged += new System.EventHandler(this.rtbText_SelectionChanged);
      // 
      // btbarCortar
      // 
      this.btbarCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarCortar.Image = ((System.Drawing.Image)(resources.GetObject("btbarCortar.Image")));
      this.btbarCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarCortar.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarCortar.MergeIndex = 6;
      this.btbarCortar.Name = "btbarCortar";
      this.btbarCortar.Size = new System.Drawing.Size(23, 22);
      this.btbarCortar.Text = "Cort&ar";
      this.btbarCortar.Click += new System.EventHandler(this.EdicionCortar_Click);
      // 
      // btbarPegar
      // 
      this.btbarPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarPegar.Image = ((System.Drawing.Image)(resources.GetObject("btbarPegar.Image")));
      this.btbarPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarPegar.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarPegar.MergeIndex = 8;
      this.btbarPegar.Name = "btbarPegar";
      this.btbarPegar.Size = new System.Drawing.Size(23, 22);
      this.btbarPegar.Text = "&Pegar";
      this.btbarPegar.Click += new System.EventHandler(this.EdicionPegar_Click);
      // 
      // btbarCopiar
      // 
      this.btbarCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btbarCopiar.Image")));
      this.btbarCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarCopiar.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarCopiar.MergeIndex = 7;
      this.btbarCopiar.Name = "btbarCopiar";
      this.btbarCopiar.Size = new System.Drawing.Size(23, 22);
      this.btbarCopiar.Text = "&Copiar";
      this.btbarCopiar.Click += new System.EventHandler(this.EdicionCopiar_Click);
      // 
      // barSeparador1
      // 
      this.barSeparador1.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.barSeparador1.MergeIndex = 5;
      this.barSeparador1.Name = "barSeparador1";
      this.barSeparador1.Size = new System.Drawing.Size(6, 25);
      // 
      // BarraDeHerramientas
      // 
      this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbarGuardar,
            this.btbarImprimir,
            this.barSeparador1,
            this.btbarCortar,
            this.btbarCopiar,
            this.btbarPegar,
            this.barSeparador2,
            this.btbarNegrita,
            this.btbarCursiva,
            this.btbarSubrayado,
            this.barSeparador3,
            this.btbarAlinIzda,
            this.btbarAlinCentrada,
            this.btbarAlinDcha});
      this.BarraDeHerramientas.Location = new System.Drawing.Point(0, 0);
      this.BarraDeHerramientas.Name = "BarraDeHerramientas";
      this.BarraDeHerramientas.Size = new System.Drawing.Size(392, 25);
      this.BarraDeHerramientas.TabIndex = 2;
      this.BarraDeHerramientas.Text = "ToolStrip1";
      this.BarraDeHerramientas.Visible = false;
      // 
      // btbarGuardar
      // 
      this.btbarGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btbarGuardar.Image")));
      this.btbarGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarGuardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarGuardar.MergeIndex = 3;
      this.btbarGuardar.Name = "btbarGuardar";
      this.btbarGuardar.Size = new System.Drawing.Size(23, 22);
      this.btbarGuardar.Text = "&Guardar";
      this.btbarGuardar.Click += new System.EventHandler(this.ArchivoGuardar_Click);
      // 
      // btbarImprimir
      // 
      this.btbarImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btbarImprimir.Image")));
      this.btbarImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarImprimir.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarImprimir.MergeIndex = 4;
      this.btbarImprimir.Name = "btbarImprimir";
      this.btbarImprimir.Size = new System.Drawing.Size(23, 22);
      this.btbarImprimir.Text = "&Imprimir";
      this.btbarImprimir.Click += new System.EventHandler(this.ArchivoImprimir_Click);
      // 
      // barSeparador2
      // 
      this.barSeparador2.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.barSeparador2.MergeIndex = 9;
      this.barSeparador2.Name = "barSeparador2";
      this.barSeparador2.Size = new System.Drawing.Size(6, 25);
      // 
      // btbarNegrita
      // 
      this.btbarNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarNegrita.Image = ((System.Drawing.Image)(resources.GetObject("btbarNegrita.Image")));
      this.btbarNegrita.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarNegrita.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarNegrita.MergeIndex = 10;
      this.btbarNegrita.Name = "btbarNegrita";
      this.btbarNegrita.Size = new System.Drawing.Size(23, 22);
      this.btbarNegrita.Text = "ToolStripButton1";
      this.btbarNegrita.ToolTipText = "Negrita";
      this.btbarNegrita.Click += new System.EventHandler(this.btbarNegrita_Click);
      // 
      // btbarCursiva
      // 
      this.btbarCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarCursiva.Image = ((System.Drawing.Image)(resources.GetObject("btbarCursiva.Image")));
      this.btbarCursiva.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarCursiva.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarCursiva.MergeIndex = 11;
      this.btbarCursiva.Name = "btbarCursiva";
      this.btbarCursiva.Size = new System.Drawing.Size(23, 22);
      this.btbarCursiva.Text = "ToolStripButton2";
      this.btbarCursiva.ToolTipText = "Cursiva";
      this.btbarCursiva.Click += new System.EventHandler(this.btbarCursiva_Click);
      // 
      // btbarSubrayado
      // 
      this.btbarSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarSubrayado.Image = ((System.Drawing.Image)(resources.GetObject("btbarSubrayado.Image")));
      this.btbarSubrayado.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarSubrayado.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarSubrayado.MergeIndex = 12;
      this.btbarSubrayado.Name = "btbarSubrayado";
      this.btbarSubrayado.Size = new System.Drawing.Size(23, 22);
      this.btbarSubrayado.Text = "ToolStripButton3";
      this.btbarSubrayado.ToolTipText = "Subrayado";
      this.btbarSubrayado.Click += new System.EventHandler(this.btbarSubrayado_Click);
      // 
      // barSeparador3
      // 
      this.barSeparador3.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.barSeparador3.MergeIndex = 13;
      this.barSeparador3.Name = "barSeparador3";
      this.barSeparador3.Size = new System.Drawing.Size(6, 25);
      // 
      // btbarAlinIzda
      // 
      this.btbarAlinIzda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarAlinIzda.Image = ((System.Drawing.Image)(resources.GetObject("btbarAlinIzda.Image")));
      this.btbarAlinIzda.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarAlinIzda.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarAlinIzda.MergeIndex = 14;
      this.btbarAlinIzda.Name = "btbarAlinIzda";
      this.btbarAlinIzda.Size = new System.Drawing.Size(23, 22);
      this.btbarAlinIzda.Text = "ToolStripButton4";
      this.btbarAlinIzda.ToolTipText = "Alinear a la izquierda";
      this.btbarAlinIzda.Click += new System.EventHandler(this.btbarAlinIzda_Click);
      // 
      // btbarAlinCentrada
      // 
      this.btbarAlinCentrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarAlinCentrada.Image = ((System.Drawing.Image)(resources.GetObject("btbarAlinCentrada.Image")));
      this.btbarAlinCentrada.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarAlinCentrada.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarAlinCentrada.MergeIndex = 15;
      this.btbarAlinCentrada.Name = "btbarAlinCentrada";
      this.btbarAlinCentrada.Size = new System.Drawing.Size(23, 22);
      this.btbarAlinCentrada.Text = "ToolStripButton5";
      this.btbarAlinCentrada.ToolTipText = "Centrar";
      this.btbarAlinCentrada.Click += new System.EventHandler(this.btbarAlinCentrada_Click);
      // 
      // btbarAlinDcha
      // 
      this.btbarAlinDcha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarAlinDcha.Image = ((System.Drawing.Image)(resources.GetObject("btbarAlinDcha.Image")));
      this.btbarAlinDcha.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarAlinDcha.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarAlinDcha.MergeIndex = 16;
      this.btbarAlinDcha.Name = "btbarAlinDcha";
      this.btbarAlinDcha.Size = new System.Drawing.Size(23, 22);
      this.btbarAlinDcha.Text = "ToolStripButton6";
      this.btbarAlinDcha.ToolTipText = "Alinear a la derecha";
      this.btbarAlinDcha.Click += new System.EventHandler(this.btbarAlinDcha_Click);
      // 
      // ArchivoImprimir
      // 
      this.ArchivoImprimir.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.ArchivoImprimir.MergeIndex = 4;
      this.ArchivoImprimir.Name = "ArchivoImprimir";
      this.ArchivoImprimir.Size = new System.Drawing.Size(150, 22);
      this.ArchivoImprimir.Text = "&Imprimir";
      this.ArchivoImprimir.Click += new System.EventHandler(this.ArchivoImprimir_Click);
      // 
      // ArchivoSeparator1
      // 
      this.ArchivoSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.ArchivoSeparator1.MergeIndex = 5;
      this.ArchivoSeparator1.Name = "ArchivoSeparator1";
      this.ArchivoSeparator1.Size = new System.Drawing.Size(147, 6);
      // 
      // menuEdicion
      // 
      this.menuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EdicionDeshacer,
            this.EdicionRehacer,
            this.EdicionSeparador1,
            this.EdicionCortar,
            this.EdicionCopiar,
            this.EdicionPegar});
      this.menuEdicion.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.menuEdicion.MergeIndex = 1;
      this.menuEdicion.Name = "menuEdicion";
      this.menuEdicion.Size = new System.Drawing.Size(58, 20);
      this.menuEdicion.Text = "&Edición";
      // 
      // EdicionDeshacer
      // 
      this.EdicionDeshacer.Name = "EdicionDeshacer";
      this.EdicionDeshacer.Size = new System.Drawing.Size(122, 22);
      this.EdicionDeshacer.Text = "Deshacer";
      this.EdicionDeshacer.Click += new System.EventHandler(this.EdicionDeshacer_Click);
      // 
      // EdicionRehacer
      // 
      this.EdicionRehacer.Name = "EdicionRehacer";
      this.EdicionRehacer.Size = new System.Drawing.Size(122, 22);
      this.EdicionRehacer.Text = "Rehacer";
      this.EdicionRehacer.Click += new System.EventHandler(this.EdicionRehacer_Click);
      // 
      // EdicionSeparador1
      // 
      this.EdicionSeparador1.Name = "EdicionSeparador1";
      this.EdicionSeparador1.Size = new System.Drawing.Size(119, 6);
      // 
      // EdicionCortar
      // 
      this.EdicionCortar.Name = "EdicionCortar";
      this.EdicionCortar.Size = new System.Drawing.Size(122, 22);
      this.EdicionCortar.Text = "Cortar";
      this.EdicionCortar.Click += new System.EventHandler(this.EdicionCortar_Click);
      // 
      // EdicionCopiar
      // 
      this.EdicionCopiar.Name = "EdicionCopiar";
      this.EdicionCopiar.Size = new System.Drawing.Size(122, 22);
      this.EdicionCopiar.Text = "Copiar";
      this.EdicionCopiar.Click += new System.EventHandler(this.EdicionCopiar_Click);
      // 
      // EdicionPegar
      // 
      this.EdicionPegar.Name = "EdicionPegar";
      this.EdicionPegar.Size = new System.Drawing.Size(122, 22);
      this.EdicionPegar.Text = "Pegar";
      this.EdicionPegar.Click += new System.EventHandler(this.EdicionPegar_Click);
      // 
      // ArchivoGuardarcomo
      // 
      this.ArchivoGuardarcomo.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.ArchivoGuardarcomo.MergeIndex = 3;
      this.ArchivoGuardarcomo.Name = "ArchivoGuardarcomo";
      this.ArchivoGuardarcomo.Size = new System.Drawing.Size(150, 22);
      this.ArchivoGuardarcomo.Text = "Guardar &como";
      this.ArchivoGuardarcomo.Click += new System.EventHandler(this.ArchivoGuardarcomo_Click);
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEdicion});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(392, 24);
      this.BarraDeMenus.TabIndex = 0;
      this.BarraDeMenus.Text = "MenuStrip1";
      this.BarraDeMenus.Visible = false;
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoGuardar,
            this.ArchivoGuardarcomo,
            this.ArchivoImprimir,
            this.ArchivoSeparator1});
      this.menuArchivo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
      this.menuArchivo.MergeIndex = 0;
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(60, 20);
      this.menuArchivo.Text = "&Archivo";
      // 
      // ArchivoGuardar
      // 
      this.ArchivoGuardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.ArchivoGuardar.MergeIndex = 2;
      this.ArchivoGuardar.Name = "ArchivoGuardar";
      this.ArchivoGuardar.Size = new System.Drawing.Size(150, 22);
      this.ArchivoGuardar.Text = "&Guardar";
      this.ArchivoGuardar.Click += new System.EventHandler(this.ArchivoGuardar_Click);
      // 
      // PrintDialog1
      // 
      this.PrintDialog1.Document = this.PrintDocument1;
      this.PrintDialog1.UseEXDialog = true;
      // 
      // PrintDocument1
      // 
      this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
      // 
      // FormDocumento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(392, 266);
      this.Controls.Add(this.rtbText);
      this.Controls.Add(this.BarraDeHerramientas);
      this.Controls.Add(this.BarraDeMenus);
      this.MainMenuStrip = this.BarraDeMenus;
      this.Name = "FormDocumento";
      this.Text = "Form2";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDocumento_FormClosing);
      this.BarraDeHerramientas.ResumeLayout(false);
      this.BarraDeHerramientas.PerformLayout();
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.RichTextBox rtbText;
    internal System.Windows.Forms.ToolStripButton btbarCortar;
    internal System.Windows.Forms.ToolStripButton btbarPegar;
    internal System.Windows.Forms.ToolStripButton btbarCopiar;
    internal System.Windows.Forms.ToolStripSeparator barSeparador1;
    internal System.Windows.Forms.ToolStrip BarraDeHerramientas;
    internal System.Windows.Forms.ToolStripButton btbarGuardar;
    internal System.Windows.Forms.ToolStripButton btbarImprimir;
    internal System.Windows.Forms.ToolStripSeparator barSeparador2;
    internal System.Windows.Forms.ToolStripButton btbarNegrita;
    internal System.Windows.Forms.ToolStripButton btbarCursiva;
    internal System.Windows.Forms.ToolStripButton btbarSubrayado;
    internal System.Windows.Forms.ToolStripSeparator barSeparador3;
    internal System.Windows.Forms.ToolStripButton btbarAlinIzda;
    internal System.Windows.Forms.ToolStripButton btbarAlinCentrada;
    internal System.Windows.Forms.ToolStripButton btbarAlinDcha;
    internal System.Windows.Forms.ToolStripMenuItem ArchivoImprimir;
    internal System.Windows.Forms.ToolStripSeparator ArchivoSeparator1;
    internal System.Windows.Forms.ToolStripMenuItem menuEdicion;
    internal System.Windows.Forms.ToolStripMenuItem EdicionDeshacer;
    internal System.Windows.Forms.ToolStripMenuItem EdicionRehacer;
    internal System.Windows.Forms.ToolStripSeparator EdicionSeparador1;
    internal System.Windows.Forms.ToolStripMenuItem EdicionCortar;
    internal System.Windows.Forms.ToolStripMenuItem EdicionCopiar;
    internal System.Windows.Forms.ToolStripMenuItem EdicionPegar;
    internal System.Windows.Forms.ToolStripMenuItem ArchivoGuardarcomo;
    internal System.Windows.Forms.MenuStrip BarraDeMenus;
    internal System.Windows.Forms.ToolStripMenuItem menuArchivo;
    internal System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
    internal System.Windows.Forms.PrintDialog PrintDialog1;
    internal System.Drawing.Printing.PrintDocument PrintDocument1;
  }
}
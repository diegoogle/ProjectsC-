namespace EditorMDI
{
  partial class FormDocumento2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocumento2));
      this.rtbText = new System.Windows.Forms.RichTextBox();
      this.btbarCortar = new System.Windows.Forms.ToolStripButton();
      this.btbarPegar = new System.Windows.Forms.ToolStripButton();
      this.btbarCopiar = new System.Windows.Forms.ToolStripButton();
      this.barSeparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
      this.btbarGuardar = new System.Windows.Forms.ToolStripButton();
      this.ArchivoSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ArchivoGuardarcomo = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
      this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeHerramientas.SuspendLayout();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // rtbText
      // 
      this.rtbText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbText.EnableAutoDragDrop = true;
      this.rtbText.Location = new System.Drawing.Point(0, 0);
      this.rtbText.Name = "rtbText";
      this.rtbText.Size = new System.Drawing.Size(392, 266);
      this.rtbText.TabIndex = 1;
      this.rtbText.Text = "";
      // 
      // btbarCortar
      // 
      this.btbarCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarCortar.Image = ((System.Drawing.Image)(resources.GetObject("btbarCortar.Image")));
      this.btbarCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarCortar.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.btbarCortar.MergeIndex = 5;
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
      this.btbarPegar.MergeIndex = 7;
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
      this.btbarCopiar.MergeIndex = 6;
      this.btbarCopiar.Name = "btbarCopiar";
      this.btbarCopiar.Size = new System.Drawing.Size(23, 22);
      this.btbarCopiar.Text = "&Copiar";
      this.btbarCopiar.Click += new System.EventHandler(this.EdicionCopiar_Click);
      // 
      // barSeparador1
      // 
      this.barSeparador1.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.barSeparador1.MergeIndex = 4;
      this.barSeparador1.Name = "barSeparador1";
      this.barSeparador1.Size = new System.Drawing.Size(6, 25);
      // 
      // BarraDeHerramientas
      // 
      this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbarGuardar,
            this.barSeparador1,
            this.btbarCortar,
            this.btbarCopiar,
            this.btbarPegar});
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
      // ArchivoSeparator1
      // 
      this.ArchivoSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.ArchivoSeparator1.MergeIndex = 4;
      this.ArchivoSeparator1.Name = "ArchivoSeparator1";
      this.ArchivoSeparator1.Size = new System.Drawing.Size(149, 6);
      // 
      // ArchivoGuardarcomo
      // 
      this.ArchivoGuardarcomo.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.ArchivoGuardarcomo.MergeIndex = 3;
      this.ArchivoGuardarcomo.Name = "ArchivoGuardarcomo";
      this.ArchivoGuardarcomo.Size = new System.Drawing.Size(152, 22);
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
            this.ArchivoSeparator1});
      this.menuArchivo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
      this.menuArchivo.MergeIndex = 0;
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(55, 20);
      this.menuArchivo.Text = "&Archivo";
      // 
      // ArchivoGuardar
      // 
      this.ArchivoGuardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.ArchivoGuardar.MergeIndex = 2;
      this.ArchivoGuardar.Name = "ArchivoGuardar";
      this.ArchivoGuardar.Size = new System.Drawing.Size(152, 22);
      this.ArchivoGuardar.Text = "&Guardar";
      this.ArchivoGuardar.Click += new System.EventHandler(this.ArchivoGuardar_Click);
      // 
      // menuEdicion
      // 
      this.menuEdicion.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.menuEdicion.MergeIndex = 1;
      this.menuEdicion.Name = "menuEdicion";
      this.menuEdicion.Size = new System.Drawing.Size(63, 20);
      this.menuEdicion.Text = "Opciones";
      // 
      // FormDocumento2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(392, 266);
      this.Controls.Add(this.rtbText);
      this.Controls.Add(this.BarraDeHerramientas);
      this.Controls.Add(this.BarraDeMenus);
      this.MainMenuStrip = this.BarraDeMenus;
      this.Name = "FormDocumento2";
      this.Text = "Form3";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDocumento2_FormClosing);
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
    internal System.Windows.Forms.ToolStripSeparator ArchivoSeparator1;
    internal System.Windows.Forms.ToolStripMenuItem ArchivoGuardarcomo;
    internal System.Windows.Forms.MenuStrip BarraDeMenus;
    internal System.Windows.Forms.ToolStripMenuItem menuArchivo;
    internal System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
    internal System.Windows.Forms.ToolStripMenuItem menuEdicion;
  }
}
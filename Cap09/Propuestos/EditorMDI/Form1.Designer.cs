namespace EditorMDI
{
  partial class FormMDI
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
      this.AyudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeHerra = new System.Windows.Forms.ToolStrip();
      this.btbarNuevo = new System.Windows.Forms.ToolStripButton();
      this.ArchivoNuevo2 = new System.Windows.Forms.ToolStripButton();
      this.btbarAbrir = new System.Windows.Forms.ToolStripButton();
      this.barSparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.btbarAyuda = new System.Windows.Forms.ToolStripButton();
      this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaOrganizar = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaSeparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
      this.etbarestPpal = new System.Windows.Forms.ToolStripStatusLabel();
      this.VentanaMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.menuVer = new System.Windows.Forms.ToolStripMenuItem();
      this.VerBarraDeHerramientas = new System.Windows.Forms.ToolStripMenuItem();
      this.VerBarraDeEstado = new System.Windows.Forms.ToolStripMenuItem();
      this.menuVentana = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeHerra.SuspendLayout();
      this.BarraDeEstado.SuspendLayout();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // AyudaAcercaDe
      // 
      this.AyudaAcercaDe.Name = "AyudaAcercaDe";
      this.AyudaAcercaDe.Size = new System.Drawing.Size(135, 22);
      this.AyudaAcercaDe.Text = "Acerca de...";
      this.AyudaAcercaDe.Click += new System.EventHandler(this.AyudaAcercaDe_Click);
      // 
      // BarraDeHerra
      // 
      this.BarraDeHerra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbarNuevo,
            this.ArchivoNuevo2,
            this.btbarAbrir,
            this.barSparador1,
            this.btbarAyuda});
      this.BarraDeHerra.Location = new System.Drawing.Point(0, 24);
      this.BarraDeHerra.Name = "BarraDeHerra";
      this.BarraDeHerra.Size = new System.Drawing.Size(457, 25);
      this.BarraDeHerra.TabIndex = 1;
      this.BarraDeHerra.Text = "ToolStrip1";
      // 
      // btbarNuevo
      // 
      this.btbarNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btbarNuevo.Image")));
      this.btbarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarNuevo.MergeIndex = 0;
      this.btbarNuevo.Name = "btbarNuevo";
      this.btbarNuevo.Size = new System.Drawing.Size(23, 22);
      this.btbarNuevo.Text = "&Nuevo";
      this.btbarNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
      // 
      // ArchivoNuevo2
      // 
      this.ArchivoNuevo2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ArchivoNuevo2.Image = ((System.Drawing.Image)(resources.GetObject("ArchivoNuevo2.Image")));
      this.ArchivoNuevo2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ArchivoNuevo2.MergeIndex = 1;
      this.ArchivoNuevo2.Name = "ArchivoNuevo2";
      this.ArchivoNuevo2.Size = new System.Drawing.Size(23, 22);
      this.ArchivoNuevo2.Text = "toolStripButton1";
      this.ArchivoNuevo2.Click += new System.EventHandler(this.ArchivoNuevo2_Click);
      // 
      // btbarAbrir
      // 
      this.btbarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btbarAbrir.Image")));
      this.btbarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarAbrir.MergeIndex = 2;
      this.btbarAbrir.Name = "btbarAbrir";
      this.btbarAbrir.Size = new System.Drawing.Size(23, 22);
      this.btbarAbrir.Text = "&Abrir";
      this.btbarAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      // 
      // barSparador1
      // 
      this.barSparador1.Name = "barSparador1";
      this.barSparador1.Size = new System.Drawing.Size(6, 25);
      // 
      // btbarAyuda
      // 
      this.btbarAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btbarAyuda.Image")));
      this.btbarAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarAyuda.Name = "btbarAyuda";
      this.btbarAyuda.Size = new System.Drawing.Size(23, 22);
      this.btbarAyuda.Text = "Ay&uda";
      // 
      // menuAyuda
      // 
      this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaAcercaDe});
      this.menuAyuda.MergeIndex = 4;
      this.menuAyuda.Name = "menuAyuda";
      this.menuAyuda.Size = new System.Drawing.Size(53, 20);
      this.menuAyuda.Text = "Ayuda";
      // 
      // VentanaOrganizar
      // 
      this.VentanaOrganizar.Name = "VentanaOrganizar";
      this.VentanaOrganizar.Size = new System.Drawing.Size(175, 22);
      this.VentanaOrganizar.Text = "Organizar iconos";
      this.VentanaOrganizar.Click += new System.EventHandler(this.VentanaOrganizar_Click);
      // 
      // VentanaSeparador1
      // 
      this.VentanaSeparador1.Name = "VentanaSeparador1";
      this.VentanaSeparador1.Size = new System.Drawing.Size(172, 6);
      // 
      // BarraDeEstado
      // 
      this.BarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etbarestPpal});
      this.BarraDeEstado.Location = new System.Drawing.Point(0, 249);
      this.BarraDeEstado.Name = "BarraDeEstado";
      this.BarraDeEstado.Size = new System.Drawing.Size(457, 22);
      this.BarraDeEstado.TabIndex = 2;
      this.BarraDeEstado.Text = "StatusStrip1";
      // 
      // etbarestPpal
      // 
      this.etbarestPpal.Name = "etbarestPpal";
      this.etbarestPpal.Size = new System.Drawing.Size(32, 17);
      this.etbarestPpal.Text = "Listo";
      // 
      // VentanaMosaicoVertical
      // 
      this.VentanaMosaicoVertical.Name = "VentanaMosaicoVertical";
      this.VentanaMosaicoVertical.Size = new System.Drawing.Size(175, 22);
      this.VentanaMosaicoVertical.Text = "Mosaico vertical";
      this.VentanaMosaicoVertical.Click += new System.EventHandler(this.VentanaMosaicoVertical_Click);
      // 
      // ArchivoAbrir
      // 
      this.ArchivoAbrir.MergeIndex = 1;
      this.ArchivoAbrir.Name = "ArchivoAbrir";
      this.ArchivoAbrir.Size = new System.Drawing.Size(109, 22);
      this.ArchivoAbrir.Text = "Abrir";
      this.ArchivoAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(109, 22);
      this.ArchivoSalir.Text = "Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      // 
      // ArchivoNuevo
      // 
      this.ArchivoNuevo.MergeIndex = 0;
      this.ArchivoNuevo.Name = "ArchivoNuevo";
      this.ArchivoNuevo.Size = new System.Drawing.Size(109, 22);
      this.ArchivoNuevo.Text = "Nuevo";
      this.ArchivoNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuVer,
            this.menuVentana,
            this.menuAyuda});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.MdiWindowListItem = this.menuVentana;
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(457, 24);
      this.BarraDeMenus.TabIndex = 0;
      this.BarraDeMenus.Text = "MenuStrip1";
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoNuevo,
            this.ArchivoAbrir,
            this.ArchivoSalir});
      this.menuArchivo.MergeIndex = 0;
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(60, 20);
      this.menuArchivo.Text = "Archivo";
      // 
      // menuVer
      // 
      this.menuVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerBarraDeHerramientas,
            this.VerBarraDeEstado});
      this.menuVer.MergeIndex = 2;
      this.menuVer.Name = "menuVer";
      this.menuVer.Size = new System.Drawing.Size(36, 20);
      this.menuVer.Text = "Ver";
      // 
      // VerBarraDeHerramientas
      // 
      this.VerBarraDeHerramientas.Checked = true;
      this.VerBarraDeHerramientas.CheckState = System.Windows.Forms.CheckState.Checked;
      this.VerBarraDeHerramientas.Name = "VerBarraDeHerramientas";
      this.VerBarraDeHerramientas.Size = new System.Drawing.Size(191, 22);
      this.VerBarraDeHerramientas.Text = "Barra de Herramientas";
      this.VerBarraDeHerramientas.Click += new System.EventHandler(this.VerBarraDeHerramientas_Click);
      // 
      // VerBarraDeEstado
      // 
      this.VerBarraDeEstado.Checked = true;
      this.VerBarraDeEstado.CheckState = System.Windows.Forms.CheckState.Checked;
      this.VerBarraDeEstado.Name = "VerBarraDeEstado";
      this.VerBarraDeEstado.Size = new System.Drawing.Size(191, 22);
      this.VerBarraDeEstado.Text = "Barra de Estado";
      this.VerBarraDeEstado.Click += new System.EventHandler(this.VerBarraDeEstado_Click);
      // 
      // menuVentana
      // 
      this.menuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentanaCascada,
            this.VentanaMosaicoHorizontal,
            this.VentanaMosaicoVertical,
            this.VentanaOrganizar,
            this.VentanaSeparador1});
      this.menuVentana.MergeIndex = 3;
      this.menuVentana.Name = "menuVentana";
      this.menuVentana.Size = new System.Drawing.Size(62, 20);
      this.menuVentana.Text = "Ventana";
      // 
      // VentanaCascada
      // 
      this.VentanaCascada.Name = "VentanaCascada";
      this.VentanaCascada.Size = new System.Drawing.Size(175, 22);
      this.VentanaCascada.Text = "Cascada";
      this.VentanaCascada.Click += new System.EventHandler(this.VentanaCascada_Click);
      // 
      // VentanaMosaicoHorizontal
      // 
      this.VentanaMosaicoHorizontal.Name = "VentanaMosaicoHorizontal";
      this.VentanaMosaicoHorizontal.Size = new System.Drawing.Size(175, 22);
      this.VentanaMosaicoHorizontal.Text = "Mosaico horizontal";
      this.VentanaMosaicoHorizontal.Click += new System.EventHandler(this.VentanaMosaicoHorizontal_Click);
      // 
      // FormMDI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(457, 271);
      this.Controls.Add(this.BarraDeHerra);
      this.Controls.Add(this.BarraDeEstado);
      this.Controls.Add(this.BarraDeMenus);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.BarraDeMenus;
      this.Name = "FormMDI";
      this.Text = "Editor MDI";
      this.MdiChildActivate += new System.EventHandler(this.FormMDI_MdiChildActivate);
      this.BarraDeHerra.ResumeLayout(false);
      this.BarraDeHerra.PerformLayout();
      this.BarraDeEstado.ResumeLayout(false);
      this.BarraDeEstado.PerformLayout();
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.ToolStripMenuItem AyudaAcercaDe;
    internal System.Windows.Forms.ToolStrip BarraDeHerra;
    internal System.Windows.Forms.ToolStripButton btbarNuevo;
    internal System.Windows.Forms.ToolStripButton btbarAbrir;
    internal System.Windows.Forms.ToolStripSeparator barSparador1;
    internal System.Windows.Forms.ToolStripButton btbarAyuda;
    internal System.Windows.Forms.ToolStripMenuItem menuAyuda;
    internal System.Windows.Forms.ToolStripMenuItem VentanaOrganizar;
    internal System.Windows.Forms.ToolStripSeparator VentanaSeparador1;
    internal System.Windows.Forms.StatusStrip BarraDeEstado;
    internal System.Windows.Forms.ToolStripStatusLabel etbarestPpal;
    internal System.Windows.Forms.ToolStripMenuItem VentanaMosaicoVertical;
    internal System.Windows.Forms.ToolStripMenuItem ArchivoAbrir;
    internal System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    internal System.Windows.Forms.ToolStripMenuItem ArchivoNuevo;
    internal System.Windows.Forms.MenuStrip BarraDeMenus;
    internal System.Windows.Forms.ToolStripMenuItem menuArchivo;
    internal System.Windows.Forms.ToolStripMenuItem menuVer;
    internal System.Windows.Forms.ToolStripMenuItem VerBarraDeHerramientas;
    internal System.Windows.Forms.ToolStripMenuItem VerBarraDeEstado;
    internal System.Windows.Forms.ToolStripMenuItem menuVentana;
    internal System.Windows.Forms.ToolStripMenuItem VentanaCascada;
    internal System.Windows.Forms.ToolStripMenuItem VentanaMosaicoHorizontal;
    private System.Windows.Forms.ToolStripButton ArchivoNuevo2;
  }
}


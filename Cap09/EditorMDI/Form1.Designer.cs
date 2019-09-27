namespace EditorMDI
{
  partial class FormMDI
  {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
      this.BarraDeHerraMdiPadre = new System.Windows.Forms.ToolStrip();
      this.btbarNuevo = new System.Windows.Forms.ToolStripButton();
      this.btbarAbrir = new System.Windows.Forms.ToolStripButton();
      this.barSparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.btbarAyuda = new System.Windows.Forms.ToolStripButton();
      this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
      this.etbarestPpal = new System.Windows.Forms.ToolStripStatusLabel();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.menuVer = new System.Windows.Forms.ToolStripMenuItem();
      this.VerBarraDeHerramientas = new System.Windows.Forms.ToolStripMenuItem();
      this.VerBarraDeEstado = new System.Windows.Forms.ToolStripMenuItem();
      this.menuVentana = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaOrganizar = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaSeparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
      this.AyudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeHerraMdiPadre.SuspendLayout();
      this.BarraDeEstado.SuspendLayout();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // BarraDeHerraMdiPadre
      // 
      this.BarraDeHerraMdiPadre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbarNuevo,
            this.btbarAbrir,
            this.barSparador1,
            this.btbarAyuda});
      this.BarraDeHerraMdiPadre.Location = new System.Drawing.Point(0, 27);
      this.BarraDeHerraMdiPadre.Name = "BarraDeHerraMdiPadre";
      this.BarraDeHerraMdiPadre.Size = new System.Drawing.Size(457, 25);
      this.BarraDeHerraMdiPadre.TabIndex = 4;
      this.BarraDeHerraMdiPadre.Text = "ToolStrip1";
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
      // btbarAbrir
      // 
      this.btbarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btbarAbrir.Image")));
      this.btbarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarAbrir.MergeIndex = 1;
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
      this.btbarAyuda.Click += new System.EventHandler(this.AyudaAcercaDe_Click);
      // 
      // BarraDeEstado
      // 
      this.BarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etbarestPpal});
      this.BarraDeEstado.Location = new System.Drawing.Point(0, 247);
      this.BarraDeEstado.Name = "BarraDeEstado";
      this.BarraDeEstado.Size = new System.Drawing.Size(457, 24);
      this.BarraDeEstado.TabIndex = 5;
      this.BarraDeEstado.Text = "StatusStrip1";
      // 
      // etbarestPpal
      // 
      this.etbarestPpal.Name = "etbarestPpal";
      this.etbarestPpal.Size = new System.Drawing.Size(38, 19);
      this.etbarestPpal.Text = "Listo";
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
      this.BarraDeMenus.Size = new System.Drawing.Size(457, 27);
      this.BarraDeMenus.TabIndex = 3;
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
      this.menuArchivo.Size = new System.Drawing.Size(67, 23);
      this.menuArchivo.Text = "Archivo";
      // 
      // ArchivoNuevo
      // 
      this.ArchivoNuevo.MergeIndex = 0;
      this.ArchivoNuevo.Name = "ArchivoNuevo";
      this.ArchivoNuevo.Size = new System.Drawing.Size(152, 24);
      this.ArchivoNuevo.Text = "Nuevo";
      this.ArchivoNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
      // 
      // ArchivoAbrir
      // 
      this.ArchivoAbrir.MergeIndex = 1;
      this.ArchivoAbrir.Name = "ArchivoAbrir";
      this.ArchivoAbrir.Size = new System.Drawing.Size(152, 24);
      this.ArchivoAbrir.Text = "Abrir";
      this.ArchivoAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(152, 24);
      this.ArchivoSalir.Text = "Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      // 
      // menuVer
      // 
      this.menuVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerBarraDeHerramientas,
            this.VerBarraDeEstado});
      this.menuVer.MergeIndex = 2;
      this.menuVer.Name = "menuVer";
      this.menuVer.Size = new System.Drawing.Size(42, 23);
      this.menuVer.Text = "Ver";
      // 
      // VerBarraDeHerramientas
      // 
      this.VerBarraDeHerramientas.Checked = true;
      this.VerBarraDeHerramientas.CheckState = System.Windows.Forms.CheckState.Checked;
      this.VerBarraDeHerramientas.Name = "VerBarraDeHerramientas";
      this.VerBarraDeHerramientas.Size = new System.Drawing.Size(215, 24);
      this.VerBarraDeHerramientas.Text = "Barra de Herramientas";
      this.VerBarraDeHerramientas.Click += new System.EventHandler(this.VerBarraDeHerramientas_Click);
      // 
      // VerBarraDeEstado
      // 
      this.VerBarraDeEstado.Checked = true;
      this.VerBarraDeEstado.CheckState = System.Windows.Forms.CheckState.Checked;
      this.VerBarraDeEstado.Name = "VerBarraDeEstado";
      this.VerBarraDeEstado.Size = new System.Drawing.Size(215, 24);
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
      this.menuVentana.Size = new System.Drawing.Size(72, 23);
      this.menuVentana.Text = "Ventana";
      // 
      // VentanaCascada
      // 
      this.VentanaCascada.Name = "VentanaCascada";
      this.VentanaCascada.Size = new System.Drawing.Size(194, 24);
      this.VentanaCascada.Text = "Cascada";
      this.VentanaCascada.Click += new System.EventHandler(this.VentanaCascada_Click);
      // 
      // VentanaMosaicoHorizontal
      // 
      this.VentanaMosaicoHorizontal.Name = "VentanaMosaicoHorizontal";
      this.VentanaMosaicoHorizontal.Size = new System.Drawing.Size(194, 24);
      this.VentanaMosaicoHorizontal.Text = "Mosaico horizontal";
      this.VentanaMosaicoHorizontal.Click += new System.EventHandler(this.VentanaMosaicoHorizontal_Click);
      // 
      // VentanaMosaicoVertical
      // 
      this.VentanaMosaicoVertical.Name = "VentanaMosaicoVertical";
      this.VentanaMosaicoVertical.Size = new System.Drawing.Size(194, 24);
      this.VentanaMosaicoVertical.Text = "Mosaico vertical";
      this.VentanaMosaicoVertical.Click += new System.EventHandler(this.VentanaMosaicoVertical_Click);
      // 
      // VentanaOrganizar
      // 
      this.VentanaOrganizar.Name = "VentanaOrganizar";
      this.VentanaOrganizar.Size = new System.Drawing.Size(194, 24);
      this.VentanaOrganizar.Text = "Organizar iconos";
      this.VentanaOrganizar.Click += new System.EventHandler(this.VentanaOrganizar_Click);
      // 
      // VentanaSeparador1
      // 
      this.VentanaSeparador1.Name = "VentanaSeparador1";
      this.VentanaSeparador1.Size = new System.Drawing.Size(191, 6);
      // 
      // menuAyuda
      // 
      this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaAcercaDe});
      this.menuAyuda.MergeIndex = 4;
      this.menuAyuda.Name = "menuAyuda";
      this.menuAyuda.Size = new System.Drawing.Size(60, 23);
      this.menuAyuda.Text = "Ayuda";
      // 
      // AyudaAcercaDe
      // 
      this.AyudaAcercaDe.Name = "AyudaAcercaDe";
      this.AyudaAcercaDe.Size = new System.Drawing.Size(146, 24);
      this.AyudaAcercaDe.Text = "Acerca de...";
      this.AyudaAcercaDe.Click += new System.EventHandler(this.AyudaAcercaDe_Click);
      // 
      // FormMDI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(457, 271);
      this.Controls.Add(this.BarraDeHerraMdiPadre);
      this.Controls.Add(this.BarraDeEstado);
      this.Controls.Add(this.BarraDeMenus);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.BarraDeMenus;
      this.Name = "FormMDI";
      this.Text = "Editor MDI";
      this.MdiChildActivate += new System.EventHandler(this.FormMDI_MdiChildActivate);
      this.BarraDeHerraMdiPadre.ResumeLayout(false);
      this.BarraDeHerraMdiPadre.PerformLayout();
      this.BarraDeEstado.ResumeLayout(false);
      this.BarraDeEstado.PerformLayout();
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip BarraDeHerraMdiPadre;
    private System.Windows.Forms.ToolStripButton btbarNuevo;
    private System.Windows.Forms.ToolStripButton btbarAbrir;
    private System.Windows.Forms.ToolStripSeparator barSparador1;
    private System.Windows.Forms.ToolStripButton btbarAyuda;
    private System.Windows.Forms.StatusStrip BarraDeEstado;
    internal System.Windows.Forms.ToolStripStatusLabel etbarestPpal;
    private System.Windows.Forms.MenuStrip BarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoNuevo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoAbrir;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    private System.Windows.Forms.ToolStripMenuItem menuVer;
    private System.Windows.Forms.ToolStripMenuItem VerBarraDeHerramientas;
    private System.Windows.Forms.ToolStripMenuItem VerBarraDeEstado;
    private System.Windows.Forms.ToolStripMenuItem menuVentana;
    private System.Windows.Forms.ToolStripMenuItem VentanaCascada;
    private System.Windows.Forms.ToolStripMenuItem VentanaMosaicoHorizontal;
    private System.Windows.Forms.ToolStripMenuItem VentanaMosaicoVertical;
    private System.Windows.Forms.ToolStripMenuItem VentanaOrganizar;
    private System.Windows.Forms.ToolStripSeparator VentanaSeparador1;
    private System.Windows.Forms.ToolStripMenuItem menuAyuda;
    private System.Windows.Forms.ToolStripMenuItem AyudaAcercaDe;
  }
}


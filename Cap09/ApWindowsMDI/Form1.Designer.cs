namespace ApWindowsMDI
{
  partial class FormPadre
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
      this.BarraMenusFormPadre = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
      this.menuVentana = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaHorizontal = new System.Windows.Forms.ToolStripMenuItem();
      this.VentanaVertical = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.BarraMenusFormPadre.SuspendLayout();
      this.SuspendLayout();
      // 
      // BarraMenusFormPadre
      // 
      this.BarraMenusFormPadre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuVentana});
      this.BarraMenusFormPadre.Location = new System.Drawing.Point(0, 0);
      this.BarraMenusFormPadre.MdiWindowListItem = this.menuVentana;
      this.BarraMenusFormPadre.Name = "BarraMenusFormPadre";
      this.BarraMenusFormPadre.Size = new System.Drawing.Size(417, 27);
      this.BarraMenusFormPadre.TabIndex = 3;
      this.BarraMenusFormPadre.Text = "MenuStrip1";
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoNuevo,
            this.ArchivoCerrar});
      this.menuArchivo.MergeIndex = 0;
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(67, 23);
      this.menuArchivo.Text = "&Archivo";
      // 
      // ArchivoNuevo
      // 
      this.ArchivoNuevo.Name = "ArchivoNuevo";
      this.ArchivoNuevo.Size = new System.Drawing.Size(118, 24);
      this.ArchivoNuevo.Text = "&Nuevo";
      this.ArchivoNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
      // 
      // ArchivoCerrar
      // 
      this.ArchivoCerrar.Name = "ArchivoCerrar";
      this.ArchivoCerrar.Size = new System.Drawing.Size(118, 24);
      this.ArchivoCerrar.Text = "&Cerrar";
      this.ArchivoCerrar.Click += new System.EventHandler(this.ArchivoCerrar_Click);
      // 
      // menuVentana
      // 
      this.menuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentanaCascada,
            this.VentanaHorizontal,
            this.VentanaVertical,
            this.ToolStripSeparator1});
      this.menuVentana.MergeIndex = 2;
      this.menuVentana.Name = "menuVentana";
      this.menuVentana.Size = new System.Drawing.Size(72, 23);
      this.menuVentana.Text = "&Ventana";
      // 
      // VentanaCascada
      // 
      this.VentanaCascada.Name = "VentanaCascada";
      this.VentanaCascada.Size = new System.Drawing.Size(141, 24);
      this.VentanaCascada.Text = "Cascada";
      this.VentanaCascada.Click += new System.EventHandler(this.VentanaCascada_Click);
      // 
      // VentanaHorizontal
      // 
      this.VentanaHorizontal.Name = "VentanaHorizontal";
      this.VentanaHorizontal.Size = new System.Drawing.Size(141, 24);
      this.VentanaHorizontal.Text = "Horizontal";
      this.VentanaHorizontal.Click += new System.EventHandler(this.VentanaHorizontal_Click);
      // 
      // VentanaVertical
      // 
      this.VentanaVertical.Name = "VentanaVertical";
      this.VentanaVertical.Size = new System.Drawing.Size(141, 24);
      this.VentanaVertical.Text = "Vertical";
      this.VentanaVertical.Click += new System.EventHandler(this.VentanaVertical_Click);
      // 
      // ToolStripSeparator1
      // 
      this.ToolStripSeparator1.Name = "ToolStripSeparator1";
      this.ToolStripSeparator1.Size = new System.Drawing.Size(138, 6);
      // 
      // FormPadre
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(417, 266);
      this.Controls.Add(this.BarraMenusFormPadre);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.BarraMenusFormPadre;
      this.Name = "FormPadre";
      this.Text = "Formulario MDI";
      this.BarraMenusFormPadre.ResumeLayout(false);
      this.BarraMenusFormPadre.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip BarraMenusFormPadre;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoNuevo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoCerrar;
    private System.Windows.Forms.ToolStripMenuItem menuVentana;
    private System.Windows.Forms.ToolStripMenuItem VentanaCascada;
    private System.Windows.Forms.ToolStripMenuItem VentanaHorizontal;
    private System.Windows.Forms.ToolStripMenuItem VentanaVertical;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
  }
}


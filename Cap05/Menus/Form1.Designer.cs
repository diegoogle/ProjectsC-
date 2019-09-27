namespace Menus
{
  partial class Form1
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
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoGuardarMismoNombre = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoGuardarOtroNombre = new System.Windows.Forms.ToolStripMenuItem();
      this.Separador1 = new System.Windows.Forms.ToolStripSeparator();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
      this.btbarAbrir = new System.Windows.Forms.ToolStripButton();
      this.btbarGuardarMismoNombre = new System.Windows.Forms.ToolStripButton();
      this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
      this.etbarestPpal = new System.Windows.Forms.ToolStripStatusLabel();
      this.BarraDeMenus.SuspendLayout();
      this.BarraDeHerramientas.SuspendLayout();
      this.BarraDeEstado.SuspendLayout();
      this.SuspendLayout();
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(492, 27);
      this.BarraDeMenus.TabIndex = 1;
      this.BarraDeMenus.Text = "Barra de menús";
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoAbrir,
            this.ArchivoGuardar,
            this.Separador1,
            this.ArchivoSalir});
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(67, 23);
      this.menuArchivo.Text = "&Archivo";
      // 
      // ArchivoAbrir
      // 
      this.ArchivoAbrir.Image = global::Menus.Properties.Resources.imagenArchivoAbrir;
      this.ArchivoAbrir.ImageTransparentColor = System.Drawing.Color.Black;
      this.ArchivoAbrir.Name = "ArchivoAbrir";
      this.ArchivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.ArchivoAbrir.Size = new System.Drawing.Size(167, 24);
      this.ArchivoAbrir.Text = "&Abrir...";
      this.ArchivoAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      this.ArchivoAbrir.MouseEnter += new System.EventHandler(this.ArchivoAbrir_MouseEnter);
      this.ArchivoAbrir.MouseLeave += new System.EventHandler(this.OrdenMenu_MouseLeave);
      // 
      // ArchivoGuardar
      // 
      this.ArchivoGuardar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoGuardarMismoNombre,
            this.ArchivoGuardarOtroNombre});
      this.ArchivoGuardar.Image = global::Menus.Properties.Resources.imagenArchivoGuardar;
      this.ArchivoGuardar.ImageTransparentColor = System.Drawing.Color.Black;
      this.ArchivoGuardar.Name = "ArchivoGuardar";
      this.ArchivoGuardar.Size = new System.Drawing.Size(167, 24);
      this.ArchivoGuardar.Text = "&Guardar";
      this.ArchivoGuardar.MouseEnter += new System.EventHandler(this.ArchivoGuardar_MouseEnter);
      this.ArchivoGuardar.MouseLeave += new System.EventHandler(this.OrdenMenu_MouseLeave);
      // 
      // ArchivoGuardarMismoNombre
      // 
      this.ArchivoGuardarMismoNombre.Name = "ArchivoGuardarMismoNombre";
      this.ArchivoGuardarMismoNombre.Size = new System.Drawing.Size(172, 24);
      this.ArchivoGuardarMismoNombre.Text = "&Mismo nombre";
      this.ArchivoGuardarMismoNombre.Click += new System.EventHandler(this.ArchivoGuardarMismoNombre_Click);
      this.ArchivoGuardarMismoNombre.MouseEnter += new System.EventHandler(this.ArchivoGuardarMismoNombre_MouseEnter);
      this.ArchivoGuardarMismoNombre.MouseLeave += new System.EventHandler(this.OrdenMenu_MouseLeave);
      // 
      // ArchivoGuardarOtroNombre
      // 
      this.ArchivoGuardarOtroNombre.Name = "ArchivoGuardarOtroNombre";
      this.ArchivoGuardarOtroNombre.Size = new System.Drawing.Size(172, 24);
      this.ArchivoGuardarOtroNombre.Text = "&Otro nombre";
      this.ArchivoGuardarOtroNombre.Click += new System.EventHandler(this.ArchivoGuardarOtroNombre_Click);
      this.ArchivoGuardarOtroNombre.MouseEnter += new System.EventHandler(this.ArchivoGuardarOtroNombre_MouseEnter);
      this.ArchivoGuardarOtroNombre.MouseLeave += new System.EventHandler(this.OrdenMenu_MouseLeave);
      // 
      // Separador1
      // 
      this.Separador1.Name = "Separador1";
      this.Separador1.Size = new System.Drawing.Size(164, 6);
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(167, 24);
      this.ArchivoSalir.Text = "&Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      this.ArchivoSalir.MouseEnter += new System.EventHandler(this.ArchivoSalir_MouseEnter);
      this.ArchivoSalir.MouseLeave += new System.EventHandler(this.OrdenMenu_MouseLeave);
      // 
      // BarraDeHerramientas
      // 
      this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbarAbrir,
            this.btbarGuardarMismoNombre});
      this.BarraDeHerramientas.Location = new System.Drawing.Point(0, 27);
      this.BarraDeHerramientas.Name = "BarraDeHerramientas";
      this.BarraDeHerramientas.Size = new System.Drawing.Size(492, 25);
      this.BarraDeHerramientas.TabIndex = 2;
      this.BarraDeHerramientas.Text = "Barra de herramientas";
      // 
      // btbarAbrir
      // 
      this.btbarAbrir.Image = global::Menus.Properties.Resources.imagenbtbarAbrir;
      this.btbarAbrir.ImageTransparentColor = System.Drawing.Color.Black;
      this.btbarAbrir.Name = "btbarAbrir";
      this.btbarAbrir.Size = new System.Drawing.Size(23, 22);
      this.btbarAbrir.ToolTipText = "Abrir";
      this.btbarAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      // 
      // btbarGuardarMismoNombre
      // 
      this.btbarGuardarMismoNombre.Image = global::Menus.Properties.Resources.imagenbtbarGuardar;
      this.btbarGuardarMismoNombre.ImageTransparentColor = System.Drawing.Color.Black;
      this.btbarGuardarMismoNombre.Name = "btbarGuardarMismoNombre";
      this.btbarGuardarMismoNombre.Size = new System.Drawing.Size(23, 22);
      this.btbarGuardarMismoNombre.ToolTipText = "Guardar";
      this.btbarGuardarMismoNombre.Click += new System.EventHandler(this.ArchivoGuardarMismoNombre_Click);
      // 
      // BarraDeEstado
      // 
      this.BarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etbarestPpal});
      this.BarraDeEstado.Location = new System.Drawing.Point(0, 242);
      this.BarraDeEstado.Name = "BarraDeEstado";
      this.BarraDeEstado.Size = new System.Drawing.Size(492, 24);
      this.BarraDeEstado.TabIndex = 3;
      this.BarraDeEstado.Text = "Barra de estado";
      // 
      // etbarestPpal
      // 
      this.etbarestPpal.Name = "etbarestPpal";
      this.etbarestPpal.Size = new System.Drawing.Size(38, 19);
      this.etbarestPpal.Text = "Listo";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(492, 266);
      this.Controls.Add(this.BarraDeEstado);
      this.Controls.Add(this.BarraDeHerramientas);
      this.Controls.Add(this.BarraDeMenus);
      this.Name = "Form1";
      this.Text = "Menús";
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.BarraDeHerramientas.ResumeLayout(false);
      this.BarraDeHerramientas.PerformLayout();
      this.BarraDeEstado.ResumeLayout(false);
      this.BarraDeEstado.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip BarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoAbrir;
    private System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
    private System.Windows.Forms.ToolStripMenuItem ArchivoGuardarMismoNombre;
    private System.Windows.Forms.ToolStripMenuItem ArchivoGuardarOtroNombre;
    private System.Windows.Forms.ToolStripSeparator Separador1;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    private System.Windows.Forms.ToolStrip BarraDeHerramientas;
    private System.Windows.Forms.ToolStripButton btbarAbrir;
    private System.Windows.Forms.ToolStripButton btbarGuardarMismoNombre;
    private System.Windows.Forms.StatusStrip BarraDeEstado;
    private System.Windows.Forms.ToolStripStatusLabel etbarestPpal;
  }
}


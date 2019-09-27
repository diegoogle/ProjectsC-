namespace MenusDinamicos
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
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.menuPais = new System.Windows.Forms.ToolStripMenuItem();
      this.PaisAnadir = new System.Windows.Forms.ToolStripMenuItem();
      this.PaisEliminar = new System.Windows.Forms.ToolStripMenuItem();
      this.Separador1 = new System.Windows.Forms.ToolStripSeparator();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuPais});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(292, 27);
      this.BarraDeMenus.TabIndex = 2;
      this.BarraDeMenus.Text = "MenuStrip1";
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoSalir});
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(67, 23);
      this.menuArchivo.Text = "&Archivo";
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(152, 24);
      this.ArchivoSalir.Text = "&Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      // 
      // menuPais
      // 
      this.menuPais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaisAnadir,
            this.PaisEliminar,
            this.Separador1});
      this.menuPais.Name = "menuPais";
      this.menuPais.Size = new System.Drawing.Size(45, 23);
      this.menuPais.Text = "&País";
      // 
      // PaisAnadir
      // 
      this.PaisAnadir.Name = "PaisAnadir";
      this.PaisAnadir.Size = new System.Drawing.Size(152, 24);
      this.PaisAnadir.Text = "Añadir";
      this.PaisAnadir.Click += new System.EventHandler(this.PaisAnadir_Click);
      // 
      // PaisEliminar
      // 
      this.PaisEliminar.Name = "PaisEliminar";
      this.PaisEliminar.Size = new System.Drawing.Size(152, 24);
      this.PaisEliminar.Text = "Eliminar";
      this.PaisEliminar.Visible = false;
      this.PaisEliminar.Click += new System.EventHandler(this.PaisEliminar_Click);
      // 
      // Separador1
      // 
      this.Separador1.Name = "Separador1";
      this.Separador1.Size = new System.Drawing.Size(123, 6);
      this.Separador1.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 166);
      this.Controls.Add(this.BarraDeMenus);
      this.Name = "Form1";
      this.Text = "Menús dinámicos";
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip BarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    private System.Windows.Forms.ToolStripMenuItem menuPais;
    private System.Windows.Forms.ToolStripMenuItem PaisAnadir;
    private System.Windows.Forms.ToolStripMenuItem PaisEliminar;
    private System.Windows.Forms.ToolStripSeparator Separador1;
  }
}


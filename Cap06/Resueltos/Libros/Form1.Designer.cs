namespace Libros
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
      this.ctPrestado = new System.Windows.Forms.TextBox();
      this.etPrestado = new System.Windows.Forms.Label();
      this.ctEditorial = new System.Windows.Forms.TextBox();
      this.etEditorial = new System.Windows.Forms.Label();
      this.ctAutor = new System.Windows.Forms.TextBox();
      this.etAutor = new System.Windows.Forms.Label();
      this.ctTitulo = new System.Windows.Forms.TextBox();
      this.etTitulo = new System.Windows.Forms.Label();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoAñadirReg = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoBuscarReg = new System.Windows.Forms.ToolStripMenuItem();
      this.Separador1 = new System.Windows.Forms.ToolStripSeparator();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // ctPrestado
      // 
      this.ctPrestado.AcceptsReturn = true;
      this.ctPrestado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ctPrestado.Location = new System.Drawing.Point(73, 129);
      this.ctPrestado.Multiline = true;
      this.ctPrestado.Name = "ctPrestado";
      this.ctPrestado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.ctPrestado.Size = new System.Drawing.Size(307, 85);
      this.ctPrestado.TabIndex = 7;
      this.ctPrestado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
      this.ctPrestado.Enter += new System.EventHandler(this.CajaTexto_Enter);
      // 
      // etPrestado
      // 
      this.etPrestado.AutoSize = true;
      this.etPrestado.Location = new System.Drawing.Point(13, 129);
      this.etPrestado.Name = "etPrestado";
      this.etPrestado.Size = new System.Drawing.Size(52, 13);
      this.etPrestado.TabIndex = 6;
      this.etPrestado.Text = "Prestado:";
      // 
      // ctEditorial
      // 
      this.ctEditorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ctEditorial.Location = new System.Drawing.Point(73, 95);
      this.ctEditorial.Name = "ctEditorial";
      this.ctEditorial.Size = new System.Drawing.Size(307, 20);
      this.ctEditorial.TabIndex = 5;
      this.ctEditorial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
      this.ctEditorial.Enter += new System.EventHandler(this.CajaTexto_Enter);
      // 
      // etEditorial
      // 
      this.etEditorial.AutoSize = true;
      this.etEditorial.Location = new System.Drawing.Point(12, 95);
      this.etEditorial.Name = "etEditorial";
      this.etEditorial.Size = new System.Drawing.Size(47, 13);
      this.etEditorial.TabIndex = 4;
      this.etEditorial.Text = "Editorial:";
      // 
      // ctAutor
      // 
      this.ctAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ctAutor.Location = new System.Drawing.Point(73, 65);
      this.ctAutor.Name = "ctAutor";
      this.ctAutor.Size = new System.Drawing.Size(307, 20);
      this.ctAutor.TabIndex = 3;
      this.ctAutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
      this.ctAutor.Enter += new System.EventHandler(this.CajaTexto_Enter);
      // 
      // etAutor
      // 
      this.etAutor.AutoSize = true;
      this.etAutor.Location = new System.Drawing.Point(12, 65);
      this.etAutor.Name = "etAutor";
      this.etAutor.Size = new System.Drawing.Size(35, 13);
      this.etAutor.TabIndex = 2;
      this.etAutor.Text = "Autor:";
      // 
      // ctTitulo
      // 
      this.ctTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ctTitulo.Location = new System.Drawing.Point(73, 33);
      this.ctTitulo.Name = "ctTitulo";
      this.ctTitulo.Size = new System.Drawing.Size(307, 20);
      this.ctTitulo.TabIndex = 1;
      this.ctTitulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
      this.ctTitulo.Enter += new System.EventHandler(this.CajaTexto_Enter);
      // 
      // etTitulo
      // 
      this.etTitulo.AutoSize = true;
      this.etTitulo.Location = new System.Drawing.Point(12, 36);
      this.etTitulo.Name = "etTitulo";
      this.etTitulo.Size = new System.Drawing.Size(38, 13);
      this.etTitulo.TabIndex = 0;
      this.etTitulo.Text = "Título:";
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(392, 27);
      this.BarraDeMenus.TabIndex = 8;
      this.BarraDeMenus.Text = "Barra de menus";
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoAñadirReg,
            this.ArchivoBuscarReg,
            this.Separador1,
            this.ArchivoSalir});
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(67, 23);
      this.menuArchivo.Text = "&Archivo";
      // 
      // ArchivoAñadirReg
      // 
      this.ArchivoAñadirReg.Name = "ArchivoAñadirReg";
      this.ArchivoAñadirReg.Size = new System.Drawing.Size(178, 24);
      this.ArchivoAñadirReg.Text = "&Añadir registro";
      this.ArchivoAñadirReg.Click += new System.EventHandler(this.ArchivoAñadirReg_Click);
      // 
      // ArchivoBuscarReg
      // 
      this.ArchivoBuscarReg.Name = "ArchivoBuscarReg";
      this.ArchivoBuscarReg.Size = new System.Drawing.Size(178, 24);
      this.ArchivoBuscarReg.Text = "&Buscar registro...";
      this.ArchivoBuscarReg.Click += new System.EventHandler(this.ArchivoBuscarReg_Click);
      // 
      // Separador1
      // 
      this.Separador1.Name = "Separador1";
      this.Separador1.Size = new System.Drawing.Size(175, 6);
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(178, 24);
      this.ArchivoSalir.Text = "&Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(392, 226);
      this.Controls.Add(this.ctPrestado);
      this.Controls.Add(this.etPrestado);
      this.Controls.Add(this.ctEditorial);
      this.Controls.Add(this.etEditorial);
      this.Controls.Add(this.ctAutor);
      this.Controls.Add(this.etAutor);
      this.Controls.Add(this.ctTitulo);
      this.Controls.Add(this.etTitulo);
      this.Controls.Add(this.BarraDeMenus);
      this.Name = "Form1";
      this.Text = "Libros prestados";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox ctPrestado;
    private System.Windows.Forms.Label etPrestado;
    private System.Windows.Forms.TextBox ctEditorial;
    private System.Windows.Forms.Label etEditorial;
    private System.Windows.Forms.TextBox ctAutor;
    private System.Windows.Forms.Label etAutor;
    private System.Windows.Forms.TextBox ctTitulo;
    private System.Windows.Forms.Label etTitulo;
    private System.Windows.Forms.MenuStrip BarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoAñadirReg;
    private System.Windows.Forms.ToolStripMenuItem ArchivoBuscarReg;
    private System.Windows.Forms.ToolStripSeparator Separador1;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
  }
}


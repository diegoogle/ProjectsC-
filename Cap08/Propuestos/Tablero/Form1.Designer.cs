namespace Tablero
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btRectangulo = new System.Windows.Forms.ToolStripButton();
      this.btElipse = new System.Windows.Forms.ToolStripButton();
      this.btLinea = new System.Windows.Forms.ToolStripButton();
      this.AyudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
      this.btManoAlzada = new System.Windows.Forms.ToolStripButton();
      this.etY = new System.Windows.Forms.ToolStripStatusLabel();
      this.Panel = new System.Windows.Forms.Panel();
      this.barraDeHerramientas = new System.Windows.Forms.ToolStrip();
      this.barraDeEstado = new System.Windows.Forms.StatusStrip();
      this.etMensaje = new System.Windows.Forms.ToolStripStatusLabel();
      this.etX = new System.Windows.Forms.ToolStripStatusLabel();
      this.AyudaInstrucciones = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoSeparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
      this.barraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.DibujarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.DibujarManoAlzada = new System.Windows.Forms.ToolStripMenuItem();
      this.DibujarLinea = new System.Windows.Forms.ToolStripMenuItem();
      this.DibujarRectangulo = new System.Windows.Forms.ToolStripMenuItem();
      this.DibujarElipse = new System.Windows.Forms.ToolStripMenuItem();
      this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
      this.barraDeHerramientas.SuspendLayout();
      this.barraDeEstado.SuspendLayout();
      this.barraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // btRectangulo
      // 
      this.btRectangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btRectangulo.Image = ((System.Drawing.Image)(resources.GetObject("btRectangulo.Image")));
      this.btRectangulo.ImageTransparentColor = System.Drawing.Color.Silver;
      this.btRectangulo.Name = "btRectangulo";
      this.btRectangulo.Size = new System.Drawing.Size(23, 22);
      this.btRectangulo.Text = "Rectángulo";
      this.btRectangulo.Click += new System.EventHandler(this.Botón_Click);
      // 
      // btElipse
      // 
      this.btElipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btElipse.Image = ((System.Drawing.Image)(resources.GetObject("btElipse.Image")));
      this.btElipse.ImageTransparentColor = System.Drawing.Color.Silver;
      this.btElipse.Name = "btElipse";
      this.btElipse.Size = new System.Drawing.Size(23, 22);
      this.btElipse.Text = "Elipse";
      this.btElipse.Click += new System.EventHandler(this.Botón_Click);
      // 
      // btLinea
      // 
      this.btLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btLinea.Image = ((System.Drawing.Image)(resources.GetObject("btLinea.Image")));
      this.btLinea.ImageTransparentColor = System.Drawing.Color.Silver;
      this.btLinea.Name = "btLinea";
      this.btLinea.Size = new System.Drawing.Size(23, 22);
      this.btLinea.Text = "Línea";
      this.btLinea.Click += new System.EventHandler(this.Botón_Click);
      // 
      // AyudaAcercaDe
      // 
      this.AyudaAcercaDe.Name = "AyudaAcercaDe";
      this.AyudaAcercaDe.Size = new System.Drawing.Size(161, 22);
      this.AyudaAcercaDe.Text = "Acerca de...";
      this.AyudaAcercaDe.Click += new System.EventHandler(this.AyudaAcercaDe_Click);
      // 
      // btManoAlzada
      // 
      this.btManoAlzada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btManoAlzada.Image = ((System.Drawing.Image)(resources.GetObject("btManoAlzada.Image")));
      this.btManoAlzada.ImageTransparentColor = System.Drawing.Color.Silver;
      this.btManoAlzada.Name = "btManoAlzada";
      this.btManoAlzada.Size = new System.Drawing.Size(23, 22);
      this.btManoAlzada.Text = "Mano alzada";
      this.btManoAlzada.Click += new System.EventHandler(this.Botón_Click);
      // 
      // etY
      // 
      this.etY.Name = "etY";
      this.etY.Size = new System.Drawing.Size(13, 17);
      this.etY.Text = "0";
      // 
      // Panel
      // 
      this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.Panel.Cursor = System.Windows.Forms.Cursors.Cross;
      this.Panel.Location = new System.Drawing.Point(0, 50);
      this.Panel.Name = "Panel";
      this.Panel.Size = new System.Drawing.Size(505, 265);
      this.Panel.TabIndex = 7;
      this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
      this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
      this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
      this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
      // 
      // barraDeHerramientas
      // 
      this.barraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btManoAlzada,
            this.btLinea,
            this.btRectangulo,
            this.btElipse});
      this.barraDeHerramientas.Location = new System.Drawing.Point(0, 24);
      this.barraDeHerramientas.Name = "barraDeHerramientas";
      this.barraDeHerramientas.Size = new System.Drawing.Size(507, 25);
      this.barraDeHerramientas.TabIndex = 5;
      this.barraDeHerramientas.Text = "ToolStrip1";
      // 
      // barraDeEstado
      // 
      this.barraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etMensaje,
            this.etX,
            this.etY});
      this.barraDeEstado.Location = new System.Drawing.Point(0, 314);
      this.barraDeEstado.Name = "barraDeEstado";
      this.barraDeEstado.Size = new System.Drawing.Size(507, 22);
      this.barraDeEstado.TabIndex = 6;
      this.barraDeEstado.Text = "StatusStrip1";
      // 
      // etMensaje
      // 
      this.etMensaje.AutoSize = false;
      this.etMensaje.Name = "etMensaje";
      this.etMensaje.Size = new System.Drawing.Size(230, 17);
      this.etMensaje.Text = "Listo";
      this.etMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // etX
      // 
      this.etX.Name = "etX";
      this.etX.Size = new System.Drawing.Size(13, 17);
      this.etX.Text = "0";
      // 
      // AyudaInstrucciones
      // 
      this.AyudaInstrucciones.Name = "AyudaInstrucciones";
      this.AyudaInstrucciones.Size = new System.Drawing.Size(161, 22);
      this.AyudaInstrucciones.Text = "Instrucciones...";
      this.AyudaInstrucciones.Click += new System.EventHandler(this.AyudaInstrucciones_Click);
      // 
      // ArchivoSeparador1
      // 
      this.ArchivoSeparador1.Name = "ArchivoSeparador1";
      this.ArchivoSeparador1.Size = new System.Drawing.Size(149, 6);
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(152, 22);
      this.ArchivoSalir.Text = "Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      // 
      // ArchivoNuevo
      // 
      this.ArchivoNuevo.Name = "ArchivoNuevo";
      this.ArchivoNuevo.Size = new System.Drawing.Size(152, 22);
      this.ArchivoNuevo.Text = "Nuevo";
      this.ArchivoNuevo.Click += new System.EventHandler(this.Form1_Load);
      // 
      // barraDeMenus
      // 
      this.barraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.DibujarToolStripMenuItem,
            this.menuAyuda});
      this.barraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.barraDeMenus.Name = "barraDeMenus";
      this.barraDeMenus.Size = new System.Drawing.Size(507, 24);
      this.barraDeMenus.TabIndex = 4;
      this.barraDeMenus.Text = "MenuStrip1";
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoNuevo,
            this.ArchivoSeparador1,
            this.ArchivoSalir});
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(55, 20);
      this.menuArchivo.Text = "Archivo";
      // 
      // DibujarToolStripMenuItem
      // 
      this.DibujarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DibujarManoAlzada,
            this.DibujarLinea,
            this.DibujarRectangulo,
            this.DibujarElipse});
      this.DibujarToolStripMenuItem.Name = "DibujarToolStripMenuItem";
      this.DibujarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.DibujarToolStripMenuItem.Text = "Dibujar";
      // 
      // DibujarManoAlzada
      // 
      this.DibujarManoAlzada.Name = "DibujarManoAlzada";
      this.DibujarManoAlzada.Size = new System.Drawing.Size(145, 22);
      this.DibujarManoAlzada.Text = "Mano alzada";
      this.DibujarManoAlzada.Click += new System.EventHandler(this.DibujarForma_Click);
      // 
      // DibujarLinea
      // 
      this.DibujarLinea.Name = "DibujarLinea";
      this.DibujarLinea.Size = new System.Drawing.Size(145, 22);
      this.DibujarLinea.Text = "Línea";
      this.DibujarLinea.Click += new System.EventHandler(this.DibujarForma_Click);
      // 
      // DibujarRectangulo
      // 
      this.DibujarRectangulo.Name = "DibujarRectangulo";
      this.DibujarRectangulo.Size = new System.Drawing.Size(145, 22);
      this.DibujarRectangulo.Text = "Rectángulo";
      this.DibujarRectangulo.Click += new System.EventHandler(this.DibujarForma_Click);
      // 
      // DibujarElipse
      // 
      this.DibujarElipse.Name = "DibujarElipse";
      this.DibujarElipse.Size = new System.Drawing.Size(145, 22);
      this.DibujarElipse.Text = "Elipse";
      this.DibujarElipse.Click += new System.EventHandler(this.DibujarForma_Click);
      // 
      // menuAyuda
      // 
      this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaInstrucciones,
            this.AyudaAcercaDe});
      this.menuAyuda.Name = "menuAyuda";
      this.menuAyuda.Size = new System.Drawing.Size(50, 20);
      this.menuAyuda.Text = "Ayuda";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(507, 336);
      this.Controls.Add(this.Panel);
      this.Controls.Add(this.barraDeHerramientas);
      this.Controls.Add(this.barraDeEstado);
      this.Controls.Add(this.barraDeMenus);
      this.Name = "Form1";
      this.Text = "Tablero";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.barraDeHerramientas.ResumeLayout(false);
      this.barraDeHerramientas.PerformLayout();
      this.barraDeEstado.ResumeLayout(false);
      this.barraDeEstado.PerformLayout();
      this.barraDeMenus.ResumeLayout(false);
      this.barraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStripButton btRectangulo;
    private System.Windows.Forms.ToolStripButton btElipse;
    private System.Windows.Forms.ToolStripButton btLinea;
    private System.Windows.Forms.ToolStripMenuItem AyudaAcercaDe;
    private System.Windows.Forms.ToolStripButton btManoAlzada;
    private System.Windows.Forms.ToolStripStatusLabel etY;
    private System.Windows.Forms.Panel Panel;
    private System.Windows.Forms.ToolStrip barraDeHerramientas;
    private System.Windows.Forms.StatusStrip barraDeEstado;
    private System.Windows.Forms.ToolStripStatusLabel etMensaje;
    private System.Windows.Forms.ToolStripStatusLabel etX;
    private System.Windows.Forms.ToolStripMenuItem AyudaInstrucciones;
    private System.Windows.Forms.ToolStripSeparator ArchivoSeparador1;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    private System.Windows.Forms.ToolStripMenuItem ArchivoNuevo;
    private System.Windows.Forms.MenuStrip barraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem DibujarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem DibujarManoAlzada;
    private System.Windows.Forms.ToolStripMenuItem DibujarLinea;
    private System.Windows.Forms.ToolStripMenuItem DibujarRectangulo;
    private System.Windows.Forms.ToolStripMenuItem DibujarElipse;
    private System.Windows.Forms.ToolStripMenuItem menuAyuda;
  }
}


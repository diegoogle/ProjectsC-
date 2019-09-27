namespace VisorImags
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
      this.AyudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
      this.etMensaje = new System.Windows.Forms.ToolStripStatusLabel();
      this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
      this.ciImagen = new System.Windows.Forms.PictureBox();
      this.Panel1 = new System.Windows.Forms.Panel();
      this.ArchivoSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
      this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesTamAjustado = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesTamReal = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesAcercar = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesAlejar = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesGirar90 = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.OpcionesCopiar = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.OpcionesEscalaDeGrises = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
      this.BarraDeEstado.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ciImagen)).BeginInit();
      this.Panel1.SuspendLayout();
      this.BarraDeMenus.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // AyudaAcercaDe
      // 
      this.AyudaAcercaDe.Name = "AyudaAcercaDe";
      this.AyudaAcercaDe.Size = new System.Drawing.Size(260, 24);
      this.AyudaAcercaDe.Text = "Acerca de visor de imágenes...";
      this.AyudaAcercaDe.Click += new System.EventHandler(this.AyudaAcercaDe_Click);
      // 
      // etMensaje
      // 
      this.etMensaje.Name = "etMensaje";
      this.etMensaje.Size = new System.Drawing.Size(38, 19);
      this.etMensaje.Text = "Listo";
      // 
      // BarraDeEstado
      // 
      this.BarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etMensaje});
      this.BarraDeEstado.Location = new System.Drawing.Point(0, 280);
      this.BarraDeEstado.Name = "BarraDeEstado";
      this.BarraDeEstado.Size = new System.Drawing.Size(409, 24);
      this.BarraDeEstado.TabIndex = 7;
      this.BarraDeEstado.Text = "Barra de estado";
      // 
      // ciImagen
      // 
      this.ciImagen.Location = new System.Drawing.Point(0, 0);
      this.ciImagen.Name = "ciImagen";
      this.ciImagen.Size = new System.Drawing.Size(264, 180);
      this.ciImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.ciImagen.TabIndex = 0;
      this.ciImagen.TabStop = false;
      // 
      // Panel1
      // 
      this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Panel1.AutoScroll = true;
      this.Panel1.Controls.Add(this.ciImagen);
      this.Panel1.Location = new System.Drawing.Point(0, 49);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new System.Drawing.Size(409, 255);
      this.Panel1.TabIndex = 8;
      // 
      // ArchivoSeparator1
      // 
      this.ArchivoSeparator1.Name = "ArchivoSeparator1";
      this.ArchivoSeparator1.Size = new System.Drawing.Size(172, 6);
      // 
      // ArchivoCerrar
      // 
      this.ArchivoCerrar.Name = "ArchivoCerrar";
      this.ArchivoCerrar.Size = new System.Drawing.Size(175, 24);
      this.ArchivoCerrar.Text = "Cerrar";
      this.ArchivoCerrar.Click += new System.EventHandler(this.ArchivoCerrar_Click);
      // 
      // menuOpciones
      // 
      this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesTamAjustado,
            this.OpcionesTamReal,
            this.OpcionesAcercar,
            this.OpcionesAlejar,
            this.OpcionesGirar90,
            this.OpcionesSeparator1,
            this.OpcionesCopiar,
            this.toolStripMenuItem1,
            this.OpcionesEscalaDeGrises});
      this.menuOpciones.Name = "menuOpciones";
      this.menuOpciones.Size = new System.Drawing.Size(78, 23);
      this.menuOpciones.Text = "Opciones";
      // 
      // OpcionesTamAjustado
      // 
      this.OpcionesTamAjustado.Name = "OpcionesTamAjustado";
      this.OpcionesTamAjustado.Size = new System.Drawing.Size(183, 24);
      this.OpcionesTamAjustado.Text = "Tamaño ajustado";
      this.OpcionesTamAjustado.Click += new System.EventHandler(this.OpcionesTamAjustado_Click);
      // 
      // OpcionesTamReal
      // 
      this.OpcionesTamReal.Name = "OpcionesTamReal";
      this.OpcionesTamReal.Size = new System.Drawing.Size(183, 24);
      this.OpcionesTamReal.Text = "Tamaño real";
      this.OpcionesTamReal.Click += new System.EventHandler(this.OpcionesTamReal_Click);
      // 
      // OpcionesAcercar
      // 
      this.OpcionesAcercar.Name = "OpcionesAcercar";
      this.OpcionesAcercar.Size = new System.Drawing.Size(183, 24);
      this.OpcionesAcercar.Text = "Acercar";
      this.OpcionesAcercar.Click += new System.EventHandler(this.OpcionesAcercar_Click);
      // 
      // OpcionesAlejar
      // 
      this.OpcionesAlejar.Name = "OpcionesAlejar";
      this.OpcionesAlejar.Size = new System.Drawing.Size(183, 24);
      this.OpcionesAlejar.Text = "Alejar";
      this.OpcionesAlejar.Click += new System.EventHandler(this.OpcionesAlejar_Click);
      // 
      // OpcionesGirar90
      // 
      this.OpcionesGirar90.Name = "OpcionesGirar90";
      this.OpcionesGirar90.Size = new System.Drawing.Size(183, 24);
      this.OpcionesGirar90.Text = "Girar 90º";
      this.OpcionesGirar90.Click += new System.EventHandler(this.OpcionesGirar90_Click);
      // 
      // OpcionesSeparator1
      // 
      this.OpcionesSeparator1.Name = "OpcionesSeparator1";
      this.OpcionesSeparator1.Size = new System.Drawing.Size(180, 6);
      // 
      // OpcionesCopiar
      // 
      this.OpcionesCopiar.Name = "OpcionesCopiar";
      this.OpcionesCopiar.Size = new System.Drawing.Size(183, 24);
      this.OpcionesCopiar.Text = "Copiar";
      this.OpcionesCopiar.Click += new System.EventHandler(this.OpcionesCopiar_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
      // 
      // OpcionesEscalaDeGrises
      // 
      this.OpcionesEscalaDeGrises.Name = "OpcionesEscalaDeGrises";
      this.OpcionesEscalaDeGrises.Size = new System.Drawing.Size(183, 24);
      this.OpcionesEscalaDeGrises.Text = "Escala de grises";
      this.OpcionesEscalaDeGrises.Click += new System.EventHandler(this.OpcionesEscalaDeGrises_Click);
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(175, 24);
      this.ArchivoSalir.Text = "Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoAbrir,
            this.ArchivoGuardarComo,
            this.ArchivoCerrar,
            this.ArchivoSeparator1,
            this.ArchivoSalir});
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(67, 23);
      this.menuArchivo.Text = "Archivo";
      // 
      // ArchivoAbrir
      // 
      this.ArchivoAbrir.Name = "ArchivoAbrir";
      this.ArchivoAbrir.Size = new System.Drawing.Size(175, 24);
      this.ArchivoAbrir.Text = "Abrir...";
      this.ArchivoAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      // 
      // ArchivoGuardarComo
      // 
      this.ArchivoGuardarComo.Name = "ArchivoGuardarComo";
      this.ArchivoGuardarComo.Size = new System.Drawing.Size(175, 24);
      this.ArchivoGuardarComo.Text = "Guardar como...";
      this.ArchivoGuardarComo.Click += new System.EventHandler(this.ArchivoGuardarComo_Click);
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuOpciones,
            this.menuAyuda});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(409, 27);
      this.BarraDeMenus.TabIndex = 5;
      this.BarraDeMenus.Text = "Barra de menús";
      // 
      // menuAyuda
      // 
      this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaAcercaDe});
      this.menuAyuda.Name = "menuAyuda";
      this.menuAyuda.Size = new System.Drawing.Size(60, 23);
      this.menuAyuda.Text = "Ayuda";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator4,
            this.toolStripButton8});
      this.toolStrip1.Location = new System.Drawing.Point(0, 27);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(409, 25);
      this.toolStrip1.TabIndex = 11;
      this.toolStrip1.Text = "Barra de herramientas";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Silver;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "Abrir";
      this.toolStripButton1.ToolTipText = "Abrir";
      this.toolStripButton1.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Silver;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton2.Text = "Guardar";
      this.toolStripButton2.ToolTipText = "Guardar";
      this.toolStripButton2.Click += new System.EventHandler(this.ArchivoGuardarComo_Click);
      // 
      // toolStripButton3
      // 
      this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
      this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Silver;
      this.toolStripButton3.Name = "toolStripButton3";
      this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton3.Text = "Cerrar";
      this.toolStripButton3.ToolTipText = "Cerrar";
      this.toolStripButton3.Click += new System.EventHandler(this.ArchivoCerrar_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButton4
      // 
      this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
      this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Silver;
      this.toolStripButton4.Name = "toolStripButton4";
      this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton4.Text = "Ajustar";
      this.toolStripButton4.ToolTipText = "Ajustar";
      this.toolStripButton4.Click += new System.EventHandler(this.OpcionesTamAjustado_Click);
      // 
      // toolStripButton5
      // 
      this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
      this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Silver;
      this.toolStripButton5.Name = "toolStripButton5";
      this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton5.Text = "Acercar";
      this.toolStripButton5.ToolTipText = "Acercar";
      this.toolStripButton5.Click += new System.EventHandler(this.OpcionesAcercar_Click);
      // 
      // toolStripButton6
      // 
      this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
      this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Silver;
      this.toolStripButton6.Name = "toolStripButton6";
      this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton6.Text = "Alejar";
      this.toolStripButton6.ToolTipText = "Alejar";
      this.toolStripButton6.Click += new System.EventHandler(this.OpcionesAlejar_Click);
      // 
      // toolStripButton7
      // 
      this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
      this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Silver;
      this.toolStripButton7.Name = "toolStripButton7";
      this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton7.Text = "Girar";
      this.toolStripButton7.ToolTipText = "Girar 90º";
      this.toolStripButton7.Click += new System.EventHandler(this.OpcionesGirar90_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButton8
      // 
      this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
      this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Silver;
      this.toolStripButton8.Name = "toolStripButton8";
      this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton8.Text = "Copiar";
      this.toolStripButton8.ToolTipText = "Copiar";
      this.toolStripButton8.Click += new System.EventHandler(this.OpcionesCopiar_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(409, 304);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.BarraDeEstado);
      this.Controls.Add(this.Panel1);
      this.Controls.Add(this.BarraDeMenus);
      this.Name = "Form1";
      this.Text = "Visor de imágenes";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.BarraDeEstado.ResumeLayout(false);
      this.BarraDeEstado.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ciImagen)).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStripMenuItem AyudaAcercaDe;
    private System.Windows.Forms.ToolStripStatusLabel etMensaje;
    private System.Windows.Forms.StatusStrip BarraDeEstado;
    private System.Windows.Forms.PictureBox ciImagen;
    private System.Windows.Forms.Panel Panel1;
    private System.Windows.Forms.ToolStripSeparator ArchivoSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ArchivoCerrar;
    private System.Windows.Forms.ToolStripMenuItem menuOpciones;
    private System.Windows.Forms.ToolStripMenuItem OpcionesTamAjustado;
    private System.Windows.Forms.ToolStripMenuItem OpcionesTamReal;
    private System.Windows.Forms.ToolStripMenuItem OpcionesAcercar;
    private System.Windows.Forms.ToolStripMenuItem OpcionesAlejar;
    private System.Windows.Forms.ToolStripMenuItem OpcionesGirar90;
    private System.Windows.Forms.ToolStripSeparator OpcionesSeparator1;
    private System.Windows.Forms.ToolStripMenuItem OpcionesCopiar;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoAbrir;
    private System.Windows.Forms.ToolStripMenuItem ArchivoGuardarComo;
    private System.Windows.Forms.MenuStrip BarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuAyuda;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem OpcionesEscalaDeGrises;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
    private System.Windows.Forms.ToolStripButton toolStripButton3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton toolStripButton4;
    private System.Windows.Forms.ToolStripButton toolStripButton5;
    private System.Windows.Forms.ToolStripButton toolStripButton6;
    private System.Windows.Forms.ToolStripButton toolStripButton7;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton toolStripButton8;

  }
}


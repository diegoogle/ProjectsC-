namespace RelojDespertador
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
      this.components = new System.ComponentModel.Container();
      this.Temporizador = new System.Timers.Timer();
      this.ctDespertador = new System.Windows.Forms.MaskedTextBox();
      this.etPais = new System.Windows.Forms.Label();
      this.ctHoraPais = new System.Windows.Forms.TextBox();
      this.MenuContextPais = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ContextPaisAnadir = new System.Windows.Forms.ToolStripMenuItem();
      this.ContextPaisEliminar = new System.Windows.Forms.ToolStripMenuItem();
      this.ContextSeparador1 = new System.Windows.Forms.ToolStripSeparator();
      this.ctHora = new System.Windows.Forms.TextBox();
      this.etHora = new System.Windows.Forms.Label();
      this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
      this.etHoraEn = new System.Windows.Forms.Label();
      this.etDespertador = new System.Windows.Forms.Label();
      this.btbarDespertador = new System.Windows.Forms.ToolStripButton();
      this.menuDespertador = new System.Windows.Forms.ToolStripMenuItem();
      this.DespertadorActivar = new System.Windows.Forms.ToolStripMenuItem();
      this.menuPais = new System.Windows.Forms.ToolStripMenuItem();
      this.PaisAnadir = new System.Windows.Forms.ToolStripMenuItem();
      this.PaisEliminar = new System.Windows.Forms.ToolStripMenuItem();
      this.Separador2 = new System.Windows.Forms.ToolStripSeparator();
      this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
      this.AyudaAcercade = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
      this.Separador1 = new System.Windows.Forms.ToolStripSeparator();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.Temporizador)).BeginInit();
      this.MenuContextPais.SuspendLayout();
      this.BarraDeHerramientas.SuspendLayout();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // Temporizador
      // 
      this.Temporizador.Enabled = true;
      this.Temporizador.Interval = 1000;
      this.Temporizador.SynchronizingObject = this;
      this.Temporizador.Elapsed += new System.Timers.ElapsedEventHandler(this.Temporizador_Elapsed);
      // 
      // ctDespertador
      // 
      this.ctDespertador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctDespertador.Location = new System.Drawing.Point(33, 164);
      this.ctDespertador.Mask = "00:00:00";
      this.ctDespertador.Name = "ctDespertador";
      this.ctDespertador.PromptChar = '*';
      this.ctDespertador.ResetOnPrompt = false;
      this.ctDespertador.Size = new System.Drawing.Size(100, 31);
      this.ctDespertador.TabIndex = 20;
      this.ctDespertador.Text = "000000";
      this.ctDespertador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // etPais
      // 
      this.etPais.AutoSize = true;
      this.etPais.Location = new System.Drawing.Point(159, 145);
      this.etPais.Name = "etPais";
      this.etPais.Size = new System.Drawing.Size(59, 13);
      this.etPais.TabIndex = 19;
      this.etPais.Text = "(hora local)";
      // 
      // ctHoraPais
      // 
      this.ctHoraPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctHoraPais.Location = new System.Drawing.Point(159, 164);
      this.ctHoraPais.Name = "ctHoraPais";
      this.ctHoraPais.ReadOnly = true;
      this.ctHoraPais.Size = new System.Drawing.Size(100, 31);
      this.ctHoraPais.TabIndex = 18;
      this.ctHoraPais.TabStop = false;
      this.ctHoraPais.Text = "00:00:00";
      this.ctHoraPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // MenuContextPais
      // 
      this.MenuContextPais.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextPaisAnadir,
            this.ContextPaisEliminar,
            this.ContextSeparador1});
      this.MenuContextPais.Name = "MenuContextPais";
      this.MenuContextPais.Size = new System.Drawing.Size(122, 54);
      // 
      // ContextPaisAnadir
      // 
      this.ContextPaisAnadir.Name = "ContextPaisAnadir";
      this.ContextPaisAnadir.Size = new System.Drawing.Size(121, 22);
      this.ContextPaisAnadir.Text = "Añadir";
      this.ContextPaisAnadir.Click += new System.EventHandler(this.PaisAnadir_Click);
      // 
      // ContextPaisEliminar
      // 
      this.ContextPaisEliminar.Name = "ContextPaisEliminar";
      this.ContextPaisEliminar.Size = new System.Drawing.Size(121, 22);
      this.ContextPaisEliminar.Text = "Eliminar";
      this.ContextPaisEliminar.Visible = false;
      this.ContextPaisEliminar.Click += new System.EventHandler(this.PaisEliminar_Click);
      // 
      // ContextSeparador1
      // 
      this.ContextSeparador1.Name = "ContextSeparador1";
      this.ContextSeparador1.Size = new System.Drawing.Size(118, 6);
      this.ContextSeparador1.Visible = false;
      // 
      // ctHora
      // 
      this.ctHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctHora.Location = new System.Drawing.Point(69, 74);
      this.ctHora.Name = "ctHora";
      this.ctHora.ReadOnly = true;
      this.ctHora.Size = new System.Drawing.Size(155, 44);
      this.ctHora.TabIndex = 15;
      this.ctHora.TabStop = false;
      this.ctHora.Text = "00:00:00";
      this.ctHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // etHora
      // 
      this.etHora.AutoSize = true;
      this.etHora.Location = new System.Drawing.Point(69, 54);
      this.etHora.Name = "etHora";
      this.etHora.Size = new System.Drawing.Size(33, 13);
      this.etHora.TabIndex = 14;
      this.etHora.Text = "Hora:";
      // 
      // BarraDeEstado
      // 
      this.BarraDeEstado.Location = new System.Drawing.Point(0, 211);
      this.BarraDeEstado.Name = "BarraDeEstado";
      this.BarraDeEstado.Size = new System.Drawing.Size(292, 22);
      this.BarraDeEstado.TabIndex = 13;
      this.BarraDeEstado.Text = "Barra de estado";
      // 
      // etHoraEn
      // 
      this.etHoraEn.AutoSize = true;
      this.etHoraEn.Location = new System.Drawing.Point(159, 125);
      this.etHoraEn.Name = "etHoraEn";
      this.etHoraEn.Size = new System.Drawing.Size(45, 13);
      this.etHoraEn.TabIndex = 17;
      this.etHoraEn.Text = "Hora en";
      // 
      // etDespertador
      // 
      this.etDespertador.AutoSize = true;
      this.etDespertador.Location = new System.Drawing.Point(33, 144);
      this.etDespertador.Name = "etDespertador";
      this.etDespertador.Size = new System.Drawing.Size(68, 13);
      this.etDespertador.TabIndex = 16;
      this.etDespertador.Text = "Despertador:";
      // 
      // btbarDespertador
      // 
      this.btbarDespertador.Image = global::RelojDespertador.Properties.Resources.reloj;
      this.btbarDespertador.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarDespertador.Name = "btbarDespertador";
      this.btbarDespertador.Size = new System.Drawing.Size(23, 22);
      // 
      // menuDespertador
      // 
      this.menuDespertador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DespertadorActivar});
      this.menuDespertador.Name = "menuDespertador";
      this.menuDespertador.Size = new System.Drawing.Size(79, 20);
      this.menuDespertador.Text = "&Despertador";
      // 
      // DespertadorActivar
      // 
      this.DespertadorActivar.Image = global::RelojDespertador.Properties.Resources.reloj;
      this.DespertadorActivar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.DespertadorActivar.Name = "DespertadorActivar";
      this.DespertadorActivar.Size = new System.Drawing.Size(119, 22);
      this.DespertadorActivar.Text = "&Activar";
      this.DespertadorActivar.Click += new System.EventHandler(this.DespertadorActivar_Click);
      // 
      // menuPais
      // 
      this.menuPais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaisAnadir,
            this.PaisEliminar,
            this.Separador2});
      this.menuPais.Name = "menuPais";
      this.menuPais.Size = new System.Drawing.Size(38, 20);
      this.menuPais.Text = "&País";
      // 
      // PaisAnadir
      // 
      this.PaisAnadir.Name = "PaisAnadir";
      this.PaisAnadir.Size = new System.Drawing.Size(121, 22);
      this.PaisAnadir.Text = "&Añadir";
      this.PaisAnadir.Click += new System.EventHandler(this.PaisAnadir_Click);
      // 
      // PaisEliminar
      // 
      this.PaisEliminar.Name = "PaisEliminar";
      this.PaisEliminar.Size = new System.Drawing.Size(121, 22);
      this.PaisEliminar.Text = "&Eliminar";
      this.PaisEliminar.Visible = false;
      this.PaisEliminar.Click += new System.EventHandler(this.PaisEliminar_Click);
      // 
      // Separador2
      // 
      this.Separador2.Name = "Separador2";
      this.Separador2.Size = new System.Drawing.Size(118, 6);
      this.Separador2.Visible = false;
      // 
      // BarraDeHerramientas
      // 
      this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbarDespertador});
      this.BarraDeHerramientas.Location = new System.Drawing.Point(0, 24);
      this.BarraDeHerramientas.Name = "BarraDeHerramientas";
      this.BarraDeHerramientas.Size = new System.Drawing.Size(292, 25);
      this.BarraDeHerramientas.TabIndex = 12;
      this.BarraDeHerramientas.Text = "Barra de herramientas";
      // 
      // AyudaAcercade
      // 
      this.AyudaAcercade.Name = "AyudaAcercade";
      this.AyudaAcercade.Size = new System.Drawing.Size(145, 22);
      this.AyudaAcercade.Text = "Acerca &de...";
      this.AyudaAcercade.Click += new System.EventHandler(this.AyudaAcercade_Click);
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuDespertador,
            this.menuPais,
            this.menuAyuda});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(292, 24);
      this.BarraDeMenus.TabIndex = 11;
      this.BarraDeMenus.Text = "Barra de menus";
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoAbrir,
            this.ArchivoGuardar,
            this.Separador1,
            this.ArchivoSalir});
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(55, 20);
      this.menuArchivo.Text = "&Archivo";
      // 
      // ArchivoAbrir
      // 
      this.ArchivoAbrir.Name = "ArchivoAbrir";
      this.ArchivoAbrir.Size = new System.Drawing.Size(136, 22);
      this.ArchivoAbrir.Text = "&Abrir...";
      this.ArchivoAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      // 
      // ArchivoGuardar
      // 
      this.ArchivoGuardar.Name = "ArchivoGuardar";
      this.ArchivoGuardar.Size = new System.Drawing.Size(136, 22);
      this.ArchivoGuardar.Text = "Guardar...";
      this.ArchivoGuardar.Click += new System.EventHandler(this.ArchivoGuardar_Click);
      // 
      // Separador1
      // 
      this.Separador1.Name = "Separador1";
      this.Separador1.Size = new System.Drawing.Size(133, 6);
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(136, 22);
      this.ArchivoSalir.Text = "&Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      // 
      // menuAyuda
      // 
      this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaAcercade});
      this.menuAyuda.Name = "menuAyuda";
      this.menuAyuda.Size = new System.Drawing.Size(50, 20);
      this.menuAyuda.Text = "Ay&uda";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 233);
      this.ContextMenuStrip = this.MenuContextPais;
      this.Controls.Add(this.ctDespertador);
      this.Controls.Add(this.etPais);
      this.Controls.Add(this.ctHoraPais);
      this.Controls.Add(this.ctHora);
      this.Controls.Add(this.etHora);
      this.Controls.Add(this.BarraDeEstado);
      this.Controls.Add(this.etHoraEn);
      this.Controls.Add(this.etDespertador);
      this.Controls.Add(this.BarraDeHerramientas);
      this.Controls.Add(this.BarraDeMenus);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Reloj despertador";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.Temporizador)).EndInit();
      this.MenuContextPais.ResumeLayout(false);
      this.BarraDeHerramientas.ResumeLayout(false);
      this.BarraDeHerramientas.PerformLayout();
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Timers.Timer Temporizador;
    private System.Windows.Forms.MaskedTextBox ctDespertador;
    private System.Windows.Forms.Label etPais;
    private System.Windows.Forms.TextBox ctHoraPais;
    private System.Windows.Forms.TextBox ctHora;
    private System.Windows.Forms.Label etHora;
    private System.Windows.Forms.StatusStrip BarraDeEstado;
    private System.Windows.Forms.Label etHoraEn;
    private System.Windows.Forms.Label etDespertador;
    private System.Windows.Forms.ToolStrip BarraDeHerramientas;
    private System.Windows.Forms.ToolStripButton btbarDespertador;
    private System.Windows.Forms.MenuStrip BarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuDespertador;
    private System.Windows.Forms.ToolStripMenuItem DespertadorActivar;
    private System.Windows.Forms.ToolStripMenuItem menuPais;
    private System.Windows.Forms.ToolStripMenuItem PaisAnadir;
    private System.Windows.Forms.ToolStripMenuItem PaisEliminar;
    private System.Windows.Forms.ToolStripSeparator Separador2;
    private System.Windows.Forms.ToolStripMenuItem menuAyuda;
    private System.Windows.Forms.ToolStripMenuItem AyudaAcercade;
    private System.Windows.Forms.ContextMenuStrip MenuContextPais;
    private System.Windows.Forms.ToolStripMenuItem ContextPaisAnadir;
    private System.Windows.Forms.ToolStripMenuItem ContextPaisEliminar;
    private System.Windows.Forms.ToolStripSeparator ContextSeparador1;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoAbrir;
    private System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
    private System.Windows.Forms.ToolStripSeparator Separador1;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
  }
}


namespace CajasDeDialogo
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
      this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.DiálogosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoCasillaV = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoBtOpcion = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoListaSimple = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoListaDesplegable = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoRangos = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoTabControl = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoGestiónDefechas = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoPanelDeDiseño = new System.Windows.Forms.ToolStripMenuItem();
      this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
      this.DialogoColor = new System.Windows.Forms.ToolStripMenuItem();
      this.DialogoFuente = new System.Windows.Forms.ToolStripMenuItem();
      this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
      this.AyudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
      this.TextBox1 = new System.Windows.Forms.TextBox();
      this.Separador3 = new System.Windows.Forms.ToolStripSeparator();
      this.DialogoTimer = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.DiálogosToolStripMenuItem1,
            this.menuAyuda});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(382, 27);
      this.BarraDeMenus.TabIndex = 1;
      this.BarraDeMenus.Text = "MenuStrip1";
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoAbrir,
            this.ArchivoGuardar,
            this.Separator1,
            this.ArchivoSalir});
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(67, 23);
      this.menuArchivo.Text = "&Archivo";
      // 
      // ArchivoAbrir
      // 
      this.ArchivoAbrir.Name = "ArchivoAbrir";
      this.ArchivoAbrir.Size = new System.Drawing.Size(152, 24);
      this.ArchivoAbrir.Text = "&Abrir";
      this.ArchivoAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
      // 
      // ArchivoGuardar
      // 
      this.ArchivoGuardar.Name = "ArchivoGuardar";
      this.ArchivoGuardar.Size = new System.Drawing.Size(152, 24);
      this.ArchivoGuardar.Text = "&Guardar";
      this.ArchivoGuardar.Click += new System.EventHandler(this.ArchivoGuardar_Click);
      // 
      // Separator1
      // 
      this.Separator1.Name = "Separator1";
      this.Separator1.Size = new System.Drawing.Size(149, 6);
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(152, 24);
      this.ArchivoSalir.Text = "&Salir";
      this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
      // 
      // DiálogosToolStripMenuItem1
      // 
      this.DiálogosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DialogoCasillaV,
            this.DialogoBtOpcion,
            this.DialogoListaSimple,
            this.DialogoListaDesplegable,
            this.DialogoRangos,
            this.DialogoTabControl,
            this.DialogoGestiónDefechas,
            this.DialogoPanelDeDiseño,
            this.Separator2,
            this.DialogoColor,
            this.DialogoFuente,
            this.Separador3,
            this.DialogoTimer});
      this.DiálogosToolStripMenuItem1.Name = "DiálogosToolStripMenuItem1";
      this.DiálogosToolStripMenuItem1.Size = new System.Drawing.Size(74, 23);
      this.DiálogosToolStripMenuItem1.Text = "&Diálogos";
      // 
      // DialogoCasillaV
      // 
      this.DialogoCasillaV.Name = "DialogoCasillaV";
      this.DialogoCasillaV.Size = new System.Drawing.Size(249, 24);
      this.DialogoCasillaV.Text = "Casilla de &verificación";
      this.DialogoCasillaV.Click += new System.EventHandler(this.DialogoCasillaV_Click);
      // 
      // DialogoBtOpcion
      // 
      this.DialogoBtOpcion.Name = "DialogoBtOpcion";
      this.DialogoBtOpcion.Size = new System.Drawing.Size(249, 24);
      this.DialogoBtOpcion.Text = "&Botón de opción";
      this.DialogoBtOpcion.Click += new System.EventHandler(this.DialogoBtOpcion_Click);
      // 
      // DialogoListaSimple
      // 
      this.DialogoListaSimple.Name = "DialogoListaSimple";
      this.DialogoListaSimple.Size = new System.Drawing.Size(249, 24);
      this.DialogoListaSimple.Text = "&Lista simple";
      this.DialogoListaSimple.Click += new System.EventHandler(this.DialogoListaSimple_Click);
      // 
      // DialogoListaDesplegable
      // 
      this.DialogoListaDesplegable.Name = "DialogoListaDesplegable";
      this.DialogoListaDesplegable.Size = new System.Drawing.Size(249, 24);
      this.DialogoListaDesplegable.Text = "Lista &desplegable";
      this.DialogoListaDesplegable.Click += new System.EventHandler(this.DialogoListaDesplegable_Click);
      // 
      // DialogoRangos
      // 
      this.DialogoRangos.Name = "DialogoRangos";
      this.DialogoRangos.Size = new System.Drawing.Size(249, 24);
      this.DialogoRangos.Text = "Controles de &rango definido";
      this.DialogoRangos.Click += new System.EventHandler(this.DialogoRangos_Click);
      // 
      // DialogoTabControl
      // 
      this.DialogoTabControl.Name = "DialogoTabControl";
      this.DialogoTabControl.Size = new System.Drawing.Size(249, 24);
      this.DialogoTabControl.Text = "Control con &pestañas";
      this.DialogoTabControl.Click += new System.EventHandler(this.DialogoTabControl_Click);
      // 
      // DialogoGestiónDefechas
      // 
      this.DialogoGestiónDefechas.Name = "DialogoGestiónDefechas";
      this.DialogoGestiónDefechas.Size = new System.Drawing.Size(249, 24);
      this.DialogoGestiónDefechas.Text = "Gestión de &fechas";
      this.DialogoGestiónDefechas.Click += new System.EventHandler(this.DialogoGestionDefechas_Click);
      // 
      // DialogoPanelDeDiseño
      // 
      this.DialogoPanelDeDiseño.Name = "DialogoPanelDeDiseño";
      this.DialogoPanelDeDiseño.Size = new System.Drawing.Size(249, 24);
      this.DialogoPanelDeDiseño.Text = "Panel de diseño";
      this.DialogoPanelDeDiseño.Click += new System.EventHandler(this.DialogoPanelDeDiseño_Click);
      // 
      // Separator2
      // 
      this.Separator2.Name = "Separator2";
      this.Separator2.Size = new System.Drawing.Size(246, 6);
      // 
      // DialogoColor
      // 
      this.DialogoColor.Name = "DialogoColor";
      this.DialogoColor.Size = new System.Drawing.Size(249, 24);
      this.DialogoColor.Text = "&Color";
      this.DialogoColor.Click += new System.EventHandler(this.DialogoColor_Click);
      // 
      // DialogoFuente
      // 
      this.DialogoFuente.Name = "DialogoFuente";
      this.DialogoFuente.Size = new System.Drawing.Size(249, 24);
      this.DialogoFuente.Text = "Fuente";
      this.DialogoFuente.Click += new System.EventHandler(this.DialogoFuente_Click);
      // 
      // menuAyuda
      // 
      this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaAcercaDe});
      this.menuAyuda.Name = "menuAyuda";
      this.menuAyuda.Size = new System.Drawing.Size(60, 23);
      this.menuAyuda.Text = "Ay&uda";
      // 
      // AyudaAcercaDe
      // 
      this.AyudaAcercaDe.Name = "AyudaAcercaDe";
      this.AyudaAcercaDe.Size = new System.Drawing.Size(146, 24);
      this.AyudaAcercaDe.Text = "Acerca de...";
      this.AyudaAcercaDe.Click += new System.EventHandler(this.AyudaAcercaDe_Click);
      // 
      // TextBox1
      // 
      this.TextBox1.Location = new System.Drawing.Point(74, 118);
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.Size = new System.Drawing.Size(235, 20);
      this.TextBox1.TabIndex = 2;
      // 
      // Separador3
      // 
      this.Separador3.Name = "Separador3";
      this.Separador3.Size = new System.Drawing.Size(246, 6);
      // 
      // DialogoTimer
      // 
      this.DialogoTimer.Name = "DialogoTimer";
      this.DialogoTimer.Size = new System.Drawing.Size(249, 24);
      this.DialogoTimer.Text = "Timer";
      this.DialogoTimer.Click += new System.EventHandler(this.DialogoTimer_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(382, 257);
      this.Controls.Add(this.TextBox1);
      this.Controls.Add(this.BarraDeMenus);
      this.Name = "Form1";
      this.Text = "Cajas de diálogo";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip BarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoAbrir;
    private System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
    private System.Windows.Forms.ToolStripSeparator Separator1;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    private System.Windows.Forms.ToolStripMenuItem DiálogosToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem DialogoCasillaV;
    private System.Windows.Forms.ToolStripMenuItem DialogoBtOpcion;
    private System.Windows.Forms.ToolStripMenuItem DialogoListaSimple;
    private System.Windows.Forms.ToolStripMenuItem DialogoListaDesplegable;
    private System.Windows.Forms.ToolStripMenuItem DialogoRangos;
    private System.Windows.Forms.ToolStripSeparator Separator2;
    private System.Windows.Forms.ToolStripMenuItem DialogoColor;
    private System.Windows.Forms.ToolStripMenuItem menuAyuda;
    private System.Windows.Forms.ToolStripMenuItem AyudaAcercaDe;
    private System.Windows.Forms.ToolStripMenuItem DialogoTabControl;
    private System.Windows.Forms.ToolStripMenuItem DialogoGestiónDefechas;
    private System.Windows.Forms.ToolStripMenuItem DialogoPanelDeDiseño;
    private System.Windows.Forms.TextBox TextBox1;
    private System.Windows.Forms.ToolStripMenuItem DialogoFuente;
    private System.Windows.Forms.ToolStripSeparator Separador3;
    private System.Windows.Forms.ToolStripMenuItem DialogoTimer;
  }
}


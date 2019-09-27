namespace Editor
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
      this.ctEditor = new System.Windows.Forms.TextBox();
      this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
      this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
      this.btbarCortar = new System.Windows.Forms.ToolStripButton();
      this.btbarCopiar = new System.Windows.Forms.ToolStripButton();
      this.btbarPegar = new System.Windows.Forms.ToolStripButton();
      this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionDeshacer = new System.Windows.Forms.ToolStripMenuItem();
      this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
      this.EdicionCortar = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionPegar = new System.Windows.Forms.ToolStripMenuItem();
      this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesFuente = new System.Windows.Forms.ToolStripMenuItem();
      this.OpFuCourierNew = new System.Windows.Forms.ToolStripMenuItem();
      this.OpFuArial = new System.Windows.Forms.ToolStripMenuItem();
      this.OpFuPredeterminada = new System.Windows.Forms.ToolStripMenuItem();
      this.OpcionesTam = new System.Windows.Forms.ToolStripMenuItem();
      this.OpTam16 = new System.Windows.Forms.ToolStripMenuItem();
      this.OpTam24 = new System.Windows.Forms.ToolStripMenuItem();
      this.OpTamPredeterminado = new System.Windows.Forms.ToolStripMenuItem();
      this.BarraDeHerramientas.SuspendLayout();
      this.BarraDeMenus.SuspendLayout();
      this.SuspendLayout();
      // 
      // ctEditor
      // 
      this.ctEditor.AcceptsReturn = true;
      this.ctEditor.AcceptsTab = true;
      this.ctEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctEditor.Location = new System.Drawing.Point(0, 52);
      this.ctEditor.Multiline = true;
      this.ctEditor.Name = "ctEditor";
      this.ctEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.ctEditor.Size = new System.Drawing.Size(492, 192);
      this.ctEditor.TabIndex = 6;
      // 
      // BarraDeEstado
      // 
      this.BarraDeEstado.Location = new System.Drawing.Point(0, 244);
      this.BarraDeEstado.Name = "BarraDeEstado";
      this.BarraDeEstado.Size = new System.Drawing.Size(492, 22);
      this.BarraDeEstado.TabIndex = 7;
      this.BarraDeEstado.Text = "Barra de estado";
      // 
      // BarraDeHerramientas
      // 
      this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbarCortar,
            this.btbarCopiar,
            this.btbarPegar});
      this.BarraDeHerramientas.Location = new System.Drawing.Point(0, 27);
      this.BarraDeHerramientas.Name = "BarraDeHerramientas";
      this.BarraDeHerramientas.Size = new System.Drawing.Size(492, 25);
      this.BarraDeHerramientas.TabIndex = 5;
      this.BarraDeHerramientas.Text = "Barra de herramientas";
      // 
      // btbarCortar
      // 
      this.btbarCortar.Image = global::Editor.Properties.Resources.imagenbtbarCortar;
      this.btbarCortar.ImageTransparentColor = System.Drawing.Color.Black;
      this.btbarCortar.Name = "btbarCortar";
      this.btbarCortar.Size = new System.Drawing.Size(23, 22);
      this.btbarCortar.ToolTipText = "Cortar";
      this.btbarCortar.Click += new System.EventHandler(this.EdicionCortar_Click);
      // 
      // btbarCopiar
      // 
      this.btbarCopiar.Image = global::Editor.Properties.Resources.imagenbtbarCopiar;
      this.btbarCopiar.ImageTransparentColor = System.Drawing.Color.Black;
      this.btbarCopiar.Name = "btbarCopiar";
      this.btbarCopiar.Size = new System.Drawing.Size(23, 22);
      this.btbarCopiar.ToolTipText = "Copiar";
      this.btbarCopiar.Click += new System.EventHandler(this.EdicionCopiar_Click);
      // 
      // btbarPegar
      // 
      this.btbarPegar.Image = global::Editor.Properties.Resources.imagenbtbarPegar;
      this.btbarPegar.ImageTransparentColor = System.Drawing.Color.Black;
      this.btbarPegar.Name = "btbarPegar";
      this.btbarPegar.Size = new System.Drawing.Size(23, 22);
      this.btbarPegar.ToolTipText = "Pegar";
      this.btbarPegar.Click += new System.EventHandler(this.EdicionPegar_Click);
      // 
      // BarraDeMenus
      // 
      this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEdicion,
            this.menuOpciones});
      this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
      this.BarraDeMenus.Name = "BarraDeMenus";
      this.BarraDeMenus.Size = new System.Drawing.Size(492, 27);
      this.BarraDeMenus.TabIndex = 4;
      this.BarraDeMenus.Text = "Barra de menus";
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
      // menuEdicion
      // 
      this.menuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EdicionDeshacer,
            this.Separator2,
            this.EdicionCortar,
            this.EdicionCopiar,
            this.EdicionPegar});
      this.menuEdicion.Name = "menuEdicion";
      this.menuEdicion.Size = new System.Drawing.Size(64, 23);
      this.menuEdicion.Text = "&Edición";
      this.menuEdicion.DropDownOpening += new System.EventHandler(this.menuEdicion_DropDownOpening);
      // 
      // EdicionDeshacer
      // 
      this.EdicionDeshacer.Image = global::Editor.Properties.Resources.imagenEdicionDeshacer;
      this.EdicionDeshacer.ImageTransparentColor = System.Drawing.Color.Black;
      this.EdicionDeshacer.Name = "EdicionDeshacer";
      this.EdicionDeshacer.Size = new System.Drawing.Size(168, 24);
      this.EdicionDeshacer.Text = "&Deshacer";
      this.EdicionDeshacer.Click += new System.EventHandler(this.EdicionDeshacer_Click);
      // 
      // Separator2
      // 
      this.Separator2.Name = "Separator2";
      this.Separator2.Size = new System.Drawing.Size(165, 6);
      // 
      // EdicionCortar
      // 
      this.EdicionCortar.Image = global::Editor.Properties.Resources.imagenEdicionCortar;
      this.EdicionCortar.ImageTransparentColor = System.Drawing.Color.Black;
      this.EdicionCortar.Name = "EdicionCortar";
      this.EdicionCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.EdicionCortar.Size = new System.Drawing.Size(168, 24);
      this.EdicionCortar.Text = "Cor&tar";
      this.EdicionCortar.Click += new System.EventHandler(this.EdicionCortar_Click);
      // 
      // EdicionCopiar
      // 
      this.EdicionCopiar.Image = global::Editor.Properties.Resources.imagenEdicionCopiar;
      this.EdicionCopiar.Name = "EdicionCopiar";
      this.EdicionCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.EdicionCopiar.Size = new System.Drawing.Size(168, 24);
      this.EdicionCopiar.Text = "&Copiar";
      this.EdicionCopiar.Click += new System.EventHandler(this.EdicionCopiar_Click);
      // 
      // EdicionPegar
      // 
      this.EdicionPegar.Image = global::Editor.Properties.Resources.imagenEdicionPegar;
      this.EdicionPegar.ImageTransparentColor = System.Drawing.Color.Black;
      this.EdicionPegar.Name = "EdicionPegar";
      this.EdicionPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.EdicionPegar.Size = new System.Drawing.Size(168, 24);
      this.EdicionPegar.Text = "&Pegar";
      this.EdicionPegar.Click += new System.EventHandler(this.EdicionPegar_Click);
      // 
      // menuOpciones
      // 
      this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesFuente,
            this.OpcionesTam});
      this.menuOpciones.Name = "menuOpciones";
      this.menuOpciones.Size = new System.Drawing.Size(78, 23);
      this.menuOpciones.Text = "&Opciones";
      // 
      // OpcionesFuente
      // 
      this.OpcionesFuente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpFuCourierNew,
            this.OpFuArial,
            this.OpFuPredeterminada});
      this.OpcionesFuente.Name = "OpcionesFuente";
      this.OpcionesFuente.Size = new System.Drawing.Size(152, 24);
      this.OpcionesFuente.Text = "&Fuente";
      // 
      // OpFuCourierNew
      // 
      this.OpFuCourierNew.Name = "OpFuCourierNew";
      this.OpFuCourierNew.Size = new System.Drawing.Size(175, 24);
      this.OpFuCourierNew.Text = "Courier New";
      this.OpFuCourierNew.Click += new System.EventHandler(this.OpFuCourierNew_Click);
      // 
      // OpFuArial
      // 
      this.OpFuArial.Name = "OpFuArial";
      this.OpFuArial.Size = new System.Drawing.Size(175, 24);
      this.OpFuArial.Text = "Arial";
      this.OpFuArial.Click += new System.EventHandler(this.OpFuArial_Click);
      // 
      // OpFuPredeterminada
      // 
      this.OpFuPredeterminada.Checked = true;
      this.OpFuPredeterminada.CheckState = System.Windows.Forms.CheckState.Checked;
      this.OpFuPredeterminada.Name = "OpFuPredeterminada";
      this.OpFuPredeterminada.Size = new System.Drawing.Size(175, 24);
      this.OpFuPredeterminada.Text = "Predeterminada";
      this.OpFuPredeterminada.Click += new System.EventHandler(this.OpFuPredeterminada_Click);
      // 
      // OpcionesTam
      // 
      this.OpcionesTam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpTam16,
            this.OpTam24,
            this.OpTamPredeterminado});
      this.OpcionesTam.Name = "OpcionesTam";
      this.OpcionesTam.Size = new System.Drawing.Size(152, 24);
      this.OpcionesTam.Text = "&Tamaño";
      // 
      // OpTam16
      // 
      this.OpTam16.Name = "OpTam16";
      this.OpTam16.Size = new System.Drawing.Size(176, 24);
      this.OpTam16.Text = "16";
      this.OpTam16.Click += new System.EventHandler(this.OpTam16_Click);
      // 
      // OpTam24
      // 
      this.OpTam24.Name = "OpTam24";
      this.OpTam24.Size = new System.Drawing.Size(176, 24);
      this.OpTam24.Text = "24";
      this.OpTam24.Click += new System.EventHandler(this.OpTam24_Click);
      // 
      // OpTamPredeterminado
      // 
      this.OpTamPredeterminado.Checked = true;
      this.OpTamPredeterminado.CheckState = System.Windows.Forms.CheckState.Checked;
      this.OpTamPredeterminado.Name = "OpTamPredeterminado";
      this.OpTamPredeterminado.Size = new System.Drawing.Size(176, 24);
      this.OpTamPredeterminado.Text = "Predeterminado";
      this.OpTamPredeterminado.Click += new System.EventHandler(this.OpTamPredeterminado_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(492, 266);
      this.Controls.Add(this.ctEditor);
      this.Controls.Add(this.BarraDeEstado);
      this.Controls.Add(this.BarraDeHerramientas);
      this.Controls.Add(this.BarraDeMenus);
      this.Name = "Form1";
      this.Text = "Editor";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.BarraDeHerramientas.ResumeLayout(false);
      this.BarraDeHerramientas.PerformLayout();
      this.BarraDeMenus.ResumeLayout(false);
      this.BarraDeMenus.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox ctEditor;
    private System.Windows.Forms.StatusStrip BarraDeEstado;
    private System.Windows.Forms.ToolStrip BarraDeHerramientas;
    private System.Windows.Forms.ToolStripButton btbarCortar;
    private System.Windows.Forms.ToolStripButton btbarCopiar;
    private System.Windows.Forms.ToolStripButton btbarPegar;
    private System.Windows.Forms.MenuStrip BarraDeMenus;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    private System.Windows.Forms.ToolStripMenuItem menuEdicion;
    private System.Windows.Forms.ToolStripMenuItem EdicionDeshacer;
    private System.Windows.Forms.ToolStripSeparator Separator2;
    private System.Windows.Forms.ToolStripMenuItem EdicionCortar;
    private System.Windows.Forms.ToolStripMenuItem EdicionCopiar;
    private System.Windows.Forms.ToolStripMenuItem EdicionPegar;
    private System.Windows.Forms.ToolStripMenuItem menuOpciones;
    private System.Windows.Forms.ToolStripMenuItem OpcionesFuente;
    private System.Windows.Forms.ToolStripMenuItem OpFuCourierNew;
    private System.Windows.Forms.ToolStripMenuItem OpFuArial;
    private System.Windows.Forms.ToolStripMenuItem OpFuPredeterminada;
    private System.Windows.Forms.ToolStripMenuItem OpcionesTam;
    private System.Windows.Forms.ToolStripMenuItem OpTam16;
    private System.Windows.Forms.ToolStripMenuItem OpTam24;
    private System.Windows.Forms.ToolStripMenuItem OpTamPredeterminado;
  }
}


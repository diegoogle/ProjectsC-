namespace ApEntidades
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
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ctNota = new System.Windows.Forms.TextBox();
      this.odAlumAsig = new System.Windows.Forms.BindingSource(this.components);
      this.odAsignaturas = new System.Windows.Forms.BindingSource(this.components);
      this.etAsigs = new System.Windows.Forms.Label();
      this.odAlumnos = new System.Windows.Forms.BindingSource(this.components);
      this.etAlumnos = new System.Windows.Forms.Label();
      this.menuCambiosEnLaBD = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosModificar = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosInsertar = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosInsertarAlumno = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosInsertarAsignatura = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosBorrar = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosBorrarAlumno = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosBorrarAsignatura = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosMatricular = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosConcurrencia = new System.Windows.Forms.ToolStripMenuItem();
      this.CambiosEstado = new System.Windows.Forms.ToolStripMenuItem();
      this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
      this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.menuPpal = new System.Windows.Forms.MenuStrip();
      this.lstAlumnos = new System.Windows.Forms.ListBox();
      this.lstAsignaturas = new System.Windows.Forms.ListBox();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.odAlumAsig)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.odAsignaturas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.odAlumnos)).BeginInit();
      this.menuPpal.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ctNota);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(11, 364);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(461, 68);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Nota del alumno y asignatura seleccionados:";
      // 
      // ctNota
      // 
      this.ctNota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.odAlumAsig, "nota", true));
      this.ctNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctNota.Location = new System.Drawing.Point(204, 30);
      this.ctNota.Name = "ctNota";
      this.ctNota.ReadOnly = true;
      this.ctNota.Size = new System.Drawing.Size(53, 27);
      this.ctNota.TabIndex = 0;
      this.ctNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // odAlumAsig
      // 
      this.odAlumAsig.DataSource = typeof(BDNotasAlumnos.alum_asig);
      // 
      // odAsignaturas
      // 
      this.odAsignaturas.DataSource = typeof(BDNotasAlumnos.asignatura);
      // 
      // etAsigs
      // 
      this.etAsigs.AutoSize = true;
      this.etAsigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.etAsigs.Location = new System.Drawing.Point(8, 199);
      this.etAsigs.Name = "etAsigs";
      this.etAsigs.Size = new System.Drawing.Size(396, 24);
      this.etAsigs.TabIndex = 2;
      this.etAsigs.Text = "Lista de asignaturas del alumno seleccionado:";
      // 
      // odAlumnos
      // 
      this.odAlumnos.DataSource = typeof(BDNotasAlumnos.alumno);
      // 
      // etAlumnos
      // 
      this.etAlumnos.AutoSize = true;
      this.etAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.etAlumnos.Location = new System.Drawing.Point(8, 34);
      this.etAlumnos.Name = "etAlumnos";
      this.etAlumnos.Size = new System.Drawing.Size(156, 24);
      this.etAlumnos.TabIndex = 0;
      this.etAlumnos.Text = "Lista de alumnos:";
      // 
      // menuCambiosEnLaBD
      // 
      this.menuCambiosEnLaBD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CambiosModificar,
            this.CambiosInsertar,
            this.CambiosBorrar,
            this.CambiosMatricular,
            this.CambiosConcurrencia,
            this.CambiosEstado});
      this.menuCambiosEnLaBD.Name = "menuCambiosEnLaBD";
      this.menuCambiosEnLaBD.Size = new System.Drawing.Size(129, 23);
      this.menuCambiosEnLaBD.Text = "Cambios en la BD";
      // 
      // CambiosModificar
      // 
      this.CambiosModificar.Name = "CambiosModificar";
      this.CambiosModificar.Size = new System.Drawing.Size(167, 24);
      this.CambiosModificar.Text = "Modificar nota";
      this.CambiosModificar.Click += new System.EventHandler(this.CambiosModificar_Click);
      // 
      // CambiosInsertar
      // 
      this.CambiosInsertar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CambiosInsertarAlumno,
            this.CambiosInsertarAsignatura});
      this.CambiosInsertar.Name = "CambiosInsertar";
      this.CambiosInsertar.Size = new System.Drawing.Size(167, 24);
      this.CambiosInsertar.Text = "Insertar";
      // 
      // CambiosInsertarAlumno
      // 
      this.CambiosInsertarAlumno.Name = "CambiosInsertarAlumno";
      this.CambiosInsertarAlumno.Size = new System.Drawing.Size(144, 24);
      this.CambiosInsertarAlumno.Text = "Alumno";
      this.CambiosInsertarAlumno.Click += new System.EventHandler(this.CambiosInsertarAlumno_Click);
      // 
      // CambiosInsertarAsignatura
      // 
      this.CambiosInsertarAsignatura.Name = "CambiosInsertarAsignatura";
      this.CambiosInsertarAsignatura.Size = new System.Drawing.Size(144, 24);
      this.CambiosInsertarAsignatura.Text = "Asignatura";
      this.CambiosInsertarAsignatura.Click += new System.EventHandler(this.CambiosInsertarAsignatura_Click);
      // 
      // CambiosBorrar
      // 
      this.CambiosBorrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CambiosBorrarAlumno,
            this.CambiosBorrarAsignatura});
      this.CambiosBorrar.Name = "CambiosBorrar";
      this.CambiosBorrar.Size = new System.Drawing.Size(167, 24);
      this.CambiosBorrar.Text = "Borrar";
      // 
      // CambiosBorrarAlumno
      // 
      this.CambiosBorrarAlumno.Name = "CambiosBorrarAlumno";
      this.CambiosBorrarAlumno.Size = new System.Drawing.Size(152, 24);
      this.CambiosBorrarAlumno.Text = "Alumno";
      this.CambiosBorrarAlumno.Click += new System.EventHandler(this.CambiosBorrarAlumno_Click);
      // 
      // CambiosBorrarAsignatura
      // 
      this.CambiosBorrarAsignatura.Name = "CambiosBorrarAsignatura";
      this.CambiosBorrarAsignatura.Size = new System.Drawing.Size(152, 24);
      this.CambiosBorrarAsignatura.Text = "Asignatura";
      this.CambiosBorrarAsignatura.Click += new System.EventHandler(this.CambiosBorrarAsignatura_Click);
      // 
      // CambiosMatricular
      // 
      this.CambiosMatricular.Name = "CambiosMatricular";
      this.CambiosMatricular.Size = new System.Drawing.Size(167, 24);
      this.CambiosMatricular.Text = "Matricular";
      this.CambiosMatricular.Click += new System.EventHandler(this.CambiosMatricular_Click);
      // 
      // CambiosConcurrencia
      // 
      this.CambiosConcurrencia.Name = "CambiosConcurrencia";
      this.CambiosConcurrencia.Size = new System.Drawing.Size(167, 24);
      this.CambiosConcurrencia.Text = "Concurrencia";
      this.CambiosConcurrencia.Click += new System.EventHandler(this.CambiosConcurrencia_Click);
      // 
      // CambiosEstado
      // 
      this.CambiosEstado.Name = "CambiosEstado";
      this.CambiosEstado.Size = new System.Drawing.Size(167, 24);
      this.CambiosEstado.Text = "Estado";
      this.CambiosEstado.Click += new System.EventHandler(this.CambiosEstado_Click);
      // 
      // menuArchivo
      // 
      this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoSalir});
      this.menuArchivo.Name = "menuArchivo";
      this.menuArchivo.Size = new System.Drawing.Size(67, 23);
      this.menuArchivo.Text = "Archivo";
      // 
      // ArchivoSalir
      // 
      this.ArchivoSalir.Name = "ArchivoSalir";
      this.ArchivoSalir.Size = new System.Drawing.Size(103, 24);
      this.ArchivoSalir.Text = "Salir";
      // 
      // menuPpal
      // 
      this.menuPpal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuCambiosEnLaBD});
      this.menuPpal.Location = new System.Drawing.Point(0, 0);
      this.menuPpal.Name = "menuPpal";
      this.menuPpal.Size = new System.Drawing.Size(484, 27);
      this.menuPpal.TabIndex = 8;
      this.menuPpal.Text = "menuStrip1";
      // 
      // lstAlumnos
      // 
      this.lstAlumnos.DataSource = this.odAlumnos;
      this.lstAlumnos.DisplayMember = "nombre";
      this.lstAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstAlumnos.FormattingEnabled = true;
      this.lstAlumnos.ItemHeight = 20;
      this.lstAlumnos.Location = new System.Drawing.Point(12, 62);
      this.lstAlumnos.Name = "lstAlumnos";
      this.lstAlumnos.Size = new System.Drawing.Size(460, 124);
      this.lstAlumnos.TabIndex = 9;
      this.lstAlumnos.ValueMember = "id_alumno";
      this.lstAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstAlumnos_SelectedIndexChanged);
      // 
      // lstAsignaturas
      // 
      this.lstAsignaturas.DataSource = this.odAsignaturas;
      this.lstAsignaturas.DisplayMember = "nombre";
      this.lstAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstAsignaturas.FormattingEnabled = true;
      this.lstAsignaturas.ItemHeight = 20;
      this.lstAsignaturas.Location = new System.Drawing.Point(12, 234);
      this.lstAsignaturas.Name = "lstAsignaturas";
      this.lstAsignaturas.Size = new System.Drawing.Size(460, 124);
      this.lstAsignaturas.TabIndex = 9;
      this.lstAsignaturas.ValueMember = "id_asignatura";
      this.lstAsignaturas.SelectedIndexChanged += new System.EventHandler(this.lstAsignaturas_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 439);
      this.Controls.Add(this.lstAsignaturas);
      this.Controls.Add(this.lstAlumnos);
      this.Controls.Add(this.menuPpal);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.etAlumnos);
      this.Controls.Add(this.etAsigs);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Notas alumnos";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.odAlumAsig)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.odAsignaturas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.odAlumnos)).EndInit();
      this.menuPpal.ResumeLayout(false);
      this.menuPpal.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox ctNota;
    private System.Windows.Forms.Label etAsigs;
    private System.Windows.Forms.Label etAlumnos;
    private System.Windows.Forms.BindingSource odAlumnos;
    private System.Windows.Forms.BindingSource odAsignaturas;
    private System.Windows.Forms.BindingSource odAlumAsig;
    private System.Windows.Forms.ToolStripMenuItem menuCambiosEnLaBD;
    private System.Windows.Forms.ToolStripMenuItem CambiosModificar;
    private System.Windows.Forms.ToolStripMenuItem CambiosInsertar;
    private System.Windows.Forms.ToolStripMenuItem CambiosInsertarAlumno;
    private System.Windows.Forms.ToolStripMenuItem CambiosInsertarAsignatura;
    private System.Windows.Forms.ToolStripMenuItem CambiosBorrar;
    private System.Windows.Forms.ToolStripMenuItem CambiosBorrarAlumno;
    private System.Windows.Forms.ToolStripMenuItem CambiosBorrarAsignatura;
    private System.Windows.Forms.ToolStripMenuItem CambiosMatricular;
    private System.Windows.Forms.ToolStripMenuItem menuArchivo;
    private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
    private System.Windows.Forms.MenuStrip menuPpal;
    private System.Windows.Forms.ListBox lstAlumnos;
    private System.Windows.Forms.ListBox lstAsignaturas;
    private System.Windows.Forms.ToolStripMenuItem CambiosConcurrencia;
    private System.Windows.Forms.ToolStripMenuItem CambiosEstado;

  }
}


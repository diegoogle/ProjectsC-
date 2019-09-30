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
      this.dgAsignaturas = new System.Windows.Forms.DataGridView();
      this.idasignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.odAsignaturas = new System.Windows.Forms.BindingSource(this.components);
      this.etAsigs = new System.Windows.Forms.Label();
      this.dgAlumnos = new System.Windows.Forms.DataGridView();
      this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.odAlumnos = new System.Windows.Forms.BindingSource(this.components);
      this.etAlumnos = new System.Windows.Forms.Label();
      this.bopTodas = new System.Windows.Forms.RadioButton();
      this.bopSuspensas = new System.Windows.Forms.RadioButton();
      this.bopAprobadas = new System.Windows.Forms.RadioButton();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.odAlumAsig)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.odAsignaturas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.odAlumnos)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ctNota);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(11, 339);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(461, 68);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Nota del alumno y asignatura seleccionados:";
      // 
      // ctNota
      // 
      this.ctNota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.odAlumAsig, "nota", true));
      this.ctNota.Location = new System.Drawing.Point(204, 30);
      this.ctNota.Name = "ctNota";
      this.ctNota.ReadOnly = true;
      this.ctNota.Size = new System.Drawing.Size(53, 31);
      this.ctNota.TabIndex = 0;
      this.ctNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // odAlumAsig
      // 
      this.odAlumAsig.DataSource = typeof(BDNotasAlumnos.alum_asig);
      // 
      // dgAsignaturas
      // 
      this.dgAsignaturas.AutoGenerateColumns = false;
      this.dgAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idasignaturaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1});
      this.dgAsignaturas.DataSource = this.odAsignaturas;
      this.dgAsignaturas.Location = new System.Drawing.Point(11, 224);
      this.dgAsignaturas.Name = "dgAsignaturas";
      this.dgAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgAsignaturas.Size = new System.Drawing.Size(462, 109);
      this.dgAsignaturas.TabIndex = 6;
      this.dgAsignaturas.SelectionChanged += new System.EventHandler(this.dgAsignaturas_SelectionChanged);
      // 
      // idasignaturaDataGridViewTextBoxColumn
      // 
      this.idasignaturaDataGridViewTextBoxColumn.DataPropertyName = "id_asignatura";
      this.idasignaturaDataGridViewTextBoxColumn.HeaderText = "ID";
      this.idasignaturaDataGridViewTextBoxColumn.Name = "idasignaturaDataGridViewTextBoxColumn";
      // 
      // nombreDataGridViewTextBoxColumn1
      // 
      this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
      this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
      this.nombreDataGridViewTextBoxColumn1.MinimumWidth = 100;
      this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
      this.nombreDataGridViewTextBoxColumn1.Width = 319;
      // 
      // odAsignaturas
      // 
      this.odAsignaturas.DataSource = typeof(BDNotasAlumnos.asignatura);
      // 
      // etAsigs
      // 
      this.etAsigs.AutoSize = true;
      this.etAsigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.etAsigs.Location = new System.Drawing.Point(8, 174);
      this.etAsigs.Name = "etAsigs";
      this.etAsigs.Size = new System.Drawing.Size(396, 24);
      this.etAsigs.TabIndex = 2;
      this.etAsigs.Text = "Lista de asignaturas del alumno seleccionado:";
      // 
      // dgAlumnos
      // 
      this.dgAlumnos.AutoGenerateColumns = false;
      this.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
      this.dgAlumnos.DataSource = this.odAlumnos;
      this.dgAlumnos.Location = new System.Drawing.Point(12, 36);
      this.dgAlumnos.Name = "dgAlumnos";
      this.dgAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgAlumnos.Size = new System.Drawing.Size(462, 132);
      this.dgAlumnos.TabIndex = 1;
      this.dgAlumnos.SelectionChanged += new System.EventHandler(this.dgAlumnos_SelectionChanged);
      // 
      // idalumnoDataGridViewTextBoxColumn
      // 
      this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "id_alumno";
      this.idalumnoDataGridViewTextBoxColumn.HeaderText = "ID";
      this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
      // 
      // nombreDataGridViewTextBoxColumn
      // 
      this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
      this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
      this.nombreDataGridViewTextBoxColumn.MinimumWidth = 100;
      this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
      this.nombreDataGridViewTextBoxColumn.Width = 319;
      // 
      // odAlumnos
      // 
      this.odAlumnos.DataSource = typeof(BDNotasAlumnos.alumno);
      // 
      // etAlumnos
      // 
      this.etAlumnos.AutoSize = true;
      this.etAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.etAlumnos.Location = new System.Drawing.Point(8, 9);
      this.etAlumnos.Name = "etAlumnos";
      this.etAlumnos.Size = new System.Drawing.Size(156, 24);
      this.etAlumnos.TabIndex = 0;
      this.etAlumnos.Text = "Lista de alumnos:";
      // 
      // bopTodas
      // 
      this.bopTodas.AutoSize = true;
      this.bopTodas.Checked = true;
      this.bopTodas.Location = new System.Drawing.Point(11, 201);
      this.bopTodas.Name = "bopTodas";
      this.bopTodas.Size = new System.Drawing.Size(55, 17);
      this.bopTodas.TabIndex = 3;
      this.bopTodas.TabStop = true;
      this.bopTodas.Text = "Todas";
      this.bopTodas.UseVisualStyleBackColor = true;
      this.bopTodas.CheckedChanged += new System.EventHandler(this.bopTodas_CheckedChanged);
      // 
      // bopSuspensas
      // 
      this.bopSuspensas.AutoSize = true;
      this.bopSuspensas.Location = new System.Drawing.Point(150, 201);
      this.bopSuspensas.Name = "bopSuspensas";
      this.bopSuspensas.Size = new System.Drawing.Size(77, 17);
      this.bopSuspensas.TabIndex = 4;
      this.bopSuspensas.Text = "Suspensas";
      this.bopSuspensas.UseVisualStyleBackColor = true;
      this.bopSuspensas.CheckedChanged += new System.EventHandler(this.bopSuspensas_CheckedChanged);
      // 
      // bopAprobadas
      // 
      this.bopAprobadas.AutoSize = true;
      this.bopAprobadas.Location = new System.Drawing.Point(301, 201);
      this.bopAprobadas.Name = "bopAprobadas";
      this.bopAprobadas.Size = new System.Drawing.Size(76, 17);
      this.bopAprobadas.TabIndex = 5;
      this.bopAprobadas.Text = "Aprobadas";
      this.bopAprobadas.UseVisualStyleBackColor = true;
      this.bopAprobadas.CheckedChanged += new System.EventHandler(this.bopAprobadas_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 419);
      this.Controls.Add(this.bopAprobadas);
      this.Controls.Add(this.bopSuspensas);
      this.Controls.Add(this.bopTodas);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dgAsignaturas);
      this.Controls.Add(this.etAlumnos);
      this.Controls.Add(this.etAsigs);
      this.Controls.Add(this.dgAlumnos);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form1";
      this.Text = "Notas alumnos";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.odAlumAsig)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.odAsignaturas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.odAlumnos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox ctNota;
    private System.Windows.Forms.DataGridView dgAsignaturas;
    private System.Windows.Forms.Label etAsigs;
    private System.Windows.Forms.DataGridView dgAlumnos;
    private System.Windows.Forms.Label etAlumnos;
    private System.Windows.Forms.RadioButton bopTodas;
    private System.Windows.Forms.RadioButton bopSuspensas;
    private System.Windows.Forms.RadioButton bopAprobadas;
    private System.Windows.Forms.BindingSource odAlumnos;
    private System.Windows.Forms.DataGridViewTextBoxColumn idasignaturaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
    private System.Windows.Forms.BindingSource odAsignaturas;
    private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource odAlumAsig;

  }
}


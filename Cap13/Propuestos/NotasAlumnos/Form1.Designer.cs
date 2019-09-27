namespace NotasAlumnos
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
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
      this.sqldaAlumnos = new System.Data.SqlClient.SqlDataAdapter();
      this.listaDesAlumnos = new System.Windows.Forms.ComboBox();
      this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsAlumnos = new NotasAlumnos.dsAlumnos();
      this.listaAsignaturasNotas = new System.Windows.Forms.ListBox();
      this.alumsasigsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsAsignaturasNotas = new NotasAlumnos.dsAsignaturasNotas();
      this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqldaAsignaturasNotas = new System.Data.SqlClient.SqlDataAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAlumnos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.alumsasigsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAsignaturasNotas)).BeginInit();
      this.SuspendLayout();
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT        alumnos.*\r\nFROM            alumnos";
      this.sqlSelectCommand1.Connection = this.sqlConnection1;
      // 
      // sqlConnection1
      // 
      this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=bd_notasAlumnos;Integrated Security=True" +
    "";
      this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
      // 
      // sqldaAlumnos
      // 
      this.sqldaAlumnos.SelectCommand = this.sqlSelectCommand1;
      this.sqldaAlumnos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "alumnos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id_alumno", "id_alumno"),
                        new System.Data.Common.DataColumnMapping("nombre", "nombre")})});
      // 
      // listaDesAlumnos
      // 
      this.listaDesAlumnos.DataSource = this.alumnosBindingSource;
      this.listaDesAlumnos.DisplayMember = "nombre";
      this.listaDesAlumnos.FormattingEnabled = true;
      this.listaDesAlumnos.Location = new System.Drawing.Point(12, 25);
      this.listaDesAlumnos.Name = "listaDesAlumnos";
      this.listaDesAlumnos.Size = new System.Drawing.Size(300, 21);
      this.listaDesAlumnos.TabIndex = 0;
      this.listaDesAlumnos.ValueMember = "id_alumno";
      this.listaDesAlumnos.SelectedIndexChanged += new System.EventHandler(this.listaDesAlumnos_SelectedIndexChanged);
      // 
      // alumnosBindingSource
      // 
      this.alumnosBindingSource.DataMember = "alumnos";
      this.alumnosBindingSource.DataSource = this.dsAlumnos;
      // 
      // dsAlumnos
      // 
      this.dsAlumnos.DataSetName = "dsAlumnos";
      this.dsAlumnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // listaAsignaturasNotas
      // 
      this.listaAsignaturasNotas.DataSource = this.alumsasigsBindingSource;
      this.listaAsignaturasNotas.DisplayMember = "nombre";
      this.listaAsignaturasNotas.FormattingEnabled = true;
      this.listaAsignaturasNotas.Location = new System.Drawing.Point(12, 64);
      this.listaAsignaturasNotas.Name = "listaAsignaturasNotas";
      this.listaAsignaturasNotas.Size = new System.Drawing.Size(300, 212);
      this.listaAsignaturasNotas.TabIndex = 1;
      this.listaAsignaturasNotas.ValueMember = "nota";
      this.listaAsignaturasNotas.SelectedIndexChanged += new System.EventHandler(this.listaAsignaturasNotas_SelectedIndexChanged);
      // 
      // alumsasigsBindingSource
      // 
      this.alumsasigsBindingSource.DataMember = "alums_asigs";
      this.alumsasigsBindingSource.DataSource = this.dsAsignaturasNotas;
      // 
      // dsAsignaturasNotas
      // 
      this.dsAsignaturasNotas.DataSetName = "dsAsignaturasNotas";
      this.dsAsignaturasNotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // sqlSelectCommand2
      // 
      this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
      this.sqlSelectCommand2.Connection = this.sqlConnection1;
      this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IDAlumno", System.Data.SqlDbType.Int, 4, "id_alumno")});
      // 
      // sqldaAsignaturasNotas
      // 
      this.sqldaAsignaturasNotas.SelectCommand = this.sqlSelectCommand2;
      this.sqldaAsignaturasNotas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "alums_asigs", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("nombre", "nombre"),
                        new System.Data.Common.DataColumnMapping("nota", "nota"),
                        new System.Data.Common.DataColumnMapping("id_alumno", "id_alumno")})});
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(326, 296);
      this.Controls.Add(this.listaAsignaturasNotas);
      this.Controls.Add(this.listaDesAlumnos);
      this.Name = "Form1";
      this.Text = "Notas";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAlumnos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.alumsasigsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsAsignaturasNotas)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlDataAdapter sqldaAlumnos;
    private System.Data.SqlClient.SqlConnection sqlConnection1;
    private System.Windows.Forms.ComboBox listaDesAlumnos;
    private dsAlumnos dsAlumnos;
    private System.Windows.Forms.BindingSource alumnosBindingSource;
    private System.Windows.Forms.ListBox listaAsignaturasNotas;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
    private System.Data.SqlClient.SqlDataAdapter sqldaAsignaturasNotas;
    private dsAsignaturasNotas dsAsignaturasNotas;
    private System.Windows.Forms.BindingSource alumsasigsBindingSource;
  }
}


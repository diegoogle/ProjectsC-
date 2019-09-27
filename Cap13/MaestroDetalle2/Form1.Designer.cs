namespace MaestroDetalle
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
      System.Windows.Forms.Label temaLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
      this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqldaTitulos = new System.Data.SqlClient.SqlDataAdapter();
      this.titulosDataGridView = new System.Windows.Forms.DataGridView();
      this.idlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.titulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsTitulos = new MaestroDetalle.dsTitulos();
      this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
      this.sqldaTemas = new System.Data.SqlClient.SqlDataAdapter();
      this.temaLabel1 = new System.Windows.Forms.Label();
      this.temasBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsTemas = new MaestroDetalle.dsTemas();
      temaLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.titulosDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsTitulos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.temasBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsTemas)).BeginInit();
      this.SuspendLayout();
      // 
      // temaLabel
      // 
      temaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      temaLabel.AutoSize = true;
      temaLabel.Location = new System.Drawing.Point(25, 280);
      temaLabel.Name = "temaLabel";
      temaLabel.Size = new System.Drawing.Size(37, 13);
      temaLabel.TabIndex = 4;
      temaLabel.Text = "Tema:";
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT titulos.* FROM titulos";
      this.sqlSelectCommand1.Connection = this.sqlConnection1;
      // 
      // sqlConnection1
      // 
      this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=bd_libros;Integrated Security=True";
      this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
      // 
      // sqlInsertCommand1
      // 
      this.sqlInsertCommand1.CommandText = "INSERT INTO [titulos] ([id_libro], [titulo], [id_tema]) VALUES (@id_libro, @titul" +
    "o, @id_tema);\r\nSELECT id_libro, titulo, id_tema FROM titulos WHERE (id_libro = @" +
    "id_libro)";
      this.sqlInsertCommand1.Connection = this.sqlConnection1;
      this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_libro", System.Data.SqlDbType.Int, 0, "id_libro"),
            new System.Data.SqlClient.SqlParameter("@titulo", System.Data.SqlDbType.NVarChar, 0, "titulo"),
            new System.Data.SqlClient.SqlParameter("@id_tema", System.Data.SqlDbType.Int, 0, "id_tema")});
      // 
      // sqlUpdateCommand1
      // 
      this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
      this.sqlUpdateCommand1.Connection = this.sqlConnection1;
      this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_libro", System.Data.SqlDbType.Int, 0, "id_libro"),
            new System.Data.SqlClient.SqlParameter("@titulo", System.Data.SqlDbType.NVarChar, 0, "titulo"),
            new System.Data.SqlClient.SqlParameter("@id_tema", System.Data.SqlDbType.Int, 0, "id_tema"),
            new System.Data.SqlClient.SqlParameter("@Original_id_libro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id_libro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_titulo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "titulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_id_tema", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id_tema", System.Data.DataRowVersion.Original, null)});
      // 
      // sqlDeleteCommand1
      // 
      this.sqlDeleteCommand1.CommandText = "DELETE FROM [titulos] WHERE (([id_libro] = @Original_id_libro) AND ([titulo] = @O" +
    "riginal_titulo) AND ([id_tema] = @Original_id_tema))";
      this.sqlDeleteCommand1.Connection = this.sqlConnection1;
      this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_id_libro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id_libro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_titulo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "titulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_id_tema", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id_tema", System.Data.DataRowVersion.Original, null)});
      // 
      // sqldaTitulos
      // 
      this.sqldaTitulos.DeleteCommand = this.sqlDeleteCommand1;
      this.sqldaTitulos.InsertCommand = this.sqlInsertCommand1;
      this.sqldaTitulos.SelectCommand = this.sqlSelectCommand1;
      this.sqldaTitulos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "titulos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id_libro", "id_libro"),
                        new System.Data.Common.DataColumnMapping("titulo", "titulo"),
                        new System.Data.Common.DataColumnMapping("id_tema", "id_tema")})});
      this.sqldaTitulos.UpdateCommand = this.sqlUpdateCommand1;
      // 
      // titulosDataGridView
      // 
      this.titulosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.titulosDataGridView.AutoGenerateColumns = false;
      this.titulosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.titulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.titulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibroDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn});
      this.titulosDataGridView.DataSource = this.titulosBindingSource;
      this.titulosDataGridView.Location = new System.Drawing.Point(0, 0);
      this.titulosDataGridView.Name = "titulosDataGridView";
      this.titulosDataGridView.Size = new System.Drawing.Size(439, 242);
      this.titulosDataGridView.TabIndex = 0;
      this.titulosDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.titulosDataGridView_RowEnter);
      // 
      // idlibroDataGridViewTextBoxColumn
      // 
      this.idlibroDataGridViewTextBoxColumn.DataPropertyName = "id_libro";
      this.idlibroDataGridViewTextBoxColumn.FillWeight = 30.45685F;
      this.idlibroDataGridViewTextBoxColumn.HeaderText = "ID";
      this.idlibroDataGridViewTextBoxColumn.MinimumWidth = 30;
      this.idlibroDataGridViewTextBoxColumn.Name = "idlibroDataGridViewTextBoxColumn";
      // 
      // tituloDataGridViewTextBoxColumn
      // 
      this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
      this.tituloDataGridViewTextBoxColumn.FillWeight = 169.5432F;
      this.tituloDataGridViewTextBoxColumn.HeaderText = "Título";
      this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
      // 
      // titulosBindingSource
      // 
      this.titulosBindingSource.DataMember = "titulos";
      this.titulosBindingSource.DataSource = this.dsTitulos;
      // 
      // dsTitulos
      // 
      this.dsTitulos.DataSetName = "dsTitulos";
      this.dsTitulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // sqlSelectCommand2
      // 
      this.sqlSelectCommand2.CommandText = "SELECT tema, id_tema FROM temas WHERE (id_tema = @IDTema)";
      this.sqlSelectCommand2.Connection = this.sqlConnection1;
      this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IDTema", System.Data.SqlDbType.Int, 4, "id_tema")});
      // 
      // sqlInsertCommand2
      // 
      this.sqlInsertCommand2.CommandText = "INSERT INTO [temas] ([tema], [id_tema]) VALUES (@tema, @id_tema);\r\nSELECT tema, i" +
    "d_tema FROM temas WHERE (id_tema = @id_tema)";
      this.sqlInsertCommand2.Connection = this.sqlConnection1;
      this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@tema", System.Data.SqlDbType.NVarChar, 0, "tema"),
            new System.Data.SqlClient.SqlParameter("@id_tema", System.Data.SqlDbType.Int, 0, "id_tema")});
      // 
      // sqlUpdateCommand2
      // 
      this.sqlUpdateCommand2.CommandText = "UPDATE [temas] SET [tema] = @tema, [id_tema] = @id_tema WHERE (([tema] = @Origina" +
    "l_tema) AND ([id_tema] = @Original_id_tema));\r\nSELECT tema, id_tema FROM temas W" +
    "HERE (id_tema = @id_tema)";
      this.sqlUpdateCommand2.Connection = this.sqlConnection1;
      this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@tema", System.Data.SqlDbType.NVarChar, 0, "tema"),
            new System.Data.SqlClient.SqlParameter("@id_tema", System.Data.SqlDbType.Int, 0, "id_tema"),
            new System.Data.SqlClient.SqlParameter("@Original_tema", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "tema", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_id_tema", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id_tema", System.Data.DataRowVersion.Original, null)});
      // 
      // sqlDeleteCommand2
      // 
      this.sqlDeleteCommand2.CommandText = "DELETE FROM [temas] WHERE (([tema] = @Original_tema) AND ([id_tema] = @Original_i" +
    "d_tema))";
      this.sqlDeleteCommand2.Connection = this.sqlConnection1;
      this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_tema", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "tema", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_id_tema", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id_tema", System.Data.DataRowVersion.Original, null)});
      // 
      // sqldaTemas
      // 
      this.sqldaTemas.DeleteCommand = this.sqlDeleteCommand2;
      this.sqldaTemas.InsertCommand = this.sqlInsertCommand2;
      this.sqldaTemas.SelectCommand = this.sqlSelectCommand2;
      this.sqldaTemas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "temas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("tema", "tema"),
                        new System.Data.Common.DataColumnMapping("id_tema", "id_tema")})});
      this.sqldaTemas.UpdateCommand = this.sqlUpdateCommand2;
      // 
      // temaLabel1
      // 
      this.temaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.temaLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.temaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.temaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temasBindingSource, "tema", true));
      this.temaLabel1.Location = new System.Drawing.Point(66, 275);
      this.temaLabel1.Name = "temaLabel1";
      this.temaLabel1.Size = new System.Drawing.Size(333, 23);
      this.temaLabel1.TabIndex = 5;
      this.temaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // temasBindingSource
      // 
      this.temasBindingSource.DataMember = "temas";
      this.temasBindingSource.DataSource = this.dsTemas;
      // 
      // dsTemas
      // 
      this.dsTemas.DataSetName = "dsTemas";
      this.dsTemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(439, 328);
      this.Controls.Add(temaLabel);
      this.Controls.Add(this.temaLabel1);
      this.Controls.Add(this.titulosDataGridView);
      this.Name = "Form1";
      this.Text = "Maestro-detalle";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.titulosDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsTitulos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.temasBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsTemas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlConnection sqlConnection1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
    private System.Data.SqlClient.SqlDataAdapter sqldaTitulos;
    private dsTitulos dsTitulos;
    private System.Windows.Forms.DataGridView titulosDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource titulosBindingSource;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
    private System.Data.SqlClient.SqlDataAdapter sqldaTemas;
    private System.Windows.Forms.Label temaLabel1;
    private System.Windows.Forms.BindingSource temasBindingSource;
    private dsTemas dsTemas;
  }
}


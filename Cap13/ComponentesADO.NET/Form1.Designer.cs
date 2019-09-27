namespace ComponentesADO.NET
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
      this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
      this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataSet11 = new ComponentesADO.NET.DataSet1();
      this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
      this.SuspendLayout();
      // 
      // sqlSelectCommand1
      // 
      this.sqlSelectCommand1.CommandText = "SELECT telefonos.*\r\nFROM    telefonos";
      this.sqlSelectCommand1.Connection = this.sqlConnection1;
      // 
      // sqlConnection1
      // 
      this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=bd_telefonos;Integrated Security=True";
      this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
      // 
      // sqlInsertCommand1
      // 
      this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
      this.sqlInsertCommand1.Connection = this.sqlConnection1;
      this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"),
            new System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"),
            new System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 0, "telefono"),
            new System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones")});
      // 
      // sqlUpdateCommand1
      // 
      this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
      this.sqlUpdateCommand1.Connection = this.sqlConnection1;
      this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"),
            new System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"),
            new System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 0, "telefono"),
            new System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "observaciones", System.Data.DataRowVersion.Original, null)});
      // 
      // sqlDeleteCommand1
      // 
      this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
      this.sqlDeleteCommand1.Connection = this.sqlConnection1;
      this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "observaciones", System.Data.DataRowVersion.Original, null)});
      // 
      // sqlDataAdapter1
      // 
      this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
      this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
      this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
      this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "telefonos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("nombre", "nombre"),
                        new System.Data.Common.DataColumnMapping("direccion", "direccion"),
                        new System.Data.Common.DataColumnMapping("telefono", "telefono"),
                        new System.Data.Common.DataColumnMapping("observaciones", "observaciones")})});
      this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
      this.dataGridView1.DataMember = "telefonos";
      this.dataGridView1.DataSource = this.dataSet11;
      this.dataGridView1.Location = new System.Drawing.Point(13, 13);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(431, 232);
      this.dataGridView1.TabIndex = 0;
      // 
      // dataSet11
      // 
      this.dataSet11.DataSetName = "DataSet1";
      this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // nombreDataGridViewTextBoxColumn
      // 
      this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
      this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
      this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
      // 
      // direccionDataGridViewTextBoxColumn
      // 
      this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
      this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
      this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
      // 
      // telefonoDataGridViewTextBoxColumn
      // 
      this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
      this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
      this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
      // 
      // observacionesDataGridViewTextBoxColumn
      // 
      this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
      this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
      this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(456, 257);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlConnection sqlConnection1;
    private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
    private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
    private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private DataSet1 dataSet11;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;

  }
}


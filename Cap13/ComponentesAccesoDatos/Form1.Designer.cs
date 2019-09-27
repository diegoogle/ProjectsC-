namespace ComponentesAccesoDatos
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
      this.Label1 = new System.Windows.Forms.Label();
      this.dgTelefonos = new System.Windows.Forms.DataGridView();
      this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCTelefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dgTelefonos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.colCTelefonosBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label1.Location = new System.Drawing.Point(12, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(188, 25);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Lista de teléfonos:";
      // 
      // dgTelefonos
      // 
      this.dgTelefonos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgTelefonos.AutoGenerateColumns = false;
      this.dgTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
      this.dgTelefonos.DataSource = this.colCTelefonosBindingSource;
      this.dgTelefonos.Location = new System.Drawing.Point(12, 39);
      this.dgTelefonos.Name = "dgTelefonos";
      this.dgTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgTelefonos.Size = new System.Drawing.Size(358, 216);
      this.dgTelefonos.TabIndex = 2;
      this.dgTelefonos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgTelefonos_CellBeginEdit);
      this.dgTelefonos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTelefonos_CellEndEdit);
      this.dgTelefonos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgTelefonos_UserDeletingRow);
      // 
      // nombreDataGridViewTextBoxColumn
      // 
      this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
      this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
      this.nombreDataGridViewTextBoxColumn.MinimumWidth = 100;
      this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
      this.nombreDataGridViewTextBoxColumn.Width = 210;
      // 
      // telefonoDataGridViewTextBoxColumn
      // 
      this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
      this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
      this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 70;
      this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
      this.telefonoDataGridViewTextBoxColumn.Width = 105;
      // 
      // direccionDataGridViewTextBoxColumn
      // 
      this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
      this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
      this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
      this.direccionDataGridViewTextBoxColumn.Width = 77;
      // 
      // observacionesDataGridViewTextBoxColumn
      // 
      this.observacionesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
      this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
      this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
      this.observacionesDataGridViewTextBoxColumn.Width = 103;
      // 
      // colCTelefonosBindingSource
      // 
      this.colCTelefonosBindingSource.DataSource = typeof(ComponentesAccesoDatos.ColCTelefonos);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(382, 267);
      this.Controls.Add(this.dgTelefonos);
      this.Controls.Add(this.Label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form1";
      this.Text = "Componentes de acceso a datos";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgTelefonos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.colCTelefonosBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Label Label1;
    private System.Windows.Forms.BindingSource colCTelefonosBindingSource;
    private System.Windows.Forms.DataGridView dgTelefonos;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
  }
}


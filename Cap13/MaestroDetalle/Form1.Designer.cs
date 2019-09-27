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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      System.Windows.Forms.Label temaLabel;
      this.dsTitulosTemas = new MaestroDetalle.dsTitulosTemas();
      this.titulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.titulosTableAdapter = new MaestroDetalle.dsTitulosTemasTableAdapters.titulosTableAdapter();
      this.tableAdapterManager = new MaestroDetalle.dsTitulosTemasTableAdapters.TableAdapterManager();
      this.titulosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.titulosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.titulosDataGridView = new System.Windows.Forms.DataGridView();
      this.temasBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.temasTableAdapter = new MaestroDetalle.dsTitulosTemasTableAdapters.temasTableAdapter();
      this.temaLabel1 = new System.Windows.Forms.Label();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      temaLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dsTitulosTemas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.titulosBindingNavigator)).BeginInit();
      this.titulosBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.titulosDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.temasBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dsTitulosTemas
      // 
      this.dsTitulosTemas.DataSetName = "dsTitulosTemas";
      this.dsTitulosTemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // titulosBindingSource
      // 
      this.titulosBindingSource.DataMember = "titulos";
      this.titulosBindingSource.DataSource = this.dsTitulosTemas;
      // 
      // titulosTableAdapter
      // 
      this.titulosTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.temasTableAdapter = this.temasTableAdapter;
      this.tableAdapterManager.titulosTableAdapter = this.titulosTableAdapter;
      this.tableAdapterManager.UpdateOrder = MaestroDetalle.dsTitulosTemasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // titulosBindingNavigator
      // 
      this.titulosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.titulosBindingNavigator.BindingSource = this.titulosBindingSource;
      this.titulosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.titulosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.titulosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.titulosBindingNavigatorSaveItem});
      this.titulosBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.titulosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.titulosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.titulosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.titulosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.titulosBindingNavigator.Name = "titulosBindingNavigator";
      this.titulosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.titulosBindingNavigator.Size = new System.Drawing.Size(439, 26);
      this.titulosBindingNavigator.TabIndex = 0;
      this.titulosBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Posición";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 19);
      this.bindingNavigatorCountItem.Text = "de {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Mover último";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
      this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Eliminar";
      // 
      // titulosBindingNavigatorSaveItem
      // 
      this.titulosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.titulosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("titulosBindingNavigatorSaveItem.Image")));
      this.titulosBindingNavigatorSaveItem.Name = "titulosBindingNavigatorSaveItem";
      this.titulosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
      this.titulosBindingNavigatorSaveItem.Text = "Guardar datos";
      this.titulosBindingNavigatorSaveItem.Click += new System.EventHandler(this.titulosBindingNavigatorSaveItem_Click);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.titulosDataGridView.DataSource = this.titulosBindingSource;
      this.titulosDataGridView.Location = new System.Drawing.Point(0, 29);
      this.titulosDataGridView.Name = "titulosDataGridView";
      this.titulosDataGridView.Size = new System.Drawing.Size(439, 220);
      this.titulosDataGridView.TabIndex = 1;
      // 
      // temasBindingSource
      // 
      this.temasBindingSource.DataMember = "titulos_temas";
      this.temasBindingSource.DataSource = this.titulosBindingSource;
      // 
      // temasTableAdapter
      // 
      this.temasTableAdapter.ClearBeforeFill = true;
      // 
      // temaLabel
      // 
      temaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      temaLabel.AutoSize = true;
      temaLabel.Location = new System.Drawing.Point(12, 270);
      temaLabel.Name = "temaLabel";
      temaLabel.Size = new System.Drawing.Size(37, 13);
      temaLabel.TabIndex = 2;
      temaLabel.Text = "Tema:";
      // 
      // temaLabel1
      // 
      this.temaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.temaLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.temaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.temaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temasBindingSource, "tema", true));
      this.temaLabel1.Location = new System.Drawing.Point(53, 265);
      this.temaLabel1.Name = "temaLabel1";
      this.temaLabel1.Size = new System.Drawing.Size(333, 23);
      this.temaLabel1.TabIndex = 3;
      this.temaLabel1.Text = "label1";
      this.temaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "id_libro";
      this.dataGridViewTextBoxColumn1.FillWeight = 32.01062F;
      this.dataGridViewTextBoxColumn1.HeaderText = "ID";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 30;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo";
      this.dataGridViewTextBoxColumn2.FillWeight = 178.1924F;
      this.dataGridViewTextBoxColumn2.HeaderText = "Título";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(439, 328);
      this.Controls.Add(temaLabel);
      this.Controls.Add(this.temaLabel1);
      this.Controls.Add(this.titulosDataGridView);
      this.Controls.Add(this.titulosBindingNavigator);
      this.Name = "Form1";
      this.Text = "Maestro-detalle";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dsTitulosTemas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.titulosBindingNavigator)).EndInit();
      this.titulosBindingNavigator.ResumeLayout(false);
      this.titulosBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.titulosDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.temasBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private dsTitulosTemas dsTitulosTemas;
    private System.Windows.Forms.BindingSource titulosBindingSource;
    private dsTitulosTemasTableAdapters.titulosTableAdapter titulosTableAdapter;
    private dsTitulosTemasTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator titulosBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton titulosBindingNavigatorSaveItem;
    private dsTitulosTemasTableAdapters.temasTableAdapter temasTableAdapter;
    private System.Windows.Forms.DataGridView titulosDataGridView;
    private System.Windows.Forms.BindingSource temasBindingSource;
    private System.Windows.Forms.Label temaLabel1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
  }
}


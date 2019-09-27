namespace EnlaceDeDatosObjetos
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
      this.listAlumnosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.listAlumnosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.listAlumnosDataGridView = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.listaCoAsignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.listaCoAsignaturasDataGridView = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.listaAsignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.listaAsigsDataGridView = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.notaTextBox = new System.Windows.Forms.TextBox();
      this.listAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      ((System.ComponentModel.ISupportInitialize)(this.listAlumnosBindingNavigator)).BeginInit();
      this.listAlumnosBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.listAlumnosDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.listaCoAsignaturasBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.listaCoAsignaturasDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.listaAsignaturasBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.listaAsigsDataGridView)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.listAlumnosBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // listAlumnosBindingNavigator
      // 
      this.listAlumnosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.listAlumnosBindingNavigator.BindingSource = this.listAlumnosBindingSource;
      this.listAlumnosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.listAlumnosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.listAlumnosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listAlumnosBindingNavigatorSaveItem});
      this.listAlumnosBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.listAlumnosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.listAlumnosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.listAlumnosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.listAlumnosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.listAlumnosBindingNavigator.Name = "listAlumnosBindingNavigator";
      this.listAlumnosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.listAlumnosBindingNavigator.Size = new System.Drawing.Size(585, 25);
      this.listAlumnosBindingNavigator.TabIndex = 0;
      this.listAlumnosBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
      this.bindingNavigatorCountItem.Text = "de {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Mover último";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // listAlumnosBindingNavigatorSaveItem
      // 
      this.listAlumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.listAlumnosBindingNavigatorSaveItem.Enabled = false;
      this.listAlumnosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listAlumnosBindingNavigatorSaveItem.Image")));
      this.listAlumnosBindingNavigatorSaveItem.Name = "listAlumnosBindingNavigatorSaveItem";
      this.listAlumnosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.listAlumnosBindingNavigatorSaveItem.Text = "Guardar datos";
      // 
      // listAlumnosDataGridView
      // 
      this.listAlumnosDataGridView.AutoGenerateColumns = false;
      this.listAlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.listAlumnosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
      this.listAlumnosDataGridView.DataSource = this.listAlumnosBindingSource;
      this.listAlumnosDataGridView.Location = new System.Drawing.Point(12, 28);
      this.listAlumnosDataGridView.Name = "listAlumnosDataGridView";
      this.listAlumnosDataGridView.Size = new System.Drawing.Size(562, 132);
      this.listAlumnosDataGridView.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(199, 167);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(189, 24);
      this.label1.TabIndex = 2;
      this.label1.Text = "Tipos de asignaturas:";
      // 
      // listaCoAsignaturasBindingSource
      // 
      this.listaCoAsignaturasBindingSource.DataMember = "ListaCoAsignaturas";
      this.listaCoAsignaturasBindingSource.DataSource = this.listAlumnosBindingSource;
      // 
      // listaCoAsignaturasDataGridView
      // 
      this.listaCoAsignaturasDataGridView.AutoGenerateColumns = false;
      this.listaCoAsignaturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.listaCoAsignaturasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
      this.listaCoAsignaturasDataGridView.DataSource = this.listaCoAsignaturasBindingSource;
      this.listaCoAsignaturasDataGridView.Location = new System.Drawing.Point(12, 194);
      this.listaCoAsignaturasDataGridView.Name = "listaCoAsignaturasDataGridView";
      this.listaCoAsignaturasDataGridView.Size = new System.Drawing.Size(562, 68);
      this.listaCoAsignaturasDataGridView.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(208, 265);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(179, 24);
      this.label2.TabIndex = 2;
      this.label2.Text = "Lista de asignaturas:";
      // 
      // listaAsignaturasBindingSource
      // 
      this.listaAsignaturasBindingSource.DataMember = "ListaAsignaturas";
      this.listaAsignaturasBindingSource.DataSource = this.listaCoAsignaturasBindingSource;
      // 
      // listaAsigsDataGridView
      // 
      this.listaAsigsDataGridView.AutoGenerateColumns = false;
      this.listaAsigsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.listaAsigsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
      this.listaAsigsDataGridView.DataSource = this.listaAsignaturasBindingSource;
      this.listaAsigsDataGridView.Location = new System.Drawing.Point(12, 292);
      this.listaAsigsDataGridView.Name = "listaAsigsDataGridView";
      this.listaAsigsDataGridView.Size = new System.Drawing.Size(562, 88);
      this.listaAsigsDataGridView.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.notaTextBox);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(13, 386);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(561, 82);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Nota de la asignatura:";
      // 
      // notaTextBox
      // 
      this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaAsignaturasBindingSource, "Nota", true));
      this.notaTextBox.Location = new System.Drawing.Point(254, 30);
      this.notaTextBox.Name = "notaTextBox";
      this.notaTextBox.Size = new System.Drawing.Size(53, 31);
      this.notaTextBox.TabIndex = 1;
      this.notaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // listAlumnosBindingSource
      // 
      this.listAlumnosBindingSource.DataSource = typeof(BaseDeDatos.Alumno);
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "IdAsignatura";
      this.dataGridViewTextBoxColumn6.HeaderText = "ID";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.Width = 60;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "NomAsignatura";
      this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.Width = 440;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Tipo";
      this.dataGridViewTextBoxColumn5.HeaderText = "Tipo";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Width = 500;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAlumno";
      this.dataGridViewTextBoxColumn1.HeaderText = "ID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 60;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "NomAlumno";
      this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 140;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "DirAlumno";
      this.dataGridViewTextBoxColumn3.HeaderText = "Dirección";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.Width = 160;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "EstAlumno";
      this.dataGridViewTextBoxColumn4.HeaderText = "Estudios";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewCheckBoxColumn1
      // 
      this.dataGridViewCheckBoxColumn1.DataPropertyName = "BecaAlumno";
      this.dataGridViewCheckBoxColumn1.HeaderText = "Beca";
      this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
      this.dataGridViewCheckBoxColumn1.Width = 40;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(585, 482);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.listaAsigsDataGridView);
      this.Controls.Add(this.listaCoAsignaturasDataGridView);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listAlumnosDataGridView);
      this.Controls.Add(this.listAlumnosBindingNavigator);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.listAlumnosBindingNavigator)).EndInit();
      this.listAlumnosBindingNavigator.ResumeLayout(false);
      this.listAlumnosBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.listAlumnosDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.listaCoAsignaturasBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.listaCoAsignaturasDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.listaAsignaturasBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.listaAsigsDataGridView)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.listAlumnosBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource listAlumnosBindingSource;
    private System.Windows.Forms.BindingNavigator listAlumnosBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton listAlumnosBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView listAlumnosDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource listaCoAsignaturasBindingSource;
    private System.Windows.Forms.DataGridView listaCoAsignaturasDataGridView;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.BindingSource listaAsignaturasBindingSource;
    private System.Windows.Forms.DataGridView listaAsigsDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox notaTextBox;
    private System.Windows.Forms.ColorDialog colorDialog1;
  }
}


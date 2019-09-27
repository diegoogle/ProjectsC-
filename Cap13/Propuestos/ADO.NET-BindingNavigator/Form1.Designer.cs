namespace ADO.NET
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label nombreLabel;
      System.Windows.Forms.Label direccionLabel;
      System.Windows.Forms.Label telefonoLabel;
      System.Windows.Forms.Label observacionesLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.dsTelefonos = new ADO.NET.dsTelefonos();
      this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.telefonosTableAdapter = new ADO.NET.dsTelefonosTableAdapters.telefonosTableAdapter();
      this.telefonosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.telefonosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.nombreTextBox = new System.Windows.Forms.TextBox();
      this.direccionTextBox = new System.Windows.Forms.TextBox();
      this.telefonoTextBox = new System.Windows.Forms.TextBox();
      this.observacionesTextBox = new System.Windows.Forms.TextBox();
      this.btbarBuscar = new System.Windows.Forms.ToolStripButton();
      nombreLabel = new System.Windows.Forms.Label();
      direccionLabel = new System.Windows.Forms.Label();
      telefonoLabel = new System.Windows.Forms.Label();
      observacionesLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dsTelefonos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).BeginInit();
      this.telefonosBindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // nombreLabel
      // 
      nombreLabel.AutoSize = true;
      nombreLabel.Location = new System.Drawing.Point(8, 45);
      nombreLabel.Name = "nombreLabel";
      nombreLabel.Size = new System.Drawing.Size(47, 13);
      nombreLabel.TabIndex = 1;
      nombreLabel.Text = "Nombre:";
      // 
      // direccionLabel
      // 
      direccionLabel.AutoSize = true;
      direccionLabel.Location = new System.Drawing.Point(8, 75);
      direccionLabel.Name = "direccionLabel";
      direccionLabel.Size = new System.Drawing.Size(55, 13);
      direccionLabel.TabIndex = 3;
      direccionLabel.Text = "Dirección:";
      // 
      // telefonoLabel
      // 
      telefonoLabel.AutoSize = true;
      telefonoLabel.Location = new System.Drawing.Point(8, 110);
      telefonoLabel.Name = "telefonoLabel";
      telefonoLabel.Size = new System.Drawing.Size(52, 13);
      telefonoLabel.TabIndex = 5;
      telefonoLabel.Text = "Teléfono:";
      // 
      // observacionesLabel
      // 
      observacionesLabel.AutoSize = true;
      observacionesLabel.Location = new System.Drawing.Point(8, 140);
      observacionesLabel.Name = "observacionesLabel";
      observacionesLabel.Size = new System.Drawing.Size(38, 13);
      observacionesLabel.TabIndex = 7;
      observacionesLabel.Text = "Notas:";
      // 
      // dsTelefonos
      // 
      this.dsTelefonos.DataSetName = "dsTelefonos";
      this.dsTelefonos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // telefonosBindingSource
      // 
      this.telefonosBindingSource.DataMember = "telefonos";
      this.telefonosBindingSource.DataSource = this.dsTelefonos;
      // 
      // telefonosTableAdapter
      // 
      this.telefonosTableAdapter.ClearBeforeFill = true;
      // 
      // telefonosBindingNavigator
      // 
      this.telefonosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.telefonosBindingNavigator.BindingSource = this.telefonosBindingSource;
      this.telefonosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.telefonosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.telefonosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.telefonosBindingNavigatorSaveItem,
            this.btbarBuscar});
      this.telefonosBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.telefonosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.telefonosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.telefonosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.telefonosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.telefonosBindingNavigator.Name = "telefonosBindingNavigator";
      this.telefonosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.telefonosBindingNavigator.Size = new System.Drawing.Size(322, 25);
      this.telefonosBindingNavigator.TabIndex = 0;
      this.telefonosBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // telefonosBindingNavigatorSaveItem
      // 
      this.telefonosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.telefonosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("telefonosBindingNavigatorSaveItem.Image")));
      this.telefonosBindingNavigatorSaveItem.Name = "telefonosBindingNavigatorSaveItem";
      this.telefonosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.telefonosBindingNavigatorSaveItem.Text = "Save Data";
      this.telefonosBindingNavigatorSaveItem.Click += new System.EventHandler(this.telefonosBindingNavigatorSaveItem_Click);
      // 
      // nombreTextBox
      // 
      this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "nombre", true));
      this.nombreTextBox.Location = new System.Drawing.Point(73, 45);
      this.nombreTextBox.Name = "nombreTextBox";
      this.nombreTextBox.Size = new System.Drawing.Size(233, 20);
      this.nombreTextBox.TabIndex = 2;
      // 
      // direccionTextBox
      // 
      this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "direccion", true));
      this.direccionTextBox.Location = new System.Drawing.Point(73, 75);
      this.direccionTextBox.Name = "direccionTextBox";
      this.direccionTextBox.Size = new System.Drawing.Size(233, 20);
      this.direccionTextBox.TabIndex = 4;
      // 
      // telefonoTextBox
      // 
      this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "telefono", true));
      this.telefonoTextBox.Location = new System.Drawing.Point(73, 110);
      this.telefonoTextBox.Name = "telefonoTextBox";
      this.telefonoTextBox.Size = new System.Drawing.Size(129, 20);
      this.telefonoTextBox.TabIndex = 6;
      // 
      // observacionesTextBox
      // 
      this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "observaciones", true));
      this.observacionesTextBox.Location = new System.Drawing.Point(73, 140);
      this.observacionesTextBox.Multiline = true;
      this.observacionesTextBox.Name = "observacionesTextBox";
      this.observacionesTextBox.Size = new System.Drawing.Size(233, 56);
      this.observacionesTextBox.TabIndex = 8;
      // 
      // btbarBuscar
      // 
      this.btbarBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btbarBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btbarBuscar.Image")));
      this.btbarBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btbarBuscar.Name = "btbarBuscar";
      this.btbarBuscar.Size = new System.Drawing.Size(23, 22);
      this.btbarBuscar.Text = "toolStripButton1";
      this.btbarBuscar.Click += new System.EventHandler(this.btbarBuscar_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(322, 211);
      this.Controls.Add(nombreLabel);
      this.Controls.Add(this.nombreTextBox);
      this.Controls.Add(direccionLabel);
      this.Controls.Add(this.direccionTextBox);
      this.Controls.Add(telefonoLabel);
      this.Controls.Add(this.telefonoTextBox);
      this.Controls.Add(observacionesLabel);
      this.Controls.Add(this.observacionesTextBox);
      this.Controls.Add(this.telefonosBindingNavigator);
      this.Name = "Form1";
      this.Text = "BD teléfonos";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dsTelefonos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).EndInit();
      this.telefonosBindingNavigator.ResumeLayout(false);
      this.telefonosBindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private dsTelefonos dsTelefonos;
    private System.Windows.Forms.BindingSource telefonosBindingSource;
    private ADO.NET.dsTelefonosTableAdapters.telefonosTableAdapter telefonosTableAdapter;
    private System.Windows.Forms.BindingNavigator telefonosBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton telefonosBindingNavigatorSaveItem;
    private System.Windows.Forms.TextBox nombreTextBox;
    private System.Windows.Forms.TextBox direccionTextBox;
    private System.Windows.Forms.TextBox telefonoTextBox;
    private System.Windows.Forms.TextBox observacionesTextBox;
    private System.Windows.Forms.ToolStripButton btbarBuscar;
  }
}


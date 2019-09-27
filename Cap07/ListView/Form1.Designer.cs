namespace ListView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Teléfonos", 0, 1);
      this.imagsGrandes = new System.Windows.Forms.ImageList(this.components);
      this.ImagsNodos = new System.Windows.Forms.ImageList(this.components);
      this.contextAñadirNodo = new System.Windows.Forms.ToolStripMenuItem();
      this.menuContextualNodos = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.contextBorrarNodo = new System.Windows.Forms.ToolStripMenuItem();
      this.contextBorrarTodos = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.ArbolTfnos = new System.Windows.Forms.TreeView();
      this.listviewTfnos = new System.Windows.Forms.ListView();
      this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.menuContextualNodos.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // imagsGrandes
      // 
      this.imagsGrandes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagsGrandes.ImageStream")));
      this.imagsGrandes.TransparentColor = System.Drawing.Color.Transparent;
      this.imagsGrandes.Images.SetKeyName(0, "CarpetaAbiertaGrande.png");
      // 
      // ImagsNodos
      // 
      this.ImagsNodos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagsNodos.ImageStream")));
      this.ImagsNodos.TransparentColor = System.Drawing.Color.Transparent;
      this.ImagsNodos.Images.SetKeyName(0, "CarpetaCerrada.png");
      this.ImagsNodos.Images.SetKeyName(1, "CarpetaAbierta.png");
      // 
      // contextAñadirNodo
      // 
      this.contextAñadirNodo.Name = "contextAñadirNodo";
      this.contextAñadirNodo.Size = new System.Drawing.Size(308, 24);
      this.contextAñadirNodo.Text = "Añadir un nodo";
      this.contextAñadirNodo.Click += new System.EventHandler(this.contextAñadirNodo_Click);
      // 
      // menuContextualNodos
      // 
      this.menuContextualNodos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAñadirNodo,
            this.contextBorrarNodo,
            this.contextBorrarTodos});
      this.menuContextualNodos.Name = "menuContextualNodos";
      this.menuContextualNodos.Size = new System.Drawing.Size(309, 76);
      // 
      // contextBorrarNodo
      // 
      this.contextBorrarNodo.Name = "contextBorrarNodo";
      this.contextBorrarNodo.Size = new System.Drawing.Size(308, 24);
      this.contextBorrarNodo.Text = "Borrar el nodo seleccionado";
      this.contextBorrarNodo.Click += new System.EventHandler(this.contextBorrarNodo_Click);
      // 
      // contextBorrarTodos
      // 
      this.contextBorrarTodos.Name = "contextBorrarTodos";
      this.contextBorrarTodos.Size = new System.Drawing.Size(308, 24);
      this.contextBorrarTodos.Text = "Borrar todos los nodos excepto la raíz";
      this.contextBorrarTodos.Click += new System.EventHandler(this.contextBorrarTodos_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.ArbolTfnos);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.listviewTfnos);
      this.splitContainer1.Size = new System.Drawing.Size(522, 266);
      this.splitContainer1.SplitterDistance = 173;
      this.splitContainer1.TabIndex = 2;
      // 
      // ArbolTfnos
      // 
      this.ArbolTfnos.ContextMenuStrip = this.menuContextualNodos;
      this.ArbolTfnos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ArbolTfnos.ImageIndex = 0;
      this.ArbolTfnos.ImageList = this.ImagsNodos;
      this.ArbolTfnos.LabelEdit = true;
      this.ArbolTfnos.Location = new System.Drawing.Point(0, 0);
      this.ArbolTfnos.Name = "ArbolTfnos";
      treeNode1.ImageIndex = 0;
      treeNode1.Name = "nodoRaiz";
      treeNode1.SelectedImageIndex = 1;
      treeNode1.Text = "Teléfonos";
      this.ArbolTfnos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
      this.ArbolTfnos.SelectedImageIndex = 1;
      this.ArbolTfnos.Size = new System.Drawing.Size(173, 266);
      this.ArbolTfnos.Sorted = true;
      this.ArbolTfnos.TabIndex = 3;
      this.ArbolTfnos.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.ArbolTfnos_AfterLabelEdit);
      this.ArbolTfnos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ArbolTfnos_AfterSelect);
      this.ArbolTfnos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ArbolTfnos_NodeMouseClick);
      // 
      // listviewTfnos
      // 
      this.listviewTfnos.AllowColumnReorder = true;
      this.listviewTfnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
      this.listviewTfnos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listviewTfnos.FullRowSelect = true;
      this.listviewTfnos.GridLines = true;
      this.listviewTfnos.LabelEdit = true;
      this.listviewTfnos.LargeImageList = this.imagsGrandes;
      this.listviewTfnos.Location = new System.Drawing.Point(0, 0);
      this.listviewTfnos.Name = "listviewTfnos";
      this.listviewTfnos.Size = new System.Drawing.Size(345, 266);
      this.listviewTfnos.SmallImageList = this.ImagsNodos;
      this.listviewTfnos.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.listviewTfnos.TabIndex = 4;
      this.listviewTfnos.UseCompatibleStateImageBehavior = false;
      // 
      // ColumnHeader1
      // 
      this.ColumnHeader1.Text = "Nombre";
      this.ColumnHeader1.Width = 90;
      // 
      // ColumnHeader2
      // 
      this.ColumnHeader2.Text = "Dirección";
      this.ColumnHeader2.Width = 90;
      // 
      // ColumnHeader3
      // 
      this.ColumnHeader3.Text = "Teléfono";
      this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.ColumnHeader3.Width = 90;
      // 
      // ColumnHeader4
      // 
      this.ColumnHeader4.Text = "Casado(a)";
      this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.ColumnHeader4.Width = 90;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(522, 266);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Árbol y lista teléfonos";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuContextualNodos.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ImageList imagsGrandes;
    private System.Windows.Forms.ImageList ImagsNodos;
    private System.Windows.Forms.ToolStripMenuItem contextAñadirNodo;
    private System.Windows.Forms.ContextMenuStrip menuContextualNodos;
    private System.Windows.Forms.ToolStripMenuItem contextBorrarNodo;
    private System.Windows.Forms.ToolStripMenuItem contextBorrarTodos;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView ArbolTfnos;
    private System.Windows.Forms.ListView listviewTfnos;
    private System.Windows.Forms.ColumnHeader ColumnHeader1;
    private System.Windows.Forms.ColumnHeader ColumnHeader2;
    private System.Windows.Forms.ColumnHeader ColumnHeader3;
    private System.Windows.Forms.ColumnHeader ColumnHeader4;

  }
}


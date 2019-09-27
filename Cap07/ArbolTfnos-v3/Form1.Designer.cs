namespace ArbolTfnos
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
      this.contextBorrarNodo = new System.Windows.Forms.ToolStripMenuItem();
      this.contextBorrarTodos = new System.Windows.Forms.ToolStripMenuItem();
      this.ImagsNodos = new System.Windows.Forms.ImageList(this.components);
      this.ArbolTfnos = new System.Windows.Forms.TreeView();
      this.menuContextualNodos = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.contextAñadirNodo = new System.Windows.Forms.ToolStripMenuItem();
      this.menuContextualNodos.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextBorrarNodo
      // 
      this.contextBorrarNodo.Name = "contextBorrarNodo";
      this.contextBorrarNodo.Size = new System.Drawing.Size(266, 22);
      this.contextBorrarNodo.Text = "Borrar el nodo seleccionado";
      this.contextBorrarNodo.Click += new System.EventHandler(this.contextBorrarNodo_Click);
      // 
      // contextBorrarTodos
      // 
      this.contextBorrarTodos.Name = "contextBorrarTodos";
      this.contextBorrarTodos.Size = new System.Drawing.Size(266, 22);
      this.contextBorrarTodos.Text = "Borrar todos los nodos excepto la raíz";
      this.contextBorrarTodos.Click += new System.EventHandler(this.contextBorrarTodos_Click);
      // 
      // ImagsNodos
      // 
      this.ImagsNodos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagsNodos.ImageStream")));
      this.ImagsNodos.TransparentColor = System.Drawing.Color.Transparent;
      this.ImagsNodos.Images.SetKeyName(0, "CarpetaCerrada.png");
      this.ImagsNodos.Images.SetKeyName(1, "CarpetaAbierta.png");
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
      this.ArbolTfnos.Size = new System.Drawing.Size(292, 266);
      this.ArbolTfnos.Sorted = true;
      this.ArbolTfnos.TabIndex = 0;
      this.ArbolTfnos.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.ArbolTfnos_AfterLabelEdit);
      this.ArbolTfnos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ArbolTfnos_AfterSelect);
      this.ArbolTfnos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ArbolTfnos_NodeMouseClick);
      // 
      // menuContextualNodos
      // 
      this.menuContextualNodos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAñadirNodo,
            this.contextBorrarNodo,
            this.contextBorrarTodos});
      this.menuContextualNodos.Name = "menuContextualNodos";
      this.menuContextualNodos.Size = new System.Drawing.Size(267, 70);
      // 
      // contextAñadirNodo
      // 
      this.contextAñadirNodo.Name = "contextAñadirNodo";
      this.contextAñadirNodo.Size = new System.Drawing.Size(266, 22);
      this.contextAñadirNodo.Text = "Añadir un nodo";
      this.contextAñadirNodo.Click += new System.EventHandler(this.contextAñadirNodo_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.ArbolTfnos);
      this.Name = "Form1";
      this.Text = "Árbol teléfonos";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuContextualNodos.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripMenuItem contextBorrarNodo;
    private System.Windows.Forms.ToolStripMenuItem contextBorrarTodos;
    private System.Windows.Forms.ImageList ImagsNodos;
    private System.Windows.Forms.TreeView ArbolTfnos;
    private System.Windows.Forms.ContextMenuStrip menuContextualNodos;
    private System.Windows.Forms.ToolStripMenuItem contextAñadirNodo;
  }
}


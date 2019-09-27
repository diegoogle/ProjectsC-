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
      System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("teléfono 1A", 0, 1);
      System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("teléfono 2A", 0, 1);
      System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("A", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
      System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Amigos", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode3});
      System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("teléfono 1B", 0, 1);
      System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("B", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode5});
      System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Clientes", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode6});
      System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Teléfonos", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
      this.ImagsNodos = new System.Windows.Forms.ImageList(this.components);
      this.ArbolTfnos = new System.Windows.Forms.TreeView();
      this.SuspendLayout();
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
      this.ArbolTfnos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ArbolTfnos.ImageIndex = 0;
      this.ArbolTfnos.ImageList = this.ImagsNodos;
      this.ArbolTfnos.LabelEdit = true;
      this.ArbolTfnos.Location = new System.Drawing.Point(0, 0);
      this.ArbolTfnos.Name = "ArbolTfnos";
      treeNode1.ImageIndex = 0;
      treeNode1.Name = "NodoTfno1A";
      treeNode1.SelectedImageIndex = 1;
      treeNode1.Text = "teléfono 1A";
      treeNode2.ImageIndex = 0;
      treeNode2.Name = "NodoTfno2A";
      treeNode2.SelectedImageIndex = 1;
      treeNode2.Text = "teléfono 2A";
      treeNode3.ImageIndex = 0;
      treeNode3.Name = "NodoA";
      treeNode3.SelectedImageIndex = 1;
      treeNode3.Text = "A";
      treeNode4.ImageIndex = 0;
      treeNode4.Name = "NodoAmigos";
      treeNode4.SelectedImageIndex = 1;
      treeNode4.Text = "Amigos";
      treeNode5.ImageIndex = 0;
      treeNode5.Name = "NodoTfno1B";
      treeNode5.SelectedImageIndex = 1;
      treeNode5.Text = "teléfono 1B";
      treeNode6.ImageIndex = 0;
      treeNode6.Name = "NodoB";
      treeNode6.SelectedImageIndex = 1;
      treeNode6.Text = "B";
      treeNode7.ImageIndex = 0;
      treeNode7.Name = "NodoClientes";
      treeNode7.SelectedImageIndex = 1;
      treeNode7.Text = "Clientes";
      treeNode8.ImageIndex = 0;
      treeNode8.Name = "NodoRaiz";
      treeNode8.SelectedImageIndex = 1;
      treeNode8.Text = "Teléfonos";
      this.ArbolTfnos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
      this.ArbolTfnos.SelectedImageIndex = 1;
      this.ArbolTfnos.Size = new System.Drawing.Size(292, 266);
      this.ArbolTfnos.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.ArbolTfnos);
      this.Name = "Form1";
      this.Text = "Árbol teléfonos";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ImageList ImagsNodos;
    private System.Windows.Forms.TreeView ArbolTfnos;
  }
}


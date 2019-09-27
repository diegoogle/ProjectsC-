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
      this.ImagsNodos = new System.Windows.Forms.ImageList(this.components);
      this.ArbolTfnos = new System.Windows.Forms.TreeView();
      this.SuspendLayout();
      // 
      // ImagsNodos
      // 
      this.ImagsNodos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.ImagsNodos.ImageSize = new System.Drawing.Size(16, 16);
      this.ImagsNodos.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // ArbolTfnos
      // 
      this.ArbolTfnos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ArbolTfnos.ImageIndex = 0;
      this.ArbolTfnos.ImageList = this.ImagsNodos;
      this.ArbolTfnos.LabelEdit = true;
      this.ArbolTfnos.Location = new System.Drawing.Point(0, 0);
      this.ArbolTfnos.Name = "ArbolTfnos";
      this.ArbolTfnos.SelectedImageIndex = 0;
      this.ArbolTfnos.Size = new System.Drawing.Size(292, 266);
      this.ArbolTfnos.TabIndex = 1;
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
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ImageList ImagsNodos;
    private System.Windows.Forms.TreeView ArbolTfnos;
  }
}


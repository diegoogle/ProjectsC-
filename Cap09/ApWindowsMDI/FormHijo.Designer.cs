namespace ApWindowsMDI
{
  partial class FormHijo
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
      this.BarraMenusFormHijo = new System.Windows.Forms.MenuStrip();
      this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionCotar = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
      this.EdicionPegar = new System.Windows.Forms.ToolStripMenuItem();
      this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
      this.BarraMenusFormHijo.SuspendLayout();
      this.SuspendLayout();
      // 
      // BarraMenusFormHijo
      // 
      this.BarraMenusFormHijo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEdicion});
      this.BarraMenusFormHijo.Location = new System.Drawing.Point(0, 0);
      this.BarraMenusFormHijo.Name = "BarraMenusFormHijo";
      this.BarraMenusFormHijo.Size = new System.Drawing.Size(292, 27);
      this.BarraMenusFormHijo.TabIndex = 3;
      this.BarraMenusFormHijo.Text = "MenuStrip1";
      this.BarraMenusFormHijo.Visible = false;
      // 
      // menuEdicion
      // 
      this.menuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EdicionCotar,
            this.EdicionCopiar,
            this.EdicionPegar});
      this.menuEdicion.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.menuEdicion.MergeIndex = 1;
      this.menuEdicion.Name = "menuEdicion";
      this.menuEdicion.Size = new System.Drawing.Size(64, 23);
      this.menuEdicion.Text = "&Edición";
      // 
      // EdicionCotar
      // 
      this.EdicionCotar.Name = "EdicionCotar";
      this.EdicionCotar.Size = new System.Drawing.Size(118, 24);
      this.EdicionCotar.Text = "Cotar";
      // 
      // EdicionCopiar
      // 
      this.EdicionCopiar.Name = "EdicionCopiar";
      this.EdicionCopiar.Size = new System.Drawing.Size(118, 24);
      this.EdicionCopiar.Text = "Copiar";
      // 
      // EdicionPegar
      // 
      this.EdicionPegar.Name = "EdicionPegar";
      this.EdicionPegar.Size = new System.Drawing.Size(118, 24);
      this.EdicionPegar.Text = "Pegar";
      // 
      // RichTextBox1
      // 
      this.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RichTextBox1.Location = new System.Drawing.Point(0, 0);
      this.RichTextBox1.Name = "RichTextBox1";
      this.RichTextBox1.Size = new System.Drawing.Size(292, 266);
      this.RichTextBox1.TabIndex = 4;
      this.RichTextBox1.Text = "";
      // 
      // FormHijo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.RichTextBox1);
      this.Controls.Add(this.BarraMenusFormHijo);
      this.MainMenuStrip = this.BarraMenusFormHijo;
      this.Name = "FormHijo";
      this.Text = "FormHijo";
      this.BarraMenusFormHijo.ResumeLayout(false);
      this.BarraMenusFormHijo.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip BarraMenusFormHijo;
    private System.Windows.Forms.ToolStripMenuItem menuEdicion;
    private System.Windows.Forms.ToolStripMenuItem EdicionCotar;
    private System.Windows.Forms.ToolStripMenuItem EdicionCopiar;
    private System.Windows.Forms.ToolStripMenuItem EdicionPegar;
    private System.Windows.Forms.RichTextBox RichTextBox1;
  }
}
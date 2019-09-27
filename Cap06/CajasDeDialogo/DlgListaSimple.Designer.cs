namespace CajasDeDialogo
{
  partial class DlgListaSimple
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
      this.btAceptar = new System.Windows.Forms.Button();
      this.lsLista1 = new System.Windows.Forms.ListBox();
      this.ctAñadir = new System.Windows.Forms.TextBox();
      this.btBorrar = new System.Windows.Forms.Button();
      this.btAñadir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btAceptar
      // 
      this.btAceptar.Location = new System.Drawing.Point(205, 10);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 3;
      this.btAceptar.Text = "&Aceptar";
      this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
      // 
      // lsLista1
      // 
      this.lsLista1.FormattingEnabled = true;
      this.lsLista1.Location = new System.Drawing.Point(12, 10);
      this.lsLista1.Name = "lsLista1";
      this.lsLista1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lsLista1.Size = new System.Drawing.Size(180, 147);
      this.lsLista1.TabIndex = 2;
      // 
      // ctAñadir
      // 
      this.ctAñadir.Location = new System.Drawing.Point(205, 92);
      this.ctAñadir.Name = "ctAñadir";
      this.ctAñadir.Size = new System.Drawing.Size(75, 20);
      this.ctAñadir.TabIndex = 7;
      // 
      // btBorrar
      // 
      this.btBorrar.Location = new System.Drawing.Point(205, 130);
      this.btBorrar.Name = "btBorrar";
      this.btBorrar.Size = new System.Drawing.Size(75, 23);
      this.btBorrar.TabIndex = 6;
      this.btBorrar.Text = "&Borrar";
      this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
      // 
      // btAñadir
      // 
      this.btAñadir.Location = new System.Drawing.Point(205, 51);
      this.btAñadir.Name = "btAñadir";
      this.btAñadir.Size = new System.Drawing.Size(75, 23);
      this.btAñadir.TabIndex = 5;
      this.btAñadir.Text = "Aña&dir";
      this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
      // 
      // DlgListaSimple
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 166);
      this.Controls.Add(this.ctAñadir);
      this.Controls.Add(this.btBorrar);
      this.Controls.Add(this.btAñadir);
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.lsLista1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DlgListaSimple";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Lista simple";
      this.Load += new System.EventHandler(this.DlgListaSimple_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btAceptar;
    private System.Windows.Forms.ListBox lsLista1;
    private System.Windows.Forms.TextBox ctAñadir;
    private System.Windows.Forms.Button btBorrar;
    private System.Windows.Forms.Button btAñadir;
  }
}
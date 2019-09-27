namespace CajasDeDialogo
{
  partial class DlgPanelDeDiseño
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
      this.ctAñadir = new System.Windows.Forms.TextBox();
      this.btAñadir = new System.Windows.Forms.Button();
      this.btAceptar = new System.Windows.Forms.Button();
      this.flpLista = new System.Windows.Forms.FlowLayoutPanel();
      this.btBorrar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // ctAñadir
      // 
      this.ctAñadir.Location = new System.Drawing.Point(205, 92);
      this.ctAñadir.Name = "ctAñadir";
      this.ctAñadir.Size = new System.Drawing.Size(75, 20);
      this.ctAñadir.TabIndex = 0;
      // 
      // btAñadir
      // 
      this.btAñadir.Location = new System.Drawing.Point(205, 51);
      this.btAñadir.Name = "btAñadir";
      this.btAñadir.Size = new System.Drawing.Size(75, 23);
      this.btAñadir.TabIndex = 1;
      this.btAñadir.Text = "Aña&dir";
      this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
      // 
      // btAceptar
      // 
      this.btAceptar.Location = new System.Drawing.Point(205, 10);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 2;
      this.btAceptar.Text = "&Aceptar";
      this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
      // 
      // flpLista
      // 
      this.flpLista.AutoScroll = true;
      this.flpLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpLista.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flpLista.Location = new System.Drawing.Point(13, 10);
      this.flpLista.Name = "flpLista";
      this.flpLista.Size = new System.Drawing.Size(176, 143);
      this.flpLista.TabIndex = 4;
      this.flpLista.WrapContents = false;
      // 
      // btBorrar
      // 
      this.btBorrar.Location = new System.Drawing.Point(205, 130);
      this.btBorrar.Name = "btBorrar";
      this.btBorrar.Size = new System.Drawing.Size(75, 23);
      this.btBorrar.TabIndex = 3;
      this.btBorrar.Text = "&Borrar";
      this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
      // 
      // DlgPanelDeDiseño
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 166);
      this.Controls.Add(this.btBorrar);
      this.Controls.Add(this.flpLista);
      this.Controls.Add(this.ctAñadir);
      this.Controls.Add(this.btAñadir);
      this.Controls.Add(this.btAceptar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DlgPanelDeDiseño";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Panel de diseño";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox ctAñadir;
    private System.Windows.Forms.Button btAñadir;
    private System.Windows.Forms.Button btAceptar;
    private System.Windows.Forms.FlowLayoutPanel flpLista;
    private System.Windows.Forms.Button btBorrar;
  }
}
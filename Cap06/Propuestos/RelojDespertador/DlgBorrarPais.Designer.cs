namespace RelojDespertador
{
  partial class DlgBorrarPais
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
      this.btCancelar = new System.Windows.Forms.Button();
      this.btAceptar = new System.Windows.Forms.Button();
      this.lsListaPaises = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btCancelar
      // 
      this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelar.Location = new System.Drawing.Point(250, 43);
      this.btCancelar.Name = "btCancelar";
      this.btCancelar.Size = new System.Drawing.Size(75, 23);
      this.btCancelar.TabIndex = 5;
      this.btCancelar.Text = "Cancelar";
      // 
      // btAceptar
      // 
      this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btAceptar.Location = new System.Drawing.Point(250, 13);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 4;
      this.btAceptar.Text = "Aceptar";
      // 
      // lsListaPaises
      // 
      this.lsListaPaises.FormattingEnabled = true;
      this.lsListaPaises.Location = new System.Drawing.Point(12, 12);
      this.lsListaPaises.Name = "lsListaPaises";
      this.lsListaPaises.Size = new System.Drawing.Size(231, 147);
      this.lsListaPaises.TabIndex = 3;
      // 
      // DlgBorrarPais
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(337, 171);
      this.Controls.Add(this.btCancelar);
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.lsListaPaises);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "DlgBorrarPais";
      this.Text = "Borrar país";
      this.Load += new System.EventHandler(this.DlgBorrarPais_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btCancelar;
    private System.Windows.Forms.Button btAceptar;
    internal System.Windows.Forms.ListBox lsListaPaises;
  }
}
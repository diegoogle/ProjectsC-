namespace CajasDeDialogo
{
  partial class DlgPalabraDePaso
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
      this.ctPalabraDePaso = new System.Windows.Forms.TextBox();
      this.etPalabraDePaso = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btCancelar
      // 
      this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelar.Location = new System.Drawing.Point(154, 114);
      this.btCancelar.Name = "btCancelar";
      this.btCancelar.Size = new System.Drawing.Size(71, 23);
      this.btCancelar.TabIndex = 7;
      this.btCancelar.Text = "&Cancelar";
      // 
      // btAceptar
      // 
      this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btAceptar.Location = new System.Drawing.Point(69, 114);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(71, 23);
      this.btAceptar.TabIndex = 6;
      this.btAceptar.Text = "&Aceptar";
      // 
      // ctPalabraDePaso
      // 
      this.ctPalabraDePaso.Location = new System.Drawing.Point(69, 70);
      this.ctPalabraDePaso.Name = "ctPalabraDePaso";
      this.ctPalabraDePaso.PasswordChar = '*';
      this.ctPalabraDePaso.Size = new System.Drawing.Size(156, 20);
      this.ctPalabraDePaso.TabIndex = 5;
      // 
      // etPalabraDePaso
      // 
      this.etPalabraDePaso.AutoSize = true;
      this.etPalabraDePaso.Location = new System.Drawing.Point(69, 32);
      this.etPalabraDePaso.Name = "etPalabraDePaso";
      this.etPalabraDePaso.Size = new System.Drawing.Size(150, 13);
      this.etPalabraDePaso.TabIndex = 4;
      this.etPalabraDePaso.Text = "Introduzca la palabra de paso:";
      // 
      // DlgPalabraDePaso
      // 
      this.AcceptButton = this.btAceptar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btCancelar;
      this.ClientSize = new System.Drawing.Size(294, 168);
      this.ControlBox = false;
      this.Controls.Add(this.btCancelar);
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.ctPalabraDePaso);
      this.Controls.Add(this.etPalabraDePaso);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "DlgPalabraDePaso";
      this.Text = "Palabra de paso";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btCancelar;
    private System.Windows.Forms.Button btAceptar;
    internal System.Windows.Forms.TextBox ctPalabraDePaso;
    private System.Windows.Forms.Label etPalabraDePaso;
  }
}
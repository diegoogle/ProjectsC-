namespace CajasDeDialogo
{
  partial class DlgCasillaVerificacion
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
      this.cvConverMayus = new System.Windows.Forms.CheckBox();
      this.ctTexto = new System.Windows.Forms.TextBox();
      this.btAceptar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cvConverMayus
      // 
      this.cvConverMayus.AutoSize = true;
      this.cvConverMayus.Location = new System.Drawing.Point(29, 91);
      this.cvConverMayus.Name = "cvConverMayus";
      this.cvConverMayus.Size = new System.Drawing.Size(135, 17);
      this.cvConverMayus.TabIndex = 3;
      this.cvConverMayus.Text = "&Convertir a mayúsculas";
      this.cvConverMayus.ThreeState = true;
      this.cvConverMayus.CheckedChanged += new System.EventHandler(this.cvConverMayus_CheckedChanged);
      this.cvConverMayus.Click += new System.EventHandler(this.cvConverMayus_Click);
      // 
      // ctTexto
      // 
      this.ctTexto.Location = new System.Drawing.Point(29, 48);
      this.ctTexto.Name = "ctTexto";
      this.ctTexto.Size = new System.Drawing.Size(234, 20);
      this.ctTexto.TabIndex = 2;
      this.ctTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctTexto_KeyPress);
      // 
      // btAceptar
      // 
      this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btAceptar.Location = new System.Drawing.Point(205, 131);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 4;
      this.btAceptar.Text = "&Aceptar";
      this.btAceptar.UseVisualStyleBackColor = true;
      // 
      // DlgCasillaVerificacion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 166);
      this.ControlBox = false;
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.cvConverMayus);
      this.Controls.Add(this.ctTexto);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "DlgCasillaVerificacion";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Casilla de verificación";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cvConverMayus;
    private System.Windows.Forms.TextBox ctTexto;
    private System.Windows.Forms.Button btAceptar;
  }
}
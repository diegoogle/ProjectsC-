namespace RelojDespertador
{
  partial class DlgAgregarPais
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
      this.cvPosNeg = new System.Windows.Forms.CheckBox();
      this.ctDifHoraria = new System.Windows.Forms.MaskedTextBox();
      this.btCancelar = new System.Windows.Forms.Button();
      this.etSigno = new System.Windows.Forms.Label();
      this.etDifHoraria = new System.Windows.Forms.Label();
      this.btAceptar = new System.Windows.Forms.Button();
      this.ctPais = new System.Windows.Forms.TextBox();
      this.etPais = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cvPosNeg
      // 
      this.cvPosNeg.AutoSize = true;
      this.cvPosNeg.Location = new System.Drawing.Point(229, 56);
      this.cvPosNeg.Name = "cvPosNeg";
      this.cvPosNeg.Size = new System.Drawing.Size(69, 17);
      this.cvPosNeg.TabIndex = 10;
      this.cvPosNeg.Text = "Negativo";
      // 
      // ctDifHoraria
      // 
      this.ctDifHoraria.Location = new System.Drawing.Point(119, 57);
      this.ctDifHoraria.Mask = "00:00:00";
      this.ctDifHoraria.Name = "ctDifHoraria";
      this.ctDifHoraria.PromptChar = '*';
      this.ctDifHoraria.ResetOnPrompt = false;
      this.ctDifHoraria.Size = new System.Drawing.Size(67, 20);
      this.ctDifHoraria.TabIndex = 9;
      this.ctDifHoraria.Text = "000000";
      this.ctDifHoraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btCancelar
      // 
      this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelar.Location = new System.Drawing.Point(312, 55);
      this.btCancelar.Name = "btCancelar";
      this.btCancelar.Size = new System.Drawing.Size(75, 23);
      this.btCancelar.TabIndex = 12;
      this.btCancelar.Text = "Cancelar";
      // 
      // etSigno
      // 
      this.etSigno.AutoSize = true;
      this.etSigno.Location = new System.Drawing.Point(193, 57);
      this.etSigno.Name = "etSigno";
      this.etSigno.Size = new System.Drawing.Size(37, 13);
      this.etSigno.TabIndex = 15;
      this.etSigno.Text = "Signo:";
      // 
      // etDifHoraria
      // 
      this.etDifHoraria.AutoSize = true;
      this.etDifHoraria.Location = new System.Drawing.Point(16, 58);
      this.etDifHoraria.Name = "etDifHoraria";
      this.etDifHoraria.Size = new System.Drawing.Size(93, 13);
      this.etDifHoraria.TabIndex = 14;
      this.etDifHoraria.Text = "Diferencia horaria:";
      // 
      // btAceptar
      // 
      this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btAceptar.Location = new System.Drawing.Point(312, 23);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 11;
      this.btAceptar.Text = "Aceptar";
      // 
      // ctPais
      // 
      this.ctPais.Location = new System.Drawing.Point(52, 25);
      this.ctPais.Name = "ctPais";
      this.ctPais.Size = new System.Drawing.Size(247, 20);
      this.ctPais.TabIndex = 8;
      // 
      // etPais
      // 
      this.etPais.AutoSize = true;
      this.etPais.Location = new System.Drawing.Point(16, 24);
      this.etPais.Name = "etPais";
      this.etPais.Size = new System.Drawing.Size(32, 13);
      this.etPais.TabIndex = 13;
      this.etPais.Text = "País:";
      // 
      // DlgAgregarPais
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(402, 101);
      this.Controls.Add(this.cvPosNeg);
      this.Controls.Add(this.ctDifHoraria);
      this.Controls.Add(this.btCancelar);
      this.Controls.Add(this.etSigno);
      this.Controls.Add(this.etDifHoraria);
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.ctPais);
      this.Controls.Add(this.etPais);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "DlgAgregarPais";
      this.Text = "Añadir país";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.CheckBox cvPosNeg;
    internal System.Windows.Forms.MaskedTextBox ctDifHoraria;
    private System.Windows.Forms.Button btCancelar;
    private System.Windows.Forms.Label etSigno;
    private System.Windows.Forms.Label etDifHoraria;
    private System.Windows.Forms.Button btAceptar;
    internal System.Windows.Forms.TextBox ctPais;
    private System.Windows.Forms.Label etPais;
  }
}
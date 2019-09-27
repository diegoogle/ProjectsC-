namespace Conver2
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.etGradosC = new System.Windows.Forms.Label();
      this.ctGradosC = new System.Windows.Forms.TextBox();
      this.etGradosF = new System.Windows.Forms.Label();
      this.ctGradosF = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // etGradosC
      // 
      this.etGradosC.AutoSize = true;
      this.etGradosC.Location = new System.Drawing.Point(12, 40);
      this.etGradosC.Name = "etGradosC";
      this.etGradosC.Size = new System.Drawing.Size(104, 13);
      this.etGradosC.TabIndex = 3;
      this.etGradosC.Text = "Grados centígrados:";
      // 
      // ctGradosC
      // 
      this.ctGradosC.Location = new System.Drawing.Point(123, 37);
      this.ctGradosC.Name = "ctGradosC";
      this.ctGradosC.Size = new System.Drawing.Size(197, 20);
      this.ctGradosC.TabIndex = 0;
      this.ctGradosC.Text = "0.00";
      this.ctGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.ctGradosC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
      this.ctGradosC.Enter += new System.EventHandler(this.CajaTexto_Enter);
      this.ctGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaTexto_KeyPress);
      // 
      // etGradosF
      // 
      this.etGradosF.AutoSize = true;
      this.etGradosF.Location = new System.Drawing.Point(12, 81);
      this.etGradosF.Name = "etGradosF";
      this.etGradosF.Size = new System.Drawing.Size(97, 13);
      this.etGradosF.TabIndex = 4;
      this.etGradosF.Text = "Grados Fahrenheit:";
      // 
      // ctGradosF
      // 
      this.ctGradosF.Location = new System.Drawing.Point(123, 78);
      this.ctGradosF.Name = "ctGradosF";
      this.ctGradosF.Size = new System.Drawing.Size(197, 20);
      this.ctGradosF.TabIndex = 1;
      this.ctGradosF.Text = "32.00";
      this.ctGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.ctGradosF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
      this.ctGradosF.Enter += new System.EventHandler(this.CajaTexto_Enter);
      this.ctGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaTexto_KeyPress);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(332, 137);
      this.Controls.Add(this.ctGradosF);
      this.Controls.Add(this.etGradosF);
      this.Controls.Add(this.ctGradosC);
      this.Controls.Add(this.etGradosC);
      this.Name = "Form1";
      this.Text = "Conversión de temperaturas";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label etGradosC;
    private System.Windows.Forms.TextBox ctGradosC;
    private System.Windows.Forms.Label etGradosF;
    private System.Windows.Forms.TextBox ctGradosF;
  }
}


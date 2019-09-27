namespace Test
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
      this.btCalcular = new System.Windows.Forms.Button();
      this.TextBoxEx3 = new TextBoxEx.TextBoxEx();
      this.TextBoxEx2 = new TextBoxEx.TextBoxEx();
      this.TextBoxEx1 = new TextBoxEx.TextBoxEx();
      this.SuspendLayout();
      // 
      // btCalcular
      // 
      this.btCalcular.Location = new System.Drawing.Point(29, 131);
      this.btCalcular.Name = "btCalcular";
      this.btCalcular.Size = new System.Drawing.Size(234, 23);
      this.btCalcular.TabIndex = 8;
      this.btCalcular.Text = "Calcular";
      this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
      // 
      // TextBoxEx3
      // 
      this.TextBoxEx3.AplicarColorFoco = false;
      this.TextBoxEx3.ColorControlDesenfocado = System.Drawing.Color.White;
      this.TextBoxEx3.ColorControlEnfocado = System.Drawing.Color.LightCyan;
      this.TextBoxEx3.Location = new System.Drawing.Point(29, 90);
      this.TextBoxEx3.Name = "TextBoxEx3";
      this.TextBoxEx3.ReadOnly = true;
      this.TextBoxEx3.Size = new System.Drawing.Size(234, 20);
      this.TextBoxEx3.TabIndex = 11;
      // 
      // TextBoxEx2
      // 
      this.TextBoxEx2.AplicarColorFoco = true;
      this.TextBoxEx2.ColorControlDesenfocado = System.Drawing.Color.White;
      this.TextBoxEx2.ColorControlEnfocado = System.Drawing.Color.LightCyan;
      this.TextBoxEx2.Location = new System.Drawing.Point(29, 52);
      this.TextBoxEx2.Name = "TextBoxEx2";
      this.TextBoxEx2.Size = new System.Drawing.Size(234, 20);
      this.TextBoxEx2.TabIndex = 10;
      // 
      // TextBoxEx1
      // 
      this.TextBoxEx1.AplicarColorFoco = true;
      this.TextBoxEx1.ColorControlDesenfocado = System.Drawing.Color.White;
      this.TextBoxEx1.ColorControlEnfocado = System.Drawing.Color.LightCyan;
      this.TextBoxEx1.Location = new System.Drawing.Point(29, 25);
      this.TextBoxEx1.Name = "TextBoxEx1";
      this.TextBoxEx1.Size = new System.Drawing.Size(234, 20);
      this.TextBoxEx1.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 176);
      this.Controls.Add(this.TextBoxEx3);
      this.Controls.Add(this.TextBoxEx2);
      this.Controls.Add(this.TextBoxEx1);
      this.Controls.Add(this.btCalcular);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btCalcular;
    private TextBoxEx.TextBoxEx TextBoxEx1;
    private TextBoxEx.TextBoxEx TextBoxEx2;
    private TextBoxEx.TextBoxEx TextBoxEx3;
  }
}


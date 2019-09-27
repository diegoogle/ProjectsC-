namespace Test
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
      this.btCalcular.TabIndex = 7;
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
      this.TextBoxEx3.TabIndex = 6;
      // 
      // TextBoxEx2
      // 
      this.TextBoxEx2.AplicarColorFoco = true;
      this.TextBoxEx2.ColorControlDesenfocado = System.Drawing.Color.White;
      this.TextBoxEx2.ColorControlEnfocado = System.Drawing.Color.LightCyan;
      this.TextBoxEx2.Location = new System.Drawing.Point(29, 49);
      this.TextBoxEx2.Name = "TextBoxEx2";
      this.TextBoxEx2.Size = new System.Drawing.Size(234, 20);
      this.TextBoxEx2.TabIndex = 5;
      // 
      // TextBoxEx1
      // 
      this.TextBoxEx1.AplicarColorFoco = true;
      this.TextBoxEx1.ColorControlDesenfocado = System.Drawing.Color.White;
      this.TextBoxEx1.ColorControlEnfocado = System.Drawing.Color.LightCyan;
      this.TextBoxEx1.Location = new System.Drawing.Point(29, 23);
      this.TextBoxEx1.Name = "TextBoxEx1";
      this.TextBoxEx1.Size = new System.Drawing.Size(234, 20);
      this.TextBoxEx1.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 176);
      this.Controls.Add(this.btCalcular);
      this.Controls.Add(this.TextBoxEx3);
      this.Controls.Add(this.TextBoxEx2);
      this.Controls.Add(this.TextBoxEx1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button btCalcular;
    internal TextBoxEx.TextBoxEx TextBoxEx3;
    internal TextBoxEx.TextBoxEx TextBoxEx2;
    internal TextBoxEx.TextBoxEx TextBoxEx1;

  }
}


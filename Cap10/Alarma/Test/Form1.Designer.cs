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
      this.etEstadoAlarma = new System.Windows.Forms.Label();
      this.btAlarma = new System.Windows.Forms.Button();
      this.Alarma1 = new Alarma.Alarma();
      this.SuspendLayout();
      // 
      // etEstadoAlarma
      // 
      this.etEstadoAlarma.AutoSize = true;
      this.etEstadoAlarma.ForeColor = System.Drawing.Color.Blue;
      this.etEstadoAlarma.Location = new System.Drawing.Point(57, 114);
      this.etEstadoAlarma.Name = "etEstadoAlarma";
      this.etEstadoAlarma.Size = new System.Drawing.Size(88, 13);
      this.etEstadoAlarma.TabIndex = 1;
      this.etEstadoAlarma.Text = "Alarma desactiva";
      // 
      // btAlarma
      // 
      this.btAlarma.Location = new System.Drawing.Point(57, 141);
      this.btAlarma.Name = "btAlarma";
      this.btAlarma.Size = new System.Drawing.Size(178, 23);
      this.btAlarma.TabIndex = 2;
      this.btAlarma.Text = "Activar alarma";
      this.btAlarma.UseVisualStyleBackColor = true;
      this.btAlarma.Click += new System.EventHandler(this.btAlarma_Click);
      // 
      // Alarma1
      // 
      this.Alarma1.FechaHoraAlarma = new System.DateTime(((long)(0)));
      this.Alarma1.Location = new System.Drawing.Point(57, 25);
      this.Alarma1.Name = "Alarma1";
      this.Alarma1.Size = new System.Drawing.Size(178, 85);
      this.Alarma1.TabIndex = 0;
      this.Alarma1.TiempoAgotado += new Alarma.TiempoAgotadoEventHandler(this.Alarma1_TiempoAgotado);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 192);
      this.Controls.Add(this.btAlarma);
      this.Controls.Add(this.etEstadoAlarma);
      this.Controls.Add(this.Alarma1);
      this.Name = "Form1";
      this.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Text = "Alarma";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Alarma.Alarma Alarma1;
    private System.Windows.Forms.Label etEstadoAlarma;
    private System.Windows.Forms.Button btAlarma;
  }
}


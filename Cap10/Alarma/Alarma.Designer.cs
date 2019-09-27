namespace Alarma
{
  partial class Alarma
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.boFechaHoraActual = new System.Windows.Forms.RadioButton();
      this.boFechaHoraAlarma = new System.Windows.Forms.RadioButton();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.ctAlarma = new System.Windows.Forms.MaskedTextBox();
      this.SuspendLayout();
      // 
      // boFechaHoraActual
      // 
      this.boFechaHoraActual.AutoSize = true;
      this.boFechaHoraActual.Location = new System.Drawing.Point(3, 62);
      this.boFechaHoraActual.Name = "boFechaHoraActual";
      this.boFechaHoraActual.Size = new System.Drawing.Size(111, 17);
      this.boFechaHoraActual.TabIndex = 6;
      this.boFechaHoraActual.Text = "Fecha-hora actual";
      this.boFechaHoraActual.CheckedChanged += new System.EventHandler(this.boFechaHoraActual_CheckedChanged);
      // 
      // boFechaHoraAlarma
      // 
      this.boFechaHoraAlarma.AutoSize = true;
      this.boFechaHoraAlarma.Checked = true;
      this.boFechaHoraAlarma.Location = new System.Drawing.Point(3, 39);
      this.boFechaHoraAlarma.Name = "boFechaHoraAlarma";
      this.boFechaHoraAlarma.Size = new System.Drawing.Size(113, 17);
      this.boFechaHoraAlarma.TabIndex = 5;
      this.boFechaHoraAlarma.TabStop = true;
      this.boFechaHoraAlarma.Text = "Fecha-hora alarma";
      this.boFechaHoraAlarma.CheckedChanged += new System.EventHandler(this.boFechaHoraAlarma_CheckedChanged);
      // 
      // Timer1
      // 
      this.Timer1.Interval = 1000;
      this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // ctAlarma
      // 
      this.ctAlarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctAlarma.Location = new System.Drawing.Point(3, 6);
      this.ctAlarma.Mask = "00/00/0000 90:00:00";
      this.ctAlarma.Name = "ctAlarma";
      this.ctAlarma.Size = new System.Drawing.Size(173, 28);
      this.ctAlarma.TabIndex = 4;
      // 
      // Alarma
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.boFechaHoraActual);
      this.Controls.Add(this.boFechaHoraAlarma);
      this.Controls.Add(this.ctAlarma);
      this.Name = "Alarma";
      this.Size = new System.Drawing.Size(178, 85);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton boFechaHoraActual;
    private System.Windows.Forms.RadioButton boFechaHoraAlarma;
    private System.Windows.Forms.Timer Timer1;
    private System.Windows.Forms.MaskedTextBox ctAlarma;
  }
}

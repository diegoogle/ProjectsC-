﻿namespace CajasDeDialogo
{
  partial class DlgTemporizador
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
      this.components = new System.ComponentModel.Container();
      this.etHora = new System.Windows.Forms.Label();
      this.Temporizador = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // etHora
      // 
      this.etHora.AutoSize = true;
      this.etHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.etHora.Location = new System.Drawing.Point(64, 97);
      this.etHora.Name = "etHora";
      this.etHora.Size = new System.Drawing.Size(164, 42);
      this.etHora.TabIndex = 1;
      this.etHora.Text = "00:00:00";
      // 
      // Temporizador
      // 
      this.Temporizador.Enabled = true;
      this.Temporizador.Interval = 1000;
      this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
      // 
      // DlgTemporizador
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 236);
      this.Controls.Add(this.etHora);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DlgTemporizador";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Temporizador";
      this.Load += new System.EventHandler(this.DlgTemporizador_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label etHora;
    private System.Windows.Forms.Timer Temporizador;
  }
}
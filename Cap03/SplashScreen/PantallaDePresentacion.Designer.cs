﻿namespace ApWinForms
{
  partial class PantallaDePresentacion
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
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 142);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(526, 42);
      this.label1.TabIndex = 0;
      this.label1.Text = "La aplicación se está iniciando";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::ApWinForms.Properties.Resources.ImagenSplash;
      this.pictureBox1.Location = new System.Drawing.Point(536, 149);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(34, 35);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // PantallaDePresentacion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 357);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Name = "PantallaDePresentacion";
      this.Text = "Pantalla de presentacion";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}
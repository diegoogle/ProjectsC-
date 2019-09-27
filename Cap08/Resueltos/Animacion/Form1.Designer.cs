namespace Animacion
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
      this.components = new System.ComponentModel.Container();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.PictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // Timer1
      // 
      this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // PictureBox1
      // 
      this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.PictureBox1.BackColor = System.Drawing.Color.White;
      this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PictureBox1.Location = new System.Drawing.Point(13, 13);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new System.Drawing.Size(387, 241);
      this.PictureBox1.TabIndex = 1;
      this.PictureBox1.TabStop = false;
      this.PictureBox1.SizeChanged += new System.EventHandler(this.PictureBox1_SizeChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(412, 266);
      this.Controls.Add(this.PictureBox1);
      this.Name = "Form1";
      this.Text = "Animación";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer Timer1;
    private System.Windows.Forms.PictureBox PictureBox1;
  }
}


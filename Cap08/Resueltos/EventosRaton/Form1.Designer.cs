namespace EventosRaton
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
      this.PictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // PictureBox1
      // 
      this.PictureBox1.BackColor = System.Drawing.Color.White;
      this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PictureBox1.Location = new System.Drawing.Point(13, 13);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new System.Drawing.Size(387, 241);
      this.PictureBox1.TabIndex = 1;
      this.PictureBox1.TabStop = false;
      this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
      this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
      this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(412, 266);
      this.Controls.Add(this.PictureBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox PictureBox1;
  }
}


namespace ApSincronismo
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
      this.btIniciarHilo = new System.Windows.Forms.Button();
      this.lsHilos = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btIniciarHilo
      // 
      this.btIniciarHilo.Location = new System.Drawing.Point(13, 231);
      this.btIniciarHilo.Name = "btIniciarHilo";
      this.btIniciarHilo.Size = new System.Drawing.Size(267, 23);
      this.btIniciarHilo.TabIndex = 3;
      this.btIniciarHilo.Text = "Iniciar un hilo";
      this.btIniciarHilo.UseVisualStyleBackColor = true;
      this.btIniciarHilo.Click += new System.EventHandler(this.btIniciarHilo_Click);
      // 
      // lsHilos
      // 
      this.lsHilos.FormattingEnabled = true;
      this.lsHilos.Location = new System.Drawing.Point(13, 13);
      this.lsHilos.Name = "lsHilos";
      this.lsHilos.Size = new System.Drawing.Size(267, 212);
      this.lsHilos.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.btIniciarHilo);
      this.Controls.Add(this.lsHilos);
      this.Name = "Form1";
      this.Text = "Sincronización de hilos";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btIniciarHilo;
    private System.Windows.Forms.ListBox lsHilos;
  }
}


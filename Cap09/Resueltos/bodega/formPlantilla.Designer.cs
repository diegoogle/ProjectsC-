namespace bodega
{
  partial class formPlantilla
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
      this.btAceptar = new System.Windows.Forms.Button();
      this.btCancelar = new System.Windows.Forms.Button();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btAceptar
      // 
      this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btAceptar.BackColor = System.Drawing.SystemColors.Control;
      this.btAceptar.Location = new System.Drawing.Point(238, 243);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 7;
      this.btAceptar.Text = "Aceptar";
      this.btAceptar.UseVisualStyleBackColor = false;
      this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
      // 
      // btCancelar
      // 
      this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btCancelar.BackColor = System.Drawing.SystemColors.Control;
      this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelar.Location = new System.Drawing.Point(328, 243);
      this.btCancelar.Name = "btCancelar";
      this.btCancelar.Size = new System.Drawing.Size(75, 23);
      this.btCancelar.TabIndex = 6;
      this.btCancelar.Text = "Cancelar";
      this.btCancelar.UseVisualStyleBackColor = false;
      this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
      // 
      // GroupBox1
      // 
      this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.GroupBox1.Location = new System.Drawing.Point(14, 38);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new System.Drawing.Size(389, 199);
      this.GroupBox1.TabIndex = 5;
      this.GroupBox1.TabStop = false;
      // 
      // Label1
      // 
      this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.Label1.Location = new System.Drawing.Point(14, 11);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(389, 23);
      this.Label1.TabIndex = 4;
      this.Label1.Text = "Label1";
      // 
      // formPlantilla
      // 
      this.AcceptButton = this.btAceptar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.CancelButton = this.btCancelar;
      this.ClientSize = new System.Drawing.Size(417, 276);
      this.ControlBox = false;
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.btCancelar);
      this.Controls.Add(this.GroupBox1);
      this.Controls.Add(this.Label1);
      this.Name = "formPlantilla";
      this.Text = "formPlantilla";
      this.ResumeLayout(false);

    }

    #endregion

    protected System.Windows.Forms.Button btAceptar;
    protected System.Windows.Forms.Button btCancelar;
    protected System.Windows.Forms.GroupBox GroupBox1;
    protected System.Windows.Forms.Label Label1;
  }
}
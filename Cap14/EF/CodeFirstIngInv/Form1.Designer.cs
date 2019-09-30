namespace CodeFirstIngInv
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
      this.flpLista = new System.Windows.Forms.FlowLayoutPanel();
      this.SuspendLayout();
      // 
      // flpLista
      // 
      this.flpLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flpLista.AutoScroll = true;
      this.flpLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpLista.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flpLista.Location = new System.Drawing.Point(12, 12);
      this.flpLista.Name = "flpLista";
      this.flpLista.Size = new System.Drawing.Size(258, 233);
      this.flpLista.TabIndex = 0;
      this.flpLista.WrapContents = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 257);
      this.Controls.Add(this.flpLista);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flpLista;
  }
}


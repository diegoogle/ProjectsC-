namespace ProbarConexion
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
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
      this.tbVersion = new System.Windows.Forms.Label();
      this.tbEstadoConexion = new System.Windows.Forms.Label();
      this.btMostrarDatos = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tbVersion
      // 
      this.tbVersion.AutoSize = true;
      this.tbVersion.Location = new System.Drawing.Point(32, 29);
      this.tbVersion.Name = "tbVersion";
      this.tbVersion.Size = new System.Drawing.Size(42, 13);
      this.tbVersion.TabIndex = 0;
      this.tbVersion.Text = "Versión";
      // 
      // tbEstadoConexion
      // 
      this.tbEstadoConexion.AutoSize = true;
      this.tbEstadoConexion.Location = new System.Drawing.Point(32, 61);
      this.tbEstadoConexion.Name = "tbEstadoConexion";
      this.tbEstadoConexion.Size = new System.Drawing.Size(86, 13);
      this.tbEstadoConexion.TabIndex = 0;
      this.tbEstadoConexion.Text = "Estado conexión";
      // 
      // btMostrarDatos
      // 
      this.btMostrarDatos.Location = new System.Drawing.Point(35, 123);
      this.btMostrarDatos.Name = "btMostrarDatos";
      this.btMostrarDatos.Size = new System.Drawing.Size(212, 23);
      this.btMostrarDatos.TabIndex = 1;
      this.btMostrarDatos.Text = "Mostrar datos";
      this.btMostrarDatos.UseVisualStyleBackColor = true;
      this.btMostrarDatos.Click += new System.EventHandler(this.btMostrarDatos_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 157);
      this.Controls.Add(this.btMostrarDatos);
      this.Controls.Add(this.tbEstadoConexion);
      this.Controls.Add(this.tbVersion);
      this.Name = "Form1";
      this.Text = "Probar conexión";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label tbVersion;
    private System.Windows.Forms.Label tbEstadoConexion;
    private System.Windows.Forms.Button btMostrarDatos;
  }
}


namespace EnlaceDatosNET
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
      this.label1 = new System.Windows.Forms.Label();
      this.ctNombre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ctTfno = new System.Windows.Forms.TextBox();
      this.btDatosObj = new System.Windows.Forms.Button();
      this.btModificarObj = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre:";
      // 
      // ctNombre
      // 
      this.ctNombre.Location = new System.Drawing.Point(67, 26);
      this.ctNombre.Name = "ctNombre";
      this.ctNombre.Size = new System.Drawing.Size(203, 20);
      this.ctNombre.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Teléfono";
      // 
      // ctTfno
      // 
      this.ctTfno.Location = new System.Drawing.Point(67, 65);
      this.ctTfno.Name = "ctTfno";
      this.ctTfno.Size = new System.Drawing.Size(203, 20);
      this.ctTfno.TabIndex = 3;
      // 
      // btDatosObj
      // 
      this.btDatosObj.Location = new System.Drawing.Point(15, 110);
      this.btDatosObj.Name = "btDatosObj";
      this.btDatosObj.Size = new System.Drawing.Size(255, 22);
      this.btDatosObj.TabIndex = 4;
      this.btDatosObj.Text = "Datos del objeto subyacente";
      this.btDatosObj.UseVisualStyleBackColor = true;
      this.btDatosObj.Click += new System.EventHandler(this.btDatosObj_Click);
      // 
      // btModificarObj
      // 
      this.btModificarObj.Location = new System.Drawing.Point(15, 138);
      this.btModificarObj.Name = "btModificarObj";
      this.btModificarObj.Size = new System.Drawing.Size(255, 22);
      this.btModificarObj.TabIndex = 4;
      this.btModificarObj.Text = "Modificar objeto subyacente";
      this.btModificarObj.UseVisualStyleBackColor = true;
      this.btModificarObj.Click += new System.EventHandler(this.btModificarObj_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 179);
      this.Controls.Add(this.btModificarObj);
      this.Controls.Add(this.btDatosObj);
      this.Controls.Add(this.ctTfno);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ctNombre);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Enlace de datos";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ctNombre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ctTfno;
    private System.Windows.Forms.Button btDatosObj;
    private System.Windows.Forms.Button btModificarObj;
  }
}


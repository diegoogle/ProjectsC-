namespace CajasDeDialogo
{
  partial class DlgGestionFechas
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
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.etMensaje = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.Location = new System.Drawing.Point(18, 68);
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.TabIndex = 0;
      this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(17, 13);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(248, 20);
      this.dateTimePicker1.TabIndex = 1;
      // 
      // etMensaje
      // 
      this.etMensaje.AutoSize = true;
      this.etMensaje.ForeColor = System.Drawing.Color.Red;
      this.etMensaje.Location = new System.Drawing.Point(15, 46);
      this.etMensaje.Name = "etMensaje";
      this.etMensaje.Size = new System.Drawing.Size(0, 13);
      this.etMensaje.TabIndex = 2;
      // 
      // DlgGestionFechas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 277);
      this.Controls.Add(this.etMensaje);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.monthCalendar1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DlgGestionFechas";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Gestión de fechas";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MonthCalendar monthCalendar1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label etMensaje;
  }
}
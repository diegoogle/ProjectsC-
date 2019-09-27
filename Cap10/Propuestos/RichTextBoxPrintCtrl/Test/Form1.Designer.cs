namespace Test
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
      this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
      this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
      this.RichTextBoxPrintCtrl1 = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
      this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
      this.btVistaPre = new System.Windows.Forms.Button();
      this.btConfigurarPag = new System.Windows.Forms.Button();
      this.btImprimir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PageSetupDialog1
      // 
      this.PageSetupDialog1.Document = this.PrintDocument1;
      // 
      // PrintDocument1
      // 
      this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
      this.PrintDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_BeginPrint);
      // 
      // PrintDialog1
      // 
      this.PrintDialog1.Document = this.PrintDocument1;
      this.PrintDialog1.UseEXDialog = true;
      // 
      // RichTextBoxPrintCtrl1
      // 
      this.RichTextBoxPrintCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.RichTextBoxPrintCtrl1.Location = new System.Drawing.Point(10, 12);
      this.RichTextBoxPrintCtrl1.Name = "RichTextBoxPrintCtrl1";
      this.RichTextBoxPrintCtrl1.Size = new System.Drawing.Size(380, 242);
      this.RichTextBoxPrintCtrl1.TabIndex = 7;
      this.RichTextBoxPrintCtrl1.Text = "";
      // 
      // PrintPreviewDialog1
      // 
      this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
      this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
      this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
      this.PrintPreviewDialog1.Document = this.PrintDocument1;
      this.PrintPreviewDialog1.Enabled = true;
      this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
      this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
      this.PrintPreviewDialog1.Visible = false;
      // 
      // btVistaPre
      // 
      this.btVistaPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btVistaPre.Location = new System.Drawing.Point(396, 41);
      this.btVistaPre.Name = "btVistaPre";
      this.btVistaPre.Size = new System.Drawing.Size(127, 23);
      this.btVistaPre.TabIndex = 5;
      this.btVistaPre.Text = "Vista preliminar";
      this.btVistaPre.Click += new System.EventHandler(this.btnPrintPreview_Click);
      // 
      // btConfigurarPag
      // 
      this.btConfigurarPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btConfigurarPag.Location = new System.Drawing.Point(396, 12);
      this.btConfigurarPag.Name = "btConfigurarPag";
      this.btConfigurarPag.Size = new System.Drawing.Size(127, 23);
      this.btConfigurarPag.TabIndex = 4;
      this.btConfigurarPag.Text = "Configurar página";
      this.btConfigurarPag.Click += new System.EventHandler(this.btnPageSetup_Click);
      // 
      // btImprimir
      // 
      this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btImprimir.Location = new System.Drawing.Point(396, 70);
      this.btImprimir.Name = "btImprimir";
      this.btImprimir.Size = new System.Drawing.Size(127, 23);
      this.btImprimir.TabIndex = 6;
      this.btImprimir.Text = "Imprimir";
      this.btImprimir.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 266);
      this.Controls.Add(this.RichTextBoxPrintCtrl1);
      this.Controls.Add(this.btVistaPre);
      this.Controls.Add(this.btConfigurarPag);
      this.Controls.Add(this.btImprimir);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PageSetupDialog PageSetupDialog1;
    private System.Drawing.Printing.PrintDocument PrintDocument1;
    private System.Windows.Forms.PrintDialog PrintDialog1;
    private RichTextBoxPrintCtrl.RichTextBoxPrintCtrl RichTextBoxPrintCtrl1;
    private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
    private System.Windows.Forms.Button btVistaPre;
    private System.Windows.Forms.Button btConfigurarPag;
    private System.Windows.Forms.Button btImprimir;
  }
}


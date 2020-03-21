namespace SlideView {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cmdForward = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cmdForward);
            this.panel1.Controls.Add(this.cmdBack);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 437);
            this.panel1.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(760, 437);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // cmdForward
            // 
            this.cmdForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdForward.BackColor = System.Drawing.Color.Transparent;
            this.cmdForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdForward.ForeColor = System.Drawing.Color.White;
            this.cmdForward.Location = new System.Drawing.Point(682, 411);
            this.cmdForward.Name = "cmdForward";
            this.cmdForward.Size = new System.Drawing.Size(75, 23);
            this.cmdForward.TabIndex = 4;
            this.cmdForward.Text = "Forward";
            this.cmdForward.UseVisualStyleBackColor = false;
            this.cmdForward.Click += new System.EventHandler(this.cmdForward_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdBack.BackColor = System.Drawing.Color.Transparent;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBack.ForeColor = System.Drawing.Color.White;
            this.cmdBack.Location = new System.Drawing.Point(3, 411);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 23);
            this.cmdBack.TabIndex = 3;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Slide View";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdForward;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.PictureBox picBox;
    }
}


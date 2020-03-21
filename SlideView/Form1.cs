using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideView {
    public partial class Form1: Form {
        private List<Bitmap> images;
        private string path = @"C:\Users\PREDATOR\Pictures\program\";
        int x =0;
        public Form1 () {
            InitializeComponent();
            searchImages(this.path);
        }
        private void searchImages (string path) {
            try {
                images = new List<Bitmap>();
                if (Directory.Exists(path)) {                    
                    string filters = "*.*";
                    var files = Directory.GetFiles(path, filters, SearchOption.AllDirectories);
                    foreach (var f in files) {
                        images.Add(new Bitmap(f));
                    }
                } else {
                    MessageBox.Show("No existe la ruta!");
                }
                
            } catch (Exception e) {
                throw new ApplicationException(e.Message);
            }
        }

        private void cmdForward_Click (object sender, EventArgs e) {
            if (x > images.Count - 1) {
                x = 0;
            }
            picBox.Image = images[x];
            x++;
            this.Refresh();
        }

        private void cmdBack_Click (object sender, EventArgs e) {
            if (x == 0) {
                x = images.Count-1;
            }
            picBox.Image = images[x];
            x--;
            this.Refresh();
        }
    }
}

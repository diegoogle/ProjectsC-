﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;

namespace ExportToExcel {
    public partial class Form1: Form {
        private List<items> table;
        public Form1 () {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
            fillDataGridView();
            dGridViewTable.DataSource = table;
            this.Show();
        }
        public class items {
            public int id { get; set; }
            public string name { get; set; }
            public string value { get; set; }

            public items (int id, string name, string value) {
                this.id = id;
                this.name = name;
                this.value = value;
            }
        }
        public void fillDataGridView () {
            try {
                table = new List<items>();
                table.Add(new items(1, "Marc", "Double"));
                table.Add(new items(2, "Diane", "Global"));
                table.Add(new items(3, "Bill", "Prestige"));
                table.Add(new items(4, "Tom", "Record"));
            } catch (Exception e) {
                throw new ApplicationException(e.Message);
            }
        }
        public void exportToExcel () {
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("Example");
            //worksheet.Cells[0, 0].Value = "Id";
            //worksheet.Cells[0, 1].Value = "Name";
            //worksheet.Cells[0, 2].Value = "Value";
            for (int i = 0; i < table.Count; i++) {
                worksheet.Cells[i, 0].Value = table[i].id;
                worksheet.Cells[i, 1].Value = table[i].name;
                worksheet.Cells[i, 2].Value = table[i].value;
            }           
            workbook.Save("C:\\Users\\PREDATOR\\Documents\\Example.xlsx");
            workbook.Save("C:\\Users\\PREDATOR\\Documents\\Example.Pdf");
            workbook.Save("C:\\Users\\PREDATOR\\Documents\\Example.Jpg");
            //ExcelFile.Load("Example.xlsx");

            Console.WriteLine("Finished!!");
        }

        private void cmdExport_Click (object sender, EventArgs e) {
            exportToExcel();
        }

        private void button1_Click (object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Imagen jpg|*.jpg";
            sfd.ShowDialog();            
            if (sfd.FileName != "") {
                Bitmap bmp = new Bitmap(dGridViewTable.Width, dGridViewTable.Height);
                dGridViewTable.DrawToBitmap(bmp, new Rectangle(0, 0, dGridViewTable.Width, dGridViewTable.Height));
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                fs.Close();
                bmp.Dispose();
            }
        }
    }
}

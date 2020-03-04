using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Monitor {
    public class Log {
        private string path = "";        
        public Log(string path) {
            this.path = path;
        }
        public void Add(string sLog) {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";
            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(path + "/" + nombre, true);//True es para anexar linea nueva
            sw.Write(cadena);
            sw.Close();
        }
        #region HELPER
        private string GetNameFile() {
            string nombre = "";
            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".log";
            return nombre;
        }
        private void CreateDirectory() {
            try {
                if (Directory.Exists(path))//Comprueba si existe el directorio
                    Directory.CreateDirectory(path);
            } catch (DirectoryNotFoundException e) {
                throw new Exception(e.Message);
            }            
        }
        #endregion
    }
}

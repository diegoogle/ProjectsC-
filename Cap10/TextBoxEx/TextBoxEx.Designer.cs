﻿namespace TextBoxEx
{
    partial class TextBoxEx
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.SuspendLayout();
      // 
      // TextBoxEx
      // 
      this.Enter += new System.EventHandler(this.TextBoxEx_Enter);
      this.Leave += new System.EventHandler(this.TextBoxEx_Leave);
      this.ResumeLayout(false);

        }

        #endregion
    }
}

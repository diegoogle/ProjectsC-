using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelojDespertador
{
  public partial class Form1 : Form
  {
    private bool DespertadorActivado = false;

    public Form1()
    {
      InitializeComponent();
    }

    private void ArchivoSalir_Click(System.Object sender, System.EventArgs e)
    {
      this.Close();
    }

    private void Temporizador_Elapsed(System.Object sender, System.Timers.ElapsedEventArgs e)
    {
      ctHora.Text = DateTime.Now.ToLongTimeString();
      ctHoraPais.Text = DateTime.Now.ToLongTimeString();

      // Un tick (paso) = 100 nanosegundos
      long horaActual = DateTime.Now.TimeOfDay.Ticks / 10000000L;
      long horaDespertador = ObtenerHoraDespertador() / 10000000L;

      //Debug.WriteLine(horaActual)
      //Debug.WriteLine(horaDespertador)

      if (DespertadorActivado && horaDespertador != -1)
      {
        if (horaActual < horaDespertador)
        {
          // Aun no ha llegado la hora de la alarma,
          // pero hay un caso especial en el que debe
          // sonar: acaba de ser medianoche, estamos en
          // los primeros minutos del día y la alarma
          // estaba puesta en los últimos minutos de ayer.
          if (horaDespertador - horaActual > 86400 - 300)
          {
            Console.Beep();
          }
        }
        else
        {
          // La hora de la alarma ya ha pasado. Si hace mas
          // de cinco minutos, NO debe sonar. Si aun no han
          // transcurrido los cinco minutos, SI debe sonar.
          if (horaActual - horaDespertador < 300)
          {
            Console.Beep();
          }
        }
      }
    }

    private long ObtenerHora(MaskedTextBox cajaTexto)
    {
      // Obtener la hora de una caja de texto MaskedTextBox.
      // Si no se introducen al menos horas:minutos,
      // la función devolverá -1.
      char delim = ':';
      string[] hms;
      hms = cajaTexto.Text.Split(delim);
      if (hms.Length < 2) return -1;
      int horas = int.Parse(hms[0]);
      int minutos;
      int segundos;
      if (hms[1].Length != 0)
      {
        minutos = int.Parse(hms[1]);
      }
      else
      {
        minutos = 0;
      }
      if (hms.Length > 2 && hms[2].Length != 0)
      {
        segundos = int.Parse(hms[2]);
      }
      else
      {
        segundos = 0;
      }

      // Si la hora no es válida, la función devolverá -1
      if (horas < 0 || horas > 23 || minutos < 0 || minutos > 59 || segundos < 0 || segundos > 59)
      {
        return -1; // hora no válida
      }
      return new TimeSpan(horas, minutos, segundos).Ticks; // hora válida
    }

    private long ObtenerHoraDespertador()
    {
      // Obtener la hora del despertador en segundos.
      // Si no se introducen al menos horas:minutos,
      // la función devolverá -1
      return ObtenerHora(ctDespertador); // ticks
    }

    private void DespertadorActivar_Click(System.Object sender, System.EventArgs e)
    {
      if (!DespertadorActivado)
      {
        DespertadorActivar.Text = "Desactivar";
        btbarDespertador.ToolTipText = "Desactivar";
        DespertadorActivado = true;
      }
      else
      {
        DespertadorActivar.Text = "Activar";
        btbarDespertador.ToolTipText = "Activar";
        DespertadorActivado = false;
      }
    }

    private void PaisAnadir_Click(System.Object sender, System.EventArgs e)
    {
      // Actúa sobre el menú País y sobre el menú contextual
      string titulo; // título del menú
      titulo = "País " + (menuPais.DropDownItems.Count - 2);
      AñadirPaisAMenu(titulo);
    }

    private void AñadirPaisAMenu(string sPais)
    {
      // Inicialmente hay 3 elementos (dos ocultos)
      if (menuPais.DropDownItems.Count == 3)
      {
        // Hacer visibles los elementos Eliminar y el separador
        PaisEliminar.Visible = true;
        Separador2.Visible = true;
        ContextPaisEliminar.Visible = true;
        ContextSeparador1.Visible = true;
      }
      // Crear un elemento
      ToolStripMenuItem elemento = new ToolStripMenuItem(sPais);
      ToolStripMenuItem contextElemento = new ToolStripMenuItem(sPais);
      // Especificar cuál será su controlador de eventos Click
      elemento.Click += new System.EventHandler(ElementoMenuPais_Click);
      contextElemento.Click += new System.EventHandler(ElementoMenuPais_Click);
      // Añadir el elemento al menú
      menuPais.DropDownItems.Add(elemento);
      MenuContextPais.Items.Add(contextElemento);
    }

    private void ElementoMenuPais_Click(System.Object sender, System.EventArgs e)
    {
      // Controlador para los elementos del menú País y sobre del menú contextual
      ToolStripMenuItem elemento = (ToolStripMenuItem)sender;
      MessageBox.Show(elemento.Text);
    }

    private void PaisEliminar_Click(System.Object sender, System.EventArgs e)
    {
      // Actúa sobre el menú País y sobre el menú contextual
      // Eliminar el último elemento
      int indUltimo = menuPais.DropDownItems.Count - 1;
      EliminarPais(indUltimo);
    }

    private void EliminarPais(int ind)
    {
      // Eliminar el elemento de índice ind en el menú País y en el contextual
      menuPais.DropDownItems.RemoveAt(ind);
      MenuContextPais.Items.RemoveAt(ind);
      if (menuPais.DropDownItems.Count == 3)
      {
        // No quedan más países. Ocultar los elementos Eliminar y Separador2
        PaisEliminar.Visible = false;
        Separador2.Visible = false;
        ContextPaisEliminar.Visible = false;
        ContextSeparador1.Visible = false;
      }
    }
  }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RelojDespertador
{
  public partial class Form1 : Form
  {
    private bool DespertadorActivado = false;
    private List<Pais> ListaPaises;
    private long DiferenciaHoraria;

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
      ctHoraPais.Text = DateTime.Now.AddTicks(DiferenciaHoraria).ToLongTimeString();

      // Un tick (paso) = 100 nanosegundos
      long horaActual = DateTime.Now.TimeOfDay.Ticks / 10000000L;  // en segundos
      long horaDespertador = ObtenerHoraDespertador() / 10000000L; // en segundos

      //Debug.WriteLine(horaActual)
      //Debug.WriteLine(horaDespertador)

      if (DespertadorActivado && horaDespertador != -1)
      {
        if (horaActual < horaDespertador)
        {
          // Aun no ha llegado la hora de la alarma,
          // pero hay un caso especial en el que debe
          // sonar: acaba de ser medianoche, estamos en
          // los primeros minutos del d�a y la alarma
          // estaba puesta en los �ltimos minutos de ayer.
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
      // la funci�n devolver� -1.
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

      // Si la hora no es v�lida, la funci�n devolver� -1
      if (horas < 0 || horas > 23 || minutos < 0 || minutos > 59 || segundos < 0 || segundos > 59)
      {
        return -1; // hora no v�lida
      }
      return new TimeSpan(horas, minutos, segundos).Ticks; // hora v�lida
    }

    private long ObtenerHoraDespertador()
    {
      // Obtener la hora del despertador en segundos.
      // Si no se introducen al menos horas:minutos,
      // la funci�n devolver� -1
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
      // Act�a sobre el men� Pa�s y sobre el men� contextual
      DlgAgregarPais dlg = new DlgAgregarPais();
      if (dlg.ShowDialog() == DialogResult.Cancel) return;

      string sPais = dlg.ctPais.Text;
      long dDifH = ObtenerHora(dlg.ctDifHoraria);
      if (sPais.Length == 0 || dDifH == -1)
      {
        MessageBox.Show("Datos no v�lidos");
        return;
      }
      if (dlg.cvPosNeg.Checked) dDifH = -dDifH;
      // Crear objeto Pais
      Pais unPais = new Pais(sPais, dDifH);
      // A�adir el objeto Pais al objeto List
      ListaPaises.Add(unPais);
      // A�adir elemento al men� Pa�s y al men� contextual
      A�adirPaisAMenu(sPais);
    }

    private void A�adirPaisAMenu(string sPais)
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
      // Especificar cu�l ser� su controlador de eventos Click
      elemento.Click += new System.EventHandler(ElementoMenuPais_Click);
      contextElemento.Click += new System.EventHandler(ElementoMenuPais_Click);
      // A�adir el elemento al men�
      menuPais.DropDownItems.Add(elemento);
      MenuContextPais.Items.Add(contextElemento);
    }

    private void ElementoMenuPais_Click(System.Object sender, System.EventArgs e)
    {
      // Controlador para los elementos del men� Pa�s y sobre del men� contextual
      ToolStripMenuItem elemento = (ToolStripMenuItem)sender;
      etPais.Text = elemento.Text;
      int ind = elemento.Owner.Items.IndexOf(elemento);
      Pais objPais = ListaPaises[ind - 3];
      DiferenciaHoraria = objPais.ObtenerDifHor();
    }

    private void PaisEliminar_Click(System.Object sender, System.EventArgs e)
    {
      // Act�a sobre el men� Pa�s y sobre el men� contextual
      DlgBorrarPais dlg = new DlgBorrarPais();
      // this (Form1) ser� el propietario de dlg
      if (dlg.ShowDialog(this) == DialogResult.Cancel)
        return;

      int indElemSelec = dlg.lsListaPaises.SelectedIndex;
      if (indElemSelec == -1) return;
      // Eliminar el elemento seleccinado en el control lista
      dlg.lsListaPaises.Items.RemoveAt(indElemSelec);
      // Eliminar el elemento seleccinado en List, Pa�s y men� contextual
      EliminarPais(indElemSelec);
    }

    private void EliminarPais(int ind)
    {
      // Eliminar el elemento de �ndice ind en List
      ListaPaises.RemoveAt(ind);
      // Eliminar el elemento de �ndice ind en el men� Pa�s y en el contextual
      menuPais.DropDownItems.RemoveAt(3 + ind);
      MenuContextPais.Items.RemoveAt(3 + ind);
      if (menuPais.DropDownItems.Count == 3)
      {
        // No quedan m�s pa�ses. Ocultar los elementos Eliminar y Separador2
        PaisEliminar.Visible = false;
        Separador2.Visible = false;
        ContextPaisEliminar.Visible = false;
        ContextSeparador1.Visible = false;
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (File.Exists("DifsHorsPredeterminado.bin"))
      {
        DialogResult respuesta;
        respuesta = MessageBox.Show("�Desea sobrescribir el fichero predeterminado?", "Seleccione una opci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (respuesta == DialogResult.No)
        {
          ArchivoGuardar.PerformClick(); // clic en Guardar
          return;
        }
      }
      Seriar("DifsHorsPredeterminado.bin");
    }

    private void Seriar(string fichero)
    {
      if (ListaPaises == null)
      {
        return;
      }
      Stream fs = File.Create(fichero);
      BinaryFormatter seriador = new BinaryFormatter();
      seriador.Serialize(fs, ListaPaises);
      fs.Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      ListaPaises = new List<Pais>();
      if (File.Exists("DifsHorsPredeterminado.bin"))
      {
        Deseriar("DifsHorsPredeterminado.bin");
      }
    }

    private void ArchivoAbrir_Click(object sender, EventArgs e)
    {
      OpenFileDialog DlgAbrir = new OpenFileDialog();

      DlgAbrir.InitialDirectory = Directory.GetCurrentDirectory();
      DlgAbrir.Filter = "fichero binario (*.bin)|*.bin";
      DlgAbrir.FilterIndex = 1;
      DlgAbrir.RestoreDirectory = true;

      // Mostrar el di�logo Abrir
      if (DlgAbrir.ShowDialog() == DialogResult.OK)
      {
        // Eliminar la configuaci�n inicialmnte establecida
        int ind;
        ind = ListaPaises.Count - 1;
        while (ind >= 0)
        {
          // Eliminar elemento de List, Pa�s y men� contextual
          EliminarPais(ind);
          ind -= 1;
        }
        // Obtener los datos del fichero
        Deseriar(DlgAbrir.FileName);
      }
    }

    private void Deseriar(string fichero)
    {
      Stream fs = File.OpenRead(fichero);
      BinaryFormatter deseriador = new BinaryFormatter();
      // A�adir los pa�ses a la lista
      ListaPaises = ((List<Pais>)deseriador.Deserialize(fs));
      fs.Close();
      // Construir el men� Pa�s y el men� contextual
      Pais unPais;
      foreach (Pais tempLoopVar_unPais in ListaPaises)
      {
        unPais = tempLoopVar_unPais;
        A�adirPaisAMenu(unPais.ToString());
      }
    }

    private void ArchivoGuardar_Click(object sender, EventArgs e)
    {
      SaveFileDialog DlgGuardar = new SaveFileDialog();

      DlgGuardar.InitialDirectory = Directory.GetCurrentDirectory();
      DlgGuardar.Filter = "fichero binario (*.bin)|*.bin";
      DlgGuardar.FilterIndex = 1;
      DlgGuardar.RestoreDirectory = true;

      if (DlgGuardar.ShowDialog() == DialogResult.OK)
      {
        // Guardar los datos en el fichero
        Seriar(DlgGuardar.FileName);
      }
    }

    private void AyudaAcercade_Click(object sender, EventArgs e)
    {
      string mensaje = "Aplicaci�n Reloj Despertador. Versi�n 1.0" + Environment.NewLine + "Copyright (c) Fco. Javier Ceballos, 2006";
      MessageBox.Show(mensaje, "Acerca de Reloj Despertador");
    }

    public List<Pais> ObtenerDatos()
    {
      return ListaPaises;
    }
  }
}
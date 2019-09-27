using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Calculadora
{
  public partial class Form1 : Form
  {
    private enum Entrada
    {
      NINGUNA,
      DIGITO,
      OPERADOR,
      CE
    }

    private Entrada ultimaEntrada;
    private bool comaDecimal;
    private char operador;
    private byte numOperandos;
    private double operando1;
    private double operando2;
    private SoundPlayer reproductor;

    public Form1()
    {
      InitializeComponent();
      ultimaEntrada = Entrada.NINGUNA;
      comaDecimal = false;
      operador = '\0';
      numOperandos = 0;
      operando1 = 0;
      operando2 = 0;
      reproductor = new SoundPlayer();
    }

    private void btDigito_Click(object sender, EventArgs e)
    {
      Button objButton = (Button)sender;
      switch (objButton.Text)
      {
        case "0":
          reproductor.SoundLocation = "..\\..\\Sonidos\\cero.wav";
          reproductor.Play();
          break;
        case "1":
          reproductor.SoundLocation = "..\\..\\Sonidos\\uno.wav";
          reproductor.Play();
          break;
        case "2":
          reproductor.SoundLocation = "..\\..\\Sonidos\\dos.wav";
          reproductor.Play();
          break;
        case "3":
          reproductor.SoundLocation = "..\\..\\Sonidos\\tres.wav";
          reproductor.Play();
          break;
        case "4":
          reproductor.SoundLocation = "..\\..\\Sonidos\\cuatro.wav";
          reproductor.Play();
          break;
        case "5":
          reproductor.SoundLocation = "..\\..\\Sonidos\\cinco.wav";
          reproductor.Play();
          break;
        case "6":
          reproductor.SoundLocation = "..\\..\\Sonidos\\seis.wav";
          reproductor.Play();
          break;
        case "7":
          reproductor.SoundLocation = "..\\..\\Sonidos\\siete.wav";
          reproductor.Play();
          break;
        case "8":
          reproductor.SoundLocation = "..\\..\\Sonidos\\ocho.wav";
          reproductor.Play();
          break;
        case "9":
          reproductor.SoundLocation = "..\\..\\Sonidos\\nueve.wav";
          reproductor.Play();
          break;
      }

      if (ultimaEntrada != Entrada.DIGITO)
      {
        if (objButton.Text == "0") return;
        etPantalla.Text = "";
        ultimaEntrada = Entrada.DIGITO;
        comaDecimal = false;
      }
      etPantalla.Text += objButton.Text;
    }

    private void btComaDec_Click(object sender, EventArgs e)
    {
      reproductor.SoundLocation = "..\\..\\Sonidos\\punto.wav";
      reproductor.Play();
      if (ultimaEntrada != Entrada.DIGITO)
      {
        etPantalla.Text = "0,";
        ultimaEntrada = Entrada.DIGITO;
      }
      else if (comaDecimal == false)
        etPantalla.Text = etPantalla.Text + ",";

      comaDecimal = true;
    }

    private void btOperacion_Click(object sender, EventArgs e)
    {
      // Obtener el id del botón que generó el evento
      Button objButton = (Button)sender;
      // Obtener el texto del botón pulsado
      string textoBoton = objButton.Text;
      switch (textoBoton)
      {
        case "+":
          reproductor.SoundLocation = "..\\..\\Sonidos\\mas.wav";
          reproductor.Play();
          break;
        case "-":
          reproductor.SoundLocation = "..\\..\\Sonidos\\menos.wav";
          reproductor.Play();
          break;
        case "x":
          reproductor.SoundLocation = "..\\..\\Sonidos\\por.wav";
          reproductor.Play();
          break;
        case "/":
          reproductor.SoundLocation = "..\\..\\Sonidos\\dividido.wav";
          reproductor.Play();
          break;
        case "=":
          reproductor.SoundLocation = "..\\..\\Sonidos\\igual.wav";
          reproductor.Play();
          break;
      }

      if ((numOperandos == 0) && (textoBoton[0] == '-'))
        ultimaEntrada = Entrada.DIGITO;

      if (ultimaEntrada == Entrada.DIGITO)
        numOperandos += 1;

      if (numOperandos == 1)
        operando1 = double.Parse(etPantalla.Text);
      else if (numOperandos == 2)
      {
        operando2 = double.Parse(etPantalla.Text);
        switch (operador)
        {
          case '+':
            operando1 += operando2;
            break;
          case '-':
            operando1 -= operando2;
            break;
          case 'x':
            operando1 *= operando2;
            break;
          case '/':
            operando1 /= operando2;
            break;
          case '=':
            operando1 = operando2;
            break;
        }
        // Visualizar el resultado
        etPantalla.Text = operando1.ToString();
        numOperandos = 1;
      }
      operador = textoBoton[0]; // carácter de la posición 0
      ultimaEntrada = Entrada.OPERADOR;
    }

    private void btTantoPorCiento_Click(object sender, EventArgs e)
    {
      reproductor.SoundLocation = "..\\..\\Sonidos\\tpc.wav";
      reproductor.PlaySync();
      double resultado;
      if (ultimaEntrada == Entrada.DIGITO)
      {
        resultado = operando1 * double.Parse(etPantalla.Text) / 100;
        // Visualizar el resultado
        etPantalla.Text = resultado.ToString();
        // Simular que se ha hecho clic en "="
        btIgual.PerformClick();
        // Enfocar la tecla %
        btTantoPorCiento.Focus();
      }
    }

    private void btIniciar_Click(object sender, EventArgs e)
    {
      reproductor.SoundLocation = "..\\..\\Sonidos\\borrart.wav";
      reproductor.Play();
      etPantalla.Text = "0,";
      ultimaEntrada = Entrada.NINGUNA;
      comaDecimal = false;
      operador = '\0';
      numOperandos = 0;
      operando1 = 0;
      operando2 = 0;
    }

    private void btBorrarEntrada_Click(object sender, EventArgs e)
    {
      reproductor.SoundLocation = "..\\..\\Sonidos\\borrard.wav";
      reproductor.Play();
      etPantalla.Text = "0,";
      ultimaEntrada = Entrada.CE;
      comaDecimal = false;
    }
  }
}
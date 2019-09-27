using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System;

namespace RelojDespertador
{
  [Serializable()]
  public class Pais
  {
    private string m_Pais;
    private long m_DifHoraria; // diferencia horaria en ticks

    public Pais()
    {
    }

    public Pais(string pais, long difhor)
    {
      m_Pais = pais;
      m_DifHoraria = difhor;
    }

    public string ObtenerPais()
    {
      return m_Pais;
    }

    public void AsignarPais(string pais)
    {
      m_Pais = pais;
    }

    public long ObtenerDifHor()
    {
      return m_DifHoraria;
    }

    public void AsignarDifHor(long difhor)
    {
      m_DifHoraria = difhor;
    }

    public override string ToString()
    {
      return m_Pais;
    }
  }
}

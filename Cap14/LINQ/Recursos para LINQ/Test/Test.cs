using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

public static class CPersonaEx
{
  public static int Edad(this CPersona persona)
  {
    int edad = DateTime.Today.Year - persona.FechaNac.Year;
    if (DateTime.Today.Month > persona.FechaNac.Month ||
        DateTime.Today.Month == persona.FechaNac.Month &&
        DateTime.Today.Day >= persona.FechaNac.Day)
      return edad;
    return edad - 1;
  }
}

// Delegados
//public delegate bool ExprCondicional(CPersona pers);
public delegate void Suma(double x, double y);

public sealed class CPersona
{
  public string Nombre { get; set; }
  public DateTime FechaNac { get; set; }

  //public static void NacidosAño(List<CPersona> lista, ExprCondicional condición)
  //{
  //  foreach (CPersona p in lista)
  //  {
  //    if (condición(p))
  //      Console.WriteLine(p.Nombre);
  //  }
  //}

  public static void NacidosAño(List<CPersona> lista, Func<CPersona, bool> condición)
  {
    foreach (CPersona p in lista)
    {
      if (condición(p))
        Console.WriteLine(p.Nombre);
    }
  }
}

class Test
{
  public static void Main(string[] args)
  {
    var persona = new { Nombre = "Elena", Edad = 24 };
    Console.WriteLine(persona.Nombre);
    Console.WriteLine(persona.GetType().FullName);

    //var persona = new CPersona {
    //              Nombre = "Elena",
    //              FechaNac = new DateTime(1990, 6, 25) };

    List<CPersona> listPersona = new List<CPersona> {
          new CPersona {
            Nombre = "Elena", FechaNac = new DateTime(1990, 6, 25) },
          new CPersona {
            Nombre = "Manuel", FechaNac = new DateTime(1991, 9, 21)},
        };

    Console.WriteLine(listPersona[1].Edad()); // o bien:
    Console.WriteLine(CPersonaEx.Edad(listPersona[1]));

    //CPersona.NacidosAño(listPersona, delegate (CPersona p) {
    //                              return p.FechaNac.Year == 1991;});
    //CPersona.NacidosAño(listPersona,
    //                    (CPersona p) => p.FechaNac.Year == 1991);
    CPersona.NacidosAño(listPersona, (p) => p.FechaNac.Year == 1991);

    Suma deSuma = (a, b) => { var s = a + b; Console.WriteLine(s); };
    deSuma(5, 6.5);

    Func<int, bool> esPar = n => n % 2 == 0;
    bool resultado = esPar(11); // retorna false
    Console.WriteLine(resultado);

    int[] números = { 6, 7, 11, 9, 8, 5, 4, 1, 3, 2 };
    int númerosPares = números.Count(n => n % 2 == 0);
    Console.WriteLine(númerosPares);
    var primerosNumsMenoresQue9 = números.TakeWhile((int n) => n < 9);
    foreach (int n in primerosNumsMenoresQue9)
      Console.WriteLine(n);

    var numsImparesOrdenados =  // resultado: 1, 3, 5, 7, 9, 11
            from n in números
            where (n % 2 != 0)
            orderby n
            select n;

    // Equivalente a:
    //var numsImparesOrdenados = números.Where (n => n % 2 != 0).OrderBy (n => n).Select (n => n);
    // Equivalente a:
    //var numsImparesOrdenados = números.
    //        Where(n => n % 2 != 0).
    //        OrderBy(n => n).
    //        Select(n => n); 

    foreach (int n in numsImparesOrdenados)
      Console.Write(n + ", ");
    Console.WriteLine();

    Func<CPersona, int, bool> esNacidoEnAño = (p, año) => p.FechaNac.Year == año;
    foreach (CPersona p in listPersona)
    {
      if (esNacidoEnAño(p, 1991))
        Console.WriteLine(p.Nombre);
    }
  }
}

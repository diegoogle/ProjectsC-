using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class CPais
{
  public string Codigo { get; set; }
  public string Nombre { get; set; }
}

public sealed class CPersona
{
  public string Nombre { get; set; }
  public DateTime FechaNac { get; set; }
  public string PaisNac { get; set; }
}

class Test
{
  public static void Main(string[] args)
  {
    List<CPais> listPais = new List<CPais> {
      new CPais {
        Codigo = "ES", Nombre = "España" },
      new CPais {
        Codigo = "EN", Nombre = "Inglaterra" },
      new CPais {
        Codigo = "FR", Nombre = "Francia" },
      new CPais {
        Codigo = "US", Nombre = "Estados Unidos" },
    };

    List<CPersona> listPersona = new List<CPersona> {
      new CPersona {
        Nombre = "Elena", FechaNac = new DateTime(1990, 10, 25), PaisNac = "ES" },
      new CPersona {
        Nombre = "Manuel", FechaNac = new DateTime(1991, 9, 21), PaisNac = "US"},
      new CPersona {
        Nombre = "Javier", FechaNac = new DateTime(1990, 7, 2), PaisNac = "ES" },
      new CPersona {
        Nombre = "María", FechaNac = new DateTime(1991, 10, 1), PaisNac = "EN"}
    };

    // Expresión de consulta
    var personas1990 =
        from p in listPersona
        where p.FechaNac.Year == 1990
        orderby p.Nombre
        select new { Nombre = p.Nombre };
    //select p.Nombre;

    //var personas1990 = listPersona.
    //    Where(p => p.FechaNac.Year == 1990).
    //    OrderBy(p => p.Nombre).
    //    Select(p => new { Nombre = p.Nombre } );

    foreach (var persona in personas1990)
      Console.WriteLine(persona.Nombre);
    //Console.WriteLine(persona);

    // Cláusula group
    Console.WriteLine("\ngroup:");
    var personasPorAño =
        from p in listPersona
        group p by p.FechaNac.Year; // Key: año

    foreach (var grupoPersonas in personasPorAño)
    {
      Console.WriteLine(grupoPersonas.Key); // año
      foreach (var persona in grupoPersonas)
        Console.WriteLine("    {0}", persona.Nombre);
    }

    // Cláusula group
    Console.WriteLine("\ngroup:");
    var personasPais =
        from pais in listPais
        join pers in listPersona
                  on pais.Codigo equals pers.PaisNac
        group new { Nombre = pers.Nombre } by pais.Nombre; // Key: nombre país

    foreach (var grupoPerPais in personasPais)
    {
      Console.WriteLine(grupoPerPais.Key); // nombre país
      foreach (var persona in grupoPerPais)
        Console.WriteLine("    {0}", persona.Nombre);
    }

    // Producto cartesiano
    Console.WriteLine("\nProducto cartesiano:");
    var productoCartesiano =
        from pais in listPais
        from pers in listPersona
        where pais.Codigo == pers.PaisNac
        select new { NomPers = pers.Nombre, NomPais = pais.Nombre };

    foreach (var elem in productoCartesiano)
      Console.WriteLine("{0}  {1}", elem.NomPers, elem.NomPais);

    // Cláusula join
    Console.WriteLine("\njoin:");
    var combinacion =
        from pais in listPais
        join pers in listPersona
                  on pais.Codigo equals pers.PaisNac
        select new { NomPers = pers.Nombre, NomPais = pais.Nombre };

    foreach (var elem in combinacion)
      Console.WriteLine("{0}  {1}", elem.NomPers, elem.NomPais);

    // Cláusula into
    Console.WriteLine("\ninto:");
    var persNacidasPorAño =
        from p in listPersona
        group p by p.FechaNac.Year into grupoPersAño
        where grupoPersAño.Count() >= 2
        select new { Año = grupoPersAño.Key, PorAño = grupoPersAño.Count() };

    foreach (var persona in persNacidasPorAño)
    {
      Console.WriteLine("En {0} nacieron {1} o más personas.", persona.Año, persona.PorAño);
    }

    // Cláusula into con group
    Console.WriteLine("\ninto con group:");
    var persPais =
        from pais in listPais
        join pers in listPersona
                  on pais.Codigo equals pers.PaisNac
        group new { Nombre = pers.Nombre }
              by pais.Nombre into persPaisOrd
        orderby persPaisOrd.Key
        select persPaisOrd;

    foreach (var grupoPerPais in persPais)
    {
      Console.WriteLine(grupoPerPais.Key);
      foreach (var persona in grupoPerPais)
        Console.WriteLine("    {0}", persona.Nombre);
    }

    // Cláusula into con join
    Console.WriteLine("\ninto con join:");
    var PaisNumPers =
      from pais in listPais
      orderby pais.Nombre
      join pers in listPersona
                on pais.Codigo equals pers.PaisNac
                into grupoPais
      select new { NomPais = pais.Nombre, NumPers = grupoPais.Count() };

    foreach (var pais in PaisNumPers)
    {
      Console.WriteLine("En {0} hay {1} personas.", pais.NomPais, pais.NumPers);
    }

    // Cláusula let
    Console.WriteLine("\nlet:");
    int unMes = 10, unAño = 1991;
    var persPaisAñoMes =
        from pais in listPais orderby pais.Nombre
        join pers in listPersona
                  on pais.Codigo equals pers.PaisNac
        let mesNac = pers.FechaNac.Month
        let añoNac = pers.FechaNac.Year
        where añoNac == unAño && mesNac == unMes
        group new { Nombre = pers.Nombre } by pais.Nombre into perPais
        select perPais;

    Console.WriteLine("Nacidos en el mes {0} del año {1}:", unMes, unAño);
    foreach (var grupoPerPais in persPaisAñoMes)
    {
      Console.WriteLine(grupoPerPais.Key);
      foreach (var persona in grupoPerPais)
        Console.WriteLine("    {0}", persona.Nombre);
    }
  }
}

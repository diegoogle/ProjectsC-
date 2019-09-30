using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

public sealed class CPersona
{
  public string Nombre { get; set; }
  public DateTime FechaNac { get; set; }
}

class Test
{
  public static void Main(string[] args)
  {
    List<CPersona> listPersona = new List<CPersona> {
          new CPersona {
            Nombre = "Elena", FechaNac = new DateTime(1990, 6, 25) },
          new CPersona {
            Nombre = "Manuel", FechaNac = new DateTime(1991, 9, 21)},
          new CPersona {
            Nombre = "Rocío", FechaNac = new DateTime(1991, 3, 15)}
        };


    //Expression<Func<CPersona, bool>> exprNacidoEnAño = (p) => p.FechaNac.Year == 1991;

    // (p) => p.FechaNac.Year == 1991;
    //ParameterExpression parametro_p = Expression.Parameter(typeof(CPersona), "p");
    //MemberExpression m1 = Expression.Property(parametro_p, "FechaNac");
    //MemberExpression left = Expression.Property(m1, "Year");
    //ConstantExpression right = Expression.Constant(1991, typeof(int));
    //BinaryExpression exprb = Expression.Equal(left, right);
    //Expression<Func<CPersona, bool>> exprNacidoEnAño =
    //  Expression.Lambda<Func<CPersona, bool>>(
    //    exprb,
    //    new ParameterExpression[] { parametro_p });

    string personas1991 = "";

    //foreach (CPersona p in listPersona)
    //{
    //  if (exprNacidoEnAño.Compile().Invoke(p))
    //    personas1991 += p.Nombre + Environment.NewLine;
    //}

    int añoNac = 1991;
    //Expression<Func<CPersona, int, bool>> exprNacidoEnAño = (p, año) => p.FechaNac.Year == año;

    // (p, año) => p.FechaNac.Year == año;
    ParameterExpression parametro_p = Expression.Parameter(typeof(CPersona), "p");
    MemberExpression m1 = Expression.Property(parametro_p, "FechaNac");
    MemberExpression left = Expression.Property(m1, "Year");
    ParameterExpression right = Expression.Parameter(typeof(int), "año"); // parámetro año
    BinaryExpression exprb = Expression.Equal(left, right);
    Expression<Func<CPersona, int, bool>> exprNacidoEnAño =
      Expression.Lambda<Func<CPersona, int, bool>>(
        exprb,
        new ParameterExpression[] { parametro_p, right });

    foreach (CPersona p in listPersona)
    {
      if (exprNacidoEnAño.Compile().Invoke(p, añoNac))
        personas1991 += p.Nombre + Environment.NewLine;
    }

    Console.WriteLine(personas1991);
  }
}

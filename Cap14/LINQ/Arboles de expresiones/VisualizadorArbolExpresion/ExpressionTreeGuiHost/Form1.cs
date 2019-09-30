//Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Linq.Expressions;
using ExpressionVisualizer;

namespace GuiHost
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void showVisualizerButton_Click(object sender, EventArgs e)
    {
      //Expression<Func<int, bool>> expr = x => x == 10;

      //Expression<Func<CPersona, bool>> expr = (p) => p.FechaNac.Year == 1991;

      // (p) => p.FechaNac.Year == 1991;
      //ParameterExpression parametro_p = Expression.Parameter(typeof(CPersona), "p");
      //MemberExpression m1 = Expression.Property(parametro_p, "FechaNac");
      //MemberExpression left = Expression.Property(m1, "Year");
      //ConstantExpression right = Expression.Constant(1991, typeof(int));
      //BinaryExpression exprb = Expression.Equal(left, right);
      //Expression<Func<CPersona, bool>> expr =
      //  Expression.Lambda<Func<CPersona, bool>>(
      //    exprb,
      //    new ParameterExpression[] { parametro_p });

      //Expression<Func<CPersona, int, bool>> expr = (p, año) => p.FechaNac.Year == año;

      // (p, año) => p.FechaNac.Year == año;
      ParameterExpression parametro_p = Expression.Parameter(typeof(CPersona), "p");
      MemberExpression m1 = Expression.Property(parametro_p, "FechaNac");
      MemberExpression left = Expression.Property(m1, "Year"); // parámetro año
      ParameterExpression right = Expression.Parameter(typeof(int), "año");
      BinaryExpression exprb = Expression.Equal(left, right);
      Expression<Func<CPersona, int, bool>> expr =
        Expression.Lambda<Func<CPersona, int, bool>>(
          exprb,
          new ParameterExpression[] { parametro_p, right });

      VisualizerDevelopmentHost host = new VisualizerDevelopmentHost(expr,
                                           typeof(ExpressionTreeVisualizer),
                                           typeof(ExpressionTreeVisualizerObjectSource));
      host.ShowVisualizer(this);
    }
  }
}

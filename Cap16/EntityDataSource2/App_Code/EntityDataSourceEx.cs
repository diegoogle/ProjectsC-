using System.Collections.Specialized;
using System.Collections;

/// <summary>
/// EntityDataSourceEx: clase que amplía EntityDataSource
/// mediante métodos extensores: Insert.
/// </summary>
namespace System.Web.UI.WebControls
{
  public static class EntityDataSourceEx
  {
    private static bool Finalizacion(int filasAfectadas, Exception exc)
    {
      return false; // indica que las excepciones no se han manipulado
    }

    public static void Insert(this EntityDataSource origenDeDatos)
    {
      // Llamada: origen.Insert() --> evento Inserting
      EntityDataSourceView vista = (origenDeDatos as IDataSource).GetView(string.Empty) as EntityDataSourceView;
      // Insertar la fila en alums_asigs
      vista.Insert(new ListDictionary(), Finalizacion);
    }

    public static void Insert(this EntityDataSource origenDeDatos, IDictionary nuevaFila)
    {
      // Llamada: origen.Insert(objetoIDictionary) --> evento Inserting
      EntityDataSourceView vista = (origenDeDatos as IDataSource).GetView(string.Empty) as EntityDataSourceView;
      // Insertar la fila en alums_asigs
      vista.Insert(nuevaFila, Finalizacion);
    }
  }
}

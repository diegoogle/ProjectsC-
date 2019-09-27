using System.Collections.Generic;

namespace TablaTfnos.BBDD
{
  public class bbdd
  {
    public static BindingListPersonas ObtenerDatos()
    {
      BindingListPersonas personas = new BindingListPersonas();
      // Simular la base de datos
      personas.Add(new Persona("../../Imagenes/foto.jpg", "Alfons González Pérez", "Argentona, Barcelona", "933333333", true));
      personas.Add(new Persona("../../Imagenes/foto.jpg", "Ana María Cuesta Suñer", "Gijón, Asturias", "984454545", false));
      personas.Add(new Persona("../../Imagenes/foto.jpg", "Elena Veiguela Suárez", "Pontevedra", "986678678", false));
      personas.Add(new Persona("../../Imagenes/foto.jpg", "Pedro Aguado Rodríguez", "Madrid", "912804574", true));
      return personas;
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
  public telefono ObtenerTfno(string tf)
  {
    return new telefonosBll().ObtenerTfnoBll(tf);
  }

  public List<Detalles> ObtenerTfnos()
  {
    return new telefonosBll().ObtenerTfnosBll();
  }

  public void ActualizarTfno(telefono entidad)
  {
    new telefonosBll().ActualizarTfnoBll(entidad);
  }

  public void AgregarTfno(telefono entidad)
  {
    new telefonosBll().AgregarTfnoBll(entidad);
  }

  public void BorrarTfno(telefono entidad)
  {
    new telefonosBll().BorrarTfnoBll(entidad);
  }
}

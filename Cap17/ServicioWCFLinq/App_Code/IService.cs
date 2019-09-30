using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//using bd_telefonos3Model;

[ServiceContract]
public interface IService
{
  [OperationContract]
  List<Detalles> ObtenerTfnos();

  [OperationContract]
  telefono ObtenerTfno(string tf);

  [OperationContract]
  void ActualizarTfno(telefono entidad);

  [OperationContract]
  void AgregarTfno(telefono entidad);

  [OperationContract]
  void BorrarTfno(telefono entidad);
}

[DataContract]
public class Detalles
{
  private string _apellido1;
  private string _telefono;
  public Detalles(string ap, string tf)
  {
    _apellido1 = ap;
    _telefono = tf;
  }

  [DataMember]
  public string apellido1
  {
    get { return _apellido1; }
    set { _apellido1 = value; }
  }

  [DataMember]
  public string telefono
  {
    get { return _telefono; }
    set { _telefono = value; }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract(Namespace = "http://websol.aut.uah.es/ServiciosWeb/")]
public interface IServWebWCFConverTemps
{
  // Operaciones del servicio
  [OperationContract]
  double ConvCentAFahr(double gCent);

  [OperationContract]
  double ConvFahrACent(double gFahr);

  [OperationContract]
  Detalles ResultadoDetallado(Detalles detalle);
}

[DataContract(Namespace = "http://websol.aut.uah.es/ServiciosWeb/")]
public class Detalles
{
  private bool _sonCentigrados;
  private string _literal;
  private double _grados;

  [DataMember]
  public bool SonCentigrados
  {
    get { return _sonCentigrados; }
    set { _sonCentigrados = value; }
  }

  [DataMember]
  public string Literal
  {
    get { return _literal; }
    set { _literal = value; }
  }

  [DataMember]
  public double Grados
  {
    get { return _grados; }
    set { _grados = value; }
  }
}

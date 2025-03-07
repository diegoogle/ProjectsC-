﻿using System.ServiceModel;
using System.ServiceModel.Activation;

[ServiceContract(Namespace = "ServicioWebAJAX")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class Service
{
	// Para usar HTTP GET, agregue el atributo [WebGet]. (El valor predeterminado de ResponseFormat es WebMessageFormat.Json)
	// Para crear una operación que devuelva XML,
	//     agregue [WebGet(ResponseFormat=WebMessageFormat.Xml)]
	//     e incluya la siguiente línea en el cuerpo de la operación:
	//         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
	[OperationContract]
  public string Saludo()
  {
    return "Hola a todos";
  }

	// Agregue aquí más operaciones y márquelas con [OperationContract]
}

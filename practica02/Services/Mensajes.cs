using System;
using System.ServiceModel;

namespace WSDL.mensajes{
    [ServiceContract]
    public interface Mensajes{
        [OperationContract]
        String Saludar (String nombre);
        [OperationContract]
        String Mostrar (String id);
    }
}
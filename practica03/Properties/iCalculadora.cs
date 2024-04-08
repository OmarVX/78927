using System;

namespace icalculadora{
    [ServiceContract]
    public interface iCalculadora{
        [OperationContract]
        int suma(int a, int b);
        int resta(int a, int b);
    }
}
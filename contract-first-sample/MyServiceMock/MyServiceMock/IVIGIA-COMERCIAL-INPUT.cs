using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyServiceMock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVIGIA_COMERCIAL_INPUT" in both code and config file together.
    [ServiceContract]
    public interface IVIGIA_COMERCIAL_INPUT
    {
        [OperationContract]
        void DoWork();
    }
}

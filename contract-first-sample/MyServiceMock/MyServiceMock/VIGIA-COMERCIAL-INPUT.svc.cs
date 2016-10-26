using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyServiceMock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VIGIA_COMERCIAL_INPUT" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VIGIA-COMERCIAL-INPUT.svc or VIGIA-COMERCIAL-INPUT.svc.cs at the Solution Explorer and start debugging.
    //public interface WSVIGIACOMERCIALInputportType
    // IVIGIA_COMERCIAL_INPUT
    public class VIGIA_COMERCIAL_INPUT : WSVIGIACOMERCIALInputportTypeClient
    {
        new public VigiaReply1 MaestroSubescalas(MaestroSubescalasRequest1 request)
        {
            return base.Channel.MaestroSubescalas(request);
        }

    }
}

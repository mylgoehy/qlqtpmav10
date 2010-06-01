using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the interface name "IListening_Service" here, you must also update the reference to "IListening_Service" in Web.config.
[ServiceContract]
public interface IListening_Service
{
    [OperationContract]
    void DoWork();
}

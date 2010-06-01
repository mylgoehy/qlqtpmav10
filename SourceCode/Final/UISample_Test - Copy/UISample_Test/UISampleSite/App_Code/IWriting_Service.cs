using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the interface name "IWriting_Service" here, you must also update the reference to "IWriting_Service" in Web.config.
[ServiceContract]
public interface IWriting_Service
{
    [OperationContract]
    void DoWork();

    [OperationContract]
    IEnumerable<WRITING> GetWritings(int ID_Unit);
}

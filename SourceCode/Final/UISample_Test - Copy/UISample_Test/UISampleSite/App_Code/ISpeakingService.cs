using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the interface name "ISpeakingService" here, you must also update the reference to "ISpeakingService" in Web.config.
[ServiceContract]
public interface ISpeakingService
{
    [OperationContract]
    void DoWork();

    [OperationContract]
    IEnumerable<SPEAKING> GetSpeakingUnit(int id_Unit);

    [OperationContract]
    List<string> GetSpeaking_PracticeContents(int ID_Unit);
}

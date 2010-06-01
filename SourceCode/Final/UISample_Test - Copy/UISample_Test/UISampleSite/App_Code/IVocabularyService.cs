using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the interface name "IVocabularyService" here, you must also update the reference to "IVocabularyService" in Web.config.
[ServiceContract]
public interface IVocabularyService
{
    [OperationContract]
    void DoWork();

    [OperationContract]
    IEnumerable<VOCABULARY> GetVocabulary();
}

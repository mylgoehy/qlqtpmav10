using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using System.IO;

// NOTE: If you change the interface name "IReading_Service" here, you must also update the reference to "IReading_Service" in Web.config.
[ServiceContract]
public interface IReading_Service
{
    //Lấy danh sách Reading
    [OperationContract]
    IEnumerable<READING> LayReading(int ID_Unit);

    //Lấy danh sách Reading_Practice
    [OperationContract]
    IEnumerable<READING_PRACTICE> LayReading_Practice(int ID_Unit, int Task, int Type);

    [OperationContract]
    List<Byte[]> GetReading_PracticeContents(int ID_Unit, int Type);

    [OperationContract]
    IEnumerable<string> GetReading_Audio(int ID_Unit);
}

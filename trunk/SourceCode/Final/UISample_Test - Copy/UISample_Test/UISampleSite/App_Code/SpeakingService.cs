using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Xml;

// NOTE: If you change the class name "SpeakingService" here, you must also update the reference to "SpeakingService" in Web.config.
public class SpeakingService : ISpeakingService
{
    public void DoWork()
    {
    }

    public IEnumerable<SPEAKING> GetSpeakingUnit(int id_Unit)
    {
        AnhVan10DataContext db = new AnhVan10DataContext();
        string chuoilenh = "select * from SPEAKING where ID_Unit=" + id_Unit;
        return db.ExecuteQuery<SPEAKING>(chuoilenh);
    }

    public List<string> GetSpeaking_PracticeContents(int ID_Unit)
    {
        IEnumerable<SPEAKING> speaking_Practices = this.GetSpeakingUnit(ID_Unit);

        List<string> list = new List<string>();

        foreach (SPEAKING item in speaking_Practices)
        {
            XmlDocument xmlDoc = new XmlDocument();
            Stream stream;
            try
            {
                stream = File.OpenRead(System.Web.Hosting.HostingEnvironment.MapPath("~/ClientBin/" + item.Suggestion));                
                xmlDoc.Load(stream);                
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.Message);
            }
            // Now create StringWriter object to get data from xml document.
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);

            xmlDoc.WriteTo(xw);
            list.Add(sw.ToString());

        }

        return list;        
    }

}

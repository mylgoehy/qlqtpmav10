using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Xml;

// NOTE: If you change the class name "Reading_Service" here, you must also update the reference to "Reading_Service" in Web.config.
public class Reading_Service : IReading_Service
{
    public IEnumerable<READING> LayReading(int ID_Unit)
    {
        AnhVan10DataContext db = new AnhVan10DataContext();
        string ChuoiLenh = "select * from READING where ID_Unit = " + ID_Unit;
        return db.ExecuteQuery<READING>(ChuoiLenh);
    }

    //Lấy danh sách Reading_Practice
    //Nếu muốn lấy hết thì truyền vô ID_Unit < 0 and Task < 0 and Type < 0
    public IEnumerable<READING_PRACTICE> LayReading_Practice(int ID_Unit, int Task, int Type)
    {
        AnhVan10DataContext db = new AnhVan10DataContext();
        string ChuoiLenh = "select * from READING_PRACTICE";
        bool Flag = false;
        if (ID_Unit >= 0)
        {
            ChuoiLenh += " where ID_Unit = " + ID_Unit;
            Flag = true;
        }

        if (Task >= 0)
        {
            if (Flag == false)
            {
                ChuoiLenh += " where Task = " + Task;
                Flag = true;
            }
            else
            {
                ChuoiLenh += " and Task = " + Task;
            }
        }

        if (Type >= 0)
        {
            if (Flag == false)
            {
                ChuoiLenh += " where Type = " + Type;
                Flag = true;
            }
            else
            {
                ChuoiLenh += " and Type = " + Type;
            }
        }

        return db.ExecuteQuery<READING_PRACTICE>(ChuoiLenh);
    }

    public List<Byte[]> GetReading_PracticeContents(int ID_Unit, int Type)
    {
        IEnumerable<READING_PRACTICE> Reading_Practices = this.LayReading_Practice(ID_Unit, -1, Type);

        List<Byte[]> list = new List<Byte[]>();

        foreach (READING_PRACTICE item in Reading_Practices)
        {
            Stream stream = File.Open(System.Web.Hosting.HostingEnvironment.MapPath( "~/ClientBin/" + item.Contents + ".xml"), FileMode.Open);
            Byte[] bytes = new Byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);

            list.Add(bytes);
        }
        
        return list;
    }

    //Lấyy đường dẫn file audio
    public IEnumerable<string> GetReading_Audio(int ID_Unit)
    {
        AnhVan10DataContext db = new AnhVan10DataContext();
        string ChuoiLenh = "select Audio from READING where ID_Unit = " + ID_Unit;
        return db.ExecuteQuery<string>(ChuoiLenh);
    }
}

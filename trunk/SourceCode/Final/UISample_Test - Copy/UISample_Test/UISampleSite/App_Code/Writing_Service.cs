using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the class name "Writing_Service" here, you must also update the reference to "Writing_Service" in Web.config.
public class Writing_Service : IWriting_Service
{
    public void DoWork()
    {
    }

    public IEnumerable<WRITING> GetWritings(int ID_Unit)
    {
        AnhVan10DataContext db = new AnhVan10DataContext();
        string chuoilenh = "select * from WRITING where ID_Unit=" + ID_Unit;
        return db.ExecuteQuery<WRITING>(chuoilenh);
    }
}

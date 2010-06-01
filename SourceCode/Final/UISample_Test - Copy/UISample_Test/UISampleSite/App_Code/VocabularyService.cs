using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the class name "VocabularyService" here, you must also update the reference to "VocabularyService" in Web.config.
public class VocabularyService : IVocabularyService
{
    public void DoWork()
    {
    }

    public IEnumerable<VOCABULARY> GetVocabulary()
    {
        AnhVan10DataContext db = new AnhVan10DataContext();
        string chuoilenh = "select * from VOCABULARY";
        return db.ExecuteQuery<VOCABULARY>(chuoilenh);
    }

  
}

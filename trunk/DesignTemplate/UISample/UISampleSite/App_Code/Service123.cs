using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq;

[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class Service123
{
    [OperationContract]
    public List<VOCABULARY> GetVocabulary(int a)
    {
        AV10DataContext db = new AV10DataContext();
        var voca = from item in db.VOCABULARies select item;
        
        //var queue = from q in dc.SomeTable
        //where q.SomeDate <= DateTime.Now && q.Locked != true
        //orderby (q.Priority, q.TimeCreated)
        //select q;

        //var queue2 = dc.SomeTable
        //.Where( q => q.SomeDate <= DateTime.Now && q.Locked != true )
        //.OrderBy(q => q.Priority)
        //.ThenBy(q => q.TimeCreated);


        return voca.ToList() ;
        //cai chuan truy van nay goi la lambda expression
        //return db.VOCABULARies.Where(VOCABULARY => VOCABULARY.ID_Voc == a).ToList();
    }

    // Add more operations here and mark them with [OperationContract]
}

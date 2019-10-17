using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ASANA_connect_API_test
{

    public class Datum
    {
        public long id { get; set; }
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    [Serializable]
    public class RootObjectUsers
    {
        public List<Datum> data { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASANA_connect_API_test
{

    public class DatumWSR
    {
        public string gid { get; set; }
        public string resource_type { get; set; }
        public string name { get; set; }
    }

    public class WorkspacesRoot
    {
        public List<DatumWSR> data { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASANA_connect_API_test
{
    public class TheElement
    {
        public long id { get; set; }
        public string gid { get; set; }
        public string name { get; set; }
    }


    public class DataTaskFull
    {
        public long id { get; set; }
        public string gid { get; set; }
        public TheElement assignee { get; set; }
        public bool completed { get; set; }
        public string due_on { get; set; }
        public List<TheElement> followers { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public List<TheElement> projects { get; set; }
    }

    [Serializable]
    public class RootObjectTaskFull
    {
        public DataTaskFull data { get; set; }
    }
}

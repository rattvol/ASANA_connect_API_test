using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASANA_connect_API_test
{
    public class FollowerTR
    {
        public string gid { get; set; }
        public string name { get; set; }
    }

    public class ProjectTR
    {
        public string gid { get; set; }
        public string name { get; set; }
    }

    public class DataTR
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public bool completed { get; set; }
        public object due_on { get; set; }
        public object assignee { get; set; }
        public List<Follower> followers { get; set; }
        public List<Project> projects { get; set; }
    }

    public class RootObjectTaskResponse
    {
        public Data data { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASANA_connect_API_test
{
    public class Assignee
    {
        public long id { get; set; }
        public string gid { get; set; }
        public string resource_type { get; set; }
        public string name { get; set; }
    }

    public class Follower
    {
        public long id { get; set; }
        public string gid { get; set; }
        public string resource_type { get; set; }
        public string name { get; set; }
    }

    public class TaskWorkspace
    {
        public long id { get; set; }
        public string gid { get; set; }
        public string resource_type { get; set; }
        public string name { get; set; }
    }

    public class Project
    {
        public long id { get; set; }
        public string gid { get; set; }
        public string resource_type { get; set; }
        public string name { get; set; }
    }

    public class DataTask
    {
        public DateTime created_at { get; set; }
        public string name { get; set; }
        public object parent { get; set; }
        public object completed_at { get; set; }
        public string notes { get; set; }
        public DateTime modified_at { get; set; }
        public string assignee_status { get; set; }
        public Assignee assignee { get; set; }
        public bool completed { get; set; }
        public List<Follower> followers { get; set; }
        public TaskWorkspace workspace { get; set; }
        public object due_on { get; set; }
        public long id { get; set; }
        public string gid { get; set; }
        public string resource_type { get; set; }
        public List<Project> projects { get; set; }
    }

    public class RootObjectTask
    {
        public DataTask dataTask { get; set; }
    }
}

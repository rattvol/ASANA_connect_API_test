using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASANA_connect_API_test
{
    public class Photo
    {
        public string image_21x21 { get; set; }
        public string image_27x27 { get; set; }
        public string image_36x36 { get; set; }
        public string image_60x60 { get; set; }
        public string image_128x128 { get; set; }
    }

    public class Workspace
    {
        public long id { get; set; }
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class Data
    {
        public long id { get; set; }
        public string gid { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public Photo photo { get; set; }
        public string resource_type { get; set; }
        public List<Workspace> workspaces { get; set; }
    }

    public class RootObject
    {
        public Data data { get; set; }
    }
}

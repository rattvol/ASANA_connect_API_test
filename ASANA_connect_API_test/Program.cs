using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text;
using Newtonsoft.Json.Serialization;
using System.Web.Script.Serialization;

namespace ASANA_connect_API_test
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Connect connect = new Connect();
            while (connect.TryToken()==0)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            Application.Run(new Form1());
        }
    }
    //получение перечня задач
    public class TaskData
    {
        public List<Datum> TasksFind(string project)
        {
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/projects/" + project+"/tasks";
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            //*******только для одного запроса про пользователя**********
            RootObjectUsers meClass = new RootObjectUsers();
            meClass = (RootObjectUsers)deser.DeserializeMe(result, meClass);
            return meClass.data;
        }
    }
    //получение подробных данных по задаче
    public class TaskFullData
    {
        public DataTaskFull TasksFind(string gid)
        {
            string fullLine = "/" + gid;
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/tasks" + fullLine+ "?opt_fields=gid,assignee.name,completed,due_on,followers.name,name,notes,projects.name";
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            //*******только для одного запроса про пользователя**********
            RootObjectTaskFull meClass = new RootObjectTaskFull();
            meClass = (RootObjectTaskFull)deser.DeserializeMe(result, meClass);
            return meClass.data;
        }
    }
    public class ProjectNames
    {
        public List<Datum> ProjectsFind(string gidOfWS)
        {
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/workspaces/"+gidOfWS+"/projects";
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            //*******только для одного запроса про пользователя**********
            RootObjectUsers meClass = new RootObjectUsers();
            meClass = (RootObjectUsers)deser.DeserializeMe(result, meClass);
            return meClass.data;
        }
    }
    //**************получение данных по пользователю*******
    public class UserData
    {
        public RootObject UserFind(string userid)
        {
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/users/" + userid;
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            RootObject meClass = new RootObject();
            meClass = (RootObject)deser.DeserializeMe(result, meClass);
            return meClass;
        }
    }
    //**************получение данных о рабочих пространствах*******
    public class Workspaces
    {
        public List<DatumWSR> WorkspacesFind()
        {
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/workspaces/";
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            WorkspacesRoot meWorkspaces = new WorkspacesRoot();
            meWorkspaces = (WorkspacesRoot)deser.DeserializeMe(result, meWorkspaces);
            return meWorkspaces.data;
        }
    }

    //***************получение данных по всем пользователям(перечень)
    public class UsersData
    {
        public List<Datum> UsersFind()
        {
            string connectionLine = "https://app.asana.com/api/1.0/users";
            Connect conection = new Connect();
            string result = conection.ConnectToLinq(connectionLine);
            RootObjectUsers meClassUSD = new RootObjectUsers();
            try
            {
                DeserializeThiseJson deser = new DeserializeThiseJson();
                meClassUSD = (RootObjectUsers)deser.DeserializeMe(result, meClassUSD);
            }
            catch (Exception e)
            {
            }
            return meClassUSD.data;
        }
    }
    //********десериализация***********
    public class DeserializeThiseJson
    {
        public object DeserializeMe(string json, object deserialized)//, string findKey)
        {
            try
            {
                JavaScriptSerializer serial = new JavaScriptSerializer();
                deserialized = serial.Deserialize(json, deserialized.GetType());
            }
            catch (Exception e)
            {

            }
            return deserialized;

        }
    }
    public class Connect
    {
        public string ConnectToLinq(string conline)
        {
                string token = ConfigurationManager.AppSettings.Get("token");
                token = "Bearer " + token;
                WebHeaderCollection webHeaderCollection = new WebHeaderCollection();
                webHeaderCollection.Add(HttpRequestHeader.Authorization, token);
                WebRequest newRequest = WebRequest.Create(conline);
                newRequest.Headers = webHeaderCollection;
                WebResponse newResponse = newRequest.GetResponse();
                Stream newStream = newResponse.GetResponseStream();
                StreamReader reader = new StreamReader(newStream);
                string outline = reader.ReadToEnd();
                return outline;
        }
        public int TryToken()
        {
            string conline = "https://app.asana.com/api/1.0/users/me";
            string token = ConfigurationManager.AppSettings.Get("token");
            token = "Bearer " + token;
            try
            {
                WebHeaderCollection webHeaderCollection = new WebHeaderCollection();
                webHeaderCollection.Add(HttpRequestHeader.Authorization, token);
                WebRequest newRequest = WebRequest.Create(conline);
                newRequest.Headers = webHeaderCollection;
                WebResponse newResponse = newRequest.GetResponse();
                //Stream newStream = newResponse.GetResponseStream();
                //StreamReader reader = new StreamReader(newStream);
                return 1;
            } catch 
            {
                return 0;
            }

        }
        public string DownloadToAsana(string data)
        {
            string conline = "https://app.asana.com/api/1.0/tasks" + "?opt_fields=gid,assignee.name,completed,due_on,followers.name,name,notes,projects.name";
            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            string token = ConfigurationManager.AppSettings.Get("token");
            token = "Bearer " + token;
            WebHeaderCollection webHeaderCollection = new WebHeaderCollection();
            webHeaderCollection.Add(HttpRequestHeader.Authorization, token);
            WebRequest newRequest = WebRequest.Create(conline);
            newRequest.Headers = webHeaderCollection;
            newRequest.Method = "POST";
            newRequest.ContentType = "application/x-www-form-urlencoded";
            newRequest.ContentLength = byteArray.Length;
            Stream newInStream = newRequest.GetRequestStream();
             using (Stream writer = newRequest.GetRequestStream())
            {
                writer.Write(byteArray,0,byteArray.Length);
            }
            WebResponse newResponse = newRequest.GetResponse();
            Stream newStream = newResponse.GetResponseStream();
            StreamReader reader = new StreamReader(newStream);
            string outline = reader.ReadToEnd();
            newStream.Close();
            return outline;
        }
    }
    public class ListBoxAdding
    {
        public List<string> DataStorage { get; private set; }
        public ListBoxAdding()
        {
            this.DataStorage = new List<string>();
        }
        public void AddToList (string gid)
        {
            DataStorage.Add(gid);
        }
        public void DeleteFromList (int id)
        {
            DataStorage.RemoveAt(id);
        }
    }
}

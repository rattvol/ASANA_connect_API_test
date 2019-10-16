using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
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
            Application.Run(new Form1());
        }
    }
    //**************получение данных по пользователю*******
    public class UserData
    {
        public string UserFind()
        {
string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/users/me";
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            //*******только для одного запроса про пользователя**********
            RootObject meClass = new RootObject();
            meClass = (RootObject)deser.DeserializeMe(result, meClass);
            string resultLine = "Имя: " + meClass.data.name + ", email:" + meClass.data.email + ", группа:" + meClass.data.workspaces[2];
            return resultLine;
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
        //public Connect(string conline)
        //{
        //    ConnectToLinq(conline);
        //}
        public string ConnectToLinq(string conline)
        {
            string token = Properties.Settings.Default.token;
            token = "Bearer " + token;
            //HttpRequestHeader. WwwAuthenticate
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
    }
}

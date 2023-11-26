using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Threading;
using TMB;

namespace TMB.src
{
    internal class Utils
    {
        public const string REPO_URL = "https://api.github.com/repos/afestupinanp/tasa-metabolica/releases";
        public const string REPO_URL_DOWNLOAD = "https://github.com/afestupinanp/tasa-metabolica/releases/{version}";
        public const string SCHOOL_PROJECT_URL = "http://esperanzadevidacosfa10a.blogspot.com.co/";

        public const int MALE = 0;
        public const int FEMALE = 1;

        public enum LIFESTYLE
        {
            Sedentario = 0,
            Ligero,
            Moderada,
            Intensa,
            Muy_intensa
        };

        public static string GetVersion()
        {
            return System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        public static void VerifyNewVersion(MainForm instance)
        {
            (new Thread(() => {
                try {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(REPO_URL);
                    request.Method = WebRequestMethods.Http.Get;
                    request.Accept = "application/json; charset=utf-8";
                    request.UserAgent = "TMB2015"; // required by GitHub.
                    request.Headers.Add("Cache-Control", "no-cache");
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    if (((int)response.StatusCode) != 200)
                    {
                        throw new Exception("Web page responded non successfully.");
                    }

                    string data;
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        data = sr.ReadToEnd();
                    }

                    JArray releases = JArray.Parse(data);
                    JToken current = releases.First;
                    if (current != null) {
                        string version = (string)current.SelectToken("tag_name");
                        instance.UpdateResponse(version != null && version != GetVersion(), version);
                    } else {
                        instance.UpdateResponse(false);
                    }

                    response.Close();
                } catch (Exception e) {
                    Console.WriteLine(e.Message);

                }
            })).Start();
        }
    }
}

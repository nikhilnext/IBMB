using RupeeseedLogLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Configuration;


namespace SitefinityWebApp
{
    public class StaticData
    {

        public static string CreateLeadAPIURL = Convert.ToString(WebConfigurationManager.AppSettings["LoansCreateLeadAPIURL"]).Trim();


        public static SqlDataService.DataSuite DbAdapter =
       new SqlDataService.DataSuite((int)SqlDataService.DBEnum.SQLServer, Convert.ToString(WebConfigurationManager.ConnectionStrings["dbString"]));

        public static string RsecEcomConfigConnString { get { return Convert.ToString(ConnectionString.RsecConfig); } }

        public static SqlDataService.DataSuite conn =
      new SqlDataService.DataSuite((int)SqlDataService.DBEnum.SQLServer, Convert.ToString(WebConfigurationManager.ConnectionStrings["dbStringnew"]));

        //public static string PostRequest(string urlController, string postData)
        //{
        //    String sResponseFromServer = string.Empty;
        //    try
        //    {
               
        //        #region squareyards


        //        if (urlController == "create-lead")
        //        {

        //            WebRequest tRequest;
        //            tRequest = WebRequest.Create(CreateLeadAPIURL + urlController);
        //            // tRequest = WebRequest.Create("http://" + txtServiceIp.Text.Trim() + "/DataPub/api/SData/" + urlController);
        //            tRequest.Method = "post";
        //            tRequest.ContentType = "application/x-www-form-urlencoded";// " application/x-www-form-urlencoded;charset=UTF-8"; for plain text
        //            tRequest.Headers.Add("api_key", "420352-d79483-83fcec-ca0589-640ddc");

        //            var client = new RestClient("http://172.20.16.58:8080/id/connect/token");
        //            var request = new RestRequest(Method.POST);
        //            request.AddHeader("postman-token", "92f24147-f6c1-bcf8-6a1f-20f6b16b3c54");
        //            request.AddHeader("cache-control", "no-cache");
        //            //request.AddHeader("content-type", "application/x-www-form-urlencoded");
        //            request.AddParameter("application/x-www-form-urlencoded", "client_id=Linthub.Sms&client_secret=secret&grant_type=client_credentials&scope=linthub.api.odata", ParameterType.RequestBody);
        //            IRestResponse response = client.Execute(request);




        //            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
        //            tRequest.ContentLength = byteArray.Length;
        //            Stream dataStream = tRequest.GetRequestStream();
        //            dataStream.Write(byteArray, 0, byteArray.Length);
        //            dataStream.Close();
        //            WebResponse tResponse = tRequest.GetResponse();

        //            dataStream = tResponse.GetResponseStream();
        //            StreamReader tReader = new StreamReader(dataStream);

        //            sResponseFromServer = tReader.ReadToEnd();
        //            tReader.Close();
        //            dataStream.Close();
        //            tResponse.Close();


        //        }
          
        //        #endregion

        //    }

        //    catch (Exception ex)
        //    {
        //        sResponseFromServer = ex.ToString();
        //        string Log = string.Format("\nTime: {0}.\nData: {1}.\rStatus: {2} #", DateTime.Now.ToLongTimeString(), ex.ToString() + "\n" + ex.StackTrace.ToString(), "InMemory") + sep;
        //        LogError.WriteLog("Erorr_Trace_" + DateTime.Now.ToString("dd-MM-yy") + ".txt", Log);
        //    }
        //    return sResponseFromServer;
        //}

    }
}
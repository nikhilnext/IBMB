using RupeeseedLogLib;
using Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitefinityWebApp
{
    public partial class DealsData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        [WebMethod(EnableSession = true)]
        //public static string Data(string DealType, string Year,string Sector)
        public static string TestGitChange(string DealType, string Sector)
        {
            return "ok";
        }


        [WebMethod(EnableSession = true)]
        //public static string Data(string DealType, string Year,string Sector)
        public static string Data(string DealType, string Sector)
        {

            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            string flag = string.Empty;
            //var conn = "Data Source=192.168.2.56;User=sa;Password=1234;Initial Catalog=IBMB";
             var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        //if (DealType=="All")
                        //{
                        //    cmd.CommandText = "dbo.AllDealType";
                        //    //cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                        //    cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;

                        //}
                       //else
                       // {
                            cmd.CommandText = "dbo.Deals";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;

                      //  }                      

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            //DealJson = DealType + ":" + DealJson;
                            // flag = adapter.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            //return DealJson;
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataPriEqu(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }
                        

                        
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                           DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                          
                            // flag = adapter.ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string dataqryEquCap(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataMergAcq(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataCapMarAdv(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataCapMarket(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataPubOff(string DealType)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "dbo.DealsAllData";
                        cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataFCCB(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataBuyBack(string DealType)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "dbo.DealsAllData";
                        cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataGDR(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataECM(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

        [WebMethod(EnableSession = true)]
        public static string AllDataAcqFinc(string DealType, string Sector, string Type)
        {
            DataSet dsRes = new DataSet();
            string DealJson = string.Empty;
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbStringnew"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Type == "AllType")
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = Sector;
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = Type;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.DealsAllData";
                            cmd.Parameters.AddWithValue("@DealType", SqlDbType.VarChar).Value = DealType;
                            cmd.Parameters.AddWithValue("@Sector", SqlDbType.VarChar).Value = "";
                            cmd.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "";
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            // flag = adapter.ToString();
                        }
                    }
                }
              
            }
            catch (Exception ex)
            {
                LogError.Log_Err("Deals Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }
















    }
}
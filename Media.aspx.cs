using RupeeseedLogLib;
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
    public partial class Media : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [WebMethod(EnableSession = true)]
        public static string MediaData(string MediaType)
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

                        cmd.CommandText = "dbo.MediaData";
                        cmd.Parameters.AddWithValue("@MediaType", SqlDbType.VarChar).Value = MediaType;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogError.Log_Err("Media Data Error", ex, LogLevel.Critical);
                return "Error 404";
            }
            return DealJson;
        }

    }
}
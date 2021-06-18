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
    public partial class TrackRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(EnableSession = true)]
        public static string TrackRecordData()
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

                        cmd.CommandText = "dbo.TrackRecordData";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            DealJson = Serialization.RsJsonSerializer.JsonSerializerObjectHd(ds);
                            LogError.WriteLog("TrackRecordData DealJson" + DateTime.Now.ToString("dd-MM-yy") + ".txt", DealJson);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogError.WriteLog("TrackRecordData Error" + DateTime.Now.ToString("dd-MM-yy") + ".txt", ex.ToString());

            }
            return DealJson;
        }

    }
}
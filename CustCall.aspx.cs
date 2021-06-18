using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.Mail;
using System.Net.Mail;
using System.Net;
using System.Web.Configuration;

namespace SitefinityWebApp
{
    public partial class CustCall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //[WebMethod(EnableSession = true)]
        //public static int saveData(string fullname, string designation, string organization, string email, string number, string service)

        //{

        //    try

        //    {

        //        int status = 1;

        //        string Query = string.Empty;
        //       SqlConnection cn = new SqlConnection("Data Source = 172.20.17.53,21443; Initial Catalog = sf_YesSecurities; Persist Security Info = True; User ID = yesadmin; Password = Yes@dmin123");
        //       //SqlConnection cn = new SqlConnection("Data Source = DESKTOP-V9I382L\\SQLEXPRESS; Initial Catalog = sf_IBMB; Persist Security Info = True; User ID = sa; Password =1234");




        //        Query = "INSERT INTO CustomerCall (FULLNAME,DESIGNATION,ORGANIZATION,EMAIL_ID,NUMBER,CREATED_DATE,SERVICE) VALUES ('" + fullname + "','" + designation + "','" + organization + "','" + email + "','" + number + "',GETDATE(),'" + service + "')";

        //        SqlCommand cmd = new SqlCommand(Query, cn);


        //        cn.Open();
        //        try
        //        {

        //            cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {

        //            ex.ToString();
        //        }

        //        cn.Close();

        //        return status;

        //    }

        //    catch (Exception ex)

        //    {
        //        ex.ToString();
        //        return -2;
             
        //    }

        //}



        //[WebMethod(EnableSession = true)]

        //public static int mail(string fullname, string designation, string organization, string email, string number, string service)

        //{
        //    string a = service;
        //    int status = 1;
        //    string mailto;

        //    if (service == "M&A Advisory" || service == "Private Equity" || service == "Join Ventures" || service == "Mezzanine Financing" || service == "Sustainable Investment Banking Advisory")
        //    {
        //        mailto = "investmentbanking@yessecuritiesltd.in";
        //        // mailto = "aarti.powale1993@gmail.com";
        //    }
        //    else
        //    {
        //        //mailto = "aarti.powale2016@gmail.com";
        //        mailto = "merchantbanking@yessecuritiesltd.in";

        //    }
        //    try
        //    {

        //        string subject = "YesSecurities IBMB Call Request";



        //        string body = string.Empty;

        //        WebClient client = new WebClient();

        //        string b = "Client Call Details" + "\n" +
        //                   "Client Name:" + fullname + "\n" +
        //                   "Designation:" + designation + "\n" +
        //                   "Organiztion:" + organization + "\n" +
        //                   "Email ID:" + email + "\n" +
        //                   "Contact Number:" + number + "\n" +
        //                   "Service:" + service;
        //        string body1 = b;





        //        //id password to send the mail
        //        string id, pass;
        //        id = "artip@rupeeseed.com";
        //        pass = "jan@2018";

        //        using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage(id, mailto)) // id : sender id ------- ceomail : receiver ceo email id
        //        {
        //            mm.Subject = subject;
        //            mm.Body = body1;
        //            string mailto2 = "investmentbanking@yessecuritiesltd.in";
        //            // string mailto2 = "bhagyashris@rupeeseed.com";

        //            if (service == "Others")
        //            {
        //                mm.CC.Add(mailto2);
        //            }


        //            mm.IsBodyHtml = false;
        //            SmtpClient smtp = new SmtpClient();
        //            smtp.Host = "mail.rupeeseed.com";
        //            smtp.EnableSsl = true;
        //            NetworkCredential NetworkCred = new NetworkCredential("artip@rupeeseed.com", pass);
        //            smtp.UseDefaultCredentials = false;
        //            smtp.Credentials = NetworkCred;
        //            smtp.Port = 25;
        //            smtp.Send(mm);
        //        }

        //        return status;

        //    }

        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //        return -10;

        //    }

        //}





    }
}
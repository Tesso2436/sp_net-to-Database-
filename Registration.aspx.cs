using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Hahuregistration_form_final
{
    public partial class HahuRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            string cs =(@"DESKTOP-CR8KTOK; database =HahuSchoolInternational; integrated security = sspI");
            SqlConnection con = new SqlConnection(cs);
            sqlcommand cmd = new sqlcommand("select * from Student", con);
            con.Open();
            */
            /* GridView1.Datasource = cmd.executeReader();
             GridView1.databind();
             */
        
           /* if (IsPostBack)

            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from  Registration  where email = '"+ TxtEmailaddress.Text+ "'";
                sqlcommand com = new sqlcommand(checkuser, conn);
                int temp = Convert.ToInt32(com.executescaalar().ToString());
                if(temp == 1)
                {
                    Response.Write("user already exists");
                }

                conn.Close();
            }
            */
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment");
        }

        /*
          protected  void Button1_Click(object sender, EventArgs e, string checkuser, object ex)
          {
              try
              {
                  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                  conn.Open();
                  string insertquery = "insert into Registration(firstname, Middlename, lastnamt" +
                      "Phonenumber, Email, address) values(@firstName, @middlename," +
                      " @lastname, @phonenumber, @Email, @addrss)";
                  sqlcommand com = new sqlcommand(insertquery, conn);
                  com.parameters.Addwithvalue("@firstName", TxtFirstName.Text);
                  com.parameters.Addwithvalue("@firstName", TxtFirstName.Text);
                  com.parameters.Addwithvalue("@firstName", TxtFirstName.Text);
                  com.parameters.Addwithvalue("@firstName", TxtFirstName.Text);
                 com.executenonquery();

                  Response.Write("registration is successful");
                  Response.Redirect("Payment");
                  conn.Close();

              }
              catch(Exception )
              {

                  {
                      Response.Write("error:" + ex.ToString());
                  }
              }
          }

          protected void btnSubmit_Click(object sender, EventArgs e)
          {

          }

          /* public private void Catch(Exception exception, object ex)
           {
               throw new NotImplementedException();
           }
           */
    }

    internal class sqlcommand
    {
        private object con;

        public sqlcommand(string checkuser, object con)
        {
            this.con = con;
        }

        public object parameters { get; internal set; }

        internal void executenonquery()
        {
            throw new NotImplementedException();
        }

        internal object executescaalar()
        {
            throw new NotImplementedException();
        }
    }
}
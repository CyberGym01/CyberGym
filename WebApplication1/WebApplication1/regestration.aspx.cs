using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using WebApplication1.App_Code;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class regestration : System.Web.UI.Page
    {
        
        CRUD cr = new CRUD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegUser_Click(object sender, EventArgs e)
        {

        }
        
        bool checkMemberExists()
        {
            try
            {
                //  if () { }
               
                if (cr.con.State == ConnectionState.Closed)
                {
                    cr.con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * from Users where UserEmail = @UserEmail;", cr.con);
                string mySql = @"Select * from Users where UserEmail = @UserEmail;";
                Dictionary<string, object> InputParaList = new Dictionary<string, object>();
                InputParaList.Add("@UserEmail",txtEmail);
                int mycommand = cr.InsertUpdateDeleteViaSqlDic(mySql, InputParaList);
                if (mycommand >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        bool ValidateEmpty(string empty)
        {
            if (empty == "")
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        void signUpNewUser()
        {
            //string instructorName = txtName.Text;
            //string instructorPhone = phone.Text;
            //string instructorEmail = txtEmail.Text;
            //string Pass = txtPassword.Text;
            //string mySql = @"INSERT INTO instructor(instructor,instructorEmail, instructorPhone,instructorPassword,instructorMajorId)
            //        values(@instructor,@instructorEmail,@instructorPhone,@instructorPassword,@instructorMajorId)";
            //Dictionary<string, object> myPara = new Dictionary<string, object>();
            //myPara.Add("@instructor", instructorName);
            //myPara.Add("@instructorPhone", instructorPhone);
            //myPara.Add("@instructorEmail", instructorEmail);
            //myPara.Add("@instructorPassword", Pass);
            //myPara.Add("@instructorMajorId", DropDownList1.SelectedItem.Value);

            //CRUD myCrud = new CRUD();

            //int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            //if (rtn >= 1)
            //{



            //    Response.Write("<script>alert('Sign Up Successful. Go to User Login to Login');</script>");
            //}

            //else
            //{
            //    Response.Write("<script>alert('## line 195');</script>");
            //}
        }
    }
}
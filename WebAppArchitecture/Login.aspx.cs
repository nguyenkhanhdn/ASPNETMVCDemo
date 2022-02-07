using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string id = Request.Form["LoginID"];
        //string pwd = Request.Form["Password"];
        string id = Request.QueryString["LoginID"];
        string pwd = Request.QueryString["Password"];
        if ((id == "admin") && (pwd == "aptech"))
        {
            Response.Write("Login thanh cong");
        }
        else
        {
            Response.Write("Khong hop le, kiem tra lai");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void EmailBox_TextChanged(object sender, EventArgs e)
    {

    }
    protected void PasswordBox_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        UserClass user1 = new UserClass();


        if (user1.UserExist(this.EmailBox.Text, this.PasswordBox.Text))
        {
            Session["Type"] = "user";
            Session["user"] = user1.UserDetails(this.EmailBox.Text);
            Session["email"] = this.EmailBox.Text;
            Response.Redirect("~/homeCus.aspx");

        }
        else
        {
            if (user1.CheckAdmin(this.EmailBox.Text, this.PasswordBox.Text))
            {
                Session["Type"] = "Admin";
                Session["user"] = user1.UserDetails(this.EmailBox.Text);
                Session["email"] = this.EmailBox.Text;
                Response.Redirect("~/signup.aspx");

            }
            else
            {
                this.Label1.Visible = true;
            }


        }
    }
}









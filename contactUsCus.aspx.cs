using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contactUsCus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Type"] != "user")
            Response.Redirect("~/login.aspx");
        TextBox2.Text = Session["email"].ToString();
        Label2.Text = Session["email"].ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox3.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string messageFrom = this.TextBox2.Text;
        string messageSubject = this.TextBox4.Text;
        string messageBody = this.TextBox3.Text;
        string sqlMsgStr = "insert into [MsgTbl]([messageFrom],[messageSubject],[messageBody],[messageRead]) values('";
        sqlMsgStr += this.TextBox2.Text + "' ,'" + this.TextBox4.Text + "','" + this.TextBox3.Text + "', false)";
        DBFunctions.ChangeTable(sqlMsgStr, "UserDB.accdb");
        this.Label1.Visible = true;
        TextBox3.Text = "";
        TextBox4.Text = "";

    }
}
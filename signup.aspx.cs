using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";


    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        UserClass user1 = new UserClass();

        user1.UserEmail = TextBox1.Text;

        if (!user1.UserExistSignUp())
        {
            string userEmail = this.TextBox1.Text;
            string userPassword = this.TextBox2.Text;
            string userFirstName = this.TextBox3.Text;
            string userLastName = this.TextBox4.Text;
            string city = this.TextBox5.Text;
            string Gender = this.TextBox6.Text;


            string sqlMsgStr2 = "insert into [UserTbl]([userEmail],[userPassword],[userFirstName],[userLastName],[city],[Gender],[userType]) values('";
            sqlMsgStr2 += this.TextBox1.Text + "','" + this.TextBox2.Text + "','" + this.TextBox3.Text + "','" + this.TextBox4.Text + "','" + this.TextBox5.Text + "','" + this.TextBox6.Text + "','" + "User" + "')";

            DBFunctions.ChangeTable(sqlMsgStr2, "UserDB.accdb");
            this.Label1.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
        else
        {
            this.Label2.Visible = true;
        }
    }


    /// <summary>
    ///  string sqlMsgStr2 = "insert into [UserTbl]([userEmail],[userPassword],[userFirstName],[userLastName],[city],[Gender],[userType]) values('";
    /// sqlMsgStr2 += this.TextBox1.Text + "' ,'" + this.TextBox2.Text + "','" + this.TextBox3.Text + this.TextBox4.Text + this.TextBox5.Text + this.TextBox6.Text + this.TextBox7.Text)";
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>




}
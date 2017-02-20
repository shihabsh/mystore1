using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


public partial class ProductsCus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      /*  if (Session["Type"] != "user")
            Response.Redirect("~/login.aspx");
        EmailBox.Text = Session["email"].ToString();*/
    }
    
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
      //  Session["category"] = this.DropDownList1.SelectedValue;

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        /*int index = GridView1.SelectedIndex;
        string productID = GridView1.SelectedRow.Cells[0].Text;
        string productName = GridView1.SelectedRow.Cells[1].Text;
        string price = GridView1.SelectedRow.Cells[2].Text;
        TextBox tb = (TextBox)GridView1.SelectedRow.Cells[4].FindControl("txtquantity");
        string quantity = tb.Text;

        string sqlstr = "Insert into [ShoppingCartTbl] ([Email], [productID],[productName], [Price],[Quantity])";
        sqlstr += "values ('" + this.EmailBox.Text + "','" + productID + "','" + productName + "','" + price + "','" + quantity + "')";
        DBFunctions.ChangeTable(sqlstr, "UserDB.accdb");
        GridView1.DataBind();
        
        Response.Redirect("~/CartCus.aspx");*/

    }
   
}
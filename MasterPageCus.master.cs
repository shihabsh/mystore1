using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageCus : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Session["user"] = " ";
        Response.Redirect("~/homeV.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        form1.Style["background"] = "red";
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        form1.Style["background"] = "LightGreen ";
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        form1.Style["background"] = "FloralWhite";
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        form1.Style["background"] = "Coral";

    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        form1.Style["background"] = "CornflowerBlue";

    }
    ///  <asp:CommandField ButtonType="Button" SelectText="Add to Cart" ShowSelectButton="True" />
    ///              <asp:BoundField DataField="productId" HeaderText="productId" SortExpression="productId" />
    ///<asp:TemplateField HeaderText="Quantity" Visible="true">
    ///  <ItemTemplate>
    ///     <asp:TextBox ID="txtquantity" runat="server" Visible="true" Width="25px"></asp:TextBox>
    /// </ItemTemplate>
    ///   </asp:TemplateField>
}

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageCus.master" AutoEventWireup="true" CodeFile="ProductsCus.aspx.cs" Inherits="ProductsCus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="EmailBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <br />
    <br />
    
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="category" 
            DataValueField="category" Height="16px" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            style="text-align: center" Width="169px">
        </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>"
         ProviderName="<%$ ConnectionStrings:ConnectionString1.ProviderName %>" SelectCommand="SELECT [category] FROM [productTbl] GROUP BY [category]">
        </asp:SqlDataSource>
     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>"
         ProviderName="<%$ ConnectionStrings:ConnectionString1.ProviderName %>" SelectCommand="SELECT * FROM [productTbl] WHERE ([category]=?)">
       <SelectParameters>
                <asp:SessionParameter DefaultValue="computers" Name="category" 
                    SessionField="category" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="text-align: center">
        <Columns>
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="productName" HeaderText="Name" SortExpression="productName" />
            <asp:BoundField DataField="category" HeaderText="category" />
            
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:Image ID="Picture" runat="server" Height="200" ImageUrl='<%#Eval("image") %>' Width="200" />
                </ItemTemplate>
            </asp:TemplateField>
           
        </Columns>
    </asp:GridView>
   <!-- <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/UserDB.accdb" 
            SelectCommand="SELECT [productId], [productName], [price],[image],[category] FROM [productsTbl] WHERE ([category] = ?)">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="cold and flu" Name="category" 
                    SessionField="category" Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
            DataFile="~/App_Data/UserDB.accdb" 
            SelectCommand="SELECT DISTINCT [category] FROM [productsTbl]">
        </asp:AccessDataSource> -->
    <br />
    <br />
    <br />
</asp:Content>


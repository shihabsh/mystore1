﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageVS : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

}

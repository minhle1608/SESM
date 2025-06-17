using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChiTietBenh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["maBenh"] != null)
        {
            rpBenh.DataSource = Cls_Benh.getDataTable_SQL_pro("select * from tbBenh where MaBenh=" + Request.Params["maBenh"]);
            rpBenh.DataBind();
        }

    }

}
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChiTietTinTuc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["maTinTuc"] != null)
        {
            rpTinTuc.DataSource = Cls_TinTuc.getDataTable_SQL_pro("select * from tbTinTuc where MaTinTuc=" + Request.Params["maTinTuc"]);
            rpTinTuc.DataBind();
        }

    }

}
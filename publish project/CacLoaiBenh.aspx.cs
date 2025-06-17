using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System;

public partial class CacLoaiBenh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rpBenh.DataSource = Cls_Benh.getDataTable_My();
        if (Request.QueryString["timKiem"] != null)
        {
            string timKiem = Request.QueryString["timKiem"].ToString();
            string query = "select * from tbBenh where TenBenh like '%" + timKiem.Trim() + "%'";
            rpBenh.DataSource = Cls_Benh.getDataTable_SQL_pro(query);
            phListBenh.Visible = true;
        }
        rpBenh.DataBind();
    }
}
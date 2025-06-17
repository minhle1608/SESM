using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System;

public partial class CacLoaiPhongBan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rpPhongBan.DataSource = Cls_PhongBan.getDataTable_My();
        if (Request.QueryString["timKiem"] != null)
        {
            string timKiem = Request.QueryString["timKiem"].ToString();
            string query = "select * from tbPhongBan where TenPhongBan like '%" + timKiem.Trim() + "%'";
            rpPhongBan.DataSource = Cls_PhongBan.getDataTable_SQL_pro(query);
            phListPhongBan.Visible = true;
        }
        rpPhongBan.DataBind();
    }
}
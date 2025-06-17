using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rpTinTuc.DataSource = Cls_TinTuc.getDataTable_My();
        if (Request.QueryString["timKiem"] != null)
        {
            string timKiem = Request.QueryString["timKiem"].ToString();
            string query = "select * from tbTinTuc where TenTinTuc like N'%" + timKiem + "%'";
            rpTinTuc.DataSource = Cls_TinTuc.getDataTable_SQL_pro(query);
        }
        else if (Request.QueryString["thoat"] != null)
        {
            Session["maBenhNhan"] = null;
        }
        rpTinTuc.DataBind();
    }

}
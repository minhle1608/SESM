using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System;

public partial class CacLoaiDichVu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rpDichVu.DataSource = Cls_DichVu.getDataTable_My();
        if (Request.QueryString["timKiem"] != null)
        {
            string timKiem = Request.QueryString["timKiem"].ToString();
            string query = "select * from tbDichVu where TenDichVu like '%" + timKiem.Trim() + "%'";
            rpDichVu.DataSource = Cls_DichVu.getDataTable_SQL_pro(query);
            phListDichVu.Visible = true;
        }
        rpDichVu.DataBind();
    }
}
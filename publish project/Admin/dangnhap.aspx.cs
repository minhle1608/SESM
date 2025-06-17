using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        string tenBenhNhan = txtTenDangNhap.Text.Trim();
        string matKhau = txtMatKhau.Text.ToString();
        string query = "select * from tbBacSy where Tendangnhap='" + tenBenhNhan + "' and MatKhau='" + matKhau + "'";

        DataTable dtBenhNhanSearch = Cls_BenhNhan.getDataTable_SQL_pro(query);
       
        if (dtBenhNhanSearch.Rows.Count > 0)
        {
            Session["UserQuanTri"] = dtBenhNhanSearch.Rows[0][1].ToString();

            Response.Redirect("default.aspx");
        }
        else
        {
            Response.Write("<script>alert('Tên đăng nhập hoặc mật khẩu không đúng');</script>");
        }
    }
}
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
        string query = "select * from tbBenhNhan where TenBenhNhan like '%" + tenBenhNhan + "%'";
        DataTable dtBenhNhanSearch = Cls_BenhNhan.getDataTable_SQL_pro(query);
        Cls_BenhNhan BenhNhan = null;

        if (dtBenhNhanSearch.Rows.Count > 0)
        {
            BenhNhan = Cls_BenhNhan.converDataRow_To_Object(dtBenhNhanSearch.Rows[0]);
            string matKhau = txtMatKhau.Text.ToString();
            int maBenhNhan = BenhNhan.MaBenhNhan;
            if (BenhNhan.MatKhau.Equals(matKhau))
            {
                Session["maBenhNhan"] = maBenhNhan;
                Session["tenBenhNhan"] = BenhNhan.TenBenhNhan;
                Response.Redirect("default.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('Tên đăng nhập hoặc mật khẩu không đúng');</script>");
        }
    }
}
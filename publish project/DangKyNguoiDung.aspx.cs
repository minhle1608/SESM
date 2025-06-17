using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DangKyNguoiDung : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    //Sau khi dang ky thanh cong thi se nhay? qua trang DangNhap lun
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        try
        {
            linqBenhNhan themBenhNhan = new linqBenhNhan();
            //[MaBenhNhan]
            //,[TenBenhNhan]
            //,[DiaChi]
            //,[DienThoai]
            //,[QuyenHan]
            //,[MatKhau]
            //,[Hidden]
            themBenhNhan.TenBenhNhan = txtTenNguoiDung.Text.Trim();
            themBenhNhan.DiaChi = txtDiaChi.Text.Trim();
            themBenhNhan.DienThoai = txtDienThoai.Text.Trim();
            themBenhNhan.MatKhau = txtMatKhau.Text.Trim();
            themBenhNhan.Hidden = false;

            db.linqBenhNhans.InsertOnSubmit(themBenhNhan);
            try
            {
                db.SubmitChanges();
                Response.Redirect("dangnhap.aspx");
            }
            catch (Exception ex)
            {

            }

        }
        catch (Exception ex)
        {
            string sMessages = "alertE('Xảy ra lỗi khi lưu, Bạn vui lòng kiểm tra lại !);";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "scriptNapLai", sMessages, true);
        }
    }
}
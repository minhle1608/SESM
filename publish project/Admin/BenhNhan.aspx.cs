using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Admin_BenhNhan : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadListBenhNhan();
        }
    }
    protected void LoadListBenhNhan()
    {
        var linqBenhNhan = from lsp in db.linqBenhNhans select lsp;
        grvBenhNhan.DataSource = linqBenhNhan;
        grvBenhNhan.DataBind();
    }
    protected void imgthem_Click(object sender, ImageClickEventArgs e)
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
            themBenhNhan.TenBenhNhan = txtTenBenhNhan.Text.Trim();
            themBenhNhan.DiaChi = txtDiaChi.Text.Trim();
            themBenhNhan.DienThoai = txtDienThoai.Text.Trim();
            themBenhNhan.MatKhau = txtMatKhau.Text.Trim();
         

            db.linqBenhNhans.InsertOnSubmit(themBenhNhan);
            try
            {
                db.SubmitChanges();
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
        LoadListBenhNhan();
    }
    protected void imgcapnhat_Click(object sender, ImageClickEventArgs e)
    {
        int maBenhNhan = Int16.Parse(txtMaBenhNhan.Text.ToString());
        linqBenhNhan updateForm = db.linqBenhNhans.Single(m => m.MaBenhNhan == maBenhNhan);
        //[MaBenhNhan]
        //,[TenBenhNhan]
        //,[DiaChi]
        //,[DienThoai]
        //,[QuyenHan]
        //,[MatKhau]
        //,[Hidden]
        updateForm.TenBenhNhan = txtTenBenhNhan.Text.Trim();
        updateForm.DiaChi = txtDiaChi.Text.Trim();
        updateForm.DienThoai = txtDienThoai.Text.Trim();
        updateForm.MatKhau = txtMatKhau.Text.Trim();
        updateForm.Hidden = false;

        try
        {
            db.SubmitChanges();
            string sMessages = "alertE('Cập nhật thành công!');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "btnLuu", sMessages, true);
        }
        catch (Exception ex)
        {
            string sMessages = "alertE('Xảy ra lỗi khi cập nhật, Bạn vui lòng kiểm tra lại !');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "scriptNapLai", sMessages, true);
        } LoadListBenhNhan();
    }
    protected void imgxoa_Click(object sender, ImageClickEventArgs e)
    {
        int maBenhNhan = Int16.Parse(txtMaBenhNhan.Text.ToString());
        linqBenhNhan delForm = db.linqBenhNhans.Single(m => m.MaBenhNhan == maBenhNhan);
        db.linqBenhNhans.DeleteOnSubmit(delForm);
        try
        {
            db.SubmitChanges();
            string sMessages = " alertS('Xóa thành công!'); ";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "btnXoa", sMessages, true);
        }
        catch (Exception ex)
        {
            string sMessages = " alertE('Xóa không thành công!'); ";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "btnXoa", sMessages, true);
        }
        LoadListBenhNhan();
    }
}
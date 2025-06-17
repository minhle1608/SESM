using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_BacSy : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadListBacSy();
        }
    }
    protected void LoadListBacSy()
    {
        var linqBacsy = from lsp in db.linqBacSies select lsp;
        grvBacSy.DataSource = linqBacsy;
        grvBacSy.DataBind();
    }
    protected void imgthem_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            linqBacSy themBacsy = new linqBacSy();
            //[MaBacSy]
            //,[TenBacSy]
            //,[DiaChi]
            //,[DienThoai]
            //,[QuyenHan]
            //,[MatKhau]
            //,[Hidden]
            themBacsy.TenBacSy = txtTenBacSy.Text.Trim();
            themBacsy.DiaChi = txtDiaChi.Text.Trim();
            themBacsy.DienThoai = txtDienThoai.Text.Trim();
            themBacsy.QuyenHan = true;
            themBacsy.MatKhau = txtMatKhau.Text.Trim();
            themBacsy.Hidden = false;

            db.linqBacSies.InsertOnSubmit(themBacsy);
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
        LoadListBacSy();
    }
    protected void imgcapnhat_Click(object sender, ImageClickEventArgs e)
    {
        int maBacSy = Int16.Parse(txtMaBacSy.Text.ToString());
        linqBacSy updateForm = db.linqBacSies.Single(m => m.MaBacSy == maBacSy);
        //[MaBacSy]
        //,[TenBacSy]
        //,[DiaChi]
        //,[DienThoai]
        //,[QuyenHan]
        //,[MatKhau]
        //,[Hidden]
        updateForm.TenBacSy = txtTenBacSy.Text.Trim();
        updateForm.DiaChi = txtDiaChi.Text.Trim();
        updateForm.DienThoai = txtDienThoai.Text.Trim();
        updateForm.QuyenHan = true;
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
        } LoadListBacSy();
    }
    protected void imgxoa_Click(object sender, ImageClickEventArgs e)
    {
        int maBacSy = Int16.Parse(txtMaBacSy.Text.ToString());
        linqBacSy delForm = db.linqBacSies.Single(m => m.MaBacSy == maBacSy);
        db.linqBacSies.DeleteOnSubmit(delForm);
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
        LoadListBacSy();
    }
}
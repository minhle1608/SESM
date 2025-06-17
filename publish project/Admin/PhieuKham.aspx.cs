using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_PhieuKham : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadToBenhNhan();
            LoadToBacSy();
            LoadListPhieuKham();
            LoadChiTietBoiMaPhieuKham();
        }
    }
    private void LoadToBenhNhan()
    {
        cmbBenhNhan.DataSource = Cls_BenhNhan.getDataTable_My();
        cmbBenhNhan.DataTextField = Cls_BenhNhan.fn_TenBenhNhan;
        cmbBenhNhan.DataValueField = Cls_BenhNhan.fn_MaBenhNhan;
        cmbBenhNhan.DataBind();
    }
    private void LoadToBacSy()
    {
        cmbBacSy.DataSource = Cls_BacSy.getDataTable_My();
        cmbBacSy.DataTextField = Cls_BacSy.fn_TenBacSy;
        cmbBacSy.DataValueField = Cls_BacSy.fn_MaBacSy;
        cmbBacSy.DataBind();
    }
    protected void LoadListPhieuKham()
    {
        var linqPhieuKham = from lsp in db.linqPhieuKhams select lsp;
        grvPhieuKham.DataSource = linqPhieuKham;
        grvPhieuKham.DataBind();
    }
    protected void imgthem_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            linqPhieuKham themPhieuKham = new linqPhieuKham();
            themPhieuKham.MaBenhNhan = Int16.Parse(cmbBenhNhan.SelectedValue.ToString());
            themPhieuKham.MaBacSy = Int16.Parse(cmbBacSy.SelectedValue.ToString());
            themPhieuKham.NgayYeuCauKham = DateTime.Now;
            themPhieuKham.Hidden = false;

            db.linqPhieuKhams.InsertOnSubmit(themPhieuKham);
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
        LoadListPhieuKham();
    }
    protected void imgcapnhat_Click(object sender, ImageClickEventArgs e)
    {
        int maPhieuKham = Int16.Parse(txtMaPhieuKham.Text.ToString());
        linqPhieuKham capnhatPhieuKham = db.linqPhieuKhams.Single(m => m.MaPhieuKham == maPhieuKham);

        capnhatPhieuKham.MaBenhNhan = Int16.Parse(cmbBenhNhan.SelectedValue.ToString());
        capnhatPhieuKham.MaBacSy = Int16.Parse(cmbBacSy.SelectedValue.ToString());
        capnhatPhieuKham.NgayYeuCauKham = DateTime.Now;
        capnhatPhieuKham.Hidden = false;

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
        } LoadListPhieuKham();
    }
    protected void imgxoa_Click(object sender, ImageClickEventArgs e)
    {
        int maPhieuKham = Int16.Parse(txtMaPhieuKham.Text.ToString());
        linqPhieuKham delForm = db.linqPhieuKhams.Single(m => m.MaPhieuKham == maPhieuKham);

        db.linqPhieuKhams.DeleteOnSubmit(delForm);
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
        LoadListPhieuKham();
    }
    protected void grvPhieuKham_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row = grvPhieuKham.Rows[e.NewSelectedIndex];
        string maPhieuMuon = row.Cells[1].Text;
        string query = "select * from tbChiTietPhieuKham ctpm inner join tbBenh s on s.MaBenh = ctpm.MaBenh where MaPhieuKham = " + maPhieuMuon;
        grvChiTietPhieuKham.DataSource = Cls_ChiTietPhieuKham.getDataTable_SQL_pro(query);
        grvChiTietPhieuKham.DataBind();
    }
    protected void LoadChiTietBoiMaPhieuKham()
    {
        if (grvPhieuKham.Rows.Count > 0)
        {
            GridViewRow row = grvPhieuKham.Rows[0];
            string maPhieuMuon = row.Cells[1].Text;
            string query = "select * from tbChiTietPhieuKham ctpm inner join tbBenh s on s.MaBenh = ctpm.MaBenh where MaPhieuKham = " + maPhieuMuon;
            grvChiTietPhieuKham.DataSource = Cls_ChiTietPhieuKham.getDataTable_SQL_pro(query);
            grvChiTietPhieuKham.DataBind();
        }
    }
}
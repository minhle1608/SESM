using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DichVu : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadListDichVu();
        }
    }
    protected void LoadListDichVu()
    {
        var linqDichVu = from lsp in db.linqDichVus select lsp;
        grvDichVu.DataSource = linqDichVu;
        grvDichVu.DataBind();
    }
    protected void imgthem_Click(object sender, ImageClickEventArgs e)
    {
        string duongDan = "";
        try
        {
            if (fuHinhDaiDien.HasFile)
            {
                if (Session["maBacSy"] != null)
                {
                    linqDichVu themDichVu = new linqDichVu();
                    themDichVu.TenDichVu = txtTenDichVu.Text;
                    themDichVu.NoiDung = txtNoiDung.Text;
                    duongDan = duongDan + fuHinhDaiDien.FileName;
                    themDichVu.BieuTuong = duongDan;
                    themDichVu.Hidden = false;
                    db.linqDichVus.InsertOnSubmit(themDichVu);
                    try
                    {
                        db.SubmitChanges();
                        //up image to physical folder
                        if ((fuHinhDaiDien.PostedFile != null) && (fuHinhDaiDien.PostedFile.ContentLength > 0))
                        {
                            string fn = System.IO.Path.GetFileName(fuHinhDaiDien.PostedFile.FileName);
                            string SaveLocation = Server.MapPath("..") + "\\image\\BaiViet\\" + fn;
                            try
                            {
                                fuHinhDaiDien.PostedFile.SaveAs(SaveLocation);
                                Response.Write("The file has been uploaded.");
                            }
                            catch (Exception ex)
                            {
                                Response.Write("Error: " + ex.Message);
                                //Note: Exception.Message returns a detailed message that describes the current exception. 
                                //For security reasons, we do not recommend that you return Exception.Message to end users in 
                                //production environments. It would be better to put a generic error message. 
                            }
                        }
                        else
                        {
                            Response.Write("Please select a file to upload.");
                        }
                        Response.Write("<script>alert('Thao tác thành công!');</script>");
                    }
                    catch (Exception ex)
                    {
                        string sMessages = "alertE('Xảy ra lỗi khi lưu, Bạn vui lòng kiểm tra lại !);";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "scriptNapLai", sMessages, true);
                    }
                }
            }
            else
            {
                string sMessages = "alertE('Vui lòng chọn ảnh!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "scriptNapLai", sMessages, true);
            }
        }
        catch (Exception ex)
        {
            string sMessages = "alertE('Xảy ra lỗi khi lưu, Bạn vui lòng kiểm tra lại !);";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "scriptNapLai", sMessages, true);
        }
        LoadListDichVu();
    }
    protected void imgcapnhat_Click(object sender, ImageClickEventArgs e)
    {
        string duongDan = "";
        int maDichVu = Int16.Parse(txtMaDichVu.Text.ToString());
        linqDichVu capnhatDichVu = db.linqDichVus.Single(m => m.MaDichVu == maDichVu);

        capnhatDichVu.TenDichVu = txtTenDichVu.Text;
        capnhatDichVu.NoiDung = txtNoiDung.Text;
        duongDan = duongDan + fuHinhDaiDien.FileName;
        capnhatDichVu.BieuTuong = duongDan;
        capnhatDichVu.Hidden = false;
        try
        {
            db.SubmitChanges();
            if ((fuHinhDaiDien.PostedFile != null) && (fuHinhDaiDien.PostedFile.ContentLength > 0))
            {
                string fn = System.IO.Path.GetFileName(fuHinhDaiDien.PostedFile.FileName);
                string SaveLocation = Server.MapPath("..") + "\\image\\BaiViet\\" + fn;
                try
                {
                    fuHinhDaiDien.PostedFile.SaveAs(SaveLocation);
                    Response.Write("The file has been uploaded.");
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                    //Note: Exception.Message returns a detailed message that describes the current exception. 
                    //For security reasons, we do not recommend that you return Exception.Message to end users in 
                    //production environments. It would be better to put a generic error message. 
                }
            }
            else
            {
                Response.Write("Please select a file to upload.");
            }
            Response.Write("<script>alert('Thao tác thành công!');</script>");
        }
        catch (Exception ex)
        {
            string sMessages = "alertE('Xảy ra lỗi khi cập nhật, Bạn vui lòng kiểm tra lại !');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "scriptNapLai", sMessages, true);
        } LoadListDichVu();
    }
    protected void imgxoa_Click(object sender, ImageClickEventArgs e)
    {
        int maDichVu = Int16.Parse(txtMaDichVu.Text.ToString());
        linqDichVu delForm = db.linqDichVus.Single(m => m.MaDichVu == maDichVu);
        db.linqDichVus.DeleteOnSubmit(delForm);
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
        LoadListDichVu();
    }
}
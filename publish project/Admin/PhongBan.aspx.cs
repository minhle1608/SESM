using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_PhongBan : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadListPhongBan();
        }
    }
    protected void LoadListPhongBan()
    {
        var linqPhongBan = from lsp in db.linqPhongBans select lsp;
        grvPhongBan.DataSource = linqPhongBan;
        grvPhongBan.DataBind();
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
                    linqPhongBan themPhongBan = new linqPhongBan();
                    themPhongBan.TenPhongBan = txtTenPhongBan.Text;
                    themPhongBan.NoiDung = txtNoiDung.Text;
                    duongDan = duongDan + fuHinhDaiDien.FileName;
                    themPhongBan.BieuTuong = duongDan;
                    themPhongBan.Hidden = false;
                    db.linqPhongBans.InsertOnSubmit(themPhongBan);
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
        LoadListPhongBan();
    }
    protected void imgcapnhat_Click(object sender, ImageClickEventArgs e)
    {
        string duongDan = "";
        int maPhongBan = Int16.Parse(txtMaPhongBan.Text.ToString());
        linqPhongBan capnhatPhongBan = db.linqPhongBans.Single(m => m.MaPhongBan == maPhongBan);

        capnhatPhongBan.TenPhongBan = txtTenPhongBan.Text;
        capnhatPhongBan.NoiDung = txtNoiDung.Text;
        duongDan = duongDan + fuHinhDaiDien.FileName;
        capnhatPhongBan.BieuTuong = duongDan;
        capnhatPhongBan.Hidden = false;
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
        } LoadListPhongBan();
    }
    protected void imgxoa_Click(object sender, ImageClickEventArgs e)
    {
        int maPhongBan = Int16.Parse(txtMaPhongBan.Text.ToString());
        linqPhongBan delForm = db.linqPhongBans.Single(m => m.MaPhongBan == maPhongBan);
        db.linqPhongBans.DeleteOnSubmit(delForm);
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
        LoadListPhongBan();
    }
}
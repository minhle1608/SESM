using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using Business;
using System.IO;

public partial class Admin_edittintuc : System.Web.UI.Page
{
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack )
        {
            
        }
    }
    private void bindata()
    {
        if (Request.Params["id"] != null)
        {
            id = int.Parse(Request.Params["id"]);
            string duongDan = "";
            try
            {

                Cls_TinTuc updateTinTuc = Cls_TinTuc.getOject_Key(id);
                txtTenTinTuc.Text= updateTinTuc.TenTinTuc ;
                noidung.Text= updateTinTuc.NoiDung;
                duongDan = duongDan + fuHinhDaiDien.FileName;
                updateTinTuc.BieuTuong = duongDan;
                updateTinTuc.Hidden = false;
            }


            catch (Exception ex)
            {
                string sMessages = "alertE('Xảy ra lỗi khi lưu, Bạn vui lòng kiểm tra lại !);";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "scriptNapLai", sMessages, true);
            }
        }
    }

    protected void btnCapnhat_Click(object sender, EventArgs e)
    {
        string duongDan = "";
        try
        {
            if (fuHinhDaiDien.HasFile)
            {
                Cls_TinTuc insertTinTuc = new Cls_TinTuc();
                insertTinTuc.TenTinTuc = txtTenTinTuc.Text.Trim();
                insertTinTuc.NoiDung = noidung.Text.Trim();
                duongDan = duongDan + fuHinhDaiDien.FileName;
                insertTinTuc.BieuTuong = duongDan;
                insertTinTuc.Hidden = false;
                if (insertTinTuc.doInsert() == 1)
                {
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
    }
            
}
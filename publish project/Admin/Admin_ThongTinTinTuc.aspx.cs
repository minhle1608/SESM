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

public partial class Admin_ThongTinTinTuc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadListTinTuc();
        }
    }
    protected void LoadListTinTuc()
    {
        DataTable dt = Cls_TinTuc.getDataTable_My();
        dt.Columns.Add("STT");
        for (int i = 0; i < dt.Rows.Count; i++)
            dt.Rows[i]["STT"] = i + 1;
        grvTinTuc.DataSource = dt;
        grvTinTuc.DataBind();
    }
   


    protected void grvTinTuc_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int idTinTuc = Convert.ToInt32(grvTinTuc.DataKeys[e.RowIndex].Value);
        Cls_TinTuc clTinTuc = Cls_TinTuc.getOject_Key(idTinTuc);
        clTinTuc.MaTinTuc_find = idTinTuc;
        if (clTinTuc.doDelete() == 1)
        {
            string sMessages = " alertS('Xóa thành công!'); ";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "btnXoa", sMessages, true);
        }
        else
        {
            string sMessages = " alertE('Xóa không thành công!'); ";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "btnXoa", sMessages, true);
        }
        LoadListTinTuc();
    }

    protected void grvTinTuc_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = (grvTinTuc.DataKeys[e.NewEditIndex].Value).ToString();
        Response.Redirect("edittintuc.aspx?id=" + id);
    }
}

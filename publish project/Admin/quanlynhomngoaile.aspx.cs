using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

public partial class Admin_quanlynhomngoaile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            databind();
        }
    }
    private void databind()
    {
        Cls_ThreadQuestion threadquestion = new Cls_ThreadQuestion();
        // grdviewkhaosat.DataSourceID = null;
        DataTable dt = Cls_ThreadQuestion.GetGroupNgoaile();
        dt.Columns.Add("STT");
        for (int i = 0; i < dt.Rows.Count; i++)
            dt.Rows[i]["STT"] = i + 1;
        grvnhomngoaile.DataSource = dt;
        grvnhomngoaile.DataBind();


    }


    protected void grvnhomngoaile_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = (grvnhomngoaile.DataKeys[e.NewEditIndex].Value).ToString();
        Response.Redirect("editnhomngoaile.aspx?id=" + id);
    }

    protected void grvnhomngoaile_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grvnhomngoaile_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(grvnhomngoaile.DataKeys[e.RowIndex].Value);
        Cls_ThreadQuestion.Delete_NhomNgoaileByID(id);
        databind();
    }
}
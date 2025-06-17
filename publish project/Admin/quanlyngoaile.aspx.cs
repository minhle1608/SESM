using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

public partial class Admin_quanlyngoaile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack )
        {
            databind();
        }
    }
    private void databind()
    {
        Cls_ThreadQuestion threadquestion = new Cls_ThreadQuestion();
        // grdviewkhaosat.DataSourceID = null;
        DataTable dt = Cls_ThreadQuestion.GetNgoaile();
        dt.Columns.Add("STT");
        for (int i = 0; i < dt.Rows.Count; i++)
            dt.Rows[i]["STT"] = i + 1;
        grdviewngoaile.DataSource = dt;
        grdviewngoaile.DataBind();


    }


    protected void grdviewngoaile_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grdviewngoaile_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = (grdviewngoaile.DataKeys[e.NewEditIndex].Value).ToString();
        Response.Redirect("editngoaile.aspx?id="+id);
        
    }

    protected void grdviewngoaile_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(grdviewngoaile.DataKeys[e.RowIndex].Value);
        Cls_ThreadQuestion.Delete_NgoaileByID(id);
        databind();
    }
}
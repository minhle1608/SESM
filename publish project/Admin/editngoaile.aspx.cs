using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

public partial class Admin_editngoaile : System.Web.UI.Page
{
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            databind();
        }
    }

    protected void btntao_Click(object sender, EventArgs e)
    {
        Update();
    }
    private void databind()
    {
        if (Request.Params["id"] != null)
        {
            id = int.Parse(Request.Params["id"]);
            Cls_ThreadQuestion threadquestion = new Cls_ThreadQuestion();
            // grdviewkhaosat.DataSourceID = null;

            DataTable dt = Cls_ThreadQuestion.GetNgoaileByID(id);
            if (dt.Rows.Count>0)
            {
                txtcauhoi.Text = dt.Rows[0][6].ToString();
                ddrLuachon.SelectedValue= dt.Rows[0][2].ToString();
                ddrphanloai.SelectedValue= dt.Rows[0][3].ToString();
                noidung.Text= dt.Rows[0][4].ToString();
            }
        }
    
        

    }
    private void Update()
    {
        if (Request.Params["id"] != null)
        {
            id = int.Parse(Request.Params["id"]);
            Cls_ThreadQuestion threadquestion = new Cls_ThreadQuestion();
            // grdviewkhaosat.DataSourceID = null;

            DataTable dt = Cls_ThreadQuestion.GetNgoaileByID(id);
            if (dt.Rows.Count > 0)
            {
                int luachon = int.Parse(ddrLuachon.SelectedValue);
                int phanloai = int.Parse(ddrphanloai.SelectedValue);
                string xuly = noidung.Text;
                Cls_ThreadQuestion.Update_Ngoaile(id,luachon,phanloai,xuly);
            }
        }
        Response.Redirect("quanlyngoaile.aspx");

    }
    protected void txtcauhoi_TextChanged(object sender, EventArgs e)
    {

    }
}
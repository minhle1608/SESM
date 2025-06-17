using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

public partial class Admin_editnhomngoaile : System.Web.UI.Page
{
     int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            databind();
        }
    }
    private void databind()
    {
        
        if (Request.Params["id"] != null)
        {
            id = int.Parse(Request.Params["id"]);
            DataTable dtnhomcauhoi = Cls_ThreadQuestion.GetGroupQuestion();
            ddrQuestiongroup.DataSource = dtnhomcauhoi;
            ddrQuestiongroup.DataBind();
            if (Cls_ThreadQuestion.GetNhomNgoaileByID(id).Rows.Count > 0)
            {
                ddrQuestiongroup.SelectedValue = Cls_ThreadQuestion.GetNhomNgoaileByID(id).Rows[0][1].ToString();
                noidung.Text= Cls_ThreadQuestion.GetNhomNgoaileByID(id).Rows[0][3].ToString();
            }
            
      
        }

    }
    private void Update()
    {
        if (Request.Params["id"] != null)
        {
            id = int.Parse(Request.Params["id"]);
            // Cls_ThreadQuestion threadquestion = new Cls_ThreadQuestion();
            // grdviewkhaosat.DataSourceID = null;

            DataTable dt = Cls_ThreadQuestion.GetNhomNgoaileByID(id);
            if (dt.Rows.Count > 0)
            {
                int NhomID = int.Parse(ddrQuestiongroup.SelectedValue);
                
                string xuly = noidung.Text;
                Cls_ThreadQuestion.Update_NhomNgoaile(id, NhomID, xuly);
            }
        }
        Response.Redirect("quanlynhomngoaile.aspx");

    }

    protected void btncapnhat_Click(object sender, EventArgs e)
    {
        Update();
    }
}
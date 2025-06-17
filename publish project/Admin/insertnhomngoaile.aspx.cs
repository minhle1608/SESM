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
        insert();
    }
    private void databind()
    {
       
            // grdviewkhaosat.DataSourceID = null;

            DataTable dt = Cls_ThreadQuestion.GetGroupQuestion();
        ddrQuestiongroup.DataSource = dt;
        ddrQuestiongroup.DataBind();
               // txtcauhoi.Text = dt.Rows[0][6].ToString();
               // ddrLuachon.SelectedValue= dt.Rows[0][2].ToString();
              //  ddrphanloai.SelectedValue= dt.Rows[0][3].ToString();
                //noidung.Text= dt.Rows[0][4].ToString();
            
        
    
        

    }
    private void insert()
    {

        int groupquestionid = int.Parse(ddrQuestiongroup.SelectedValue);
                
                string xuly = noidung.Text;
                Cls_ThreadQuestion.Insert_NhomNgoaile(groupquestionid, xuly);
            
        
        Response.Redirect("quanlynhomngoaile.aspx");

    }
    protected void txtcauhoi_TextChanged(object sender, EventArgs e)
    {

    }
}
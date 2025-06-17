using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

public partial class Admin_quanlycauhoi : System.Web.UI.Page
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
        DataTable dt = Cls_ThreadQuestion.GetQuestion_ByThreadID(1);
        dt.Columns.Add("STT");
        for (int i = 0; i < dt.Rows.Count; i++)
            dt.Rows[i]["STT"] = i + 1;
        grdviewcauhoi.DataSource = dt;
        grdviewcauhoi.DataBind();
        
        
    }

    protected void grdviewcauhoi_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
          
                // reference the Delete LinkButton
                LinkButton db = (LinkButton)e.Row.Cells[7].Controls[2];
if (db.Text=="Delele")
            { 
                db.OnClientClick = "return confirm('Bạn có muốn xóa câu hỏi này?');";
            }
            // string item = e.Row.Cells[0].Text;
            DropDownList DropDowNhomcauhoi = (e.Row.FindControl("ddrnhomcauhoi") as DropDownList);
           
            DataTable dtnhomcauhoi = Cls_ThreadQuestion.GetGroupQuestion();
            HiddenField hfDepartmentId = e.Row.FindControl("IDGroupQuestion") as HiddenField;

            DropDowNhomcauhoi.DataSource = dtnhomcauhoi;

            //DropDownList1.DataTextField = "qualification";
            // DropDownList1.DataValueField = "qualification";
            DropDowNhomcauhoi.DataBind();
            DropDowNhomcauhoi.SelectedValue = hfDepartmentId.Value ;
           
            //DropDownList1.Items.Insert(0, new ListItem("--Select Qualification--", "0"));
        }
        
        }

    protected void grdviewcauhoi_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grdviewcauhoi_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(grdviewcauhoi.DataKeys[e.RowIndex].Value);
        Cls_ThreadQuestion.Delete_QuestionByID(id);
        databind();
        

    }

    protected void grdviewcauhoi_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdviewcauhoi.EditIndex = e.NewEditIndex;
        databind();
    }

    protected void grdviewcauhoi_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdviewcauhoi.EditIndex = -1;
        databind();
    }

    protected void grdviewcauhoi_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdviewcauhoi.PageIndex = e.NewPageIndex;
        databind();
    }

    protected void grdviewcauhoi_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int QuestionID = Convert.ToInt32(grdviewcauhoi.DataKeys[e.RowIndex].Value.ToString());
        GridViewRow row = (GridViewRow)grdviewcauhoi.Rows[e.RowIndex];
        Label lblID = (Label)row.FindControl("lblID");
        //TextBox txtname=(TextBox)gr.cell[].control[];  
        string question = (row.Cells[2].Controls[0] as TextBox).Text;
        string khong = ((DropDownList)row.FindControl("ddrgiatrikhong")).SelectedValue;
        string motphan = ((DropDownList)row.FindControl("ddrgiatrimotphan")).SelectedValue;
        string dung = ((DropDownList)row.FindControl("ddrgiatrichacchan")).SelectedValue;
        string nhomcauhoi = ((DropDownList)row.FindControl("ddrnhomcauhoi")).SelectedValue;
        // TextBox textadd = (TextBox)row.Cells[1].Controls[0];
        //TextBox textc = (TextBox)row.Cells[2].Controls[0];
        //TextBox textadd = (TextBox)row.FindControl("txtadd");  
        //TextBox textc = (TextBox)row.FindControl("txtc");  
        grdviewcauhoi.EditIndex = -1;
        Cls_ThreadQuestion.Update_QuestionByID(QuestionID, question, int.Parse(khong), int.Parse(motphan), int.Parse(dung), int.Parse(nhomcauhoi));
        databind();
        //conn.Open();
        //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
        //SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);
        //cmd.ExecuteNonQuery();
        //conn.Close();
       // gvbind();
    }

    protected void grdviewcauhoi_RowCreated(object sender, GridViewRowEventArgs e)
    {
    }

    protected void txtcauhoi_TextChanged(object sender, EventArgs e)
    {

    }
}
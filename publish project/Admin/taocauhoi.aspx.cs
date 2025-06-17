using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

public partial class Admin_taocauhoi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack )
        {
            binddata();
        }
    }
    private void binddata()
    {
        DataTable dtnhomcauhoi = Cls_ThreadQuestion.GetGroupQuestion();
        ddrQuestiongroup.DataSource = dtnhomcauhoi;
        ddrQuestiongroup.DataBind();

    }


    protected void btntao_Click(object sender, EventArgs e)
    {
        taocauhoi();
    }
    private void taocauhoi()
    {
        string question = txtcauhoi.Text;
        int khong = int.Parse(ddrkhong.SelectedValue);
        int motphan = int.Parse(ddrmotphan.SelectedValue);
        int hoantoan = int.Parse(ddrhoantoan.SelectedValue);
        int groupid = int.Parse(ddrQuestiongroup.SelectedValue);
        Cls_ThreadQuestion.Insert_Question(question,khong,motphan,hoantoan,groupid);
        Response.Redirect("quanlycauhoi.aspx");
    }
}
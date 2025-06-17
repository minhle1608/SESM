using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

public partial class khaosat1 : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    int maBenhNhan;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            if (Session["maBenhNhan"] != null) LoadBenhNhanBySession();
            else
                Response.Redirect("dangnhap.aspx");
            Cls_ThreadQuestion threadquestion = new Cls_ThreadQuestion();
            // grdviewkhaosat.DataSourceID = null;
            DataTable dt = Cls_ThreadQuestion.GetQuestion_ByThreadID(1);
            dt.Columns.Add("STT");
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["STT"] = i + 1;
            grdviewkhaosat.DataSource = dt;
            grdviewkhaosat.DataBind();
        }
    }
    protected void LoadBenhNhanBySession()
    {
         maBenhNhan = int.Parse(Session["maBenhNhan"].ToString());
        linqBenhNhan benhNhan = db.linqBenhNhans.Single(m => m.MaBenhNhan == maBenhNhan);
       
    }
    void getkhaosat()
    {
        string idcauhoi = "";
        int giatri=0;
        maBenhNhan = int.Parse(Session["maBenhNhan"].ToString());
        int ketquaid =Cls_ThreadQuestion.insert_ketqua_khaosat(1, maBenhNhan);

        foreach (GridViewRow gr in grdviewkhaosat.Rows)
        {
            RadioButton rb1 = new RadioButton();
            RadioButton rb2 = new RadioButton();
            RadioButton rb3 = new RadioButton();
            rb1 = (RadioButton)gr.FindControl("rbtkhongdung");
            rb2 = (RadioButton)gr.FindControl("rbtdungmotphan");
            rb3 = (RadioButton)gr.FindControl("rbtchacchandung");
            idcauhoi = grdviewkhaosat.DataKeys[gr.RowIndex].Values[0].ToString();


            if (rb1.Checked)
            {
                giatri = 0;
            }
            if (rb2.Checked)
            {
                giatri = 1;
            }
            if (rb3.Checked)
            {
                giatri = 2;
            }
            Cls_ThreadQuestion.insert_ketqua_chitiet(ketquaid, int.Parse(idcauhoi),giatri );
        }
        Cls_ThreadQuestion.ketquachuandoan(ketquaid);

    }

    protected void btnkhaosat_Click(object sender, EventArgs e)
    {
        
        getkhaosat();
        Response.Redirect("ketquakhaosat.aspx");
    }
}
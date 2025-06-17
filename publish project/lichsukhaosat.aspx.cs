using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;
public partial class lichsukhaosat : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    int maBenhNhan;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["maBenhNhan"] != null) LoadBenhNhanBySession();
            else
                Response.Redirect("dangnhap.aspx");
            Cls_ThreadQuestion threadquestion = new Cls_ThreadQuestion();
            // grdviewkhaosat.DataSourceID = null;
            DataTable dt = Cls_ThreadQuestion.Get_Lichsukhaosat_User(maBenhNhan);
            dt.Columns.Add("STT");
            dt.Columns.Add("lankhaosat");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;
                dt.Rows[i]["lankhaosat"] ="Lần khảo sát thứ " + (dt.Rows.Count- i) ;
            }
            grvLichsuketqua.DataSource = dt;
            grvLichsuketqua.DataBind();
        }
    }
    protected void LoadBenhNhanBySession()
    {
        maBenhNhan = int.Parse(Session["maBenhNhan"].ToString());
        linqBenhNhan benhNhan = db.linqBenhNhans.Single(m => m.MaBenhNhan == maBenhNhan);

    }
    void getkhaosat()
    {
        
        maBenhNhan = int.Parse(Session["maBenhNhan"].ToString());
        
        

    }
}
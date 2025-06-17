using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

public partial class _Default : System.Web.UI.Page
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
            DataTable dt = Cls_ThreadQuestion.Get_Ketquakhaosat(maBenhNhan);
            dt.Columns.Add("STT");
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["STT"] = i + 1;
            grdviewkhaosat.DataSource = dt;
            grdviewkhaosat.DataBind();
            DataTable dttomtat = Cls_ThreadQuestion.Get_TomtatketquavuakhaosatByUser(maBenhNhan);
            dttomtat.Columns.Add("STT");
            for (int i = 0; i < dttomtat.Rows.Count; i++)
                dttomtat.Rows[i]["STT"] = i + 1;
            grvTomtat.DataSource = dttomtat;
            grvTomtat.DataBind();
            getkhaosat();
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
        int giatri = 0;
        maBenhNhan = int.Parse(Session["maBenhNhan"].ToString());
        int ketquaid =int.Parse(Cls_ThreadQuestion.Get_Ketquavuakhaosat( maBenhNhan).Rows[0][0].ToString());
        if (ketquaid == 2)
        {

            lblThongbao.Text = "Bạn có vấn đề nghiêm trọng về sức khỏe tâm thần.  <a href = 'https://hengio.danang.gov.vn/' target=_blank>Vui lòng nhấn vào đây để liên hệ bác sĩ ngay </a>";
        }
        else if (ketquaid == 1)
        {
            lblThongbao.Text = "Bạn nên chú ý tới sức khỏe tâm thần. "  ;
            lblbaitap.Text = Cls_ThreadQuestion.Get_Ketquavuakhaosat(maBenhNhan).Rows[0][1].ToString();
        }
        else if (ketquaid == 0)
        {
            lblThongbao.Text = "Chúc mừng bạn, sức khỏe bạn hoàn toàn bình thường, hãy sống lành mạnh!";
        }
            //foreach (GridViewRow gr in grdviewkhaosat.Rows)
            //{
            //    RadioButton rb1 = new RadioButton();
            //    RadioButton rb2 = new RadioButton();
            //    RadioButton rb3 = new RadioButton();
            //    rb1 = (RadioButton)gr.FindControl("rbtkhongdung");
            //    rb2 = (RadioButton)gr.FindControl("rbtdungmotphan");
            //    rb3 = (RadioButton)gr.FindControl("rbtchacchandung");
            //    idcauhoi = grdviewkhaosat.DataKeys[gr.RowIndex].Values[0].ToString();


            //    if (rb1.Checked)
            //    {
            //        giatri = 0;
            //    }
            //    if (rb2.Checked)
            //    {
            //        giatri = 1;
            //    }
            //    if (rb3.Checked)
            //    {
            //        giatri = 2;
            //    }
            //    Cls_ThreadQuestion.insert_ketqua_chitiet(ketquaid, int.Parse(idcauhoi), giatri);
            //}
            //Cls_ThreadQuestion.ketquachuandoan(ketquaid);

        }

    protected void grvTomtat_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            GridView HeaderGrid = (GridView)sender;
            GridViewRow HeaderGridRow = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
            TableCell HeaderCell = new TableCell();
            HeaderCell.Text = "STT";
            HeaderCell.ColumnSpan = 1;
            HeaderCell.RowSpan = 1;



            HeaderGridRow.Cells.Add(HeaderCell);
            HeaderCell.HorizontalAlign = HorizontalAlign.Center;

            HeaderCell = new TableCell();
            HeaderCell.Text = "Biểu hiện";
            HeaderCell.ColumnSpan = 1;
            HeaderCell.RowSpan = 1;
            HeaderGridRow.Cells.Add(HeaderCell);
            HeaderCell.HorizontalAlign = HorizontalAlign.Center;

            HeaderCell = new TableCell();
            HeaderCell.Text = "Điểm chuẩn";
            HeaderCell.ColumnSpan = 3;
            HeaderCell.RowSpan = 1;
            HeaderGridRow.Cells.Add(HeaderCell);
            HeaderCell.HorizontalAlign = HorizontalAlign.Center;


            HeaderCell = new TableCell();
            HeaderCell.Text = "Kết quả";
            HeaderCell.ColumnSpan = 2;
            HeaderCell.RowSpan = 1;
            HeaderGridRow.Cells.Add(HeaderCell);
            HeaderCell.HorizontalAlign = HorizontalAlign.Center;


            HeaderCell = new TableCell();
            HeaderCell.Text = "Khuyến cáo";
            HeaderCell.ColumnSpan = 1;
            HeaderCell.RowSpan = 1;
            HeaderGridRow.Cells.Add(HeaderCell);

            HeaderCell.HorizontalAlign = HorizontalAlign.Center;

            grvTomtat.Controls[0].Controls.AddAt(0, HeaderGridRow);
        }
    }

    protected void grvTomtat_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void OnDataBound(object sender, EventArgs e)
    {

    }
}
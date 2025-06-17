using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    int maBenhNhan;
    int ketquaid=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["maBenhNhan"] != null) LoadBenhNhanBySession();
            else
                Response.Redirect("dangnhap.aspx");
            if (Request.Params["ketquaid"] != null)
            {
                ketquaid = int.Parse(Request.Params["ketquaid"]);

                Cls_ThreadQuestion threadquestion = new Cls_ThreadQuestion();
                DataTable dt = Cls_ThreadQuestion.Get_Ketquakhaosat_User_KetquaID(maBenhNhan,ketquaid);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                    dt.Rows[i]["STT"] = i + 1;
                grdviewkhaosat.DataSource = dt;
                grdviewkhaosat.DataBind();
                DataTable dttomtat = Cls_ThreadQuestion.Get_TomtatketquavuakhaosatByIDKetqua( ketquaid);
                dttomtat.Columns.Add("STT");
                for (int i = 0; i < dttomtat.Rows.Count; i++)
                    dttomtat.Rows[i]["STT"] = i + 1;
                grvTomtat.DataSource = dttomtat;
                grvTomtat.DataBind();
                getkhaosat();
            }
        }
    }
    protected void LoadBenhNhanBySession()
    {
        maBenhNhan = int.Parse(Session["maBenhNhan"].ToString());
        linqBenhNhan benhNhan = db.linqBenhNhans.Single(m => m.MaBenhNhan == maBenhNhan);

    }
    protected void OnDataBound(object sender, EventArgs e)
    {
       // grvTomtat.HeaderRow.Parent.Controls.RemoveAt(0);
       

       
       // grvTomtat.HeaderRow.Parent.Controls.AddAt(0, row);
    }
    void getkhaosat()
    {
        string idcauhoi = "";
        int giatri = 0;
        maBenhNhan = int.Parse(Session["maBenhNhan"].ToString());
        giatri = int.Parse(Cls_ThreadQuestion.Get_Ketquakhaosat_user_ketqua( maBenhNhan,ketquaid ).Rows[0][0].ToString());
        if (giatri == 2)
        {

            lblThongbao.Text = "Bạn có vấn đề nghiêm trọng về sức khỏe tâm thần.  <a href = 'https://hengio.danang.gov.vn/' target=_blank>Vui lòng nhấn vào đây để liên hệ bác sĩ ngay </a>";
        }
        else if (giatri == 1)
        {
            lblThongbao.Text = "Bạn nên chú ý tới sức khỏe tâm thần. " ;
            lbltapluyen.Text = Cls_ThreadQuestion.Get_Ketquakhaosat_user_ketqua(maBenhNhan, ketquaid).Rows[0][1].ToString();
        }
        else if (giatri == 0)
        {
            lblThongbao.Text = "Chúc mừng bạn, sức khỏe bạn hoàn toàn bình thường, hãy sống lành mạnh!";
        }
            

        }
    protected void grdviewkhaosat_RowCreated(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.Header)
        //{
        //    GridView HeaderGrid = (GridView)sender;
        //    GridViewRow HeaderGridRow = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
        //    TableCell HeaderCell = new TableCell();
        //    HeaderCell.Text = "Department";
        //    HeaderCell.ColumnSpan = 1;
        //    HeaderCell.RowSpan = 2;
        //    HeaderGridRow.Cells.Add(HeaderCell);

        //    HeaderCell = new TableCell();
        //    HeaderCell.Text = "Employee";
        //    HeaderCell.ColumnSpan = 2;
        //    HeaderGridRow.Cells.Add(HeaderCell);

        //    grdviewkhaosat.Controls[0].Controls.AddAt(0, HeaderGridRow);

        //}
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
}
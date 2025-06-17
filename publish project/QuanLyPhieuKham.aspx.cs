using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuanLyPhieuKham : System.Web.UI.Page
{
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadListPhieuKham();
            LoadChiTietBoiMaPhieuKham();
        }
    }

    protected void LoadListPhieuKham()
    {
        string maBenhNhan = Session["maBenhNhan"].ToString();
        string query = "select * from tbPhieuKHam pk"
                     + " inner join tbBenhNhan bn on bn.MaBenhNhan = pk.MaBenhNhan"
                     + " inner join tbBacSy bs on bs.MaBacSy= pk.MaBacSy"
                     + " where pk.MaBenhNhan = " + maBenhNhan;

        grvPhieuKham.DataSource = Cls_PhieuKham.getDataTable_SQL_pro(query);
        grvPhieuKham.DataBind();
    }

    protected void grvPhieuKham_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row = grvPhieuKham.Rows[e.NewSelectedIndex];
        string maPhieuMuon = row.Cells[1].Text;
        string query = "select * from tbChiTietPhieuKham ctpm inner join tbBenh s on s.MaBenh = ctpm.MaBenh where MaPhieuKham = " + maPhieuMuon;

        grvChiTietPhieuKham.DataSource = Cls_ChiTietPhieuKham.getDataTable_SQL_pro(query);
        grvChiTietPhieuKham.DataBind();
    }
    protected void LoadChiTietBoiMaPhieuKham()
    {
        if (grvPhieuKham.Rows.Count > 0)
        {
            GridViewRow row = grvPhieuKham.Rows[0];
            string maPhieuMuon = row.Cells[1].Text;
            string query = "select * from tbChiTietPhieuKham ctpm inner join tbBenh s on s.MaBenh = ctpm.MaBenh where MaPhieuKham = " + maPhieuMuon;
            grvChiTietPhieuKham.DataSource = Cls_ChiTietPhieuKham.getDataTable_SQL_pro(query);
            grvChiTietPhieuKham.DataBind();
        }
    }
}
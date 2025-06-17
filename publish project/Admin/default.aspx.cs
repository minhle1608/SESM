using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;

using System.Web.UI.DataVisualization.Charting;


public partial class Admin_ketquakhaosat : System.Web.UI.Page
{
    DateTime ngaybatdau = new DateTime(2020,1,1);
    DateTime ngayketthuc = DateTime.Today;
    int tochuc = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataTable dttochuc = Cls_ThreadQuestion.Get_Tochuc();
            ddrtochuc.DataSource = dttochuc;
            ddrtochuc.DataBind();
            ddrtochuc.Items.Insert(0, new ListItem("<<Tất cả>>", "0"));

            binddata(ngaybatdau,ngayketthuc,tochuc);
          

        }
    }
    private void binddata(DateTime batdau, DateTime ketthuc, int tochucid)
    {
                tochucid = int.Parse(ddrtochuc.SelectedItem.Value.ToString());
        DataTable dt = Cls_ThreadQuestion.Get_Ketquakhaosat_bieudo_tochuc_thoigian(batdau, ketthuc, tochucid);
        string[] x = new string[dt.Rows.Count];
        int[] y = new int[dt.Rows.Count];
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            x[i] = dt.Rows[i][1].ToString();
            y[i] = Convert.ToInt32(dt.Rows[i][0]);
        }
        Chart1.Series[0].Points.DataBindXY(x, y);
        //Chart1.Series[0].ChartType = SeriesChartType.Pie;
        //Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        //Chart1.Series["Series1"].Label = "#PERCENT{P2}";
        //Chart1.Series["Series1"].LegendText = "#VALX";
        Chart1.Legends[0].Enabled = false ;
        //Chart1.Legends[0].LegendStyle = LegendStyle.Column;
       // Chart1.Legends[0].Docking = Docking.Right;
        //.Legends[0].Alignment = System.Drawing.StringAlignment.Center;



    }


    protected void grvkhaosat_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void btnlocdulieu_Click(object sender, EventArgs e)
    {
        try { 
        ngaybatdau = DateTime.ParseExact(txtngaybatdau.Text, "yyyy-MM-dd", null);
        ngayketthuc= DateTime.ParseExact(txtngayketthuc.Text, "yyyy-MM-dd", null);
        }
        catch
        {
            ngaybatdau = DateTime.Now;
            ngayketthuc = DateTime.Now;
        }
        binddata(ngaybatdau, ngayketthuc, tochuc);
        
    }

    protected void grvkhaosat_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddrtochuc_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grvkhaosat_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
       
    }
  
}
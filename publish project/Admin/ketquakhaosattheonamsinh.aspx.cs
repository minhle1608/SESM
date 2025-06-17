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




public partial class Admin_ketquakhaosat : System.Web.UI.Page
{
    DateTime ngaybatdau = new DateTime(2020,1,1);
    DateTime ngayketthuc = DateTime.Today;
    int tochuc = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //DataTable dttochuc = Cls_ThreadQuestion.Get_Tochuc();
            //ddrGioitinh.DataSource = dttochuc;
            //ddrGioitinh.DataBind();
            //ddrGioitinh.Items.Insert(0, new ListItem("<<Tất cả>>", "0"));

            binddata(ngaybatdau,ngayketthuc,tochuc);
          

        }
    }
    private void binddata(DateTime batdau, DateTime ketthuc, int tochucid)
    {
        int namsinh1=DateTime.Now.Year-30, namsinh2 = DateTime.Now.Year;
        if (int.TryParse(txtnam1.Text,out namsinh1)&& int.TryParse(txtnam2.Text,out namsinh2 ))
        { }
                
        DataTable dt = Cls_ThreadQuestion.Get_Ketquakhaosat_namsinh_thoigian(batdau, ketthuc,namsinh1 , namsinh2 );
        dt.Columns.Add("STT");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt.Rows[i]["STT"] = i + 1;
        }
        grvkhaosat.DataSource = dt;
        grvkhaosat.DataBind();
        //foreach (GridViewRow row in grvkhaosat.Rows)
        //{
            
        //    if (row.Cells[1].Text == "2")
        //    {
        //        row.BackColor = System.Drawing.Color.Red;
        //        //grvkhaosat.AlternatingRowStyle.BackColor = System.Drawing.Color.Red;
        //    }
        //    if (row.Cells[1].Text == "1")
        //    {
        //        row.BackColor = System.Drawing.Color.YellowGreen;
        //        //grvkhaosat.AlternatingRowStyle.BackColor = System.Drawing.Color.Red;
        //    }
        //}
       
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
        grvkhaosat.Columns[1].Visible = false;
    }

    protected void grvkhaosat_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddrtochuc_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grvkhaosat_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvkhaosat.PageIndex = e.NewPageIndex;
        this.binddata(ngaybatdau, ngayketthuc, tochuc);
    }
  
}
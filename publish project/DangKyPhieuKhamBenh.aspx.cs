using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DangKyPhieuKhamBenh : System.Web.UI.Page
{
    string maBenh = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadToBenh();
            LoadToBacSy();
            if (Session["maBenhNhan"] != null) LoadBenhNhanBySession();
        }
    }
    private void LoadToBenh()
    {
        cmbTenBenh.DataSource = Cls_Benh.getDataTable_My();
        cmbTenBenh.DataTextField = Cls_Benh.fn_TenBenh;
        cmbTenBenh.DataValueField = Cls_Benh.fn_MaBenh;
        cmbTenBenh.DataBind();
    }
    private void LoadToBacSy()
    {
        cmbBacSy.DataSource = Cls_BacSy.getDataTable_My();
        cmbBacSy.DataTextField = Cls_BacSy.fn_TenBacSy;
        cmbBacSy.DataValueField = Cls_BacSy.fn_MaBacSy;
        cmbBacSy.DataBind();
    }
    private void AddProductToShopCart()
    {
        int iMaBenh = Convert.ToInt32(maBenh);
        Cls_Benh benh = Cls_Benh.getOject_Key(iMaBenh);
        string tenBenh = benh.TenBenh;

        Product newProduct = new Product();
        newProduct.ProductID = iMaBenh;
        newProduct.ProductName = tenBenh;

        ShoppingCart.Instance.AddProduct(newProduct);
        BindData();
    }
    private void BindData()
    {
        gvCart.DataSource = ShoppingCart.Instance.Products;
        gvCart.DataBind();
    }
    dbBenhVienDataContext db = new dbBenhVienDataContext();
    protected void LoadBenhNhanBySession()
    {
        int maBenhNhan = Int16.Parse( Session["maBenhNhan"].ToString());
        linqBenhNhan benhNhan = db.linqBenhNhans.Single(m => m.MaBenhNhan == maBenhNhan);
        txtTenBenhNhan.Text = benhNhan.TenBenhNhan;
        txtDiaChi.Text = benhNhan.DiaChi;
        txtDienThoai.Text = benhNhan.DienThoai;
    }
    protected void btnDangKyBenhChoPhieuKham_Click(object sender, EventArgs e)
    {
        maBenh = cmbTenBenh.SelectedValue.ToString();
        AddProductToShopCart();
    }
    protected void btnDangKy_Click(object sender, EventArgs e)
    {
        if (Session["maBenhNhan"] != null)
        {
            Cls_PhieuKham PhieuKham = new Cls_PhieuKham();
            PhieuKham.MaBenhNhan = Int16.Parse(Session["maBenhNhan"].ToString());

            string maBacSy= cmbBacSy.SelectedValue.ToString();
            PhieuKham.MaBacSy =Int16.Parse( maBacSy);
            PhieuKham.NgayYeuCauKham = DateTime.Now;
            if (PhieuKham.doInsert() == 1)
            {
                int maxPhieuKhamId = Cls_PhieuKham.getMaxIdAuto();
                foreach (Product product in ShoppingCart.Instance.Products)
                {
                    Cls_ChiTietPhieuKham ChiTietPhieuKham = new Cls_ChiTietPhieuKham();
                    ChiTietPhieuKham.MaPhieuKham = maxPhieuKhamId;
                    ChiTietPhieuKham.MaBenh = product.ProductID;
                    ChiTietPhieuKham.NgayThucKham = DateTime.Now.AddDays(2);
                    ChiTietPhieuKham.doInsert();
                }
                ShoppingCart.Instance.Clear();
            }
            Response.Redirect("~/CamOn.aspx");
        }
        else
        {
            string sMessages = "alertE('Mời bạn đăng nhập để thực hiện việc đăng ký');";
           // ScriptManager.RegisterStartupScript(this, typeof(Page), "btnLuu", sMessages, true);
        }
    }

    protected void gvCart_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
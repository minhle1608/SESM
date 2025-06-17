<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="DangKyPhieuKhamBenh.aspx.cs" Inherits="DangKyPhieuKhamBenh" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
 
    <form id="form1" >
    <div class="noidungleft">
        <div class="tieude">
           
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="16pt"
                ForeColor="#33CC33" Text="Thông Tin phiếu khám"></asp:Label>
        </div>
        <div class="lable">
            Tên bệnh :
           <br />
            <br />
            Bác sỹ  :
            <br />
            <br />
            Tên bệnh nhân  :
            <br />
            <br />
            Địa chỉ:
            <br />
            <br />
            Số điện thoại :
        </div>
        <div class="textbox">
            <div class="margin">
                <asp:DropDownList ID="cmbTenBenh" runat="server" clientinstancename="cmbTenBenh" CssClass="InputText"
                    Width="100%">
                </asp:DropDownList>
            </div>
            <div class="margin">
                <asp:DropDownList ID="cmbBacSy" runat="server" clientinstancename="cmbBacSy" CssClass="InputText"
                    Width="100%">
                </asp:DropDownList>
            </div>
            <div class="margin">
                <asp:TextBox ID="txtTenBenhNhan" runat="server" clientinstancename="txtTenBenhNhan" CssClass="InputText"
                    Width="100%">
                </asp:TextBox>
            </div>
            <div class="margin">
                 <asp:TextBox ID="txtDiaChi" runat="server" clientinstancename="txtDiaChi" CssClass="InputText"
                    Width="100%">
                </asp:TextBox>
            </div>
            <div class="margin">
                 <asp:TextBox ID="txtDienThoai" runat="server" clientinstancename="txtDienThoai" CssClass="InputText"
                    Width="100%">
                </asp:TextBox>
            </div>
            <div class="margin">
                <asp:Button ID="btnDangKyBenhChoPhieuKham" runat="server" Text="Đăng ký bệnh cho phiếu khám"
                    OnClick="btnDangKyBenhChoPhieuKham_Click" />
            </div>
            <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="false"
                CellPadding="5" DataKeyNames="ProductID"
                EmptyDataText="Bạn chưa chọn bệnh nào cả" ShowFooter="True"
                Width="100%" OnSelectedIndexChanged="gvCart_SelectedIndexChanged">
                <HeaderStyle HorizontalAlign="Left" BackColor="#3D7169" ForeColor="#FFFFFF" />
                <FooterStyle HorizontalAlign="Right" BackColor="#6C6B66" ForeColor="#FFFFFF" />
                <AlternatingRowStyle BackColor="#F8F8F8" />
                <Columns>
                    <asp:BoundField DataField="ProductName" HeaderText="Tên bệnh" />
                </Columns>
            </asp:GridView>

            <div class="margin">
                <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký phiếu khám"
                    OnClick="btnDangKy_Click" />
            </div>
            <br />
        </div>



    </div>
        </form>
</asp:Content>


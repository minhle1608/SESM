<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="dangkykhambenh.aspx.cs" Inherits="dangkykhambenh" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="textbox">
            <div class="margin">Khám bệnh:
                <asp:DropDownList ID="cmbTenBenh" runat="server" clientinstancename="cmbTenBenh" CssClass="InputText"
                    Width="100%">
                </asp:DropDownList>
            </div>
            <div class="margin">
                Bác sĩ:
                <asp:DropDownList ID="cmbBacSy" runat="server" clientinstancename="cmbBacSy" CssClass="InputText"
                    Width="100%">
                </asp:DropDownList>
            </div>
            <div class="margin">
                Tên bệnh nhân:
                <asp:TextBox ID="txtTenBenhNhan" runat="server" clientinstancename="txtTenBenhNhan" CssClass="InputText"
                    Width="100%">
                </asp:TextBox>
            </div>
            <div class="margin">
                Địa chỉ:
                 <asp:TextBox ID="txtDiaChi" runat="server" clientinstancename="txtDiaChi" CssClass="InputText"
                    Width="100%">
                </asp:TextBox>
            </div>
            <div class="margin">
                Điện thoại:
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
        <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký phiếu khám"
                    OnClick="btnDangKy_Click" />
</asp:Content>



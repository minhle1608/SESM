<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="DangKyNguoiDung.aspx.cs" Inherits="DangKyNguoiDung" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <span style="float:left;padding-left:180px;padding-bottom:30px;">ĐĂNG KÝ NGƯỜI DÙNG</span>
     
   <form id="frm" >
      <table style="width: 100%;float:left;text-align: left;">

        
        <tr>
            <th style="width: 15%;text-align:right;">Tên người dùng:
            </th>

            <th>
                <asp:TextBox ID="txtTenNguoiDung" runat="server" clientinstancename="txtTenNguoiDung" CssClass="InputText"
                    Width="40%">
                </asp:TextBox>
            </th>
        </tr>
        <tr>
            <th style="width: 15%;text-align:right;">Mật khẩu:
            </th>

            <th>
                <asp:TextBox ID="txtMatKhau" runat="server" clientinstancename="txtMatKhau" CssClass="InputText" Width="40%" >
                </asp:TextBox>
            </th>
        </tr>
        <tr>
            <th style="width: 15%;text-align:right;">Địa chỉ:
            </th>

            <th>
                <asp:TextBox ID="txtDiaChi" runat="server" clientinstancename="txtDiaChi" CssClass="InputText"
                    Width="40%" >
                </asp:TextBox>
            </th>
        </tr>
         <tr>
            <th style="width: 15%;text-align:right;">Điện thoại
            </th>

            <th>
                <asp:TextBox ID="txtDienThoai" runat="server" clientinstancename="txtDienThoai" CssClass="InputText"
                    Width="40%">
                </asp:TextBox>
            </th>
                        <asp:Button ID="btnDangNhap" runat="server" Text="Đăng ký"
                    OnClick="btnDangNhap_Click" />
       
        </tr>
    </table>
    <br />
       <div style="margin-left:150px">
       </div>
       
       </form>
</asp:Content>


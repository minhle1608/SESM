<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CacLoaiPhongBan.aspx.cs" Inherits="CacLoaiPhongBan" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .mauchu {
            float: right;
            color: red;
        }

        .chu {
            font-size: 2em;
            text-align: center;
            color: red;
            padding-left: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:PlaceHolder ID="phListPhongBan" runat="server" Visible="true">
        <asp:Repeater ID="rpPhongBan" runat="server">
            <ItemTemplate>

                <div class="khung">
                    <img style="width: 180px; height: 230px; padding: 10px 18px;" src="image/BaiViet/<%#Eval("BieuTuong")%>" />
                    <div class="nd-PhongBan">
                        <span class="chu"><%#Eval("TenPhongBan")%></span>
                        <br />
                        <span class="mauchu"><a href='ChiTietPhongBan.aspx?maPhongBan=<%#Eval("MaPhongBan")%>'>Chi tiết bệnh</a></span>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </asp:PlaceHolder>


</asp:Content>



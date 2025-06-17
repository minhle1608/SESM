<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CacLoaiDichVu.aspx.cs" Inherits="CacLoaiDichVu" %>


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
    l<asp:PlaceHolder ID="phListDichVu" runat="server" Visible="true">
        <asp:Repeater ID="rpDichVu" runat="server">
            <ItemTemplate>

                <div class="khung">
                    <img style="width: 180px; height: 230px; padding: 10px 18px;" src="image/BaiViet/<%#Eval("BieuTuong")%>" />
                    <div class="nd-DichVu">
                        <span class="chu"><%#Eval("TenDichVu")%></span>
                        <br />
                        <span class="mauchu"><a href='ChiTietDichVu.aspx?maDichVu=<%#Eval("MaDichVu")%>'>Chi tiết bệnh</a></span>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </asp:PlaceHolder>


</asp:Content>



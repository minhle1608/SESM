<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="ChiTietTin.aspx.cs" Inherits="ChiTietTinTuc" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <div class="khungnoidung">
        <asp:Repeater ID="rpTinTuc" runat="server">
            <ItemTemplate>
                <div class="khungnoidung">
                    <img width="200px" height="200px" src="image/BaiViet/<%#Eval("BieuTuong")%>" />
                </div>
                <div class="noidung">
                    <%#Eval("TenTinTuc")%><br />
                </div>
                <hr />
                <div class="noidungbaiviet">
                    Nội dung: <%#Eval("NoiDung")%><br />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="CacLoaiBenh.aspx.cs" Inherits="CacLoaiBenh" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <asp:PlaceHolder ID="phListBenh" runat="server" Visible="true">
        <asp:Repeater ID="rpBenh" runat="server">
            <ItemTemplate>

                <div >
                    <img style="width: 180px; padding: 10px 18px;" src="image/BaiViet/<%#Eval("BieuTuong")%>" />
                    
                        <span class="chu"><%#Eval("TenBenh")%></span>
                        
                        <span class="mauchu"><a href='ChiTietBenh.aspx?maBenh=<%#Eval("MaBenh")%>'>Chi tiết bệnh</a></span>
                    <br />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </asp:PlaceHolder>


</asp:Content>



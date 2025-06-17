<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="index" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">

    <asp:PlaceHolder ID="phTinTuc" runat="server" Visible="true">
        
            <div class="tieude_home2"><span>Tin tức bệnh viện</span> <a class="xem_tiep2">Xem tất cả +</a></div>
            <div style="padding-left: 5px; padding-top: 10px; padding-right: 5px; padding-bottom: 15px;">
                <asp:Repeater ID="rpTinTuc" runat="server">
                    <ItemTemplate>

                        <div >
                            <a href='ChiTietTin.aspx?maTinTuc=<%#Eval("MaTinTuc")%>'>
                                <img style="width: 180px; padding: 10px 18px;" src="image/BaiViet/<%#Eval("BieuTuong")%>" />
                            </a>
                           <span class="chu"><%#Eval("TenTinTuc")%></span>
                                
                                <span class="mauchu"><a href='ChiTietTin.aspx?maTinTuc=<%#Eval("MaTinTuc")%>'>Chi tiết tin</a></span>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
      
    </asp:PlaceHolder>
</asp:Content>


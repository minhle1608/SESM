<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="editngoaile.aspx.cs" Inherits="Admin_editngoaile" ValidateRequest="false" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 240px">Nội dung câu hỏi</td>
            <td>
                <asp:TextBox ID="txtcauhoi" runat="server" Width="100%" OnTextChanged="txtcauhoi_TextChanged" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 240px">Lựa chọn</td>
            <td>
               <asp:DropDownList ID="ddrLuachon" runat="server" SelectedValue='<%# Eval("Luachon").ToString().Trim() %>'>
                    <asp:ListItem Value="0">Không đúng</asp:ListItem>
                    <asp:ListItem Value="1">Đúng một phần</asp:ListItem>
                    <asp:ListItem Value="2">Đúng hoàn toàn</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 240px">Phân loại</td>
            <td>
                <asp:DropDownList ID="ddrphanloai" runat="server" SelectedValue='<%# Eval("Phanloai").ToString().Trim() %>'>
                  <asp:ListItem Value="0">Bình thường</asp:ListItem>
                    <asp:ListItem Value="1">Ranh giới</asp:ListItem>
                    <asp:ListItem Value="2">Có Biểu hiện</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 240px">Xử lý</td>
            <td>
                
            
                
                <asp:TextBox ID="noidung" runat="server" TextMode="MultiLine" Width="453px"></asp:TextBox>
            </td>
       
        </tr>
        
    </table>
    <asp:Button ID="btntao" runat="server" Text="Cập nhật" OnClick="btntao_Click" />
    </asp:Content>


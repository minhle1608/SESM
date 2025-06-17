<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="insertngoaile.aspx.cs" Inherits="Admin_editngoaile" ValidateRequest="false" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <table style="width:100%;" border="0">
        <tr>
            <td style="width: 240px">Nội dung câu hỏi</td>
            <td>
                <asp:DropDownList ID="ddrcauhoi" runat="server" DataTextField="Question" DataValueField="QuestionsID" Width="100%">
                </asp:DropDownList>
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
                
            
                
                <asp:TextBox ID="noidung" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
            </td>
       
        </tr>
        
    </table>
    <asp:Button ID="btntao" runat="server" Text="Thêm ngoại lệ" OnClick="btntao_Click" />
    </asp:Content>


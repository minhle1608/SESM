<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="insertnhomngoaile.aspx.cs" Inherits="Admin_editngoaile" ValidateRequest="false" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 240px">Nội dung nhóm câu hỏi</td>
            <td>
                <asp:DropDownList ID="ddrQuestiongroup" DataTextField="GroupQuestionName" DataValueField="IDGroupQuestion" runat="server">
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
    <asp:Button ID="btntao" runat="server" Text="Thêm nhóm ngoại lệ" OnClick="btntao_Click" />
    </asp:Content>


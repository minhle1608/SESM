<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="editnhomngoaile.aspx.cs" Inherits="Admin_editnhomngoaile" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 160px">Nhóm câu hỏi
            </td>
            <td>
                <asp:DropDownList ID="ddrQuestiongroup" DataTextField="GroupQuestionName" DataValueField="IDGroupQuestion" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 160px">Nội dung bài tập</td>
            <td style="height: 38px">
                
            
                
                <asp:TextBox ID="noidung" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 240px">&nbsp;</td>
            <td>
                <asp:Button ID="btncapnhat" runat="server" OnClick="btncapnhat_Click" Text="Cập nhật" />
            </td>
        </tr>
    </table>
</asp:Content>


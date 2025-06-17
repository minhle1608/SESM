<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="taocauhoi.aspx.cs" Inherits="Admin_taocauhoi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 240px">Nội dung câu hỏi</td>
            <td>
                <asp:TextBox ID="txtcauhoi" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 240px">Giá trị không</td>
            <td>
                <asp:DropDownList ID="ddrkhong" runat="server">
                    <asp:ListItem>0</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 240px">Giá trị một phần</td>
            <td>

                <asp:DropDownList ID="ddrmotphan" runat="server">
                    <asp:ListItem>0</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 240px">Giá trị hoàn toàn</td>
            <td><asp:DropDownList ID="ddrhoantoan" runat="server">
                    <asp:ListItem>0</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 240px">Nhóm câu hỏi
            </td>
            <td>
                <asp:DropDownList ID="ddrQuestiongroup" DataTextField="GroupQuestionName" DataValueField="IDGroupQuestion" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <asp:Button ID="btntao" runat="server" Text="Tạo câu hỏi" OnClick="btntao_Click" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcauhoi" ErrorMessage="Phải điền nội dung câu hỏi" ForeColor="#FF3300"></asp:RequiredFieldValidator>
</asp:Content>


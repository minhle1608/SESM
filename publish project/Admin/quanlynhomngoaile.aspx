<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="quanlynhomngoaile.aspx.cs" Inherits="Admin_quanlynhomngoaile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:GridView ID="grvnhomngoaile" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="NhomngoaileID" ForeColor="#333333" GridLines="None" Width="100%" OnRowDeleting="grvnhomngoaile_RowDeleting" OnRowEditing="grvnhomngoaile_RowEditing" OnSelectedIndexChanged="grvnhomngoaile_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="STT" HeaderText="STT" />
            <asp:BoundField DataField="NhomngoaileID" HeaderText="NhomngoaileID" InsertVisible="False" ReadOnly="True" SortExpression="NhomngoaileID" Visible="False" />
            <asp:BoundField DataField="GroupQuestionName" HeaderText="Nhóm câu hỏi" SortExpression="GroupQuestionName" />
            <asp:TemplateField HeaderText="Xử lý">
            <ItemTemplate>
                &nbsp;<script>
                // Replace the <textarea id="editor1"> with a CKEditor
                // instance, using default configuration.
               
            </script><asp:Label ID="lblxuly" runat="server" Text='<%# Eval("motaxuly").ToString().Trim() %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    </asp:Content>


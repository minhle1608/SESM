<%@ Page Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="Admin_ThongTinTinTuc.aspx.cs" Inherits="Admin_ThongTinTinTuc" Title="Administrator - Thông Tin tin tức" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <center><strong>QUẢN LÝ TIN TỨC</strong></center><asp:GridView ID="grvTinTuc" runat="server" AutoGenerateColumns="False"
        CellPadding="4" DataKeyNames="MaTinTuc"
        ForeColor="#333333" GridLines="None" PageSize="8" OnRowDeleting="grvTinTuc_RowDeleting" OnRowEditing="grvTinTuc_RowEditing">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="STT" HeaderText="STT" />
            <asp:BoundField DataField="MaTinTuc" HeaderText="Mã tin tức" ReadOnly="True" SortExpression="MaTinTuc" Visible="False" />
            <asp:BoundField DataField="TenTinTuc" HeaderText="Tên tin tức"
                SortExpression="TenTinTuc" />
            <asp:TemplateField HeaderText="Nội dung">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("NoiDung").ToString().Trim() %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />

        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <br />
    

</asp:Content>


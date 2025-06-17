<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="quanlyngoaile.aspx.cs" Inherits="Admin_quanlyngoaile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:GridView ID="grdviewngoaile" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False" DataKeyNames="NgoaileID" OnSelectedIndexChanged="grdviewngoaile_SelectedIndexChanged" OnRowEditing="grdviewngoaile_RowEditing" OnRowDeleting="grdviewngoaile_RowDeleting">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="STT" HeaderText="STT" />
        <asp:BoundField DataField="Question" HeaderText="Câu hỏi" />
        <asp:TemplateField HeaderText="Lựa chọn">
            <ItemTemplate>
                <asp:DropDownList ID="ddrLuachon" runat="server" SelectedValue='<%# Eval("Luachon").ToString().Trim() %>'>
                    <asp:ListItem Value="0">Không đúng</asp:ListItem>
                    <asp:ListItem Value="1">Đúng một phần</asp:ListItem>
                    <asp:ListItem Value="2">Đúng hoàn toàn</asp:ListItem>
                </asp:DropDownList>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Phân loại">
            <ItemTemplate>
                <asp:DropDownList ID="ddrphanloai" runat="server" SelectedValue='<%# Eval("Phanloai").ToString().Trim() %>'>
                    <asp:ListItem Value="0">Bình thường</asp:ListItem>
                    <asp:ListItem Value="1">Ranh giới</asp:ListItem>
                    <asp:ListItem Value="2">Có Biểu hiện</asp:ListItem>
                </asp:DropDownList>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Xử lý">
            <ItemTemplate>
                &nbsp;<script>
                // Replace the <textarea id="editor1"> with a CKEditor
                // instance, using default configuration.
                CKEDITOR.replace( 'editor1' );
            </script><asp:Label ID="lblxuly" runat="server" Text='<%# Eval("Xuly").ToString().Trim() %>'></asp:Label>
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


<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="quanlycauhoi.aspx.cs" Inherits="Admin_quanlycauhoi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:GridView ID="grdviewcauhoi" runat="server" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="QuestionsID" GridLines="Horizontal" Width="100%" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" OnRowDataBound="grdviewcauhoi_RowDataBound" OnSelectedIndexChanged="grdviewcauhoi_SelectedIndexChanged" OnRowDeleting="grdviewcauhoi_RowDeleting" OnRowEditing="grdviewcauhoi_RowEditing" OnPageIndexChanging="grdviewcauhoi_PageIndexChanging" OnRowCancelingEdit="grdviewcauhoi_RowCancelingEdit" OnRowCreated="grdviewcauhoi_RowCreated" OnRowUpdating="grdviewcauhoi_RowUpdating">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="STT" HeaderText="STT" SortExpression="STT" ReadOnly="True" />
            <asp:BoundField DataField="QuestionsID" HeaderText="QuestionsID" ReadOnly="True" SortExpression="QuestionsID" Visible="False" />
            <asp:BoundField DataField="Question" HeaderText="Câu hỏi" SortExpression="Question" />
            <asp:TemplateField HeaderText="Không đúng">
                <ItemTemplate>
                    <asp:DropDownList ID="ddrgiatrikhong" runat="server" SelectedValue='<%# Eval("Khong").ToString().Trim() %>'>
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đúng một phần">
                <ItemTemplate>
                    <asp:DropDownList ID="ddrgiatrimotphan" runat="server" SelectedValue='<%# Eval("Motphan").ToString().Trim() %>'>
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Chắc chắn đúng">
                <ItemTemplate>
                    <asp:DropDownList ID="ddrgiatrichacchan" runat="server" SelectedValue='<%# Eval("Hoantoan").ToString().Trim() %>'>
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nhóm">
                <ItemTemplate>
                            <asp:HiddenField ID="IDGroupQuestion" runat="server" Value='<%# Bind("IDGroupQuestion") %>' />

                    <asp:DropDownList ID="ddrnhomcauhoi" runat="server" DataTextField="GroupQuestionName" DataValueField="IDGroupQuestion">
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField HeaderText="Thao tác" ShowDeleteButton="True" ShowEditButton="True"  />
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/bv.master" AutoEventWireup="true" CodeFile="khaosat1.aspx.cs" Inherits="khaosat1" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <asp:GridView ID="grdviewkhaosat" runat="server" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="QuestionsID" GridLines="Horizontal" Width="100%" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="STT" HeaderText="STT" SortExpression="STT" />
            <asp:BoundField DataField="QuestionsID" HeaderText="QuestionsID" ReadOnly="True" SortExpression="QuestionsID" Visible="False" />
            <asp:BoundField DataField="Question" HeaderText="Câu hỏi" SortExpression="Question" />
            <asp:TemplateField HeaderText="Không đúng">
                            <ItemTemplate>
                                <asp:RadioButton ID="rbtkhongdung" runat="server" GroupName="QuestionsID" Checked="True" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Đúng một phần">
                            <ItemTemplate>
                                <asp:RadioButton ID="rbtdungmotphan" runat="server" GroupName="QuestionsID" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Chắc chắn đúng">
                            <ItemTemplate >
                                <asp:RadioButton ID="rbtchacchandung" runat="server" GroupName="QuestionsID"  />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
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
        <asp:Button ID="btnkhaosat" runat="server" OnClick="btnkhaosat_Click" Text="Gửi khảo sát" />
</form>
</asp:Content>


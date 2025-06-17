<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="lichsukhaosat.aspx.cs" Inherits="lichsukhaosat" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">

    <form id="form1" >
        <asp:GridView ID="grvLichsuketqua" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="KetquaID,Expr3" ForeColor="#333333" GridLines="None" Width="100%">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="STT" HeaderText="STT" />
                <asp:BoundField DataField="KetquaID" HeaderText="KetquaID" InsertVisible="False" ReadOnly="True" SortExpression="KetquaID" Visible="False" />
                <asp:BoundField DataField="TenBenhNhan" HeaderText="Tên bệnh nhân" SortExpression="TenBenhNhan" />
                <asp:BoundField DataField="lankhaosat" HeaderText="Lần khảo sát" />
                <asp:BoundField DataField="Expr2" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Thời gian khảo sát" SortExpression="Expr2" />
  <asp:TemplateField HeaderText="Tổng điểm">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Tongdiem") %> ' tooltip='<%# Eval("nhomdiem") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>                <asp:BoundField DataField="Giatriketqua" HeaderText="Kết quả" SortExpression="Giatriketqua" />
                <asp:HyperLinkField DataNavigateUrlFields="KetquaID" DataNavigateUrlFormatString="~\ketquakhaosatchitiet.aspx?ketquaid={0}"  DataTextFormatString="{0:c}" HeaderText="Chi tiết" Text="Xem chi tiết" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </form>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="ketquakhaosat.aspx.cs" Inherits="Admin_ketquakhaosat" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <center>
    THỐNG KÊ KHẢO SÁT TÂM LÝ HỌC ĐƯỜNG THEO TỔ CHỨC<br />
            
    </center>Ngày bắt đầu:
    <asp:TextBox ID="txtngaybatdau" runat="server"  TextMode="Date" Width="139px" ></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp; Ngày kết thúc:
    <asp:TextBox ID="txtngayketthuc" runat="server"  TextMode="Date" Width="137px" ></asp:TextBox>
            Tổ chức:&nbsp;<asp:DropDownList ID="ddrtochuc" runat="server" DataTextField="Tentochuc" DataValueField="TochucID" OnSelectedIndexChanged="ddrtochuc_SelectedIndexChanged">
            </asp:DropDownList>
     <asp:Button ID="btnlocdulieu" runat="server" OnClick="btnlocdulieu_Click" Text="Lọc dữ liệu" />
            <asp:GridView ID="grvkhaosat" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="KetquaID" ForeColor="#333333" GridLines="None" Width="100%" OnRowDataBound="grvkhaosat_RowDataBound" AllowPaging="True" EnableSortingAndPagingCallbacks="True" OnPageIndexChanging="grvkhaosat_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="KetquaID" HeaderText="KetquaID" InsertVisible="False" ReadOnly="True" SortExpression="KetquaID" Visible="False" />
            <asp:BoundField DataField="Ketqua" HeaderText="Ketqua" ReadOnly="True" SortExpression="Ketqua" Visible="False" />

            <asp:BoundField DataField="STT" HeaderText="STT" SortExpression="STT" />
            <asp:BoundField DataField="Timekhaosat" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Thời gian" SortExpression="Timekhaosat" />
            <asp:BoundField DataField="Tenhienthi" HeaderText="Người khảo sát" SortExpression="Tenhienthi" />
            <asp:BoundField DataField="Tentochuc" HeaderText="Tổ chức" SortExpression="Tentochuc" />
            <asp:BoundField DataField="DiaChi" HeaderText="Bộ phận" SortExpression="DiaChi" />
            <asp:BoundField DataField="TheadName" HeaderText="Tên khảo sát" SortExpression="TheadName" Visible="False" />
            <asp:TemplateField HeaderText="Tổng điểm">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Tongdiem") %> ' tooltip='<%# Eval("nhomdiem") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Giatriketqua" HeaderText="Kết quả" SortExpression="Giatriketqua" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
         
   </ContentTemplate>
   </asp:UpdatePanel>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="PhieuKham.aspx.cs" Inherits="Admin_PhieuKham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="16pt"
            ForeColor="#33CC33" Text="Thông Tin phiếu khám"></asp:Label>
        <br />
        <asp:GridView ID="grvPhieuKham" runat="server" AutoGenerateColumns="False"
            CellPadding="4" DataKeyNames="MaPhieuKham"
            ForeColor="#333333" GridLines="None" PageSize="8"
            AutoGenerateSelectButton="true"
            OnSelectedIndexChanging="grvPhieuKham_SelectedIndexChanging">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="MaPhieuKham" HeaderText="Mã phiếu khám" ReadOnly="True"
                    SortExpression="MaPhieuKham" />
                <asp:BoundField DataField="MaBenhNhan" HeaderText="Mã bệnh nhân" ReadOnly="True"
                    SortExpression="MaBenhNhan" />
                <asp:BoundField DataField="MaBacSy" HeaderText="Mã bác sỹ"
                    SortExpression="MaBacSy" />
                <asp:BoundField DataField="NgayYeuCauKham" HeaderText="Ngày yêu cầu khám"
                    SortExpression="NgayYeuCauKham" />
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="16pt"
            ForeColor="#33CC33" Text="Thông Tin chi tiết phiếu khám"></asp:Label>
        <br />
        <asp:GridView ID="grvChiTietPhieuKham" runat="server" AutoGenerateColumns="False"
            CellPadding="4" DataKeyNames="MaChiTietPhieuKham"
            ForeColor="#333333" GridLines="None" PageSize="8">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="MaChiTietPhieuKham" HeaderText="Mã chi tiết phiếu khám" ReadOnly="True"
                    SortExpression="MaChiTietPhieuKham" />
                <asp:BoundField DataField="MaBenh" HeaderText="Mã bệnh" ReadOnly="True"
                    SortExpression="MaBenh" />
                <asp:BoundField DataField="TenBenh" HeaderText="Tên bệnh" ReadOnly="True"
                    SortExpression="TenBenh" />
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <br />
        <br />
        <table style="width: 67%; text-align: right;">
            <tr>
                <th >Mã&nbsp; phiếu&nbsp; khám
                </th>
                <th style="width: 150px">
                    <asp:TextBox ID="txtMaPhieuKham" runat="server" clientinstancename="txtMaPhieuKham" CssClass="InputText"
                        Width="100%">
                    </asp:TextBox>
                </th>
            </tr>
            <tr>
                <th >Mã&nbsp; bệnh &nbsp;nhân
                </th>

                <th style="width: 150px">
                    <asp:DropDownList ID="cmbBenhNhan" runat="server" clientinstancename="cmbBenhNhan" CssClass="InputText"
                        Width="100%">
                    </asp:DropDownList>
                </th>
            </tr>

            <tr>
                <th >Bác&nbsp; sỹ
                </th>

                <th style="width: 150px">
                    <asp:DropDownList ID="cmbBacSy" runat="server" clientinstancename="cmbBacSy" CssClass="InputText"
                        Width="100%">
                    </asp:DropDownList>
                </th>
            </tr>
        </table>
        <br />
        <asp:ImageButton ID="imgthem" runat="server" ImageUrl="~/icon/Add.png"
            ToolTip="Thêm mới" OnClick="imgthem_Click" />
        <asp:ImageButton ID="imgcapnhat" runat="server" ImageUrl="~/icon/Load.png"
            ToolTip="Cập nhật" OnClick="imgcapnhat_Click" />
        <asp:ImageButton ID="imgxoa" runat="server" ImageUrl="~/icon/Delete.png"
            ToolTip="Xóa" OnClick="imgxoa_Click" />
    </div>
</asp:Content>


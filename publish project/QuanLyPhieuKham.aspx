<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QuanLyPhieuKham.aspx.cs" Inherits="QuanLyPhieuKham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .noidung_left {
            float: left;
            width: 500px;
            height: auto;
            text-align: center;
            padding-left: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="frm" runat="server">
        <div class="noidung_left">
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
                    <asp:BoundField DataField="TenBenhNhan" HeaderText="Tên bệnh nhân" ReadOnly="True"
                        SortExpression="TenBenhNhan" />
                    <asp:BoundField DataField="TenBacSy" HeaderText="Tên bác sỹ"
                        SortExpression="TenBacSy" />
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
        </div>
    </form>
</asp:Content>


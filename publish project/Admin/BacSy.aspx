<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="BacSy.aspx.cs" Inherits="Admin_BacSy" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="16pt"
            ForeColor="#33CC33" Text="Thông Tin bác sỹ"></asp:Label>
        <br />
        <asp:GridView ID="grvBacSy" runat="server" AutoGenerateColumns="False"
            CellPadding="4" DataKeyNames="MaBacSy"
            ForeColor="#333333" GridLines="None" PageSize="8">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="MaBacSy" HeaderText="Mã bác sỹ" ReadOnly="True"
                    SortExpression="MaBacsy" />
                <asp:BoundField DataField="TenBacSy" HeaderText="Tên bác sỹ"
                    SortExpression="TenBacsy" />
                <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ"
                    SortExpression="DiaChi" />
                <asp:BoundField DataField="DienThoai" HeaderText="Điện thoại"
                    SortExpression="DienThoai" />
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <br />
        <!--//[MaBacSy]
            //,[TenBacSy]
            //,[DiaChi]
            //,[DienThoai]
            //,[QuyenHan]
            //,[MatKhau]
            //,[Hidden]-->
        <br />
        <table style="width: 100%; text-align: right;">
            <tr>
                <th >Mã&nbsp; bác&nbsp; sỹ
                </th>
                <th style="width: 100px">
                    <asp:TextBox ID="txtMaBacSy" runat="server" clientinstancename="txtMaBacSy" CssClass="InputText"
                        Width="100%">
                    </asp:TextBox>
                </th>
            </tr>
            <tr>
                <th >Tên&nbsp; bác&nbsp; sỹ
                </th>

                <th style="width: 100px">
                    <asp:TextBox ID="txtTenBacSy" runat="server" clientinstancename="txtTenBacSy" CssClass="InputText"
                        Width="100%">
                    </asp:TextBox>
                </th>
            </tr>

            <tr>
                <th >Địa&nbsp; chỉ
                </th>

                <th style="width: 100px">
                    <asp:TextBox ID="txtDiaChi" runat="server" clientinstancename="txtDiaChi" CssClass="InputText"
                        Width="100%">
                    </asp:TextBox>
                </th>
            </tr>
            <tr>
                <th >Điện&nbsp; thoại
                </th>

                <th style="width: 100px">
                    <asp:TextBox ID="txtDienThoai" runat="server" clientinstancename="txtDienThoai" CssClass="InputText"
                        Width="100%">
                    </asp:TextBox>
                </th>
            </tr>
            <tr>
                <th >Mật khẩu
                </th>

                <th style="width: 100px">
                    <asp:TextBox ID="txtMatKhau" runat="server" clientinstancename="txtMatKhau" CssClass="InputText"
                        Width="100%">
                    </asp:TextBox>
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


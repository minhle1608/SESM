<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Benh.aspx.cs" Inherits="Admin_Benh" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="16pt"
            ForeColor="#33CC33" Text="Thông Tin bệnh "></asp:Label>
        <br />
        <asp:GridView ID="grvBenh" runat="server" AutoGenerateColumns="False"
            CellPadding="4" DataKeyNames="MaBenh"
            ForeColor="#333333" GridLines="None" PageSize="8">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="MaBenh" HeaderText="Mã bệnh " ReadOnly="True"
                    SortExpression="MaBenh" />
                <asp:BoundField DataField="TenBenh" HeaderText="Tên bệnh "
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
        <!--[MaBenh]
      ,[TenBenh]
      ,[BieuTuong]
      ,[NoiDung]
      ,[Hidden]-->
        <br />
        <table style="width: 100%; text-align: right;">
            <tr>
                <th >Mã&nbsp; bệnh 
                </th>
                <th style="width: 150px">
                    <asp:TextBox ID="txtMaBenh" runat="server" clientinstancename="txtMaBenh" CssClass="InputText"
                        Width="100%">
                    </asp:TextBox>
                </th>
            </tr>
            <tr>
                <th >Tên&nbsp; bệnh 
                </th>

                <th style="width: 150px">
                    <asp:TextBox ID="txtTenBenh" runat="server" clientinstancename="txtTenBenh" CssClass="InputText"
                        Width="100%">
                    </asp:TextBox>
                </th>
            </tr>
            <tr>
                <th >Hình&nbsp; ảnh
                </th>

                <th style="width: 150px">
                    <asp:FileUpload ID="fuHinhDaiDien" runat="server" />
                </th>
                <tr>
                    <th >Nội&nbsp; dung
                    </th>

                    <th style="width: 150px">
                        <asp:TextBox ID="txtNoiDung" runat="server" clientinstancename="txtNoiDung" CssClass="InputText"
                            Width="100%">
                        </asp:TextBox>
                    </th>
                </tr>
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


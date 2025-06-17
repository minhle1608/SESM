<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master"ValidateRequest="false"  AutoEventWireup="true" CodeFile="inserttintuc.aspx.cs" Inherits="Admin_edittintuc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <table style="width: 100%; align-content='left'" >
       
        <tr>
            <th >Tên tin tức </th>
            <th>
                <asp:TextBox ID="txtTenTinTuc" runat="server" clientinstancename="txtTenTinTuc" Width="100%"  ></asp:TextBox>
            </th>
        </tr>
        <tr>
            <th>Nội dung </th>
            <th>
                <asp:TextBox ID="noidung" runat="server" clientinstancename="noidung" TextMode="MultiLine" Width="100%"></asp:TextBox>
            </th>
        </tr>
        <tr>
            <th>Hình đại diện</th>
            <th >
                <asp:FileUpload ID="fuHinhDaiDien" runat="server" />
                
            </th>
        </tr>
    </table>
    <asp:Button ID="btnCapnhat" runat="server" Text="Tạo mới" OnClick="btnCapnhat_Click" />
</asp:Content>


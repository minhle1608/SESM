<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="bieudokhaosatgioitinh.aspx.cs" Inherits="Admin_ketquakhaosat" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <center>
            BIỂU ĐỒ THỐNG KÊ KHẢO SÁT TÂM LÝ HỌC ĐƯỜNG THEO GIỚI TÍNH<br />
            
    </center>Ngày bắt đầu:
    <asp:TextBox ID="txtngaybatdau" runat="server"  TextMode="Date" Width="139px" ></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp; Ngày kết thúc:
    <asp:TextBox ID="txtngayketthuc" runat="server"  TextMode="Date" Width="137px" ></asp:TextBox>
            Giới tính:&nbsp;<asp:DropDownList ID="ddrGioitinh" runat="server" OnSelectedIndexChanged="ddrtochuc_SelectedIndexChanged">
                <asp:ListItem Value="0">Nam</asp:ListItem>
                <asp:ListItem Value="1">Nữ</asp:ListItem>
            </asp:DropDownList>
     <asp:Button ID="btnlocdulieu" runat="server" OnClick="btnlocdulieu_Click" Text="Lọc dữ liệu" />
            <br />
            <asp:Chart ID="Chart1" runat="server" Width="800px">
                <Legends>
                    <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" LegendStyle="Row" Name="Default" />
                </Legends>
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
         
   </ContentTemplate>
   </asp:UpdatePanel>
</asp:Content>


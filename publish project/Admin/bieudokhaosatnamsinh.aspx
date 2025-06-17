<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="bieudokhaosatnamsinh.aspx.cs" Inherits="Admin_ketquakhaosat" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <center>
            BIỂU ĐỒ THỐNG KÊ KHẢO SÁT TÂM LÝ HỌC ĐƯỜNG THEO NĂM SINH<br />
            
    </center>Ngày bắt đầu:
    <asp:TextBox ID="txtngaybatdau" runat="server"  TextMode="Date" Width="139px" ></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp; Ngày kết thúc:
    <asp:TextBox ID="txtngayketthuc" runat="server"  TextMode="Date" Width="137px" ></asp:TextBox>
            &nbsp;Năm sinh bắt đầu:<asp:TextBox ID="txtnam1" runat="server" TextMode="Number" Width="80px"></asp:TextBox>
            &nbsp;Năm sinh kết thúc:<asp:TextBox ID="txtnam2" runat="server" TextMode="Number" Width="80px"></asp:TextBox>
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


<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="ketquakhaosat.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <form id="form1" >
                <asp:Label ID="lblThongbao" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC3300"></asp:Label>

                <br />
        <asp:GridView ID="grvTomtat" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IDGroupQuestion" ForeColor="#333333" GridLines="None" OnRowCreated="grvTomtat_RowCreated" OnRowDataBound="grvTomtat_RowDataBound" OnDataBound = "OnDataBound" Width="100%">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="STT"  ReadOnly="True" SortExpression="STT" >
                        <HeaderStyle BorderStyle="None" />
                        </asp:BoundField>
                        <asp:BoundField DataField="GroupQuestionName" SortExpression="GroupQuestionName" />
                        <asp:BoundField DataField="binhthuong" HeaderText="Bình thường" ReadOnly="True" SortExpression="binhthuong" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ranhgioi" HeaderText="Ranh giới" ReadOnly="True" SortExpression="ranhgioi" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cobieuhien" HeaderText="Có biểu hiện" ReadOnly="True" SortExpression="cobieuhien" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Diem" HeaderText="Điểm đạt" ShowHeader="False" SortExpression="Diem" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Giatriketqua" HeaderText="Mức độ" ShowHeader="False" SortExpression="Giatriketqua" />
                        <asp:BoundField DataField="Ghichu" ShowHeader="False" SortExpression="Ghichu" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:Label ID="lblbaitap" runat="server"></asp:Label>
        <asp:GridView ID="grdviewkhaosat" runat="server" AutoGenerateColumns="False" CellPadding="4" GridLines="None" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="STT" HeaderText="STT" />
                <asp:BoundField DataField="Question" HeaderText="Câu hỏi" SortExpression="Question" />
                <asp:BoundField DataField="Luachon" HeaderText="Luachon" SortExpression="Luachon" Visible="False" />
                <asp:TemplateField HeaderText="Không đúng">
                            <ItemTemplate>
                                <asp:RadioButton ID="rbtkhongdung" runat="server" GroupName="QuestionsID" Checked='<%# Eval("Luachon").ToString().Trim()=="0" %>' Enabled="False"    />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Đúng một phần">
                            <ItemTemplate>
                                <asp:RadioButton ID="rbtdungmotphan" runat="server" GroupName="QuestionsID" Checked='<%# Eval("Luachon").ToString().Trim()=="1" %>' Enabled="False" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Chắc chắn đúng">
                            <ItemTemplate >
                                <asp:RadioButton ID="rbtchacchandung" runat="server" GroupName="QuestionsID" Checked='<%# Eval("Luachon").ToString().Trim()=="2" %>' Enabled="False"  />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
                l</form>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/benhvien.master" AutoEventWireup="true" CodeFile="dangnhap.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <div class="khung_body">

 <div style="background-color: #CDEBF6">
        <div id="divSep1" style="height: 40px">
        </div>
        <div id="divMain" align="center">
            <div style="width: 889px; height: 393px;">
                <div style="width: 610px; float: left; height: 392px;">
                   <img src="image/login.jpg" />
                </div>
                <div style="width: 277px; text-align: left; float: right; height: 390px; background:#f5f5f5;">
						
                    <div style="height: 78px;padding-top:10px;">
					<h1 style="text-shadow: 1px 1px #fff;text-align:center;">ĐĂNG NHẬP QUẢN TRỊ</h1>
                    </div>
					
                    <div>
                        <br />
                       Tên đăng nhập: 
						 <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
                      
                    </div>
                    <div style="height: 23px;">
                    </div>
                 
                        Mật khẩu:  <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                      
				
                    <div style="height: 23px">
                    </div>
                  
                    <div>
                        <div style="height: 10px;">
                        </div>
                        <div style="text-align:center;">
                         <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập"
                    OnClick="btnDangNhap_Click" />
                        </div>
                     
                    </div>
                </div>
            </div>
        </div>
        <div id="divSep2" style="height: 40px; vertical-align: middle; font-size: small;
            text-align: center">
        </div>
    </div>
   
</div>
</asp:Content>


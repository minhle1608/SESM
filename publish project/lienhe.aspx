<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="lienhe.aspx.cs" Inherits="lienhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    			<div class="box_left">
        	<div class="tieude_home2"><span>Liên hệ</span></div>
            <div style="padding-bottom:15px; padding-top:5px;">
           <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.2.6/jquery.js"></script>
           <div>
         

<div style="padding-top:10px;text-align:center; line-height:18px">MỌI CHI TIẾT XIN LIÊN HỆ</div>

<form action="" method="post">
<div style="padding-top:20px;">
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td valign="top"><div>
    	<div style="padding-bottom:10px;"><input type="text" value="" placeholder="Họ tên (*)" name="ten" class="input"  /></div>
        <div style="padding-bottom:10px;"><input type="text" value="" placeholder="Địa chỉ" name="diachi" class="input"  /></div>
         <div style="padding-bottom:10px;"><input type="text" value="" placeholder="Email (*)" name="email" class="input"  /></div>
          <div style="padding-bottom:10px;"><input type="text" value="" placeholder="Điện thoại (*)" name="email" class="input"  /></div>
        
    
    </div></td>
    <td valign="top">
    <div> <textarea style="height:146px;" placeholder="Nội dung"  name="noidung" class="input" ></textarea></div>
    </td>
  </tr>
</table>


<div style="padding-top:10px;"><button type="submit" class="btn" style="margin-right:10px;">Gửi</button><button type="reset" class="btn">Viết lại</button></div>
</div>
</form>


           </div>
           
           
           </div>
            
            
        <div style="clear:both"></div>
        </div>
		
</asp:Content>


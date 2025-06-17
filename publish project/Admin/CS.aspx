<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script src="Scripts/jquery.dynDateTime.min.js" type="text/javascript"></script>
<script src="Scripts/calendar-en.min.js" type="text/javascript"></script>
<link href="Styles/calendar-blue.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(document).ready(function () {
        $("#<%=TextBox1.ClientID %>").dynDateTime({
            
            ifFormat: "%d/%m/%Y ",
            daFormat: " %m,  %Y",
            align: "BR",
            electric: false,
            singleClick: false,
          
            button: ".next()"
        });
         $("#<%=TextBox2.ClientID %>").dynDateTime({
            
            ifFormat: "%d/%m/%Y ",
            daFormat: " %m,  %Y",
            align: "BR",
            electric: false,
            singleClick: false,
          
            button: ".next()"
        });
    });
</script>
</head>
<body>
    <form id="form1" runat="server">
<asp:TextBox ID="TextBox1" runat="server" ReadOnly = "true"></asp:TextBox>
<img src="calender.png" style="width: 16px" />
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
<asp:TextBox ID="TextBox2" runat="server" ReadOnly = "true"></asp:TextBox>
<img src="calender.png" style="width: 16px" /></form>
</body>
</html>

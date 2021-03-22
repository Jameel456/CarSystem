<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #CCFFFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnNoStaff" runat="server" style="z-index: 1; left: 155px; top: 145px; position: absolute; height: 25px; width: 75px" Text="No" BackColor="#FFCCFF" OnClick="btnNoStaff_Click" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 60px; top: 103px; position: absolute; height: 26px" Text="Are you sure you want to delete this staff member?"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYesStaff" runat="server" OnClick="btnYesStaff_Click" style="z-index: 1; left: 62px; top: 145px; position: absolute; height: 25px; width: 75px; right: 1141px" Text="Yes" BackColor="#FFCCFF" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStock.aspx.cs" Inherits="DeleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 144px; background-color: #CCFFFF">
        </div>
        <asp:Label ID="lblAreYouSure" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Are you sure you want to delete this address?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 13px; top: 77px; position: absolute; width: 56px" Text="Yes" BackColor="#FFCCFF" />
        <asp:Button ID="bntNo" runat="server" style="z-index: 1; left: 75px; top: 78px; position: absolute; width: 62px" Text="No" OnClick="bntNo_Click" BackColor="#FFCCFF" />
    </form>
</body>
</html>

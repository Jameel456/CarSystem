﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #CCFFFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteCustomer" runat="server" Text="Are you sure you want to delete this customer?"></asp:Label>
        <p>
            <asp:Button ID="btnYesCustomer" runat="server" OnClick="btnYesCustomer_Click" Text="Yes" style="background-color: #FFCCFF" />
            <asp:Button ID="btnNoCustomer" runat="server" OnClick="btnNoCustomer_Click" style="margin-top: 0px; background-color: #FFCCFF;" Text="No" />
        </p>
    </form>
</body>
</html>

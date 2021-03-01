<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" Height="131px" Width="247px"></asp:ListBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Please Enter Customer Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtEnterName" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
            <asp:Button ID="btnApply" runat="server" Text="Apply" />
        </p>
        <asp:Button ID="btnAdd" runat="server" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" />
    </form>
</body>
</html>

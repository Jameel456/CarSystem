<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultCustomer.aspx.cs" Inherits="DefaultCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" Height="217px" Width="355px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Label ID="lblCustomerSearch" runat="server" Text="Please enter Customer Name"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtCustomerSearch" runat="server" Height="16px" Width="237px"></asp:TextBox>
        </p>
        <asp:Button ID="btnDisplayAllCustomer" runat="server" style="z-index: 1; left: 128px; top: 342px; position: absolute; right: 318px" Text="Display All" />
        <asp:Button ID="btnApplyCustomer" runat="server" Text="Apply" Width="56px" />
        <p>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 21px; top: 400px; position: absolute; right: 475px; height: 29px" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 76px; top: 400px; position: absolute; right: 427px" Text="Edit" />
            <asp:Button ID="btnCustomerDelete" runat="server" style="z-index: 1; left: 137px; top: 401px; position: absolute" Text="Delete" />
        </p>
    </form>
</body>
</html>

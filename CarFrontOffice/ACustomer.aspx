<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerTelNumber" runat="server" Text="Customer Tel Number"></asp:Label>
        <asp:TextBox ID="txtCustomerTelNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateJoined" runat="server" Text="Date Joined"></asp:Label>
            <asp:TextBox ID="txtDateJoined" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="ChkActive" runat="server" Text="Active" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="49px" />
        <asp:Button ID="btnCancel" runat="server" style="margin-top: 0px" Text="Cancel" />
    </form>
</body>
</html>

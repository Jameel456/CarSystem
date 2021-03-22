<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultCustomer.aspx.cs" Inherits="DefaultCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            background-color: #CCFFFF;
        }
    </style>
</head>
<body style="background-color: #CCFFFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" Height="217px" Width="355px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Label ID="lblCustomerSearch" runat="server" Text="Please enter Customer Name"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtCustomerSearch" runat="server" Height="16px" Width="237px" OnTextChanged="txtCustomerSearch_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="btnApplyCustomer" runat="server" Text="Apply" Width="56px" OnClick="btnApplyCustomer_Click" style="background-color: #FFCCFF" />
        <asp:Button ID="btnDisplayAllCustomers" runat="server" Text="Display All" OnClick="btnDisplayAllCustomers_Click" style="background-color: #FFCCFF" />
        <p style="background-color: #CCFFFF">
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 21px; top: 396px; position: absolute; right: 713px; height: 29px; background-color: #FFCCFF;" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 75px; top: 393px; position: absolute; right: 659px; height: 30px; margin-top: 0px; background-color: #FFCCFF;" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnCustomerDelete" runat="server" style="z-index: 1; left: 128px; top: 395px; position: absolute; height: 28px; background-color: #FFCCFF;" Text="Delete" OnClick="btnCustomerDelete_Click" />
        </p>
        <asp:Label ID="lblErrorCustomer" runat="server"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

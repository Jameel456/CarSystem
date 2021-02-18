<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 12px; top: 167px; position: absolute" Text="Date Added"></asp:Label>
        </div>
        <asp:Label ID="lblCarModel" runat="server" Text="Car Model"></asp:Label>
        <asp:Label ID="lblBHP" runat="server" style="z-index: 1; left: 11px; top: 76px; position: absolute" Text="BHP"></asp:Label>
        <asp:TextBox ID="txtBHP" runat="server" style="z-index: 1; left: 133px; top: 73px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 11px; top: 118px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 132px; top: 121px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkAvailability" runat="server" style="z-index: 1; left: 121px; top: 235px; position: absolute" Text="Availability" />
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 129px; top: 165px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 135px; top: 35px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 124px; top: 285px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 125px; top: 349px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 191px; top: 351px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>

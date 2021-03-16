<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 17px; background-color: #CCFFFF">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 19px; top: 197px; position: absolute; height: 22px;" Text="Date Added"></asp:Label>
        </div>
        <asp:Label ID="lblBHP" runat="server" style="z-index: 1; left: 19px; top: 126px; position: absolute" Text="BHP"></asp:Label>
        <asp:TextBox ID="txtBHP" runat="server" style="z-index: 1; left: 137px; top: 120px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 20px; top: 161px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 136px; top: 159px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkAvailability" runat="server" style="z-index: 1; left: 128px; top: 241px; position: absolute" Text="Availability" />
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 131px; top: 195px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 137px; top: 82px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 124px; top: 285px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 125px; top: 349px; position: absolute" Text="OK" BackColor="#FFCCFF" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 344px; top: 44px; position: absolute" Text="Find" BackColor="#FFCCFF" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 191px; top: 351px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" BackColor="#FFCCFF" />
        <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 19px; top: 86px; position: absolute" Text="Car Model"></asp:Label>
        <asp:TextBox ID="txtModelNo" runat="server" style="z-index: 1; left: 137px; top: 46px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblModelNo" runat="server" style="z-index: 1; left: 22px; top: 48px; position: absolute" Text="ModelNo"></asp:Label>
    </form>
</body>
</html>

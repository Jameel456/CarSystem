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
        <asp:ListBox ID="lstStocks" runat="server" Height="174px" Width="309px"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 139px; top: 321px; position: absolute" Text="Delete" />
        <asp:Label ID="lblCarModelSearch" runat="server" style="z-index: 1; left: 15px; top: 214px; position: absolute; width: 302px" Text="Please Enter a Car Model Name Here"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtCarModelSearch" runat="server" style="z-index: 1; left: 12px; top: 241px; position: absolute; width: 303px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 14px; top: 272px; position: absolute" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 101px; top: 272px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 11px; top: 320px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 76px; top: 319px; position: absolute" Text="Edit" />
    </form>
</body>
</html>

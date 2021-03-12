<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultStock.aspx.cs" Inherits="DefaultStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCarModelSearch" runat="server" style="z-index: 1; left: 18px; top: 362px; position: absolute" Text="Please Enter a Car Model"></asp:Label>
            <asp:TextBox ID="txtCarModelSearch" runat="server" style="z-index: 1; left: 15px; top: 393px; position: absolute; width: 430px"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 16px; top: 448px; position: absolute; width: 133px" Text="Apply" />
            <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 188px; top: 448px; position: absolute; width: 163px" Text="DisplayAll" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 80px; top: 496px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 141px; top: 498px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        </div>
        <asp:ListBox ID="lstStock" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 255px; width: 459px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 322px; position: absolute"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 495px; position: absolute" Text="Add" />
    </form>
</body>
</html>

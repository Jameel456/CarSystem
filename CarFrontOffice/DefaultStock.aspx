<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultStock.aspx.cs" Inherits="DefaultStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 529px; background-color: #CCFFFF">
            <asp:Label ID="lblCarModelSearch" runat="server" style="z-index: 1; left: 18px; top: 362px; position: absolute" Text="Please Enter a Car Model"></asp:Label>
            <asp:TextBox ID="txtCarModelSearch" runat="server" style="z-index: 1; left: 15px; top: 393px; position: absolute; width: 430px"></asp:TextBox>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 134px; top: 497px; position: absolute" Text="Delete" OnClick="btnDelete_Click" BackColor="#FFCCFF" />

        </div>
        <asp:ListBox ID="lstStock" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 255px; width: 459px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 322px; position: absolute"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 495px; position: absolute" Text="Add" BackColor="#FFCCFF" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 76px; top: 496px; position: absolute; " Text="Edit" BackColor="#FFCCFF" />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 20px; top: 433px; position: absolute" Text="Apply" OnClick="btnApply_Click1" BackColor="#FFCCFF" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 104px; top: 434px; position: absolute; height: 28px;" Text="Display All" BackColor="#FFCCFF" />
    </form>
</body>
</html>

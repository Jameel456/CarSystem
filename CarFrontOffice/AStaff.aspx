<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 13px; top: 52px; position: absolute; right: 1353px; height: 25px;" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" OnTextChanged="txtStaffName_TextChanged" style="z-index: 1; left: 149px; top: 51px; position: absolute; height: 17px"></asp:TextBox>
        <asp:Label ID="lblStaffNumber" runat="server" style="z-index: 1; left: 10px; position: absolute; top: 143px; right: 1345px; height: 48px;" Text="Staff Tel Number"></asp:Label>
        <asp:TextBox ID="txtStaffTelNumber" runat="server" style="z-index: 1; left: 146px; top: 144px; position: absolute; height: 17px;"></asp:TextBox>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 12px; top: 93px; position: absolute; right: 1350px; height: 24px;" Text="Staff Address"></asp:Label>
        <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 148px; top: 94px; position: absolute; height: 17px;"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 145px; top: 198px; position: absolute; height: 17px;"></asp:TextBox>
        <asp:Label ID="txtDateJoined" runat="server" style="z-index: 1; left: 11px; top: 198px; position: absolute" Text="Date Joined"></asp:Label>
        <asp:CheckBox runat="server" style="z-index: 1; left: 12px; top: 239px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 13px; top: 301px; position: absolute; height: 26px; width: 60px;" Text="Ok" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 267px; position: absolute"></asp:Label>
        
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 101px; top: 300px; position: absolute; height: 28px;" Text="Cancel" />
        
    </form>
</body>
</html>

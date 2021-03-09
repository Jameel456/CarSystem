<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultStaff.aspx.cs" Inherits="DefaultStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 15px; top: 44px; position: absolute; height: 259px; width: 456px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 326px; position: absolute; height: 20px; width: 69px"></asp:Label>
        <asp:Label ID="lblStaffIDSearch" runat="server" style="z-index: 1; left: 25px; top: 366px; position: absolute; width: 194px" Text="Please Enter Staff ID"></asp:Label>
        <asp:Button ID="btnDeleteStaff" runat="server" style="z-index: 1; left: 168px; top: 482px; position: absolute; height: 25px; width: 50px" Text="Delete" />
        <asp:Button ID="btnEditStaff" runat="server" style="z-index: 1; left: 97px; top: 482px; position: absolute; height: 25px; width: 50px; right: 1072px;" Text="Edit" />
        <asp:Button ID="btnAddStaff" runat="server" style="z-index: 1; left: 26px; top: 480px; position: absolute; height: 25px; width: 50px" Text="Add" />
        <asp:Button ID="btnDisplayAllStaff" runat="server" style="z-index: 1; left: 151px; top: 429px; position: absolute; height: 26px; width: 107px" Text="Display All" />
        <asp:Button ID="btnApplyStaff" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 25px; top: 430px; position: absolute; height: 23px; width: 100px; " Text="Apply" />
        <asp:TextBox ID="txtSearchStaff" runat="server" style="z-index: 1; left: 28px; top: 394px; position: absolute; width: 304px"></asp:TextBox>
    </form>
</body>
</html>

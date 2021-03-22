<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultStaff.aspx.cs" Inherits="DefaultStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #CCFFFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 15px; top: 44px; position: absolute; height: 259px; width: 456px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 328px; position: absolute; height: 34px; width: 330px"></asp:Label>
        <asp:Label ID="lblStaffIDSearch" runat="server" style="z-index: 1; left: 54px; top: 377px; position: absolute; width: 194px" Text="Please Enter Staff ID"></asp:Label>
        <asp:Button ID="btnDeleteStaff" runat="server" style="z-index: 1; left: 234px; top: 491px; position: absolute; height: 25px; width: 90px" Text="Delete" OnClick="btnDeleteStaff_Click1" BackColor="#FFCCFF" />
        <asp:Button ID="btnEditStaff" runat="server" style="z-index: 1; left: 117px; top: 491px; position: absolute; height: 25px; width: 90px; right: 933px;" Text="Edit" OnClick="btnEditStaff_Click" BackColor="#FFCCFF" />
        <asp:Button ID="btnAddStaff" runat="server" style="z-index: 1; left: 12px; top: 491px; position: absolute; height: 25px; width: 90px" Text="Add" OnClick="btnAddStaff_Click" BackColor="#FFCCFF" />
        <asp:Button ID="btnDisplayAllStaff" runat="server" style="z-index: 1; left: 166px; top: 447px; position: absolute; height: 26px; width: 107px; color: #000000;" Text="Display All" BackColor="#FFCCFF" OnClick="btnDisplayAllStaff_Click" />
        <asp:Button ID="btnApplyStaff" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 27px; top: 448px; position: absolute; height: 23px; width: 100px; " Text="Apply" BackColor="#FFCCFF" />
        <asp:TextBox ID="txtSearchStaff" runat="server" style="z-index: 1; left: 13px; top: 411px; position: absolute; width: 304px"></asp:TextBox>
    </form>
</body>
</html>

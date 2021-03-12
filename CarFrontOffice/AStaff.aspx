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
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 13px; top: 107px; position: absolute; right: 1169px; height: 23px;" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" OnTextChanged="txtStaffName_TextChanged" style="z-index: 1; left: 185px; top: 112px; position: absolute; height: 17px; width: 140px;"></asp:TextBox>
        <asp:Label ID="lblStaffNumber" runat="server" style="z-index: 1; left: 10px; position: absolute; top: 183px; right: 1133px; height: 38px; margin-left: 0px;" Text="Staff Tel Number"></asp:Label>
        <asp:TextBox ID="txtStaffTelNumber" runat="server" style="z-index: 1; left: 184px; top: 194px; position: absolute; height: 17px; width: 140px;"></asp:TextBox>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 12px; top: 150px; position: absolute; height: 21px;" Text="Staff Address"></asp:Label>
        <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 183px; top: 152px; position: absolute; height: 17px; width: 140px;"></asp:TextBox>
        <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 180px; top: 252px; position: absolute; height: 17px; width: 138px;"></asp:TextBox>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 8px; top: 253px; position: absolute" Text="Date Joined"></asp:Label>
        <asp:CheckBox runat="server" style="z-index: 1; left: 16px; top: 281px; position: absolute" Text="Active" ID="chkActive" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 317px; position: absolute"></asp:Label>
        
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 199px; top: 344px; position: absolute; height: 28px;" Text="Cancel" OnClick="btnCancel_Click" />
        
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 186px; top: 65px; position: absolute; width: 140px;"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 373px; top: 63px; position: absolute; width: 60px;" Text="Find" />
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 15px; top: 64px; position: absolute; width: 103px; height: 23px" Text="Staff ID"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 118px; top: 345px; position: absolute; height: 26px; width: 60px;" Text="OK" />
        </p>
        
    </form>
</body>
</html>

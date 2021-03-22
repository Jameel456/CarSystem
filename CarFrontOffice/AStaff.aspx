<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #CCFFFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 7px; top: 107px; position: absolute; right: 984px; height: 23px;" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" OnTextChanged="txtStaffName_TextChanged" style="z-index: 1; left: 178px; top: 102px; position: absolute; height: 17px; width: 140px;"></asp:TextBox>
        <asp:Label ID="lblStaffNumber" runat="server" style="z-index: 1; left: 6px; position: absolute; top: 200px; right: 976px; height: 58px; margin-left: 0px;" Text="Staff Tel Number"></asp:Label>
        <asp:TextBox ID="txtStaffTelNumber" runat="server" style="z-index: 1; left: 176px; top: 200px; position: absolute; height: 17px; width: 140px;"></asp:TextBox>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 7px; top: 159px; position: absolute; height: 21px; width: 94px;" Text="Staff Address"></asp:Label>
        <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 176px; top: 156px; position: absolute; height: 17px; width: 140px;"></asp:TextBox>
        <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 174px; top: 268px; position: absolute; height: 17px; width: 138px;"></asp:TextBox>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 8px; top: 269px; position: absolute" Text="Date Joined"></asp:Label>
        <asp:CheckBox runat="server" style="z-index: 1; left: 16px; top: 312px; position: absolute; height: 22px; width: 80px;" Text="Active" ID="chkActive" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 349px; position: absolute; height: 58px; width: 514px;"></asp:Label>
        
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 140px; top: 426px; position: absolute; height: 25px; width: 90px;" Text="Cancel" OnClick="btnCancel_Click" BackColor="#FFCCFF" />
        
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 179px; top: 62px; position: absolute; width: 140px;"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 373px; top: 63px; position: absolute; width: 90px; height: 25px;" Text="Find" BackColor="#FFCCFF" />
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
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 9px; top: 64px; position: absolute; width: 103px; height: 23px" Text="Staff ID"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 17px; top: 426px; position: absolute; height: 25px; width: 90px;" Text="OK" BackColor="#FFCCFF" />
        </p>
        
    </form>
</body>
</html>

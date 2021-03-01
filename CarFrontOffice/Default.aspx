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
        <asp:Button ID="btnDeleteStock" runat="server" style="z-index: 1; left: 139px; top: 321px; position: absolute" Text="Delete" />
        <asp:Label ID="lblCarModelSearch" runat="server" style="z-index: 1; left: 15px; top: 214px; position: absolute; width: 302px" Text="Please Enter a Car Model Name Here"></asp:Label>
        <p>
            <asp:Label ID="lblCustomerSearch" runat="server" style="z-index: 1; left: 362px; top: 214px; position: absolute; width: 318px" Text="Please enter Customer Name"></asp:Label>
            <asp:Label ID="lblStaffSearch" runat="server" style="z-index: 1; left: 730px; top: 219px; position: absolute" Text="Please enter Staff Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtCarModelSearch" runat="server" style="z-index: 1; left: 12px; top: 241px; position: absolute; width: 303px"></asp:TextBox>
        <asp:Button ID="btnApplyStock" runat="server" style="z-index: 1; left: 14px; top: 272px; position: absolute" Text="Apply" />
        <asp:Button ID="btnDisplayAllStock" runat="server" style="z-index: 1; left: 104px; top: 275px; position: absolute" Text="Display All" />
        <asp:Button ID="btnEditStock" runat="server" style="z-index: 1; left: 76px; top: 319px; position: absolute" Text="Edit" />
        <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 361px; top: 43px; position: absolute; height: 164px; width: 327px; margin-right: 53px"></asp:ListBox>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 727px; top: 45px; position: absolute; height: 166px; width: 343px"></asp:ListBox>
        <asp:TextBox ID="txtCustomerSearch" runat="server" style="z-index: 1; left: 357px; top: 241px; position: absolute; width: 321px;"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtStaffSearch" runat="server" style="z-index: 1; left: 728px; top: 241px; position: absolute; width: 338px"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnAddStock" runat="server" style="z-index: 1; left: 11px; top: 320px; position: absolute" Text="Add" />
            <asp:Button ID="btnDisplayAllCustomer" runat="server" style="z-index: 1; left: 458px; top: 276px; position: absolute" Text="Display All" />
        </p>
        <asp:Button ID="btnApplyCustomer" runat="server" style="z-index: 1; left: 361px; top: 275px; position: absolute; margin-top: 0px" Text="Apply" />
        <asp:Button ID="btnAddCustomer" runat="server" style="z-index: 1; left: 359px; top: 321px; position: absolute" Text="Add" />
        <p>
            <asp:Button ID="btnEditCustomer" runat="server" style="z-index: 1; left: 430px; top: 322px; position: absolute" Text="Edit" />
            <asp:Button ID="btnApplyStaff" runat="server" style="z-index: 1; left: 729px; top: 283px; position: absolute" Text="Apply" />
            <asp:Button ID="btnAddStaff" runat="server" style="z-index: 1; left: 728px; top: 321px; position: absolute" Text="Add" />
            <asp:Button ID="btnEditStaff" runat="server" style="z-index: 1; left: 789px; top: 321px; position: absolute" Text="Edit" />
            <asp:Button ID="btnDeleteStaff" runat="server" style="z-index: 1; left: 851px; top: 320px; position: absolute" Text="Delete" />
        </p>
        <asp:Button ID="btnDisplayAllStaff" runat="server" style="z-index: 1; left: 807px; top: 284px; position: absolute" Text="DisplayAll" />
        <asp:Button ID="btnDeleteCustomer" runat="server" style="z-index: 1; left: 507px; top: 323px; position: absolute" Text="Delete" />

    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLtoDropDown.aspx.cs" Inherits="Practicals.XMLtoDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList AutoPostBack="true" ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

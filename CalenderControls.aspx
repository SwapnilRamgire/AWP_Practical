<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalenderControls.aspx.cs" Inherits="Practicals.CalenderControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
        <div> 
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar> 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br/> 
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label> 
        </div> 
    </form>
</body>
</html>

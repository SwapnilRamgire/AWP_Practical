<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adrotator.aspx.cs" Inherits="Practicals.Adrotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" Target="_blank" AdvertisementFile="~/XMLFile1.xml" />
        </div>
    </form>
</body>
</html>

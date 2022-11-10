<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserControls.aspx.cs" Inherits="Practicals.UserControls" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:WebUserControl1 runat="server" id="WebUserControl1" />
        </div>
    </form>
</body>
</html>

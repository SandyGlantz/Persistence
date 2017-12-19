<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SaveAsTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <p>
        <br class="auto-style1" />
        <span class="auto-style1">Testing VS2015 New Project from existing code</span></p>
    <p class="auto-style1">
        &nbsp;</p>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="okButton" runat="server" CssClass="auto-style1" OnClick="okButton_Click" Text="Click for action" />
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style1"></asp:Label>
        </p>
        <div>
        </div>
    </form>
    <p>
        Testing out line break</p>
    <p>
        Doesn&#39;t work in vs17 either :-(</p>
</body>
</html>

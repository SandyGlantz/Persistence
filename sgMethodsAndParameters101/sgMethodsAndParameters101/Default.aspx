﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sgMethodsAndParameters101.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br class="auto-style2" />
        <asp:Button ID="okButton" runat="server" CssClass="auto-style2" OnClick="okButton_Click" Text="Click for magic" />
        <br class="auto-style2" />
        <br class="auto-style2" />
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style2"></asp:Label>
    
    </div>
    </form>
</body>
</html>
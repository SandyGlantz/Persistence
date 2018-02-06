<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SuperSimple.Default" %>

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
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            margin-left: 80px;
        }
        .auto-style4 {
            margin-left: 120px;
        }
    </style>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <p class="auto-style1">
            <asp:Button ID="okButton" runat="server" CssClass="auto-style2" OnClick="okButton_Click" Text="Hope and a prayer" />
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style4">
            <asp:Label ID="resultLabel" runat="server" CssClass="auto-style2"></asp:Label>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>

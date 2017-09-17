
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CacheDataset.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="load data" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Clear Cache" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Message"></asp:Label>
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>

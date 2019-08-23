<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="uglyTicTacToe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Not So Ugly TicTacToe</title>
    <link href="Resources/stylesheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Not So Ugly TicTacToe</h1>
        
        <asp:Panel ID="Board" runat="server">
            <asp:Button ID="TopLeft" runat="server" Text =" " Width="100px" Height="100px" OnClick="TopLeft_Click" />
            <asp:Button ID="Top" runat="server" Text=" " Width="100px" Height="100px" OnClick="Top_Click" />
            <asp:Button ID="TopRight" runat="server" Text =" " Width="100px" Height="100px" OnClick="TopRight_Click" />
            <br />
            <asp:Button ID="Left" runat="server" Text =" " Width="100px" Height="100px" OnClick="Left_Click" />
            <asp:Button ID="Center" runat="server" Text =" " Width="100px" Height="100px" OnClick="Center_Click" />
            <asp:Button ID="Right" runat="server" Text =" " Width="100px" Height="100px" OnClick="Right_Click" />
            <br />
            <asp:Button ID="BottomLeft" runat="server" Text =" " Width="100px" Height="100px" OnClick="BottomLeft_Click" />
            <asp:Button ID="Bottom" runat="server" Text =" " Width="100px" Height="100px" OnClick="Bottom_Click" />
            <asp:Button ID="BottomRight" runat="server" Text =" " Width="100px" Height="100px" OnClick="BottomRight_Click"/>
        </asp:Panel>
        <br />
        <asp:Label ID="TurnNumber" runat="server" />
        <asp:Label ID="Result" CssClass="result" runat="server" />
        <br />
        <br />
        <asp:Panel runat="server" />
            <asp:HyperLink ID="NewGame" runat="server"
                ImageUrl="~/Resources/newgame.png" NavigateUrl="~/Default.aspx" CssClass="NewGame"></asp:HyperLink>
        </asp:Panel>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Versaler.Default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
  <link href="~/Content/Style.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hur många versaler?</h1>
        <asp:TextBox ID="TextBox" TextMode="MultiLine" runat="server" Height="171px" Width="355px" ViewStateMode="Enabled"></asp:TextBox>
    </div>
        <asp:PlaceHolder ID="PlaceHolder" runat="server" Visible="false">
        <p>
            Texten innehåller 
        <asp:Label ID="Label" runat="server" Text=""></asp:Label>
            verselar.
        </p>
            </asp:PlaceHolder>
        <p>
        <asp:Button ID="Button" runat="server" Text="Bestäm hur många versaler" OnClick="Button_Click"  Visible="true"/>
        </p>
        
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WinkelmandLeeg.aspx.cs" Inherits="gsmWebsite.WinkelmandLeeg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WinkelmandjeIsleeg</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div >
             <div class="hero-bkg-animated">
  <h1>Online GSM-Shop-Winkelmandje is leeg</h1>
</div>
            <div class="hero-bkg-animated2">
            <p>
                &nbsp;</p>
            <p>
                Het winkelmandje is leeg. Klik op de knop om terug te keren naar de catalogus.</p>
            <p>
                <asp:Button ID="btnGoback" runat="server" OnClick="btnGoback_Click" Text="terug naar catalogus..." />
            </p>
        </div>
            </div>
    </form>
</body>
</html>

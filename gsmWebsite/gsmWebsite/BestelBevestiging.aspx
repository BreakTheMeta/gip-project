<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BestelBevestiging.aspx.cs" Inherits="gsmWebsite.BestelBevestiging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bestelbevestiging</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       
            <div class="hero-bkg-animated">
  <h1>Online GSM-Shop-Catalogus</h1>
</div>
         <div class="hero-bkg-animated2">
            <p>
                Uw bestelbevestiging met ordernummer
                <asp:Label ID="lblOrderNr" runat="server"></asp:Label>
&nbsp;werd door ons goed ontvangen.</p>
            <p>
                Na betaling van
                <asp:Label ID="lblPrijs" runat="server"></asp:Label>
&nbsp;op rekeningnummer BE94 5645 1245 9534 zullen wij overgaan tot de verzending van de telefoontoestellen.</p>
            <p>
                gelieve het ordernummer als betalingsreferentie mee te geven</p>
            <p>
                bedankt voor uw vertrouwen!</p>
            <p>
                <asp:Button ID="btngoback" runat="server" OnClick="btngoback_Click" Text="Terug naar catalogus..." Width="272px" />
            </p>
        </div>
    </form>
</body>
</html>

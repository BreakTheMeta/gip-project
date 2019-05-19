<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemToevoegenWinkelmandje.aspx.cs" Inherits="gsmWebsite.ItemToevoegenWinkelmandje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Item Toevoegen aan mandje</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="hero-bkg-animated">
  <h1>Online GSM-Shop-Item toevoegen aan Winkelmand</h1>
</div>
        <div class="hero-bkg-animated2">
            <center>
            <table >
                <tr>
                    <td>
                        <asp:Image ID="imgArtikel" runat="server" Height="194px" Width="251px" />
                    </td>
                    <td>
                        <table class="auto-style2">
                            <tr>
                                <td>ArtNr:</td>
                                <td>
                                    <asp:Label ID="lblArtNr" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Naam</td>
                                <td>
                                    <asp:Label ID="lblNaam" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Verkoopprijs</td>
                                <td>
                                    <asp:Label ID="lblPrijs" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Voorraad</td>
                                <td>
                                    <asp:Label ID="lblVoorraad" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
                </center>
            <p>
</p>
        
        <p>
            Aantal te bestellen exemplaren van dit item: <asp:TextBox ID="txtAantal" runat="server"></asp:TextBox>

            <asp:Button ID="btnVoegtoe" runat="server" Text="Voeg toe aan mandje..." OnClick="btnVoegtoe_Click" />
        </p>
            <p>
        <asp:Label ID="lblfout" runat="server"></asp:Label>
   
                <asp:Button ID="btncatalogus" runat="server" OnClick="btncatalogus_Click" Text="Terug naar Catalogus" Width="169px" />
        </p>
            </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

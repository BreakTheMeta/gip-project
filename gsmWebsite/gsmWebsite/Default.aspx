<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gsmWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="hero-bkg-animated">
  <h1>Online GSM-Shop-Catalogus</h1>
</div>
        <div>
            <div class="hero-bkg-animated2">
                
            <p>
                <center>
                <asp:GridView ID="gvArtikels" runat="server" AutoGenerateColumns="False" Height="270px" Width="1146px" OnSelectedIndexChanged="gvArtikels_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="ArtNr" HeaderText="ArtNr">
                        <ItemStyle Width="75px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Naam" HeaderText="Naam">
                        <ItemStyle Width="250px" />
                        </asp:BoundField>
                        <asp:ImageField HeaderText="Foto" DataImageUrlField="Foto" DataImageUrlFormatString="~/Images/{0}">
                            <ControlStyle Height="200px" Width="175px" />
                        </asp:ImageField>
                        <asp:BoundField DataField="Prijs" HeaderText="Verkoopprijs" DataFormatString="{0:c}">
                        <ItemStyle Width="150px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Voorraad" HeaderText="Voorraad" >
                        <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:CommandField SelectText="Voeg toe aan winkelmandje.." ShowSelectButton="True" >
                        <ItemStyle Width="250px" />
                        </asp:CommandField>
                    </Columns>
                </asp:GridView> 
                    <br />
                 </center>
            <asp:Button ID="btnWinkelmandje" runat="server" OnClick="btnWinkelmandje_Click" Text="Bekijk de inhoud van het winkelmandje..." Width="342px" />
            </p>
                </div>
        </div>
    </form>
</body>
</html>

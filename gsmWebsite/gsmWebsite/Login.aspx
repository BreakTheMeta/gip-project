<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="gsmWebsite.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="hero-bkg-animated">
    <h2>Online GSM-Shop - Login</h2>
        </div>
        <div class="hero-bkg-animated2">
            <center>
        <table >
            <tr>
                <td >
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        GebruikersNaam:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGebruikersNaam" runat="server"></asp:TextBox>
            
                    </p>
                    
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="rfvGebr" runat="server" ControlToValidate="txtGebruikersNaam" ErrorMessage="Gebruikersnaam verplicht!" ForeColor="#CC0000" style="text-align: justify"></asp:RequiredFieldValidator>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Wachtwoord:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="txtWachtwoord" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtWachtwoord" ErrorMessage="Wachtwoord verplicht!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
        </table>
                </center>
            <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aanmelden" Width="170px" />
        </p>
            <p>
            <asp:Label ID="lblUitvoer" runat="server"></asp:Label>
        </p>
            <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
                
        </div>
    </form>
    
</body>
</html>

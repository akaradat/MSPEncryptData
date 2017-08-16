<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MSPEncryptData.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Style.css"/>
    <title>MSP Encrypt Data</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="site-head">
            <a  class="txt-head" href="index.aspx">
                <img src="MSP.png"  class="pic-head" />
                <span style="font-size: 40px;">MSP encrypt data V.1</span>
            </a>
        </div>
        <p>
            Input text or choose file: 
            <asp:FileUpload ID="file_up" runat="server" Width="90px"/>
        </p>
        <p>
            <asp:TextBox ID="txt_input" runat="server" Height="50px" TextMode="MultiLine" Width="40%"></asp:TextBox>
        </p>
        
        
        <p >
            <asp:RadioButton ID="radio_encrypt" GroupName="Encrypt" runat="server" Text="Encrypt" Checked="True" />    
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
            <asp:RadioButton ID="radio_decrypt" GroupName="Encrypt" runat="server" Text="Decrypt"  />
        </p>
        <p>
            Password(Number only):
            <asp:TextBox ID="txt_pass" runat="server"  Width="20%"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="bt_start" runat="server" Text="Start" OnClick="bt_start_Click" />
        </p>
        <p>
            <asp:Label ID="lb_msg" runat="server"  Font-Bold="true"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txt_view" runat="server"  TextMode="MultiLine" Width="40%"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lb_download" runat="server" Enabled="False"></asp:Label>

        </p>
        
        <p>
            <asp:Button ID="bt_download" runat="server" Enabled="False" OnClick="bt_download_Click" Text="Download" />
        </p>
    </form>
    
</body>
</html>

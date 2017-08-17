<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MSPEncryptData.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 
    <title>MSP Encrypt Data</title>
    <style>        
        body{
            margin:0px 0px 10px 0px;
            
            position:relative;
            text-align:center;
            background-color: lightgray;
        }
        .header{
            background-color: gray;
            width: 100%;
            height: 50px;
            font-size: 40px;
            top:10px;
            padding-bottom:15px;
            
        }
        .header1{
            max-height: 50px;
            color: #b4009e;
            text-decoration:none;
           
        }
        footer{
            margin:0px 0px 10px 0px;
            width:100%;
            text-decoration:none;
            text-align:right;
            color:#666666;
            bottom:0px;

            
        }
        .main{
            height:500px;
            background-color:antiquewhite;
        }
        .footer-link{

            text-decoration:none;
            margin-right:15px;
            
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="header">
            
                <a class="header1"  href="index.aspx">
                    <img style="max-height: 80%; margin-top:10px" src="MSP.png"  />
                    MSP encrypt data V.1
                </a>
                
            </div>
        </header>
        
            
        <div >
            <h2>
                    Encrypt data for protect your data
            </h2>
            <br />
            <p>
            Input text or choose file: 
            <asp:FileUpload ID="file_up" runat="server"/>
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
                <asp:TextBox ID="txt_view" runat="server"  Height="100px" TextMode="MultiLine" Width="40%" Visible="False"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="lb_download" runat="server" Enabled="False"></asp:Label>

            </p>
        
            <p>
                <asp:Button ID="bt_download" runat="server" Enabled="False" OnClick="bt_download_Click" Text="Download" />
            </p>
        </div>
        

        <footer>
            <hr />
            
            <asp:LinkButton ID="lnk_help" runat="server" CssClass="footer-link" ForeColor="#333333" OnClick="lnk_help_Click">Help</asp:LinkButton>
            <asp:LinkButton ID="lnk_helpthai" runat="server" CssClass="footer-link" ForeColor="#333333" OnClick="lnk_helpthai_Click">วิธีใช้</asp:LinkButton>
            <p style="padding-right:15px;" >
                <asp:Label ID="lb_help" runat="server" Visible="False" >Information</asp:Label>
            </p>
            
            
        </footer>
        
    </form>
   
</body>
</html>

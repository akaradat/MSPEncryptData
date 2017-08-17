<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MSPEncryptData.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>MSP Encrypt Data</title>
    <style>        
        body{
            margin-top:0px;
            margin-left:0px;
            margin-bottom:10px;
            width:100%;
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
            width:100%;
            text-decoration:none;
            text-align:right;
            color:darkgray;
            bottom:0px;
            padding-right:15px;
            margin-right:15px;
        }
        .main{
            height:500px;
            background-color:antiquewhite;
        }
        .footer-link{
            text-decoration:none;
            margin-right:15px;
            
        }
        .footer-infor{
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
            
            <asp:LinkButton ID="lnk_help" runat="server" CssClass="footer-link" ForeColor="#666666" OnClick="lnk_help_Click">Help</asp:LinkButton>
            <p  >
                <asp:Label ID="lb_help" runat="server" Visible="False" >Information</asp:Label>
            </p>
            
            
        </footer>
        
    </form>
   
</body>
</html>

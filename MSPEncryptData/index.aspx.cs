using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PassGenWithCS;
using System.IO;
using System.Data;

namespace MSPEncryptData
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_start_Click(object sender, EventArgs e)
        {
            string fileEx = Path.GetExtension(file_up.FileName);
            string strin = "";//String input
            string stren = "";//String after encode 
            string namein = "";
            string nameout = "";//file out name
            CheckEn ce;
            
            if(file_up.HasFile == false && txt_input.Text == "")
            {
                lb_msg.ForeColor = System.Drawing.Color.Red;
                lb_msg.Text = "Input text or choose file with .txt .Encrypt";
            }
            else if (file_up.HasFile == true && txt_pass.Text != "")
            {
                if (fileEx.ToLower() != ".txt" && fileEx.ToLower() != ".encrypt")
                {
                    lb_msg.ForeColor = System.Drawing.Color.Red;
                    lb_msg.Text = "Only files with .txt or .Encrypt";
                }
                else
                {
                    namein = file_up.FileName;
                    file_up.PostedFile.SaveAs(Server.MapPath("~/DataEn/") + namein);
                }
            }            
            else if(txt_pass.Text == "")
            {
                
                lb_msg.ForeColor = System.Drawing.Color.Red;
                lb_msg.Text = "Enter pass";
            }
            else
            {                          
                namein = "data.";
                File.WriteAllText(Server.MapPath("~/DataEn/") + namein, txt_input.Text);
            }
            if(namein != "" && txt_pass.Text != "")
            {
                
                lb_msg.ForeColor = System.Drawing.Color.Green;
                lb_msg.Text = "↓↓↓ OUTPUT ↓↓↓";
                strin = File.ReadAllText(Server.MapPath("~/DataEn/") + namein);
                //lb_msg.Text = namein;
                if (radio_encrypt.Checked == true)
                {

                    ce = new CheckEn(strin,  txt_pass.Text, 1);
                    stren = ce.StartEn();                    
                    nameout = namein.Replace("txt", "") + "Encrypt";
                    File.WriteAllText(Server.MapPath("~/DataEn/") + nameout, stren);
                    lb_download.Text = nameout;
                    txt_view.Visible = false;
                }
                else if (radio_decrypt.Checked == true)
                {
                    
                    ce = new CheckEn(strin,  txt_pass.Text, 0);
                    stren = ce.StartEn();
                    nameout = namein.Replace("Encrypt", "") + "txt";
                    File.WriteAllText(Server.MapPath("~/DataEn/") + nameout, stren);
                    lb_download.Text = nameout;
                    txt_view.Visible = true;
                }

                //txt_view.Height = 100;
                txt_view.Text = File.ReadAllText(Server.MapPath("~/DataEn/") + nameout);
                File.Delete(Server.MapPath("~/DataEn/") + namein);
                bt_download.Enabled = true;
                txt_input.Text = "";
            }
            

        }

        protected void bt_download_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "filename=" + lb_download.Text);
            Response.TransmitFile(Server.MapPath("~/DataEn/") + lb_download.Text);
            Response.End();
        }
    }
}
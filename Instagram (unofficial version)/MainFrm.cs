using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Linq;

namespace Instagram__unofficial_version_
{
    public partial class MainFrm : Form
    {
        private String Get_Value;

        public object DataTime { get; private set; }

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Con(Get_Net());
            TopMost_Setting();
            ToolTip a = new ToolTip();
            a.SetToolTip(Lbl_Speed_Show,"Click Me To Show Your Internet Speed !");
            a.SetToolTip(label1,"Setting");
            a.SetToolTip(label2,"This Is instagram Downloader !!!");
        }

        private void TopMost_Setting()
        {
            TopMost = S_S.Default.TopMost;
        }

        private bool Get_Net()
        {
            bool Is_Connected = false;
            try
            {
                Ping ping = new Ping();
                PingReply pingStatus = ping.Send("google.com");
                if (pingStatus.Status == IPStatus.Success)
                {
                    Is_Connected = true;
                }
                else
                {
                    Is_Connected = false;
                }
            }
            catch (Exception EX)
            {
                Is_Connected = false;
            }

            try
            {
                WebClient IsState = new WebClient();
                Get_Value = IsState.DownloadString("http://www.google.com");
                Is_Connected = true;
            }
            catch (Exception ex)
            {
                Is_Connected = false;
            }

            return Is_Connected;
        }

        private void Con(bool Con)
        {
            if (Con == true)
            {
                Ins_W_b.Show();
            }
            else
            {
                Ins_W_b.Hide();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Setting a = new Setting();
            a.ShowDialog();
            TopMost_Setting();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Download_Frm a = new Download_Frm();
            a.Show();
        }


        public double CheckInternetSpeed()
        {
            // Create Object Of WebClient
            System.Net.WebClient wc = new System.Net.WebClient();

            //DateTime Variable To Store Download Start Time.
            DateTime dt1 = DateTime.Now;

            //Number Of Bytes Downloaded Are Stored In ‘data’
            byte[] data = wc.DownloadData("http://google.com");

            //DateTime Variable To Store Download End Time.
            DateTime dt2 = DateTime.Now;

            //To Calculate Speed in Kb Divide Value Of data by 1024 And Then by End Time Subtract Start Time To Know Download Per Second.
            return Math.Round((data.Length / 1024) / (dt2 - dt1).TotalSeconds, 2);
        }

        private void Lbl_Speed_Show_Click(object sender, EventArgs e)
        {
            Lbl_Speed_Show.Text = CheckInternetSpeed().ToString() + " Kb/s";
        }

        private void Ins_W_b_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

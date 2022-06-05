using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace AcinonXNetTools
{
    public partial class Form1 : Form
    {
        int page = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            internetAddr.Text = "IP Address... " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            netName.Text = "User Domain... " + Environment.UserDomainName;
            //machineName.Text = "User Domain... " + Environment.MachineName;
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            netItrfCount.Text = "Network Interfaces... " + interfaces.Count().ToString();
            long totalBytesSent = 0;
            long totalBytesReceived = 0;
            foreach (NetworkInterface ni in interfaces)
            {
                totalBytesSent = totalBytesSent + ni.GetIPv4Statistics().BytesSent;
                totalBytesReceived = totalBytesReceived + ni.GetIPv4Statistics().BytesReceived;
            }
            long mbSent = totalBytesSent / (1024 * 1024);
            long mbReceived = totalBytesReceived / (1024 * 1024);
            netUsageSent.Text = "Data Sent... " + mbSent.ToString() + "MiB";
            netUsageReceived.Text = "Data Received... " + mbReceived.ToString() + "MiB";*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            internetAddr.Text = "IP Address... " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            netName.Text = "User Domain... " + Environment.UserDomainName;
            //machineName.Text = "User Domain... " + Environment.MachineName;
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            netItrfCount.Text = "Network Interfaces... " + interfaces.Count().ToString();
            long totalBytesSent = 0;
            long totalBytesReceived = 0;
            foreach (NetworkInterface ni in interfaces)
            {
                totalBytesSent = totalBytesSent + ni.GetIPv4Statistics().BytesSent;
                totalBytesReceived = totalBytesReceived + ni.GetIPv4Statistics().BytesReceived;
            }
            long mbSent = (totalBytesSent / 1024) / 1024;
            long mbReceived = (totalBytesReceived / 1024) / 1024;
            netUsageSent.Text = "Data Sent... " + mbSent.ToString() + "MiB";
            netUsageReceived.Text = "Data Received... " + mbReceived.ToString() + "MiB";
        }

        private void gotoOpsTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            page = 1;

            tabLayout.SelectedIndex = page;
            tabLayout.Refresh();
        }

        private void pingBtn_Click(object sender, EventArgs e)
        {
            PingPrompt prompt = new PingPrompt();
            prompt.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AcinonXNetTools
{
    public partial class PingPrompt : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        public PingPrompt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttachConsole(15624);
            string pingTarget = pingTargetInput.Text;
            try
            {
                if (pingTarget.Length < 1)
                {
                    throw new ArgumentException("Please input a host name!");
                }
                Process.Start("cmd.exe");
                AutoResetEvent waiter = new AutoResetEvent(false);

                Ping pingSender = new Ping();

                // When the PingCompleted event is raised,  
                // the PingCompletedCallback method is called.  
                pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);

                // Create a buffer of 32 bytes of data to be transmitted.  
                string data = "hello from acinonx! i'm pinging!";
                byte[] buffer = Encoding.ASCII.GetBytes(data);

                // Wait 8 seconds for a reply.  
                int timeout = 8000;

                // Set options for transmission:  
                // The data can go through 64 gateways or routers  
                // before it is destroyed, and the data packet  
                // cannot be fragmented.  
                PingOptions options = new PingOptions(64, true);

                Console.WriteLine("Time to live: {0}", options.Ttl);
                ttlLabel.Text = "Time to live: " + options.Ttl;
                Console.WriteLine("Don't fragment: {0}", options.DontFragment);
                dFragLabel.Text = "Don't fragment: " + options.DontFragment;

                // Send the ping asynchronously.  
                // Use the waiter as the user token.  
                // When the callback completes, it can wake up this thread.  
                pingSender.SendAsync(pingTarget, timeout, buffer, options, waiter);

                // Prevent this example application from ending.  
                // A real application should do something useful  
                // when possible.  
                waiter.WaitOne();
                Console.WriteLine("Ping to \"{0}\" finished.",pingTarget);
                MessageBox.Show("Ping to \"" + pingTarget + "\" finished.", "Ping Results");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error: " + ex.InnerException);
            }
        }
        public static void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            // If the operation was canceled, display a message to the user.  
            if (e.Cancelled)
            {
                Console.WriteLine("Ping canceled.");
                MessageBox.Show("Ping canceled ", "Ping Results");

                // Let the main thread resume.
                // UserToken is the AutoResetEvent object that the main thread
                // is waiting for.  
                ((AutoResetEvent)e.UserState).Set();
            }

            // If an error occurred, display the exception to the user.  
            if (e.Error != null)
            {
                Console.WriteLine("Ping failed:");
                MessageBox.Show("Ping failed: " + e.Error.ToString(), "Ping Results");
                Console.WriteLine(e.Error.ToString());

                // Let the main thread resume.
                ((AutoResetEvent)e.UserState).Set();
            }

            PingReply reply = e.Reply;

            DisplayReply(reply);

            // Let the main thread resume.  
            ((AutoResetEvent)e.UserState).Set();
        }
        public static void DisplayReply(PingReply reply)
        {
            if (reply == null)
                return;

            Console.WriteLine("ping status: {0}", reply.Status);
            string pingStat = reply.Status.ToString();
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Address: {0}", reply.Address.ToString());
                string addr = reply.Address.ToString();
                Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                string rtt = reply.RoundtripTime.ToString();
                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                string ttl = reply.Options.Ttl.ToString();
                Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                string dontFragment = reply.Options.DontFragment.ToString();
                Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                string buffSize = reply.Buffer.Length.ToString();
            }
        }

        private void getResultsBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

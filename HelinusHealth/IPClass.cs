using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace HelinusPingUtility
{
    internal class IPClass
    {
        Ping ping;
        public IPClass(string ip)
        {
            ping = new Ping();
            this.IP = ip.Trim();
            this.LatencySum = 0;
            this.StatusMessage = string.Empty;
            this.PingAmount = 0;
            this.FailedPings = 0;
            this.AveragePing = 0;
            this.PacketLoss = 0;
            this.PingTime = 0;
            this.TTL = 0;
        }

        public IPAddress Address { get; set; }
        public string IP { get; set; }
        public IPStatus Status { get; set; }
        public string StatusMessage { get; set; }
        public long LatencySum { get; set; }
        public int PingAmount { get; set; }
        public int FailedPings { get; set; }
        public double AveragePing { get; set; }
        public double PacketLoss { get; set; }
        public long PingTime { get; set; }
        public int TTL { get; set; }
        public string PingIt()
        {
            lock (this)
            {
                try
                {
                    PingReply reply = ping.Send(this.IP);
                    Status = reply.Status;
                    this.PingTime = reply.RoundtripTime;
                    this.Address = reply.Address;
                    this.TTL = reply.Options.Ttl;
                    if (reply.Status != IPStatus.Success)
                    {
                        this.FailedPings += 1;
                        this.PingTime = -1;
                
                    }
                    if (reply.Status == IPStatus.Success && reply.RoundtripTime==0)
                        this.PingTime = 1;

                    this.StatusMessage = this.Status.ToString();

                }
                catch (Exception err)
                {
                    this.FailedPings += 1;
                    this.PingTime = -1;
                    this.StatusMessage = err.Message;
                }

                this.LatencySum += this.PingTime;
                this.PingAmount++;

                this.AveragePing = Math.Round(((double)this.LatencySum / (double)this.PingAmount), 1);
                this.PacketLoss = Math.Round(((double)this.FailedPings / (double)this.PingAmount) * 100, 1);
            }
            return this.StatusMessage;
        }
        public static string FindLocalIPAddress()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    Console.WriteLine(ni.Name);
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            return ip.Address.ToString();
                        }
                    }
                }
            }
            //var local = NetworkInterface.GetAllNetworkInterfaces().Where(i => i.Name == "Local Area Connection").FirstOrDefault();
            //var stringAddress = local.GetIPProperties().UnicastAddresses[0].Address.ToString();
            //var ipAddress = IPAddress.Parse(stringAddress);
            return string.Empty;
        }
    }
}

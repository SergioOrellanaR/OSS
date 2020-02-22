using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchServerSelector
{
    public class RegionRuleCreator
    {

        public FirewallInstanceHelper FirewallInstanceHelper { get; set; }
        public string ProgramPath { get; set; }

        public RegionRuleCreator(string programPath)
        {
            FirewallInstanceHelper = new FirewallInstanceHelper();
            ProgramPath = programPath;
        }

        /*NORTH CALIFORNIA
         * Region	IP Prefix	IP	Test
ipRanges.Add("13.52.0.0-13.52.0.1")	
ipRanges.Add("13.56.0.0-13.56.63.251")	
ipRanges.Add("13.57.0.0-13.57.0.253")
ipRanges.Add("18.144.0.0-18.144.0.254")	
ipRanges.Add("50.18.0.0-50.18.56.1")	
ipRanges.Add("52.8.0.0-52.8.191.254")	
ipRanges.Add("52.9.0.0-52.9.63.252")	
ipRanges.Add("52.52.0.0-52.52.63.252")	
ipRanges.Add("54.67.0.0-54.67.63.253")
ipRanges.Add("54.151.0.0-54.151.0.2")	
ipRanges.Add("54.153.0.0-54.153.63.252")	
ipRanges.Add("54.176.0.0-54.176.64.1")	
ipRanges.Add("54.183.0.0-54.183.64.3")	
ipRanges.Add("54.193.0.0-54.193.0.3")	
ipRanges.Add("54.215.0.0-54.215.0.1")	
ipRanges.Add("54.219.0.0-54.219.127.255")	
ipRanges.Add("54.241.0.0-54.241.127.255")	
ipRanges.Add("184.72.0.0-184.72.56.36")	
ipRanges.Add("184.169.128.0-184.169.255.254")	
ipRanges.Add("204.236.128.0-204.236.129.206")	
         */

        public void CreateRuleThatBlocksUSW1()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("13.52.0.0-13.52.0.1");
            ipRanges.Add("13.56.0.0-13.56.63.251");
            ipRanges.Add("13.57.0.0-13.57.0.253");
            ipRanges.Add("18.144.0.0-18.144.0.254");
            ipRanges.Add("50.18.0.0-50.18.56.1");
            ipRanges.Add("52.8.0.0-52.8.191.254");
            ipRanges.Add("52.9.0.0-52.9.63.252");
            ipRanges.Add("52.52.0.0-52.52.63.252");
            ipRanges.Add("54.67.0.0-54.67.63.253");
            ipRanges.Add("54.151.0.0-54.151.0.2");
            ipRanges.Add("54.153.0.0-54.153.63.252");
            ipRanges.Add("54.176.0.0-54.176.64.1");
            ipRanges.Add("54.183.0.0-54.183.64.3");
            ipRanges.Add("54.193.0.0-54.193.0.3");
            ipRanges.Add("54.215.0.0-54.215.0.1");
            ipRanges.Add("54.219.0.0-54.219.127.255");
            ipRanges.Add("54.241.0.0-54.241.127.255");
            ipRanges.Add("184.72.0.0-184.72.56.36");
            ipRanges.Add("184.169.128.0-184.169.255.254");
            ipRanges.Add("204.236.128.0-204.236.129.206");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksUSW1", ProgramPath, ipRanges);
        }

/*       OREGON
 *       Region IP Prefix IP  Test
ipRanges.Add("18.236.0.0-18.236.0.1");
ipRanges.Add("34.208.0.0-34.208.63.251");
ipRanges.Add("35.155.0.0-35.155.0.1");
ipRanges.Add("35.160.0.0-35.160.63.253");
ipRanges.Add("50.112.0.0-50.112.120.53");
ipRanges.Add("52.10.0.0-52.10.63.252");
ipRanges.Add("52.12.0.0-52.13.255.255");
ipRanges.Add("52.24.0.0-52.24.63.252");
ipRanges.Add("52.32.0.0-52.32.63.252");	
ipRanges.Add("52.36.0.0-52.36.0.2");
ipRanges.Add("52.40.0.0-52.43.255.254");	
ipRanges.Add("52.88.0.0-52.88.0.2");
ipRanges.Add("54.68.0.0-54.68.63.252");	
ipRanges.Add("54.70.0.0-54.70.0.12");	
ipRanges.Add("54.148.0.0-54.148.0.2");	
ipRanges.Add("54.184.0.0-54.184.0.3");	
ipRanges.Add("54.186.0.0-54.186.0.3");	
ipRanges.Add("54.188.0.0-54.188.0.1");
ipRanges.Add("54.190.0.0-54.190.0.1");
ipRanges.Add("54.191.0.0-54.191.63.252");	
ipRanges.Add("54.200.0.0-54.200.0.1");	
ipRanges.Add("54.202.0.0-54.202.0.1");	
ipRanges.Add("54.212.0.0-54.212.0.1");	
ipRanges.Add("54.214.0.0-54.214.0.1");	
ipRanges.Add("54.218.0.0-54.218.4.254");	
ipRanges.Add("54.240.24.0-54.240.24.1");	
ipRanges.Add("54.240.60.0-54.240.63.254");	
ipRanges.Add("54.244.0.0-54.244.128.1");	
ipRanges.Add("54.245.0.0-54.245.127.255");	
ipRanges.Add("100.20.0.0-100.20.0.1");
*/
        public void CreateRuleThatBlocksUSW2()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("18.236.0.0-18.236.0.1");
            ipRanges.Add("34.208.0.0-34.208.63.251");
            ipRanges.Add("35.155.0.0-35.155.0.1");
            ipRanges.Add("35.160.0.0-35.160.63.253");
            ipRanges.Add("50.112.0.0-50.112.120.53");
            ipRanges.Add("52.10.0.0-52.10.63.252");
            ipRanges.Add("52.12.0.0-52.13.255.255");
            ipRanges.Add("52.24.0.0-52.24.63.252");
            ipRanges.Add("52.32.0.0-52.32.63.252");
            ipRanges.Add("52.36.0.0-52.36.0.2");
            ipRanges.Add("52.40.0.0-52.43.255.254");
            ipRanges.Add("52.88.0.0-52.88.0.2");
            ipRanges.Add("54.68.0.0-54.68.63.252");
            ipRanges.Add("54.70.0.0-54.70.0.12");
            ipRanges.Add("54.148.0.0-54.148.0.2");
            ipRanges.Add("54.184.0.0-54.184.0.3");
            ipRanges.Add("54.186.0.0-54.186.0.3");
            ipRanges.Add("54.188.0.0-54.188.0.1");
            ipRanges.Add("54.190.0.0-54.190.0.1");
            ipRanges.Add("54.191.0.0-54.191.63.252");
            ipRanges.Add("54.200.0.0-54.200.0.1");
            ipRanges.Add("54.202.0.0-54.202.0.1");
            ipRanges.Add("54.212.0.0-54.212.0.1");
            ipRanges.Add("54.214.0.0-54.214.0.1");
            ipRanges.Add("54.218.0.0-54.218.4.254");
            ipRanges.Add("54.240.24.0-54.240.24.1");
            ipRanges.Add("54.240.60.0-54.240.63.254");
            ipRanges.Add("54.244.0.0-54.244.128.1");
            ipRanges.Add("54.245.0.0-54.245.127.255");
            ipRanges.Add("100.20.0.0-100.20.0.1");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksUSW2", ProgramPath, ipRanges);
        }

        /*CANADA
Region	IP Prefix	IP	Test
ipRanges.Add("35.182.0.0-35.182.0.251");	
ipRanges.Add("52.60.0.0-52.60.50.1");
ipRanges.Add("99.79.0.0-99.79.0.1");
         */

        public void CreateRuleThatBlocksCanada()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("35.182.0.0-35.182.0.251");
            ipRanges.Add("52.60.0.0-52.60.50.1");
            ipRanges.Add("99.79.0.0-99.79.0.1");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksCAN", ProgramPath, ipRanges);
        }

        /*North Virginia
Region	IP Prefix	IP	Test
ipRanges.Add("3.80.0.0-3.80.0.1");	
ipRanges.Add("3.208.0.0-3.208.0.1");	
ipRanges.Add("3.224.0.0-3.224.0.1");	
ipRanges.Add("18.204.0.0-18.204.0.1");	
ipRanges.Add("18.208.0.0-18.208.0.1");	
ipRanges.Add("18.232.0.0-18.232.0.1");	
ipRanges.Add("23.20.0.0-23.23.255.255");	
ipRanges.Add("34.192.0.0-34.192.0.54");	
ipRanges.Add("34.224.0.0-34.224.0.252");	
ipRanges.Add("35.153.0.0-35.153.128.254");	
ipRanges.Add("35.168.0.0-35.168.0.253");	
ipRanges.Add("50.16.0.0-50.17.255.254");	
ipRanges.Add("50.19.0.0-50.19.255.254");	
ipRanges.Add("52.0.0.0-52.1.255.254");	
ipRanges.Add("52.2.0.0-52.2.0.2");	
ipRanges.Add("52.4.0.0-52.7.255.255");	
ipRanges.Add("52.20.0.0-52.20.63.253");	
ipRanges.Add("52.44.0.0-52.45.127.254");	
ipRanges.Add("52.54.0.0-52.54.63.252");	
ipRanges.Add("52.70.0.0-52.70.63.252");	
ipRanges.Add("52.72.0.0-52.72.63.252");	
ipRanges.Add("52.86.0.0-52.86.63.252");	
ipRanges.Add("52.90.0.0-52.90.63.252");	
ipRanges.Add("52.200.0.0-52.200.255.254");	
ipRanges.Add("54.80.0.0-54.80.0.2");	
ipRanges.Add("54.84.0.0-54.84.0.3");	
ipRanges.Add("54.86.0.0-54.86.63.252");	
ipRanges.Add("54.88.0.0-54.88.0.3");	
ipRanges.Add("54.89.0.0-54.89.0.3");	
ipRanges.Add("54.90.0.0-54.90.0.3");	
ipRanges.Add("54.92.128.0-54.92.128.2");	
ipRanges.Add("54.144.0.0-54.144.0.2");	
ipRanges.Add("54.152.0.0-54.152.63.252");	
ipRanges.Add("54.156.0.0-54.156.0.1");	
ipRanges.Add("54.160.0.0-54.160.0.2");	
ipRanges.Add("54.164.0.0-54.164.63.252");	
ipRanges.Add("54.166.0.0-54.166.0.2");	
ipRanges.Add("54.172.0.0-54.172.63.252");	
ipRanges.Add("54.174.0.0-54.174.0.2");	
ipRanges.Add("54.196.0.0-54.196.0.1");	
ipRanges.Add("54.198.0.0-54.198.0.1");	
ipRanges.Add("54.204.0.0-54.205.255.255");	
ipRanges.Add("54.208.0.0-54.208.0.1");	
ipRanges.Add("54.210.0.0-54.210.63.252");	
ipRanges.Add("54.221.0.0-54.221.214.221");	
ipRanges.Add("54.224.0.0-54.225.110.215");	
ipRanges.Add("54.226.0.0-54.226.0.1");	
ipRanges.Add("54.234.0.0-54.235.236.60");	
ipRanges.Add("54.236.0.0-54.236.0.1");
ipRanges.Add("54.240.8.0-54.240.8.1");	
ipRanges.Add("54.240.48.0-54.240.49.254");	
ipRanges.Add("54.242.0.0-54.243.255.254");	
ipRanges.Add("67.202.0.0-67.202.0.5");	
ipRanges.Add("72.44.32.0-72.44.32.8");	
ipRanges.Add("75.101.128.0-75.101.163.105");	
ipRanges.Add("100.24.0.0-100.24.0.1");	
ipRanges.Add("107.20.0.0-107.22.255.255");	
ipRanges.Add("174.129.0.0-174.129.0.31");	
ipRanges.Add("184.72.64.0-184.72.92.4");	
ipRanges.Add("184.72.128.0-184.72.255.254");
ipRanges.Add("184.73.0.0-184.73.173.231");
ipRanges.Add("204.236.192.0-204.236.238.4");	
*/
        public void CreateRuleThatBlocksUSE1()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("3.80.0.0-3.80.0.1");
            ipRanges.Add("3.208.0.0-3.208.0.1");
            ipRanges.Add("3.224.0.0-3.224.0.1");
            ipRanges.Add("18.204.0.0-18.204.0.1");
            ipRanges.Add("18.208.0.0-18.208.0.1");
            ipRanges.Add("18.232.0.0-18.232.0.1");
            ipRanges.Add("23.20.0.0-23.23.255.255");
            ipRanges.Add("34.192.0.0-34.192.0.54");
            ipRanges.Add("34.224.0.0-34.224.0.252");
            ipRanges.Add("35.153.0.0-35.153.128.254");
            ipRanges.Add("35.168.0.0-35.168.0.253");
            ipRanges.Add("50.16.0.0-50.17.255.254");
            ipRanges.Add("50.19.0.0-50.19.255.254");
            ipRanges.Add("52.0.0.0-52.1.255.254");
            ipRanges.Add("52.2.0.0-52.2.0.2");
            ipRanges.Add("52.4.0.0-52.7.255.255");
            ipRanges.Add("52.20.0.0-52.20.63.253");
            ipRanges.Add("52.44.0.0-52.45.127.254");
            ipRanges.Add("52.54.0.0-52.54.63.252");
            ipRanges.Add("52.70.0.0-52.70.63.252");
            ipRanges.Add("52.72.0.0-52.72.63.252");
            ipRanges.Add("52.86.0.0-52.86.63.252");
            ipRanges.Add("52.90.0.0-52.90.63.252");
            ipRanges.Add("52.200.0.0-52.200.255.254");
            ipRanges.Add("54.80.0.0-54.80.0.2");
            ipRanges.Add("54.84.0.0-54.84.0.3");
            ipRanges.Add("54.86.0.0-54.86.63.252");
            ipRanges.Add("54.88.0.0-54.88.0.3");
            ipRanges.Add("54.89.0.0-54.89.0.3");
            ipRanges.Add("54.90.0.0-54.90.0.3");
            ipRanges.Add("54.92.128.0-54.92.128.2");
            ipRanges.Add("54.144.0.0-54.144.0.2");
            ipRanges.Add("54.152.0.0-54.152.63.252");
            ipRanges.Add("54.156.0.0-54.156.0.1");
            ipRanges.Add("54.160.0.0-54.160.0.2");
            ipRanges.Add("54.164.0.0-54.164.63.252");
            ipRanges.Add("54.166.0.0-54.166.0.2");
            ipRanges.Add("54.172.0.0-54.172.63.252");
            ipRanges.Add("54.174.0.0-54.174.0.2");
            ipRanges.Add("54.196.0.0-54.196.0.1");
            ipRanges.Add("54.198.0.0-54.198.0.1");
            ipRanges.Add("54.204.0.0-54.205.255.255");
            ipRanges.Add("54.208.0.0-54.208.0.1");
            ipRanges.Add("54.210.0.0-54.210.63.252");
            ipRanges.Add("54.221.0.0-54.221.214.221");
            ipRanges.Add("54.224.0.0-54.225.110.215");
            ipRanges.Add("54.226.0.0-54.226.0.1");
            ipRanges.Add("54.234.0.0-54.235.236.60");
            ipRanges.Add("54.236.0.0-54.236.0.1");
            ipRanges.Add("54.240.8.0-54.240.8.1");
            ipRanges.Add("54.240.48.0-54.240.49.254");
            ipRanges.Add("54.242.0.0-54.243.255.254");
            ipRanges.Add("67.202.0.0-67.202.0.5");
            ipRanges.Add("72.44.32.0-72.44.32.8");
            ipRanges.Add("75.101.128.0-75.101.163.105");
            ipRanges.Add("100.24.0.0-100.24.0.1");
            ipRanges.Add("107.20.0.0-107.22.255.255");
            ipRanges.Add("174.129.0.0-174.129.0.31");
            ipRanges.Add("184.72.64.0-184.72.92.4");
            ipRanges.Add("184.72.128.0-184.72.255.254");
            ipRanges.Add("184.73.0.0-184.73.173.231");
            ipRanges.Add("204.236.192.0-204.236.238.4");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksUSE1", ProgramPath, ipRanges);
        }

        /*Ohio
Region	IP Prefix	IP	Test
ipRanges.Add("3.16.0.0-3.16.0.1");	
ipRanges.Add("13.58.0.0-13.58.0.253");	
ipRanges.Add("18.188.0.0-18.188.0.1");	
ipRanges.Add("18.191.0.0-18.191.0.1");	
ipRanges.Add("18.216.0.0-18.216.0.253");	
ipRanges.Add("18.220.0.0-18.220.0.252");	
ipRanges.Add("18.224.0.0-18.224.0.1");	
ipRanges.Add("52.14.0.0-52.14.64.1");	
ipRanges.Add("52.15.0.0-52.15.55.1");
         */

        public void CreateRuleThatBlocksUSE2()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("3.16.0.0-3.16.0.1");
            ipRanges.Add("13.58.0.0-13.58.0.253");
            ipRanges.Add("18.188.0.0-18.188.0.1");
            ipRanges.Add("18.191.0.0-18.191.0.1");
            ipRanges.Add("18.216.0.0-18.216.0.253");
            ipRanges.Add("18.220.0.0-18.220.0.252");
            ipRanges.Add("18.224.0.0-18.224.0.1");
            ipRanges.Add("52.14.0.0-52.14.64.1");
            ipRanges.Add("52.15.0.0-52.15.55.1");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksUSE2", ProgramPath, ipRanges);
        }
        /*
         *São Paulo
Region	IP Prefix	IP	Test
ipRanges.Add("18.228.0.0-18.228.0.1");	
ipRanges.Add("18.229.0.0-18.229.0.1");
ipRanges.Add("18.231.0.0-18.231.0.252");
ipRanges.Add("52.67.0.0-52.67.255.254");	
ipRanges.Add("54.94.0.0-54.94.0.66");	
ipRanges.Add("54.94.128.0-54.94.191.252");	
ipRanges.Add("54.207.0.0-54.207.127.254");	
ipRanges.Add("54.232.0.0-54.232.127.254");	
ipRanges.Add("54.233.64.0-54.233.127.252");	
ipRanges.Add("54.233.128.0-54.233.192.1");	
ipRanges.Add("54.240.16.0-54.240.16.1");	
ipRanges.Add("177.71.128.0-177.71.255.255");	
         */
        public void CreateRuleThatBlocksBrazil()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("18.228.0.0-18.228.0.1");
            ipRanges.Add("18.229.0.0-18.229.0.1");
            ipRanges.Add("18.231.0.0-18.231.0.252");
            ipRanges.Add("52.67.0.0-52.67.255.254");
            ipRanges.Add("54.94.0.0-54.94.0.66");
            ipRanges.Add("54.94.128.0-54.94.191.252");
            ipRanges.Add("54.207.0.0-54.207.127.254");
            ipRanges.Add("54.232.0.0-54.232.127.254");
            ipRanges.Add("54.233.64.0-54.233.127.252");
            ipRanges.Add("54.233.128.0-54.233.192.1");
            ipRanges.Add("54.240.16.0-54.240.16.1");
            ipRanges.Add("177.71.128.0-177.71.255.255");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksBR", ProgramPath, ipRanges);
        }
        /*
         * Ireland
Region	IP Prefix	IP	Test
ipRanges.Add("18.202.0.0-18.202.0.1");
ipRanges.Add("34.240.0.0-34.240.0.253");
ipRanges.Add("34.248.0.0-34.248.60.213");	
ipRanges.Add("46.51.128.0-46.51.178.50");	
ipRanges.Add("46.137.0.0-46.137.120.1");	
ipRanges.Add("46.137.128.0-46.137.191.254");	
ipRanges.Add("52.16.0.0-52.16.0.2");	
ipRanges.Add("52.18.0.0-52.19.0.2");	
ipRanges.Add("52.30.0.0-52.30.63.252");	
ipRanges.Add("52.48.0.0-52.48.63.252");	
ipRanges.Add("52.208.0.0-52.215.255.254");	
ipRanges.Add("54.72.0.0-54.72.255.252");	
ipRanges.Add("54.73.0.0-54.73.0.1");	
ipRanges.Add("54.74.0.0-54.74.0.1");	
ipRanges.Add("54.76.0.0-54.76.0.3");	
ipRanges.Add("54.78.0.0-54.78.0.3");	
ipRanges.Add("54.154.0.0-54.154.63.252");	
ipRanges.Add("54.155.0.0-54.155.0.1");	
ipRanges.Add("54.170.0.0-54.170.248.3");	
ipRanges.Add("54.171.0.0-54.171.63.252");	
ipRanges.Add("54.194.0.0-54.194.255.254");	
ipRanges.Add("54.216.0.0-54.216.0.1");	
ipRanges.Add("54.220.0.0-54.220.0.1");	
ipRanges.Add("54.228.0.0-54.228.250.251");	
ipRanges.Add("54.229.0.0-54.229.0.1");	
ipRanges.Add("54.240.0.0-54.240.0.1");	
ipRanges.Add("54.240.56.0-54.240.56.254");	
ipRanges.Add("54.246.0.0-54.246.127.255");	
ipRanges.Add("54.247.0.0-54.247.127.254");	
ipRanges.Add("63.32.0.0-63.32.0.1");	
ipRanges.Add("79.125.0.0-79.125.120.9");	
ipRanges.Add("99.80.0.0-99.80.0.1");	
ipRanges.Add("108.128.0.0-108.128.0.1");	
ipRanges.Add("176.34.64.0-176.34.127.254");	
ipRanges.Add("176.34.128.0-176.34.255.255");	
ipRanges.Add("185.48.120.0-185.48.120.66");	
         */
        public void CreateRuleThatBlocksEUW1()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("18.202.0.0-18.202.0.1");
            ipRanges.Add("34.240.0.0-34.240.0.253");
            ipRanges.Add("34.248.0.0-34.248.60.213");
            ipRanges.Add("46.51.128.0-46.51.178.50");
            ipRanges.Add("46.137.0.0-46.137.120.1");
            ipRanges.Add("46.137.128.0-46.137.191.254");
            ipRanges.Add("52.16.0.0-52.16.0.2");
            ipRanges.Add("52.18.0.0-52.19.0.2");
            ipRanges.Add("52.30.0.0-52.30.63.252");
            ipRanges.Add("52.48.0.0-52.48.63.252");
            ipRanges.Add("52.208.0.0-52.215.255.254");
            ipRanges.Add("54.72.0.0-54.72.255.252");
            ipRanges.Add("54.73.0.0-54.73.0.1");
            ipRanges.Add("54.74.0.0-54.74.0.1");
            ipRanges.Add("54.76.0.0-54.76.0.3");
            ipRanges.Add("54.78.0.0-54.78.0.3");
            ipRanges.Add("54.154.0.0-54.154.63.252");
            ipRanges.Add("54.155.0.0-54.155.0.1");
            ipRanges.Add("54.170.0.0-54.170.248.3");
            ipRanges.Add("54.171.0.0-54.171.63.252");
            ipRanges.Add("54.194.0.0-54.194.255.254");
            ipRanges.Add("54.216.0.0-54.216.0.1");
            ipRanges.Add("54.220.0.0-54.220.0.1");
            ipRanges.Add("54.228.0.0-54.228.250.251");
            ipRanges.Add("54.229.0.0-54.229.0.1");
            ipRanges.Add("54.240.0.0-54.240.0.1");
            ipRanges.Add("54.240.56.0-54.240.56.254");
            ipRanges.Add("54.246.0.0-54.246.127.255");
            ipRanges.Add("54.247.0.0-54.247.127.254");
            ipRanges.Add("63.32.0.0-63.32.0.1");
            ipRanges.Add("79.125.0.0-79.125.120.9");
            ipRanges.Add("99.80.0.0-99.80.0.1");
            ipRanges.Add("108.128.0.0-108.128.0.1");
            ipRanges.Add("176.34.64.0-176.34.127.254");
            ipRanges.Add("176.34.128.0-176.34.255.255");
            ipRanges.Add("185.48.120.0-185.48.120.66");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksEUW1", ProgramPath, ipRanges);
        }

        /*
         London
Region	IP Prefix	IP	Test
ipRanges.Add("3.8.0.0-3.8.0.1");	
ipRanges.Add("18.130.0.0-18.130.0.1");	
ipRanges.Add("35.176.0.0-35.176.0.252");	
ipRanges.Add("35.178.0.0-35.178.0.253");	
ipRanges.Add("52.56.0.0-52.56.34.1");	
*/

        public void CreateRuleThatBlocksEUW2()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("3.8.0.0-3.8.0.1");
            ipRanges.Add("18.130.0.0-18.130.0.1");
            ipRanges.Add("35.176.0.0-35.176.0.252");
            ipRanges.Add("35.178.0.0-35.178.0.253");
            ipRanges.Add("52.56.0.0-52.56.34.1");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksEUW2", ProgramPath, ipRanges);
        }

        /*
         Paris
Region	IP Prefix	IP	Test
ipRanges.Add("35.180.0.0-35.180.0.253");	
ipRanges.Add("35.181.0.0-35.181.0.1");	
ipRanges.Add("52.47.0.0-52.47.32.127");
*/

        public void CreateRuleThatBlocksEUW3()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("35.180.0.0-35.180.0.253");
            ipRanges.Add("35.181.0.0-35.181.0.1");
            ipRanges.Add("52.47.0.0-52.47.32.127");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksEUW3", ProgramPath, ipRanges);
        }

        /*
         * Frankfurt
Region	IP Prefix	IP	Test
ipRanges.Add("3.120.0.0-3.120.0.1");
ipRanges.Add("3.124.0.0-3.124.0.1");	
ipRanges.Add("18.184.0.0-18.184.0.1");	
ipRanges.Add("18.194.0.0-18.194.0.252");	
ipRanges.Add("18.196.0.0-18.196.0.253");	
ipRanges.Add("35.156.0.0-35.156.63.252");	
ipRanges.Add("52.28.0.0-52.28.63.252");	
ipRanges.Add("52.29.0.0-52.29.63.252");	
ipRanges.Add("52.57.0.0-52.57.255.254");	
ipRanges.Add("52.58.0.0-52.58.63.252");	
ipRanges.Add("54.93.0.0-54.93.32.2");	
ipRanges.Add("54.93.128.0-54.93.162.162");	
         */

        public void CreateRuleThatBlocksEUC()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("3.120.0.0-3.120.0.1");
            ipRanges.Add("3.124.0.0-3.124.0.1");
            ipRanges.Add("18.184.0.0-18.184.0.1");
            ipRanges.Add("18.194.0.0-18.194.0.252");
            ipRanges.Add("18.196.0.0-18.196.0.253");
            ipRanges.Add("35.156.0.0-35.156.63.252");
            ipRanges.Add("52.28.0.0-52.28.63.252");
            ipRanges.Add("52.29.0.0-52.29.63.252");
            ipRanges.Add("52.57.0.0-52.57.255.254");
            ipRanges.Add("52.58.0.0-52.58.63.252");
            ipRanges.Add("54.93.0.0-54.93.32.2");
            ipRanges.Add("54.93.128.0-54.93.162.162");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksEUC", ProgramPath, ipRanges);
        }

        /*
         * Stockholm
Region	IP Prefix	IP	Test
ipRanges.Add("13.53.0.0-13.53.128.254");	
         */

        public void CreateRuleThatBlocksEUN()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("13.53.0.0-13.53.128.254");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksEUN", ProgramPath, ipRanges);
        }

        /*
         * Seoul
Region	IP Prefix	IP	Test
ipRanges.Add("13.124.0.0-13.124.63.251");	
ipRanges.Add("13.125.0.0-13.125.0.253");	
ipRanges.Add("13.209.0.0-13.209.0.1");	
ipRanges.Add("15.164.0.0-15.164.0.1");	
ipRanges.Add("52.78.0.0-52.78.63.252");	
ipRanges.Add("52.79.0.0-52.79.52.64");	
ipRanges.Add("54.180.0.0-54.180.0.1");	
         */

        public void CreateRuleThatBlocksKorea()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("13.124.0.0-13.124.63.251");
            ipRanges.Add("13.125.0.0-13.125.0.253");
            ipRanges.Add("13.209.0.0-13.209.0.1");
            ipRanges.Add("15.164.0.0-15.164.0.1");
            ipRanges.Add("52.78.0.0-52.78.63.252");
            ipRanges.Add("52.79.0.0-52.79.52.64");
            ipRanges.Add("54.180.0.0-54.180.0.1");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksKR", ProgramPath, ipRanges);
        }

        /*Tokyo
Region	IP Prefix	IP	Test
ipRanges.Add("3.112.0.0-3.112.0.1");	
ipRanges.Add("13.112.0.0-13.112.63.251");	
ipRanges.Add("13.230.0.0-13.230.0.253");	
ipRanges.Add("18.179.0.0-18.179.0.8");	
ipRanges.Add("18.182.0.0-18.182.0.1");	
ipRanges.Add("46.51.224.0-46.51.255.254");	
ipRanges.Add("52.68.0.0-52.68.63.252");	
ipRanges.Add("52.192.0.0-52.192.63.252");	
ipRanges.Add("52.194.0.0-52.194.0.1");	
ipRanges.Add("52.196.0.0-52.196.63.252");	
ipRanges.Add("54.64.0.0-54.64.0.2");	
ipRanges.Add("54.92.0.0-54.92.0.2");	
ipRanges.Add("54.95.0.0-54.95.0.2");	
ipRanges.Add("54.150.0.0-54.150.0.255");	
ipRanges.Add("54.168.0.0-54.168.0.2");	
ipRanges.Add("54.178.0.0-54.178.0.2");	
ipRanges.Add("54.199.0.0-54.199.127.255");	
ipRanges.Add("54.238.0.0-54.238.0.1");	
ipRanges.Add("54.248.0.0-54.248.127.254");	
ipRanges.Add("54.250.0.0-54.250.128.1");	
ipRanges.Add("103.4.8.0-103.4.10.139");	
ipRanges.Add("175.41.192.0-175.41.248.202");	
ipRanges.Add("176.32.64.0-176.32.95.254");	
ipRanges.Add("176.34.0.0-176.34.56.254");	

            Osaka-Local
Region	IP Prefix	IP	Test
ipRanges.Add("13.208.0.0-13.208.32.253");	
         */

        public void CreateRuleThatBlocksJapan()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("3.112.0.0-3.112.0.1");
            ipRanges.Add("13.112.0.0-13.112.63.251");
            ipRanges.Add("13.230.0.0-13.230.0.253");
            ipRanges.Add("18.179.0.0-18.179.0.8");
            ipRanges.Add("18.182.0.0-18.182.0.1");
            ipRanges.Add("46.51.224.0-46.51.255.254");
            ipRanges.Add("52.68.0.0-52.68.63.252");
            ipRanges.Add("52.192.0.0-52.192.63.252");
            ipRanges.Add("52.194.0.0-52.194.0.1");
            ipRanges.Add("52.196.0.0-52.196.63.252");
            ipRanges.Add("54.64.0.0-54.64.0.2");
            ipRanges.Add("54.92.0.0-54.92.0.2");
            ipRanges.Add("54.95.0.0-54.95.0.2");
            ipRanges.Add("54.150.0.0-54.150.0.255");
            ipRanges.Add("54.168.0.0-54.168.0.2");
            ipRanges.Add("54.178.0.0-54.178.0.2");
            ipRanges.Add("54.199.0.0-54.199.127.255");
            ipRanges.Add("54.238.0.0-54.238.0.1");
            ipRanges.Add("54.248.0.0-54.248.127.254");
            ipRanges.Add("54.250.0.0-54.250.128.1");
            ipRanges.Add("103.4.8.0-103.4.10.139");
            ipRanges.Add("175.41.192.0-175.41.248.202");
            ipRanges.Add("176.32.64.0-176.32.95.254");
            ipRanges.Add("176.34.0.0-176.34.56.254");
            ipRanges.Add("13.208.0.0-13.208.32.253");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksJP", ProgramPath, ipRanges);
        }

        /*
         * Singapore
Region	IP Prefix	IP	Test
ipRanges.Add("3.0.0.0-3.0.0.9");	
ipRanges.Add("13.228.0.0-13.228.0.251");	
ipRanges.Add("13.250.0.0-13.250.0.253");	
ipRanges.Add("18.136.0.0-18.136.0.1");	
ipRanges.Add("18.138.0.0-18.138.0.1");	
ipRanges.Add("46.51.216.0-46.51.216.14");	
ipRanges.Add("46.137.192.0-46.137.255.254");	
ipRanges.Add("52.74.0.0-52.74.0.2");	
ipRanges.Add("52.76.0.0-52.76.0.2");	
ipRanges.Add("52.76.128.0-52.76.191.252");	
ipRanges.Add("52.77.0.0-52.77.63.252");	
ipRanges.Add("52.220.0.0-52.221.255.252");	
ipRanges.Add("54.151.128.0-54.151.128.2");	
ipRanges.Add("54.169.0.0-54.169.0.2");	
ipRanges.Add("54.169.128.0-54.169.191.253");	
ipRanges.Add("54.179.0.0-54.179.0.2");	
ipRanges.Add("54.179.128.0-54.179.191.252");	
ipRanges.Add("54.251.0.0-54.251.63.255");	
ipRanges.Add("54.254.0.0-54.254.128.1");	
ipRanges.Add("54.255.0.0-54.255.0.2");	
ipRanges.Add("122.248.192.0-122.248.255.254");	
ipRanges.Add("175.41.128.0-175.41.146.190");	
         */
        public void CreateRuleThatBlocksSingapore()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("3.0.0.0-3.0.0.9");
            ipRanges.Add("13.228.0.0-13.228.0.251");
            ipRanges.Add("13.250.0.0-13.250.0.253");
            ipRanges.Add("18.136.0.0-18.136.0.1");
            ipRanges.Add("18.138.0.0-18.138.0.1");
            ipRanges.Add("46.51.216.0-46.51.216.14");
            ipRanges.Add("46.137.192.0-46.137.255.254");
            ipRanges.Add("52.74.0.0-52.74.0.2");
            ipRanges.Add("52.76.0.0-52.76.0.2");
            ipRanges.Add("52.76.128.0-52.76.191.252");
            ipRanges.Add("52.77.0.0-52.77.63.252");
            ipRanges.Add("52.220.0.0-52.221.255.252");
            ipRanges.Add("54.151.128.0-54.151.128.2");
            ipRanges.Add("54.169.0.0-54.169.0.2");
            ipRanges.Add("54.169.128.0-54.169.191.253");
            ipRanges.Add("54.179.0.0-54.179.0.2");
            ipRanges.Add("54.179.128.0-54.179.191.252");
            ipRanges.Add("54.251.0.0-54.251.63.255");
            ipRanges.Add("54.254.0.0-54.254.128.1");
            ipRanges.Add("54.255.0.0-54.255.0.2");
            ipRanges.Add("122.248.192.0-122.248.255.254");
            ipRanges.Add("175.41.128.0-175.41.146.190");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksSP", ProgramPath, ipRanges);
        }

        /*
         * Sydney
Region	IP Prefix	IP	Test
ipRanges.Add("13.54.0.0-13.54.63.252");	
ipRanges.Add("13.210.0.0-13.210.0.252");		
ipRanges.Add("13.236.0.0-13.236.0.253");		
ipRanges.Add("52.62.0.0-52.62.63.252");		
ipRanges.Add("52.64.0.0-52.64.63.253");		
ipRanges.Add("52.64.128.0-52.64.191.252");		
ipRanges.Add("52.65.0.0-52.65.63.252");		
ipRanges.Add("54.66.0.0-54.66.0.2");		
ipRanges.Add("54.66.128.0-54.66.191.252");		
ipRanges.Add("54.79.0.0-54.79.127.252");		
ipRanges.Add("54.153.128.0-54.153.191.252");		
ipRanges.Add("54.206.0.0-54.206.127.254");		
ipRanges.Add("54.206.128.0/-54.206.128.2");		
ipRanges.Add("54.252.0.0-54.252.88.8");		
ipRanges.Add("54.253.0.0-54.253.0.1");		
         */

        public void CreateRuleThatBlocksAustralia()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("13.54.0.0-13.54.63.252");
            ipRanges.Add("13.210.0.0-13.210.0.252");
            ipRanges.Add("13.236.0.0-13.236.0.253");
            ipRanges.Add("52.62.0.0-52.62.63.252");
            ipRanges.Add("52.64.0.0-52.64.63.253");
            ipRanges.Add("52.64.128.0-52.64.191.252");
            ipRanges.Add("52.65.0.0-52.65.63.252");
            ipRanges.Add("54.66.0.0-54.66.0.2");
            ipRanges.Add("54.66.128.0-54.66.191.252");
            ipRanges.Add("54.79.0.0-54.79.127.252");
            ipRanges.Add("54.153.128.0-54.153.191.252");
            ipRanges.Add("54.206.0.0-54.206.127.254");
            ipRanges.Add("54.206.128.0-54.206.128.2");
            ipRanges.Add("54.252.0.0-54.252.88.8");
            ipRanges.Add("54.253.0.0-54.253.0.1");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksOCE", ProgramPath, ipRanges);
        }

        /*
         * Mumbai
Region	IP Prefix	IP	Test
ipRanges.Add("13.126.0.0-13.126.0.252");	
ipRanges.Add("13.232.0.0-13.232.0.253");	
ipRanges.Add("35.154.0.0-35.154.63.252");	
ipRanges.Add("52.66.0.0-52.66.66.2");	
         */
        public void CreateRuleThatBlocksIndia()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("13.126.0.0-13.126.0.252");
            ipRanges.Add("13.232.0.0-13.232.0.253");
            ipRanges.Add("35.154.0.0-35.154.63.252");
            ipRanges.Add("52.66.0.0-52.66.66.2");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksIND", ProgramPath, ipRanges);
        }

        /*
         * CHINA
Beijing
Region	IP Prefix	IP	Test
ipRanges.Add("52.80.0.0-52.80.5.207");		
ipRanges.Add("52.81.0.0-52.81.0.253");		
ipRanges.Add("54.222.128.0-54.222.240.4");		
ipRanges.Add("54.223.0.0-54.223.48.68");		
Ningxia
Region	IP Prefix	IP	Test
ipRanges.Add("52.82.0.0-52.82.0.253");		
ipRanges.Add("52.83.0.0-52.83.214.1");	
         */
        public void CreateRuleThatBlocksChina()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("52.80.0.0-52.80.5.207");
            ipRanges.Add("52.81.0.0-52.81.0.253");
            ipRanges.Add("54.222.128.0-54.222.240.4");
            ipRanges.Add("54.223.0.0-54.223.48.68");
            ipRanges.Add("52.82.0.0-52.82.0.253");
            ipRanges.Add("52.83.0.0-52.83.214.1");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksCHN", ProgramPath, ipRanges);
        }

        /*        SERVIDOR SAC1(CHILE)

        ipRanges.Add("200.29.0.0-200.29.255.255");
        ipRanges.Add("170.84.0.0-170.84.255.255"); */

        public void CreateRuleThatBlocksChile()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("200.29.0.0-200.29.255.255");
            ipRanges.Add("170.84.0.0-170.84.255.255");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksCL", ProgramPath, ipRanges);
        }

        /*
         * SERVIDOR SAA1 (ARGENTINA)

12)
De: 200.32.0.0
A: 200.32.255.255
         */
        public void CreateRuleThatBlocksArgentina()
        {
            List<string> ipRanges = new List<string>();
            ipRanges.Add("200.32.0.0-200.32.255.255");
            FirewallInstanceHelper.CreateOutboundRuleIpRange("OverwatchSSBlocksARG", ProgramPath, ipRanges);
        }

        public bool CreateAllOutboundRules()
        {
            try
            {
                CreateRuleThatBlocksArgentina();
                //CreateRuleThatBlocksAustralia();
                CreateRuleThatBlocksBrazil();
                //CreateRuleThatBlocksCanada();
                CreateRuleThatBlocksChile();
                //CreateRuleThatBlocksChina();
                //CreateRuleThatBlocksEUC();
                //CreateRuleThatBlocksEUN();
                //CreateRuleThatBlocksEUW1();
                //CreateRuleThatBlocksEUW2();
                //CreateRuleThatBlocksEUW3();
                //CreateRuleThatBlocksIndia();
                //CreateRuleThatBlocksJapan();
                //CreateRuleThatBlocksKorea();
                //CreateRuleThatBlocksSingapore();
                //CreateRuleThatBlocksUSE1();
                //CreateRuleThatBlocksUSE2();
                //CreateRuleThatBlocksUSW1();
                //CreateRuleThatBlocksUSW2();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
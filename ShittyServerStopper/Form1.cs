﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NATUPNPLib;
using NETCONLib;
using NetFwTypeLib;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Net;

namespace Shitty_Server_Stopper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Color dlbColor = SystemColors.MenuHighlight;
        const string version = "0.3.1";
        const string emptyLine = @"
";
        private const string CLSID_FIREWALL_MANAGER =
      "{304CE942-6E39-40D8-943A-B913C40C9CD4}";

        const string guidFWPolicy2 = "{E2B3C97F-6AE1-41AC-817A-F6F92166D7DD}";
        const string guidRWRule = "{2C5BC43E-3369-4C33-AB0C-BE9469677AF4}";
        string insLoc = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\";

        Color ttB = Color.FromArgb(60, 60, 60);
        Color ttF = SystemColors.MenuHighlight;

        public void hentaiRape(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_hentairape";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Hentai Rape Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "204.11.16.132,139.162.79.149,72.11.148.168,204.11.16.134,167.160.36.76,82.211.30.241,107.161.172.59,107.161.172.41";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "204.11.16.132,139.162.79.149,72.11.148.168,204.11.16.134,167.160.36.76,82.211.30.241,107.161.172.59,107.161.172.41".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }              
                }
                
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_hentairape")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_hentairape");
                foreach (string s in "204.11.16.132,139.162.79.149,72.11.148.168,204.11.16.134,167.160.36.76,82.211.30.241,107.161.172.59,107.161.172.41".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }         
        }
        public void lewd4dead(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_lewd4dead";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Lewd4Dead Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "139.162.30.4,204.11.16.135,162.217.248.223";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;                
                foreach (string s in "139.162.30.4,204.11.16.135,162.217.248.223".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_lewd4dead")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_lewd4dead");
                foreach (string s in "139.162.30.4,204.11.16.135,162.217.248.223".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void yandere(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_yandere";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Yandere Attack Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "45.32.24.56";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "45.32.24.56".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_yandere")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_yandere");
                foreach (string s in "45.32.24.56".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "74.91.112.57,66.85.14.37,74.91.116.113,66.150.121.176,74.91.117.236";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "74.91.112.57,66.85.14.37,74.91.116.113,66.150.121.176,74.91.117.236".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc");
                foreach (string s in "74.91.112.57,66.85.14.37,74.91.116.113,66.150.121.176,74.91.117.236".Split(',')) 
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc2(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc2";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "192.223.27.251,139.99.8.171,216.52.148.77,66.150.121.181,74.91.112.57";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "192.223.27.251,139.99.8.171,216.52.148.77,66.150.121.181,74.91.112.57".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc2")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc2");
                foreach (string s in "192.223.27.251,139.99.8.171,216.52.148.77,66.150.121.181,74.91.112.57".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc3(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc3";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "73.166.184.238,74.91.123.74,74.208.228.57,104.153.108.113";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "73.166.184.238,74.91.123.74,74.208.228.57,104.153.108.113".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc3")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc3");
                foreach (string s in "73.166.184.238,74.91.123.74,74.208.228.57,104.153.108.113".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc4(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc4";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "68.232.163.38,63.251.20.27,68.232.172.105,72.5.102.151,192.99.47.29,208.167.234.174,208.167.234.179";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "68.232.163.38,63.251.20.27,68.232.172.105,72.5.102.151,192.99.47.29,208.167.234.174,208.167.234.179".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc4")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc4");
                foreach (string s in "68.232.163.38,63.251.20.27,68.232.172.105,72.5.102.151,192.99.47.29,208.167.234.174,208.167.234.179".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc5(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc5";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "216.52.143.154,107.181.178.201,207.246.66.175,108.61.125.67,66.150.214.154,74.91.126.10";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "216.52.143.154,107.181.178.201,207.246.66.175,108.61.125.67,66.150.214.154,74.91.126.10".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc5")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc5");
                foreach (string s in "216.52.143.154,107.181.178.201,207.246.66.175,108.61.125.67,66.150.214.154,74.91.126.10".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc6(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc6";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "74.91.120.197,66.55.154.110,66.55.154.46";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "74.91.120.197,66.55.154.110,66.55.154.46".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc6")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc6");
                foreach (string s in "74.91.120.197,66.55.154.110,66.55.154.46".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc7(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc7";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "206.217.139.100,74.91.119.247,192.223.24.17,74.91.126.33,74.91.118.8";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "206.217.139.100,74.91.119.247,192.223.24.17,74.91.126.33,74.91.118.8".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc7")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc7");
                foreach (string s in "206.217.139.100,74.91.119.247,192.223.24.17,74.91.126.33,74.91.118.8".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc8(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc8";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "108.61.10.125,108.61.10.124,192.223.31.191,66.150.121.181,74.91.114.244,68.232.166.105";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "108.61.10.125,108.61.10.124,192.223.31.191,66.150.121.181,74.91.114.244,68.232.166.105".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc8")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc8");
                foreach (string s in "108.61.10.125,108.61.10.124,192.223.31.191,66.150.121.181,74.91.114.244,68.232.166.105".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        public void misc9(int choice)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_misc9";
            newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = "46.174.48.20,46.174.48.189,46.174.52.3,46.174.52.8,46.174.52.26,46.174.54.89,89.184.10.77,91.32.139.191,104.243.46.122,185.50.105.210,188.134.2.223,194.1.236.157,201.82.201.45,201.214.26.128,210.194.213.10,212.75.210.39";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            if (choice == 1)
            {
                bool exists = false;
                foreach (string s in "46.174.48.20,46.174.48.189,46.174.52.3,46.174.52.8,46.174.52.26,46.174.54.89,89.184.10.77,91.32.139.191,104.243.46.122,185.50.105.210,188.134.2.223,194.1.236.157,201.82.201.45,201.214.26.128,210.194.213.10,212.75.210.39".Split(','))
                {
                    if (!ipList.Items.Contains(s)) { ipList.Items.Add(s); }
                }
                
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_misc9")
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists == false) { fwPolicy2.Rules.Add(newRule); }
            }
            else
            {
                fwPolicy2.Rules.Remove("sss_misc9");
                foreach (string s in "46.174.48.20,46.174.48.189,46.174.52.3,46.174.52.8,46.174.52.26,46.174.54.89,89.184.10.77,91.32.139.191,104.243.46.122,185.50.105.210,188.134.2.223,194.1.236.157,201.82.201.45,201.214.26.128,210.194.213.10,212.75.210.39".Split(','))
                {
                    ipList.Items.Remove(s);
                }
            }
        }
        [ComImport]
        [Guid("00021401-0000-0000-C000-000000000046")]
        internal class ShellLink
        {
        }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("000214F9-0000-0000-C000-000000000046")]
        internal interface IShellLink
        {
            void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
            void GetIDList(out IntPtr ppidl);
            void SetIDList(IntPtr pidl);
            void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
            void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
            void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
            void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
            void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
            void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
            void GetHotkey(out short pwHotkey);
            void SetHotkey(short wHotkey);
            void GetShowCmd(out int piShowCmd);
            void SetShowCmd(int iShowCmd);
            void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
            void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
            void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
            void Resolve(IntPtr hwnd, int fFlags);
            void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             

            toolTip1.Draw += ToolTip1_Draw;

            Properties.Settings.Default.InstallLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper";

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\firsttimesetupdone.dat"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper");
                IShellLink link = (IShellLink)new ShellLink();
                link.SetDescription("Shitty Server Stopper");
                link.SetPath(System.Reflection.Assembly.GetExecutingAssembly().Location);
                IPersistFile file = (IPersistFile)link;
                string shortCutSave = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
                file.Save(Path.Combine(shortCutSave, "Shitty Server Stopper.lnk"), false);
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\firsttimesetupdone.dat").Close();
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\theme_black.dat").Close();
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\shitty_server_stopper_uninstaller.exe", Properties.Resources.shitty_server_stopper_uninstaller);
              
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\blocked_ips.dat").Close();
                Properties.Settings.Default.FirstStartUpDone = true;
                Properties.Settings.Default.Save();
            }

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat"))
            {
                Type typeFWPolicy3 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
                Type typeFWRule2 = Type.GetTypeFromCLSID(new Guid(guidRWRule));
                INetFwPolicy2 fwPolicy3 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy3);
                try
                {
                    string cts = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat");
                    List<String> officalList = new List<string>();
                    foreach (string s in Properties.Resources.complete_list.Split(','))
                    {
                        officalList.Add(s);
                    }
                    foreach (string s in File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat").Split(','))
                    {
                        if (officalList.Contains(s))
                        {
                            cts = cts.Replace(s + ",", "");
                            fwPolicy3.Rules.Remove("sss_" + s);                           
                        }
                    }
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat", cts);
                }
                catch { }
            }

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\update.dat"))
            {
                List<String> Lines = new List<string>();
                foreach (string line in File.ReadLines(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\update.dat"))
                {
                    if (line != string.Empty)
                    {
                        Lines.Add(line);
                    }
                }
                Properties.Settings.Default.NumCIPS = Convert.ToInt32(Lines[0]); // Number of custom IPS
                Properties.Settings.Default.FirstStartUpDone = true;  // first start up
                Properties.Settings.Default.HRBlocked = Convert.ToBoolean(Lines[1]); // Hentai Rape
                Properties.Settings.Default.L4DBlocked = Convert.ToBoolean(Lines[2]); // Lewd4Dead
                Properties.Settings.Default.MiscBlocked = Convert.ToBoolean(Lines[3]); // Misc
                Properties.Settings.Default.YABlocked = Convert.ToBoolean(Lines[4]); // Yandere Attack
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\blocked_ips.dat", File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\cips_temp.dat"));
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\sss_update.exe");
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\cips_temp.dat");
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\update.dat");
                Properties.Settings.Default.Save();
                update2();
            }

            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            foreach (INetFwRule rule in fwPolicy2.Rules)
            {
                if (rule.Name == "sss_hentairape")
                {
                    hentairapeCheckBox.Checked = true;                                 
                }
                else if (rule.Name == "sss_lewd4dead")
                {
                    lewd4deadCheck.Checked = true;                   
                }
                else if (rule.Name == "sss_yandere")
                {
                    ydCheck.Checked = true;                 
                }
                else if (rule.Name == "sss_misc1" || rule.Name == "sss_misc2" || rule.Name == "sss_misc3" || rule.Name == "sss_misc4" || rule.Name == "sss_misc5" || rule.Name == "sss_misc6" || rule.Name == "sss_misc7" || rule.Name == "sss_misc8" || rule.Name == "sss_misc9")
                {
                    xpmCheckBox.Checked = true;                  
                }
            }

            if (Properties.Settings.Default.NumCIPS > 0)
            {
                int custIPS = 0;

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat"))
                {
                    foreach (string s in File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat").Split(','))
                    {                     
                        if (s != "" || s != null || s != String.Empty || !ipList.Items.Contains(s))
                        {
                            ipList.Items.Add(s);
                            custIPS++;
                        }
                        if (custIPS == Properties.Settings.Default.NumCIPS)
                        {
                            break;
                        }
                    }
                }           
            }
            
            //reset();
            if (Properties.Settings.Default.HRBlocked == true)
            {
                hentairapeCheckBox.Checked = true;
            }
            if (Properties.Settings.Default.L4DBlocked == true)
            {
                lewd4deadCheck.Checked = true;
            }
            if (Properties.Settings.Default.YABlocked == true)
            {
                ydCheck.Checked = true;
            }
            if (Properties.Settings.Default.MiscBlocked == true)
            {
               xpmCheckBox.Checked = true;
            }

            update();
            update2();

            string contents;
            if (internetConnection() == true)
            {             
                using (var wc = new System.Net.WebClient())
                    contents = wc.DownloadString("http://wallymodz.weebly.com/uploads/5/3/7/8/53782675/sss_version.txt");
            }
            else
            {
                contents = version;
            }
                  
          

            if (contents != version)
            {
                Form NewUpdate = new NewUpdate();
                NewUpdate.ShowDialog();

            }

            if (File.Exists(insLoc + "theme_white.dat"))
            {
                themeWhite();
            }

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upl_recheck.dat"))
            {
                if (lewd4deadCheck.Checked == false) { File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upl_recheck.dat"); return; }
                lewd4deadCheck.Checked = false;
                System.Threading.Thread.Sleep(100);
                lewd4deadCheck.Checked = true;
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upl_recheck.dat");
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\uph_recheck.dat"))
            {
                if (hentairapeCheckBox.Checked == false) { File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\uph_recheck.dat"); return; }
                hentairapeCheckBox.Checked = false;
                System.Threading.Thread.Sleep(100);
                hentairapeCheckBox.Checked = true;
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\uph_recheck.dat");
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upy_recheck.dat"))
            {
                if (ydCheck.Checked == false) { File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upy_recheck.dat"); return; }
                ydCheck.Checked = false;
                System.Threading.Thread.Sleep(100);
                ydCheck.Checked = true;
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upy_recheck.dat");
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upm_recheck.dat"))
            {
                if (xpmCheckBox.Checked == false) { File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upm_recheck.dat"); return; }
                xpmCheckBox.Checked = false;
                System.Threading.Thread.Sleep(100);
                xpmCheckBox.Checked = true;
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\upm_recheck.dat");
            }


            
        }

        private void ToolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            toolTip1.BackColor = ttB;
            toolTip1.ForeColor = ttF;
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hentaiRape(1);
        }

        private void hentairapeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hentairapeCheckBox.Checked == true)
            {
                hentaiRape(1);
                Properties.Settings.Default.HRBlocked = true;
                Properties.Settings.Default.Save();
                update();
                hentairapeCheckBox.ForeColor = SystemColors.MenuHighlight;
                
            }
            else
            {
                hentaiRape(2);
                Properties.Settings.Default.HRBlocked = false;
                Properties.Settings.Default.Save();
                update();
                hentairapeCheckBox.ForeColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void ydCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ydCheck.Checked == true)
            {
                yandere(1);
                Properties.Settings.Default.YABlocked = true;
                Properties.Settings.Default.Save();
                update();
                ydCheck.ForeColor = SystemColors.MenuHighlight;
                
            }
            else
            {
                yandere(2);
                Properties.Settings.Default.YABlocked = false;
                Properties.Settings.Default.Save();
                update();
                ydCheck.ForeColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void lewd4deadCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (lewd4deadCheck.Checked == true)
            {
                dlbColor = Color.FromArgb(231, 76, 60);
                lewd4dead(1);
                
                Properties.Settings.Default.L4DBlocked = true;
                Properties.Settings.Default.Save();
                update();
                lewd4deadCheck.ForeColor = SystemColors.MenuHighlight;
                
            }
            else
            {
                lewd4dead(2);
                Properties.Settings.Default.L4DBlocked = false;
                Properties.Settings.Default.Save();
                update();
                lewd4deadCheck.ForeColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void xpmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (xpmCheckBox.Checked == true)
            {
                misc(1);
                misc2(1);
                misc3(1);
                misc4(1);
                misc5(1);
                misc6(1);
                misc7(1);
                misc8(1);
                misc9(1);
                Properties.Settings.Default.MiscBlocked = true;
                Properties.Settings.Default.Save();
                update();
                xpmCheckBox.ForeColor = SystemColors.MenuHighlight;
              
            }
            else
            {
                misc(2);
                misc2(2);
                misc3(2);
                misc4(2);
                misc5(2);
                misc6(2);
                misc7(2);
                misc8(2);
                misc9(2);
                Properties.Settings.Default.MiscBlocked = false;
                Properties.Settings.Default.Save();
                update();
                xpmCheckBox.ForeColor = Color.FromArgb(30, 30, 30);
            }
        }
        public void update()
        {
            foreach (var item in ipList.Items)
            {
                if (ipList.GetItemText(item) == string.Empty)
                {
                    ipList.Items.Remove(item);
                    break;
                }
            }
        }
        public void update2()
        {
            if (Properties.Settings.Default.HRBlocked == true) { hentairapeCheckBox.Checked = true; }
            if (Properties.Settings.Default.YABlocked == true) { ydCheck.Checked = true; }
            if (Properties.Settings.Default.L4DBlocked == true) {lewd4deadCheck.Checked = true; }
            if (Properties.Settings.Default.MiscBlocked == true) { xpmCheckBox.Checked = true; }
        }
        public void reset()
        {
            ipList.Items.Clear();
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat");
            Properties.Settings.Default.CurrBocked = null;
            Properties.Settings.Default.FirstStartUpDone = false;
            Properties.Settings.Default.InstallLocation = null;
            Properties.Settings.Default.Save();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                  
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addCusIP();
        }
       public void addCusIP()
        {
            if (ipTextBox.Text == string.Empty) { return; }

            foreach (string s in Properties.Resources.complete_list.Split(','))
            {
                if (s == ipTextBox.Text)
                {
                    showError.ShowError("Error: 7", "IP Belongs to Group", "This IP Belongs to a Group, it cannot be added individually.");
                    ipTextBox.Text = "";
                    return;
                }
            }
            try
            {
                if (ValidateIPv4(ipTextBox.Text) == true)
                {

                    bool addtolist = false;
                    if (ipList.Items.Count > 0)
                    {
                        foreach (string item in ipList.Items)
                        {
                            if (item == ipTextBox.Text)
                            {
                                showError.ShowError("Error: 1", "IP Already Blocked", "This IP Adress is already being blocked.");
                                addtolist = false;
                            }
                            else
                            {
                                addtolist = true;
                            }
                        }
                    }
                    else
                    {
                        addtolist = true;
                    }

                    if (addtolist == true)
                    {
                        Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
                        Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
                        INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
                        INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
                        newRule.Name = "sss_" + ipTextBox.Text;
                        newRule.Description = "Shitty Sever Stopper - Blocks connections to Misc Servers";
                        newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
                        newRule.LocalPorts = "";
                        newRule.RemoteAddresses = ipTextBox.Text;
                        newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                        newRule.Enabled = true;
                        newRule.Grouping = "Shitty Server Stopper";
                        newRule.Profiles = 2147483647;
                        newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                        bool exists = false;
                        foreach (INetFwRule rule in fwPolicy2.Rules)
                        {
                            if (rule.Name == "sss_" + ipTextBox.Text)
                            {
                                exists = true;
                                break;
                            }
                            else
                            {
                                exists = false;
                            }
                        }
                        if (exists == false)
                        {
                            fwPolicy2.Rules.Add(newRule);
                            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat", ipTextBox.Text + ",");
                            ipList.Items.Add(ipTextBox.Text);
                            Properties.Settings.Default.NumCIPS++;
                            Properties.Settings.Default.Save();
                            notifyIcon1.ShowBalloonTip(2000, "IP Blocked", ipTextBox.Text + " is now being blocked!", ToolTipIcon.Info);
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            showError.ShowError("Error: 6", "Rule Already Exists", "Winodws Firewall already contains this rule.");
                            ipTextBox.Text = "";
                            return;
                        }
                    }
                }
                else
                {
                    showError.ShowError("Error: 3", "IP Adress Invalid", "Make sure the IP is in the correct format." + emptyLine + "Example: 192.168.2.1");
                    ipTextBox.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                showError.ShowError("Error: 4", "N/A", "Unknown Error Occured");
            }
            ipTextBox.Text = "";
        }
             
           
        
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeSelected();
        }
        public void removeSelected()
        {
            try
            {
                Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
                Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
                INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {
                    if (rule.Name == "sss_" + ipList.SelectedItem)
                    {
                        fwPolicy2.Rules.Remove("sss_" + ipList.SelectedItem);
                        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat", File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat").Replace(ipList.SelectedItem + ",", ""));
                        ipList.Items.Remove(ipList.SelectedItem);
                    }
                }

            }
            catch
            {
                showError.ShowError("Error: 2", "You Cannot Remove this Item", "There was an unknown error while attempting to remove item.");
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form About = new About();
            About.Show();
        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ipList.SelectedItem.ToString());
            }
            catch { }
          
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ipTextBox.Paste(Clipboard.GetText());
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ipTextBox.SelectionLength > 0)
            {
                ipTextBox.Copy();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ipTextBox.Text != "")
            {
                ipTextBox.Cut();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ipTextBox.Undo();
            ipTextBox.ClearUndo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ipTextBox.SelectAll();
        }
        
        private void ipList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)ipList.SelectedItem == "")
            {
                ipCMS.Enabled = false;
            }
            else
            {
                ipCMS.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.NumCIPS > 0)
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat"))
                {
                    if (File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat") == string.Empty) { return; }
                    string content = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat");
                    exportIP.ShowDialog();
                    if (exportIP.FileName != "")
                    {
                        File.WriteAllText(exportIP.FileName, content);
                        notifyIcon1.ShowBalloonTip(2000, "Success", "IP Pack Exported!", ToolTipIcon.Info);
                    }

                }
            }                                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                openIP.ShowDialog();

                if (openIP.FileName != "")
                {
                    foreach (string ip in File.ReadAllText(openIP.FileName).Split(','))
                    {
                        try
                        {
                            if (ip != string.Empty)
                            {
                                addRule(ip, ip);
                            }
                        }
                        catch { }
                    }
                }
            }
           catch
            {
                showError.ShowError("Error: 5", "Counln't Open File", "Error while attempting to open file. Please try again.");
            }
        }
        public void addRule(string name, string ip)
        {
            Type typeFWPolicy2 = Type.GetTypeFromCLSID(new Guid(guidFWPolicy2));
            Type typeFWRule = Type.GetTypeFromCLSID(new Guid(guidRWRule));
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(typeFWPolicy2);
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(typeFWRule);
            newRule.Name = "sss_" + name;
            newRule.Description = "Shitty Sever Stopper - Blocks connection to custom Servers";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = "";
            newRule.RemoteAddresses = ip;
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Enabled = true;
            newRule.Grouping = "Shitty Server Stopper";
            newRule.Profiles = 2147483647;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            bool exists = false;
            foreach (INetFwRule rule in fwPolicy2.Rules)
            {
                if (rule.Name == "sss_" + name)
                {
                    exists = true;
                    break;
                }
                else
                {
                    exists = false;
                }
            }
            if (exists == false)
            {
                fwPolicy2.Rules.Add(newRule);
                File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\blocked_ips.dat", ip + ",");
                ipList.Items.Add(ip);
                Properties.Settings.Default.NumCIPS++;
                Properties.Settings.Default.Save();
            }
            update();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uh oh, you found me! :-)");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form NewUpdate = new NewUpdate();
            NewUpdate.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
         
        }

        private void ipList_DrawItem(object sender, DrawItemEventArgs e)
        {
           
        }

        private void ipList_MouseDown(object sender, MouseEventArgs e)
        {
        
            ipList.SelectedIndex = ipList.IndexFromPoint(e.X, e.Y);
        }

        private void ipCMS_Opening(object sender, CancelEventArgs e)
        {
            if (ipList.Items.Count == 0)
            {
                ipCMS.Enabled = false;
            }
            else
            {
                ipCMS.Enabled = true;
            }
        }

        private void ipTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addCusIP();
            }
        }

        private void ipList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                removeSelected();
            }
        }
     
        public void changeButtonsCLR(Color colourF, Color colourB, Color hoverClr)
        {
            List<Control> btns = new List<Control> ();
            foreach (Control ctrls in this.Controls)
            {
                if (ctrls.GetType() == typeof(Button))
                {
                    btns.Add(ctrls);
                }
            }     
            foreach (Button btn in btns)
            {
                btn.ForeColor = colourF;
                btn.BackColor = colourB;
                btn.FlatAppearance.MouseOverBackColor = hoverClr;
            }              
        }
        
        private void themeBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(insLoc + "theme_white.dat") && !File.Exists(insLoc + "theme_black.dat"))
            {
                File.Create(insLoc + "theme_white.dat").Close();
                themeWhite();
            }

            if (File.Exists(insLoc + "theme_black.dat"))
            {
                File.Delete(insLoc + "theme_black.dat");
                File.Create(insLoc + "theme_white.dat").Close();
                themeWhite();
            }
            else if (File.Exists(insLoc + "theme_white.dat"))
            {
                File.Delete(insLoc + "theme_white.dat");
                File.Create(insLoc + "theme_black.dat").Close();
                themeBlack();
            }
            ipList.Focus();
        }
        public void themeWhite()
        {  
            themeBtn.Text = "Dark Mode";
            this.BackColor = Color.White;
            ipList.BackColor = Color.Gray;
            ipTextBox.BackColor = Color.Gray;
            ipTextBox.ForeColor = Color.Black;
            ipList.ForeColor = Color.Black;
            changeButtonsCLR(Color.Black, Color.LightGray, Color.Silver);
            ttF = Color.Black;
            ttB = Color.White;

            ipCMS.BackColor = Color.White;
            iptextContext.BackColor = Color.White;

            foreach (ToolStripItem item1 in ipCMS.Items)
            {
                item1.ForeColor = Color.Black;
                item1.BackColor = Color.White;
            }
            foreach (ToolStripItem item2 in iptextContext.Items)
            {
                item2.ForeColor = Color.Black;
                item2.BackColor = Color.White;
            }
            tss1.BackColor = Color.White;
            tss2.BackColor = Color.White;
        }
        public void themeBlack()
        {           
            themeBtn.Text = "Light Mode";
            ipList.BackColor = Color.FromArgb(50, 50, 50);
            ipTextBox.BackColor = Color.FromArgb(50, 50, 50);
            ipTextBox.ForeColor = SystemColors.MenuHighlight;
            ipList.ForeColor = SystemColors.MenuHighlight;
                this.BackColor = Color.FromArgb(64, 64, 64);
            changeButtonsCLR(Color.FromArgb(119, 119, 119), Color.FromArgb(51, 51, 51), Color.FromArgb(60,60,60));
            ttF = SystemColors.MenuHighlight;
            ttB = Color.FromArgb(60,60,60);
            ipCMS.BackColor = Color.FromArgb(60, 60, 60); // Boarder Color
            iptextContext.BackColor = Color.FromArgb(60, 60, 60);
            foreach (ToolStripItem item1 in ipCMS.Items)
            {
                item1.ForeColor = SystemColors.MenuHighlight;
                item1.BackColor = Color.FromArgb(60,60,60);
            }
            foreach (ToolStripItem item2 in iptextContext.Items)
            {
                item2.ForeColor = SystemColors.MenuHighlight;
                item2.BackColor = Color.FromArgb(60,60,60);
            }
            tss1.BackColor = Color.FromArgb(60, 60, 60);
            tss2.BackColor = Color.FromArgb(60, 60, 60);
        }
        private void ipLabel_Click(object sender, EventArgs e)
        {
            showError.ShowError("Error: 9", "IP Adress Invalid", "Make sure the IP is in the correct format." + emptyLine + "Example: 192.168.2.1");
        }
        public bool internetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}

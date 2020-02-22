using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFirewallHelper;

namespace OverwatchServerSelector
{
    public class FirewallInstanceHelper
    {
        public FirewallInstanceHelper()
        {
        }

        public List<IRule> GetOutboundRegisteredRules()
        {
            List<IRule> SortedList = FirewallManager.Instance.Rules.ToArray().OrderBy(o => o.Name).ToList();
            List<IRule> OutboundRulesList = new List<IRule>();
            foreach (IRule rule in SortedList)
            {
                if (rule.Direction.ToString().Equals("Outbound"))
                    OutboundRulesList.Add(rule);
            }
            return OutboundRulesList;
        }

        public bool CreateOutboundRuleIpRange (string ruleName, string programPath, List<string>ipRanges)
        {
            try
            {
                if (!RuleAlreadyExists(ruleName))
                {
                    IRule OutboundRule = AddOutboundRule(ruleName, programPath);
                    List<IAddress> AddressList = new List<IAddress>();
                    foreach (string ipRange in ipRanges)
                    {
                        WindowsFirewallHelper.Addresses.IPRange range;
                        bool isValid = WindowsFirewallHelper.Addresses.IPRange.TryParse(ipRange, out range);
                        AddressList.Add(range);
                    }
                    OutboundRule.RemoteAddresses = AddressList.ToArray();
                    FirewallManager.Instance.Rules.Add(OutboundRule);
                }
                return true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                return false;
            }
        }

        public bool CreateOutboundRuleIpSingle(string ruleName, string programPath, List<string>ipSingles)
        {
            try
            {
                if (!RuleAlreadyExists(ruleName))
                {
                    List<IAddress> AddressList = new List<IAddress>();
                    IRule OutboundRule = AddOutboundRule(ruleName, programPath);
                    foreach (string ipSingle in ipSingles)
                    {
                        AddressList.Add(WindowsFirewallHelper.Addresses.SingleIP.Parse(ipSingle));
                    }
                    OutboundRule.RemoteAddresses = AddressList.ToArray();
                    FirewallManager.Instance.Rules.Add(OutboundRule);
                }
                return true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                return false;
            }
        }

        public IRule AddOutboundRule(string ruleName, string programPath)
        {
            IRule OutboundRule = FirewallManager.Instance.CreateApplicationRule(FirewallManager.Instance.GetProfile().Type, ruleName, FirewallAction.Block, programPath);
            OutboundRule.Direction = FirewallDirection.Outbound;
            OutboundRule.Scope = FirewallScope.All;
            OutboundRule.Protocol = FirewallProtocol.Any;
            OutboundRule.Profiles = FirewallProfiles.Domain | FirewallProfiles.Private | FirewallProfiles.Public;
            OutboundRule.IsEnable = false;
            return OutboundRule;
        }

        private bool RuleAlreadyExists (string ruleName)
        {
            return GetOutboundRegisteredRules().Exists(o => o.Name == ruleName);
        }


    }
}

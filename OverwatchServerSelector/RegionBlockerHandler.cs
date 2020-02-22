using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFirewallHelper;

namespace OverwatchServerSelector
{
    public class RegionBlockerHandler
    {
        public List<IRule> OverwatchSSBRules { get; set; }

        public RegionBlockerHandler()
        {
            OverwatchSSBRules = SearchOverwatchSSBRules();
        }

        public List<IRule> SearchOverwatchSSBRules()
        {
            FirewallInstanceHelper instance = new FirewallInstanceHelper();
            List<IRule> overwatchSSBRulesList = new List<IRule>();
            foreach (IRule rule in instance.GetOutboundRegisteredRules())
            {
                string name = rule.Name;
                if (name.Length > 15 && name.Substring(0,12).Equals("OverwatchSSB"))
                {
                    overwatchSSBRulesList.Add(rule);
                }
            }
            return overwatchSSBRulesList;
        }

        public void ResetRestrictions()
        {
            UpdateRules();
            foreach (IRule rule in OverwatchSSBRules)
            {
                rule.IsEnable = false;
            }
        }

        public void DeleteRestrictions()
        {
            UpdateRules();
            foreach (IRule rule in OverwatchSSBRules)
            {
                FirewallManager.Instance.Rules.Remove(rule);
            }
        }

        public bool enableRegion(string restrictionName)
        {
            
            try
            {
                IRule rule = GetSpecificRule(restrictionName);
                rule.IsEnable = false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool disableRegion(string restrictionName)
        {
            try
            {
                IRule rule = GetSpecificRule(restrictionName);
                rule.IsEnable = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsEnabled (string restrictionName)
        {
            IRule rule = GetSpecificRule(restrictionName);
            return rule.IsEnable;
        }

        public IRule GetSpecificRule (string restrictionName)
        {
            UpdateRules();
            return OverwatchSSBRules.First( x => x.Name == restrictionName);
        }

        private void UpdateRules()
        {
            OverwatchSSBRules = SearchOverwatchSSBRules();
        }
    }
}

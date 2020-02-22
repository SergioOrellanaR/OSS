using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverwatchServerSelector;
using WindowsFirewallHelper;

namespace OverwatchServerSelectorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string programPath = @"T:\Archivos de Programa\Overwatch\Overwatch.exe";
            RegionRuleCreator regionBlocker = new RegionRuleCreator(programPath);
            Console.WriteLine(regionBlocker.CreateAllOutboundRules());
            RegionBlockerHandler handler = new RegionBlockerHandler();
            foreach (IRule rule in handler.OverwatchSSBRules)
            {
                Console.WriteLine(rule.Name);
                foreach (IAddress address in rule.RemoteAddresses)
                    Console.WriteLine(address.ToString());
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}

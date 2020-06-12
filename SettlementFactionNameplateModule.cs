using TaleWorlds.MountAndBlade;
using System.Windows.Forms;
using HarmonyLib;
using System;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace SettlementFactionNameplate
{
    public class SettlementFactionNameplateModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad() {
            base.OnSubModuleLoad();
            
            try
            {
                Harmony harmony = new Harmony("com.teoti.bannerlord.settlementfactionnameplate");
                harmony.PatchAll();
            }
            catch (Exception ex) {
                MessageBox.Show($"Failed to apply patch SettlementFactionNameplate:\n{ex.Message}\n{ex.InnerException.Message}");
            }
        }
        /*
        public override bool DoLoading(Game game) {
            base.DoLoading(game);
            try 
            { 
                if(Campaign.Current != null && Campaign.Current.Settlements != null) {
                    foreach (Settlement s in Campaign.Current.Settlements)
                    {
                        if (s != null && !s.IsHideout()) 
                        {
                            utils.print("hello");
                            //string id = s.StringId;
                            string name = s.ToString() != null ? s.ToString().ToLower() : "noluck";
                            SettlementRef.NamesToSettlement.Add(name, s);
                            utils.print("WNAME: " + name + "SAVED");// + " ID: " + id);
                            Hero.MainHero.MapFaction.ToString()
                        }                         
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Failed to to build Dictionary of settlements:\n{ex.Message}\n{ex.InnerException.Message}");
            }
            return true;
        }*/

    }
}
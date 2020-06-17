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
                Harmony harmony = new Harmony("oet.bannerlord.settlementfactionnameplate");
                harmony.PatchAll();
            }
            catch (Exception ex) {
                MessageBox.Show($"Failed to apply patch SettlementFactionNameplate:\n{ex.Message}\n{ex.InnerException.Message}");
            }
        }
    }
}
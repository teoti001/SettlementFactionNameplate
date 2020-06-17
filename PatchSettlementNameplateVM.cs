using System;
using HarmonyLib;
using SandBox.ViewModelCollection.Nameplate;
using TaleWorlds.CampaignSystem;

namespace SettlementFactionNameplate
{
    [HarmonyPatch(typeof(SettlementNameplateVM), "RefreshRelationStatus")]
    class PatchSettlementNameplateVM
    {
        private static bool Prefix(SettlementNameplateVM __instance, ref int ____bindRelation, IFaction ____currentFaction) {
            String faction = ____currentFaction.ToString().Replace(" ","");      
            switch (faction) {
                case "Aserai":
                    ____bindRelation = 3;
                    break;
                case "Battania":
                    ____bindRelation = 4;
                    break;
                case "Khuzait":
                    ____bindRelation = 5;
                    break;
                case "NorthernEmpire":
                    ____bindRelation = 6;
                    break;
                case "SouthernEmpire":
                    ____bindRelation = 7;
                    break;
                case "Sturgia":
                    ____bindRelation = 8;
                    break;
                case "Vlandia":
                    ____bindRelation = 9;
                    break;
                case "WesternEmpire":
                    ____bindRelation = 10;
                    break;
                default:
                    return true;
                    break;
            }
            return false;
        }
    }
}

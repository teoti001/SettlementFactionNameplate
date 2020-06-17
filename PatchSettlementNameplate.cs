using TaleWorlds.MountAndBlade.GauntletUI.Widgets.Nameplate;
using HarmonyLib;


namespace SettlementFactionNameplate
{
    [HarmonyPatch(typeof(SettlementNameplateWidget), "SetNameplateRelationType")]
    [HarmonyPatch]
    public class PatchSettlementNameplate
    {
        private static bool Prefix(SettlementNameplateWidget __instance, ref int type, ref string ____currentRelationState, ref bool ____isVisualStateDirty)
        {
            switch (type)
            {
                case 3:
                    ____currentRelationState = "Aserai";
                    break;
                case 4:
                    ____currentRelationState = "Battania";
                    break;
                case 5:
                    ____currentRelationState = "Khuzait";
                    break;
                case 6:
                    ____currentRelationState = "NorthernEmpire";
                    break;
                case 7:
                    ____currentRelationState = "SouthernEmpire";
                    break;
                case 8:
                    ____currentRelationState = "Sturgia";
                    break;
                case 9:
                    ____currentRelationState = "Vlandia";
                    break;
                case 10:
                    ____currentRelationState = "WesternEmpire";
                    break;
                default:    //do normal assignement of _currentRelationStatus
                    return true;
                    break;
            }
            ____isVisualStateDirty = true;
            return false;
        }
    }
}


using TaleWorlds.Core;

namespace SettlementFactionNameplate
{
    public static class utils
    {
        public static void print(string s)
        {
            InformationManager.DisplayMessage(new InformationMessage(s));
        }
    }
}

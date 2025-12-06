namespace ICSModMenu.Patches
{
    public static class PlayerStatsPatch
    {
        public static bool Prefix(PlayerStats __instance)
        {
            return false;
        }
    }
}
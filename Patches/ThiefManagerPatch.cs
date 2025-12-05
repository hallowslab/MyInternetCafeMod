using ICSModMenu.Utils;

namespace ICSModMenu.Features
{
    public static class ThiefManagerPatch
    {
        // Prefix runs before SendMyThief
        public static bool Prefix(ThiefManager __instance)
        {
            // Returning false skips the original method
            return false;
        }
    }
}

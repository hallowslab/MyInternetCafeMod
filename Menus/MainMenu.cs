using UnityEngine;

namespace ICSModMenu.Menus
{
    public class MainMenu
    {
        private ModMenuPlugin plugin;

        private static readonly float menuWidth = 240f;
        private static readonly float menuHeight = 150f;
        private static readonly float menuX = 10f;
        private static readonly float menuY = 10f;
        private static readonly float buttonWidth = 180f;
        private static readonly float buttonHeight = 30f;
        // center horizontally
        private readonly float buttonX = menuX + (menuWidth - buttonWidth) / 2f;

        public MainMenu(ModMenuPlugin plugin)
        {
            this.plugin = plugin;
        }

        public void Draw()
        {
            GUI.Box(new Rect(menuX, menuY, menuWidth, menuHeight), "Mod Menu");

            if (GUI.Button(new Rect(buttonX, 50, buttonWidth, buttonHeight), "Cheats"))
            {
                plugin.ActivePage = ModMenuPlugin.MenuPage.Cheats;
            }

            if (GUI.Button(new Rect(buttonX, 90, buttonWidth, buttonHeight), "Patches"))
            {
                plugin.ActivePage = ModMenuPlugin.MenuPage.Patches;
            }
        }
    }
}

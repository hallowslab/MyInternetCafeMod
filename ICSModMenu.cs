using BepInEx;
using UnityEngine;
using ICSModMenu.Features;

namespace ICSModMenu
{
    [BepInPlugin("com.hallowslab.ICSModMenu", "Internet Cafe Simulator Mod Menu", "1.0.0")]
    public class ModMenuPlugin : BaseUnityPlugin
    {
        private bool menuVisible = false;
        private string moneyToAddText = "1000"; // store input as string
        private float moneyToAdd = 1000f;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F11))
                menuVisible = !menuVisible;
        }

        void OnGUI()
        {
            if (!menuVisible) return;

            // Mod Menu box
            GUI.Box(new Rect(10, 10, 220, 120), "Mod Menu");

            // Money label
            GUI.Label(new Rect(20, 40, 80, 20), "Amount:");
            // Creat input with default value
            moneyToAddText = GUI.TextField(new Rect(100, 40, 100, 20), moneyToAddText);

            // Convert string to float safely
            if (!float.TryParse(moneyToAddText, out moneyToAdd))
            {
                moneyToAdd = 0f;
            }

            // Create GUI button: https://docs.unity3d.com/ScriptReference/GUI.Button.html
            if (GUI.Button(new Rect(20, 70, 180, 30), "Add money"))
            {
                // Call the AddMoney method from GameLogic
                GameLogic.AddMoney(moneyToAdd);
            }
        }
    }
}

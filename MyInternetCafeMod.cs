using BepInEx;
using HarmonyLib;
using UnityEngine;
using MyInternetCafeMod.Utils;

namespace MyInternetCafeMod
{
    [BepInPlugin("com.hallowslab.internetcafemod", "Internet Cafe Mod", "1.0.0")]
    public class MyInternetCafeMod : BaseUnityPlugin
    {
        void Awake()
        {
            // Create overlay
            var g_obj = new GameObject("DebugOverlayObject");
            g_obj.AddComponent<DebugOverlay>();
            DontDestroyOnLoad(g_obj);

            DebugOverlay.Log("DebugOverlay initialized!");

            // Harmony patching
            var harmony = new Harmony("com.hallowslab.internetcafemod");
            harmony.PatchAll();

            Logger.LogInfo("MyInternetCafeMod loaded!");
        }
    }
}

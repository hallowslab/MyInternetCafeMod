using UnityEngine;
using UnityEngine.SceneManagement;

namespace ICSModMenu.Utils
{
    public static class LoadingHelper
    {
        private static SaveManager saveManager;
        private static bool saveLoadInProgress = false;

        public static bool IsLoading()
        {
            // Check if SaveManager exists
            if (saveManager == null)
                saveManager = Object.FindObjectOfType<SaveManager>();

            // If no save manager, likely in main menu: not loading
            if (saveManager == null) return false;

            // If saveLoadInProgress flag is set, we are loading a save
            if (saveLoadInProgress) return true;

            // Optionally, check for any active scene load operations
            if (SceneManager.GetActiveScene().isLoaded == false) return true;

            return false;
        }

        // Call this via Harmony patch or manually at start/end of SaveManager.Load()
        public static void StartSaveLoad() => saveLoadInProgress = true;
        public static void EndSaveLoad() => saveLoadInProgress = false;
    }
}

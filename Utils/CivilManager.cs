using System.Reflection;

namespace ICSModMenu.Utils
{
    public static class CivilManagerUtils
    {
        public static void SendNewCustomer(CivilManager manager)
        {
            if (manager == null) return;

            MethodInfo method = typeof(CivilManager).GetMethod(
                "SendCustomer",
                BindingFlags.NonPublic | BindingFlags.Instance
            );

            if (method != null)
            {
                method.Invoke(manager, null);
            }
            else
            {
                DebugOverlay.Log("SendCustomer method not found!");
            }
        }
    }
}

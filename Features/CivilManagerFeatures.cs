using System.Reflection;

namespace ICSModMenu.Features
{
    public static class CivilManagerFeatures
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
                ModMenuPlugin.Log.LogError("SendCustomer method not found!");
            }
        }
    }
}

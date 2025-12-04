using UnityEngine;

namespace ICSModMenu.Features
{
    public static class GameLogic
    {
        public static void SetMoney(float amount)
        {
            PlayerPrefs.SetFloat("money", amount);
            PlayerPrefs.Save();

            MoneyTaker.Instance?.GenerateMoneyTaker(amount);

            Debug.Log($"Money has been set to: {amount}$");
        }
    }
}

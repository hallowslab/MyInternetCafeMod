using UnityEngine;

namespace ICSModMenu.Features
{
    public static class GameLogic
    {
        public static void AddMoney(float amount)
        {
            float current = PlayerPrefs.GetFloat("money");
            current += amount;
            PlayerPrefs.SetFloat("money", current);
            PlayerPrefs.Save();

            if (MoneyTaker.Instance != null)
                MoneyTaker.Instance.GenerateMoneyTaker(amount);

            Debug.Log($"Added {amount}$, new total: {current}$");
        }
    }
}

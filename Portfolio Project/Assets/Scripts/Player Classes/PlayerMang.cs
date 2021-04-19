using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerClasses
{
    public class PlayerMang : MonoBehaviour
    {
        #region Economy Properties
        private static int p_Money { get; set; }
        private static int p_Health { get; set; }
        #endregion

        #region Economy Functions
        public static void UpdateHealth(int input) => p_Health += input;
        public static void UpdateMoney(int input) => p_Money += input;
        #endregion

        private void Awake()
        {
            p_Money = 10;
            p_Health = 10;
        }
    }
}
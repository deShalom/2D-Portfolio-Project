using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerClasses
{
    public class Pickup_Generic : MonoBehaviour
    {
        enum p_Type { t_Health, t_Money };
        [SerializeField] p_Type ItemType;
        [SerializeField] int health, money;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            print("There has been a collision.");

            if (collision.gameObject.name == "Tester Player")
            {
                switch (ItemType)
                {
                    case p_Type.t_Health:
                        print("This pick-up is of type health.");
                        break;
                    case p_Type.t_Money:
                        print("This pick-up is of type money.");
                        break;
                }
                Destroy(gameObject);
            }
        }

    }
}

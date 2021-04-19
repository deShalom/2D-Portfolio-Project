using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerClasses
{
    public class PlayerCont : MonoBehaviour
    {
        PlayerContBinds playerContBinds;

        [SerializeField] Player_SO playerData;
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private Collider2D col;
        [SerializeField] private LayerMask groundLayer;

        #region PlayerContMap Enable/Disable's
        private void OnEnable() { playerContBinds.Enable(); }

        private void OnDisable() { playerContBinds.Disable(); }
        #endregion

        private void Awake()
        {
            playerContBinds = new PlayerContBinds();
        }

        private void Start()
        {
            StartCoroutine("Movement");
            playerContBinds.StandardCont.Jump.performed += _ => Jump();
        }

        #region Movement Functions
        IEnumerator Movement()
        {
            while (true)
            {
                float movementInputs = playerContBinds.StandardCont.Move.ReadValue<float>();
                rb.velocity = new Vector2(movementInputs * playerData.movementSpeed, rb.velocity.y);

                yield return null;
            }
        }

        private void Jump()
        {
            if (GroundCheck())
            {
                rb.AddForce(new Vector2(0, playerData.jumpSpeed), ForceMode2D.Impulse);
            }

        }

        private bool GroundCheck()
        {
            Vector2 feetPos = transform.position;
            feetPos.y -= col.bounds.extents.y;
            return Physics2D.OverlapCircle(feetPos, .1f, groundLayer);
        }
        #endregion
    }
}

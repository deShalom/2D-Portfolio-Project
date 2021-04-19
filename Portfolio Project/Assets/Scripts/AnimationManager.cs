using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PlayerClasses
{
    public class AnimationManager : MonoBehaviour
    {
        [SerializeField] Animator animator;
        [SerializeField] Animations_SO animationData;

        enum animStates { a_Idle, a_Walk, a_Jump, };
        [SerializeField] animStates a_States;

        [SerializeField] Rigidbody2D rBody;
        [SerializeField] SpriteRenderer sRend;

        private void Start() => StartCoroutine("Animating");

        IEnumerator Animating()
        {
            while (true)
            {

                switch(a_States)
                {
                    case animStates.a_Idle:
                        animator.Play(animationData.anims[0].name);
                        break;

                    case animStates.a_Jump:
                        animator.Play(animationData.anims[2].name);
                        break;

                    case animStates.a_Walk:
                        animator.Play(animationData.anims[1].name);
                        break;
                }

                yield return null;
            }
        }

        private void FixedUpdate()
        {

            if (rBody.velocity.x == 0)
                a_States = animStates.a_Idle;

            if (rBody.velocity.x > 0) { a_States = animStates.a_Walk; sRend.flipX = false; }

            if (rBody.velocity.x < 0) { a_States = animStates.a_Walk; sRend.flipX = true; }

            if (rBody.velocity.y > 0 || rBody.velocity.y < 0)
                a_States = animStates.a_Jump;

        }

    }
}

using UnityEngine;

namespace GGJ2020 {
    public class PlayerBody : Body {
        SpriteRenderer spriteRenderer;
        Animator animator;

        int animatorDirection = 2;
        int AnimatorDirection {
            set {
                if (value != animatorDirection) {
                    animatorDirection = value;
                    animator.SetInteger("Direction", animatorDirection);
                    animator.SetTrigger("StartMoving");
                    spriteRenderer.flipX = animatorDirection == 1;
                }
            }
        }

        bool moving;

        bool Moving {
            set {
                if (value != moving) {
                    moving = value;
                    if (moving) {
                        animator.SetTrigger("StartMoving");
                    } else {
                        animator.SetTrigger("StopMoving");
                    }
                }
            }
        }

        void Start() {
            spriteRenderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
        }

        public override void SetDirection(Vector2 direction) {
            this.AnimatorDirection = DirectionForAnimator(direction);
        }

        public override void SetSpeed(float speed) {
            this.Moving = speed > 0;
        }

        int DirectionForAnimator(Vector2 direction) {
            if (Mathf.Abs(direction.x) >= Mathf.Abs(direction.y)) {
                return direction.x >= 0 ? 1 : 3;
            }
            return direction.y >= 0 ? 0 : 2;
        }
    }
}

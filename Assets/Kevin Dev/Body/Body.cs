using UnityEngine;

namespace GGJ2020 {
    public class Body : MonoBehaviour {
        BodyCollisionHandler collisionHandler;
        public void SetDirection(Vector2 direction) {

        }

        public void SetCollisionHandler(BodyCollisionHandler handler) {
            collisionHandler = handler;
        }

        void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.GetComponent<Bullet>()) {
                collisionHandler.OnWeaponHit();
            }
        }
    }
}

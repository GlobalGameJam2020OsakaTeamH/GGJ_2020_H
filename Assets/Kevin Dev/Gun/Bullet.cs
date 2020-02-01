using UnityEngine;

namespace GGJ2020 {
    public class Bullet : MonoBehaviour {
        Rigidbody2D body;
        public float speed = 8f;
        public float lifetime = 5f;
        float shootTime;
        Vector2 direction;
        public void SetDirection(Vector2 direction) {
            this.direction = direction;
        }

        void Start() {
            body = GetComponent<Rigidbody2D>();
            shootTime = TimeManager.GameTime;
        }

        void Update() {
            body.velocity = speed * direction.normalized;
            if (TimeManager.GameTime - shootTime >= lifetime) {
                Destroy(gameObject);
            }
        }
    }
}

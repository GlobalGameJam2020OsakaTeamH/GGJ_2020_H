using UnityEngine;
using System.Collections;

namespace GGJ2020 {
    public class Bullet : MonoBehaviour {
        Rigidbody2D body;
        public float speed = 8f;
        public float lifetime = 5f;
        Vector2 direction;
        public void SetDirection(Vector2 direction) {
            this.direction = direction;
        }

        void Start() {
            body = GetComponent<Rigidbody2D>();
            StartCoroutine(DestroyBlade());
        }

        void Update() {
            body.velocity = speed * direction.normalized;
        }

        void OnCollisionEnter2D(Collision2D collision) {
            Destroy(gameObject);
        }

        IEnumerator DestroyBlade() {
            yield return new GameTime.WaitForSeconds(lifetime);
            Destroy(gameObject);
        }
    }
}

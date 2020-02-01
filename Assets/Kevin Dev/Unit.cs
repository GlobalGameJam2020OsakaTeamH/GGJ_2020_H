using UnityEngine;

namespace GGJ2020 {
    public class Unit : MonoBehaviour {
        public void SetDirection(Vector2 direction) {
            if (direction.magnitude > 0) {
                Debug.Log($"Direciton {direction}");
            }
        }

        public void UseSword() {
            Debug.Log($"Sword");
        }

        public void UseGun() {
            Debug.Log($"Gun");
        }

        void Start() {

        }

        void Update() {

        }
    }
}

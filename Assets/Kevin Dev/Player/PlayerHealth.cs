using UnityEngine;

namespace GGJ2020 {
    public class PlayerHealth : MonoBehaviour, BodyCollisionHandler {
        public void OnWeaponHit() {
            Debug.Log("Hit by enemy bullet");
        }
    }

}

using UnityEngine;

namespace GGJ2020 {
    public class PlayerHealth : MonoBehaviour, BodyCollisionHandler {
        public void OnWeaponHit(Collision2D collision) {
            Debug.Log("Hit by enemy bullet");
        }
    }

}

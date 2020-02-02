using UnityEngine;

namespace GGJ2020 {
    public class PlayerHealth : MonoBehaviour, BodyCollisionHandler {
        public void OnWeaponHit(Collision2D collision) {
            GetComponent<PlayerStats>().HP -= 1;
        }
    }

}

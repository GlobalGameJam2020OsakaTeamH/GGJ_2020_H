using UnityEngine;

namespace GGJ2020 {
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMagnet : MonoBehaviour {
        [SerializeField] float magnetStrength;
        [SerializeField] float magnetDistance;

        Rigidbody2D rbody2D;
        GameObject gameObjectTarget;

        void Start() {
            gameObjectTarget = GameObject.FindGameObjectWithTag("Player");
            rbody2D = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate() {
            Vector3 vectorToPlayer = gameObjectTarget.transform.position - transform.position;
            float distanceToPlayer = vectorToPlayer.magnitude;
            if (distanceToPlayer < magnetDistance) {
                Vector2 force = vectorToPlayer.normalized * magnetStrength / vectorToPlayer.sqrMagnitude;
                rbody2D.AddForce(force);
            }
        }
    }
}

using System.Collections;

using UnityEngine;

namespace GGJ2020 {
    public class SwordBlade : MonoBehaviour {
        void Start() {
            StartCoroutine(DestroyBlade());
        }

        IEnumerator DestroyBlade() {
            yield return new WaitForSeconds(0.3f);
            Destroy(gameObject);
        }
    }

}

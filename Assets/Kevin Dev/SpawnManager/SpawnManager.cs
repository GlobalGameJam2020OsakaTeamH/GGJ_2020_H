using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public static SpawnManager instance;
    public static Transform parentTransform;
    void Awake() {
        SpawnManager.parentTransform = this.gameObject.transform;
        SpawnManager.instance = this;
        StartCoroutine(CheckForRespawn());
    }

    public int enemies = 0;

    IEnumerator CheckForRespawn() {
        while (true) {
            yield return new WaitForSeconds(5);
            if (enemies < 3) {
                GetComponent<SpawnManagerAkio>().InitializeSpawn();
            }
        }
    }

}

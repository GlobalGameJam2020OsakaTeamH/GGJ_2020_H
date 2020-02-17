using System.Collections;
using UnityEngine;

using GGJ2020.Util;

public class SpawnManager : SingletonBase<SpawnManager> {

    public static Transform parentTransform;
    void Awake() {
        SpawnManager.parentTransform = this.gameObject.transform;
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

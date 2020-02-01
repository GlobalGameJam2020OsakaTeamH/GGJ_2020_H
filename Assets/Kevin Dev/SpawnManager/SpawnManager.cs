using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public static Transform parentTransform;
    void Awake() {
        SpawnManager.parentTransform = this.gameObject.transform;
    }
}

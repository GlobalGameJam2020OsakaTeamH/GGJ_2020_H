using UnityEngine;

public class SpawnParent : MonoBehaviour {
    public static Transform parentTransform;
    void Awake() {
        SpawnParent.parentTransform = this.gameObject.transform;
    }
}

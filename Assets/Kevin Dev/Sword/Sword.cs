using UnityEngine;

public class Sword : MonoBehaviour {
    public GameObject bladePrefab;
    public GameObject bladeOrigin;

    public void Use(Vector2 direction) {
        Vector3 eulerAngles = new Vector3(0, 0, Vector2.SignedAngle(Vector2.up, direction));
        transform.eulerAngles = eulerAngles;
        GameObject blade = GameObject.Instantiate(bladePrefab, SpawnManager.parentTransform, true);
        blade.transform.position = bladeOrigin.transform.position;
        blade.transform.eulerAngles = eulerAngles;
        blade.layer = gameObject.layer; // Same collision layer as Gun
    }

}

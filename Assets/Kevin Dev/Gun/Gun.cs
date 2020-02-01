using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletOrigin;
    // Start is called before the first frame update

    public void Use(Vector2 direction) {
        transform.eulerAngles = new Vector3(0, 0, Vector2.SignedAngle(Vector2.up, direction));
        GameObject bullet = GameObject.Instantiate(bulletPrefab, SpawnParent.parentTransform, true);
        bullet.transform.position = bulletOrigin.transform.position;
        bullet.layer = gameObject.layer; // Same collision layer as Gun
        bullet.GetComponent<Bullet>().SetDirection(direction);
    }
}

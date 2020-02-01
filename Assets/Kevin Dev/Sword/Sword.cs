using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject swordBody;
    public Animator animator;

    public void Use(Vector2 direction) {
        transform.eulerAngles = new Vector3(0, 0, Vector2.SignedAngle(Vector2.up, direction));
        animator.SetTrigger("Use");
    }
}

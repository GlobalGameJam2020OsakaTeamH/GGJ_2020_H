using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject swordBody;
    public Animator animator;

    public void Use() {
        animator.SetTrigger("Use");
    }
}

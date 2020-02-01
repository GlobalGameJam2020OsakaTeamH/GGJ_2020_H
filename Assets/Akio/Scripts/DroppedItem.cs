using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedItem : MonoBehaviour
{

    [SerializeField] float magnetSpeed;
    Vector2 startVelocity;

    Rigidbody2D rbody2D;

    GameObject gameObjectTarget;

    bool isMagnet = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObjectTarget = GameObject.FindGameObjectWithTag("Player");
        rbody2D = GetComponent<Rigidbody2D>();
        rbody2D.velocity = startVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        float relativeX = gameObjectTarget.transform.position.x - transform.position.x;
        float relativeY = gameObjectTarget.transform.position.y - transform.position.y;
        float relativeZ = gameObjectTarget.transform.position.z - transform.position.z;

        Vector3 relative = new Vector3(relativeX, relativeY, relativeZ);
        if (isMagnet)
        {

            
            Vector3 force = Vector3.Normalize(relative);
            Vector2 force2D = new Vector2(force.x, force.y) * magnetSpeed;

            rbody2D.velocity = force2D;
        }
        else
        {
            if(relative.magnitude < 3.0f)
            {
                isMagnet = true;
            }
        }
    }

    public void Initialize(Vector2 startVelocity)
    {
        this.startVelocity = startVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Got item");
            Destroy(gameObject);
        }
    }
}

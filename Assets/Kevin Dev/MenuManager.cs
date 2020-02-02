using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject menumessage;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerIsAtBase) {
            menumessage.SetActive(true);
            if (Input.GetKey(KeyCode.Space)) {
                menu.SetActive(true);
            }
        } else {
            menumessage.SetActive(false);
        }
    }

    bool PlayerIsAtBase {
        get {
            return (player.transform.position - transform.position).magnitude < 3;
        }
    }
}

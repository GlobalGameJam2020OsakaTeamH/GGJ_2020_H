using UnityEngine;

public class DroppedItem : MonoBehaviour
{
    public Sprite screwSprite;
    public Sprite gearSprite;

    bool isScrew;

    // Start is called before the first frame update
    void Start()
    {
        isScrew = Random.Range(0, 2) == 1;
        if (isScrew) {
            GetComponent<SpriteRenderer>().sprite = screwSprite;
        } else {
            GetComponent<SpriteRenderer>().sprite = gearSprite;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (isScrew) {
                collision.gameObject.GetComponent<PlayerInventory>().Screws += 1;
            } else {
                collision.gameObject.GetComponent<PlayerInventory>().Gears += 1;
            }
            Destroy(gameObject);
        }
    }
}

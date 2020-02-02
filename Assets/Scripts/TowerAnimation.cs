using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAnimation : MonoBehaviour
{
    public IntegerBindingVariable TowerHealth;
    public Sprite[] sprites;


    SpriteRenderer spriteRenderer;

    public void SetEnergy(int _energy)
    {
        TowerHealth.Value = (int)_energy;
    }

    // Start is called before the first frame update
    void Start()
    {
      //  sprites = new Sprite[7];
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TowerHealth.Value < 14)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if (TowerHealth.Value < 28)
        {
            spriteRenderer.sprite = sprites[1];

        }
        else if (TowerHealth.Value < 42)
        {
            spriteRenderer.sprite = sprites[2];

        }
        else if (TowerHealth.Value < 56)
        {
            spriteRenderer.sprite = sprites[3];

        }
        else if (TowerHealth.Value < 70)
        {
            spriteRenderer.sprite = sprites[4];

        }
        else if (TowerHealth.Value < 84)
        {
            spriteRenderer.sprite = sprites[5];

        }
        else
        {
            spriteRenderer.sprite = sprites[6];

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTitle : MonoBehaviour
{
    public float spd =0.2f;
    public GameObject TitlePic;
    public GameObject StartPic;
    public IntegerBindingVariable TowerHealth;
    SpriteRenderer spriteRenderer;
    SpriteRenderer titleRenderer;
    SpriteRenderer StartRenderer;

    float dt = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        titleRenderer = TitlePic.GetComponent<SpriteRenderer>();
        StartRenderer = StartPic.GetComponent<SpriteRenderer>();
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0.0f);
        Color temp = titleRenderer.color;
        Color temp2 = StartRenderer.color;
        titleRenderer.color= new Color(temp.r,temp.g,temp.b, 0.0f);
        StartRenderer.color= new Color(temp.r,temp.g,temp.b, 0.0f);
        TowerHealth.Value =100;
    }

    // Update is called once per frame
    void Update()
    {
        if(spriteRenderer.color.a<1.0f)
        {
            if(spriteRenderer.color.a > 0.5f)
            {
                if (titleRenderer.color.a < 1.0f)
                {
                    titleRenderer.color = new Color(titleRenderer.color.r, titleRenderer.color.g, titleRenderer.color.b, titleRenderer.color.a + Time.deltaTime * spd*2);
                }

            }
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, spriteRenderer.color.a+Time.deltaTime*spd);
            if (TowerHealth.Value >0)
            {
                dt += Time.deltaTime * 2;
                // Debug.Log(dt);
                if(dt>0.1f)
                {
                    dt = 0;
                    TowerHealth.Value -= 1;
                }
            }
        }
        else
        {
            if (StartRenderer.color.a < 1.0f)
            {
                StartRenderer.color = new Color(titleRenderer.color.r, titleRenderer.color.g, titleRenderer.color.b, titleRenderer.color.a + Time.deltaTime * spd*2);
            }
            if (Input.GetKey(KeyCode.Space))
            {

                Manager.SceneMoveManager.Instance.Test = true;
                Manager.MainGameManager.Instance.StartGame();
            }
        }

    }
}

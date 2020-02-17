using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerAkio : MonoBehaviour
{

    [SerializeField] GameObject prefabEnemyA;
    [SerializeField] GameObject prefabEnemyB;
    [SerializeField] int gameLevel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SPAWNED");
        InitializeSpawn();
    }


    public void InitializeSpawn()
    {
        switch (gameLevel)
        {
            case 1:
                for (int i = 0; i < 10; i++)
                {
                    Vector3 position = GetPositionByRadius(5.0f, 8.0f);
                    SpawnEnemyA(position);
                }
                Instantiate(prefabEnemyB, GetPositionByRadius(5.0f, 8.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
                SpawnManager.Instance.enemies += 11;
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemyA(Vector3 position)
    {
        Instantiate(prefabEnemyA, position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
    }

    Vector3 GetPositionByRadius(float minRadius, float maxRadius)
    {
        float r = Random.Range(minRadius, maxRadius);
        float th = Random.Range(0.0f, 2 * Mathf.PI);
        float x = r * Mathf.Cos(th);
        float y = r * Mathf.Sin(th);
        return new Vector3(x, y);
    }
}

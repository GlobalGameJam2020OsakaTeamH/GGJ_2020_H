using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KikuchiTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Manager.SceneMoveManager.Instance.Test = true;
            Manager.MainGameManager.Instance.StartGame();
        }
    }

    void OnCollisionEnter(Collision c)
    {
        Debug.Log("collision");
    }
}

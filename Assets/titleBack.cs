using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleBack : MonoBehaviour
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

            Manager.SceneMoveManager.Instance.MoveScene(Manager.SceneMoveManager.SceneType.Title);
            //Manager.MainGameManager.Instance.StartGame();
        }
    }
}

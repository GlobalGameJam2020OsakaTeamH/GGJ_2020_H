using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GogameOver : MonoBehaviour
{
    public IntegerBindingVariable PlayerHealth;
    public IntegerBindingVariable Tower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.Value == 0)
        {
            //Manager.SceneMoveManager.Instance.SetNextScene(Manager.SceneMoveManager.SceneType.Over);
            SceneManager.LoadScene("gameOver");
        }
        if(Tower.Value==100)
        {
            SceneManager.LoadScene("win");

        }
    }
}

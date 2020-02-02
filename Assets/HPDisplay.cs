using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPDisplay : MonoBehaviour, IListener
{
    public IntegerBindingVariable PlayerHP;


    public void Notify()
    {
        UpdateHP();
    }

    private void OnEnable()
    {
        PlayerHP.AddListener(this);
        UpdateHP();
    }

    private void OnDisable()
    {
        PlayerHP.RemoveListener(this);
    }


    private void UpdateHP()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive( i < PlayerHP.Value);
        }
    }
}

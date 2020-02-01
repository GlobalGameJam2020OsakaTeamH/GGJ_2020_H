using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(1.2f);
        Destroy(gameObject);
    }
}

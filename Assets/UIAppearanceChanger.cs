using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppearanceChanger : MonoBehaviour
{

    public Image SelectionCursor;
    private void Start() {
        if(SelectionCursor == null)
            this.SelectionCursor = GetComponent<Image>();
    }


    public void SetActive(){
        if(this.SelectionCursor == null)
            Start();
        SelectionCursor.enabled = true;
    }

    public void SetInactive(){
        SelectionCursor.enabled = false;
    }
}

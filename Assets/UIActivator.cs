using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIActivator : MonoBehaviour
{
    

    public UIActivator LeftActivator;
    public UIActivator RightActivator;
    public UIActivator UpActivator;
    public UIActivator DownActivator;

    private ShopItem UIImage;
    private Button UIButton;

    private void Start() {
        UIImage = GetComponent<ShopItem>();
        UIButton = GetComponent<Button>();
    }


    public void ActivateButton(){
        if(UIImage){
            UIImage.Activate();
        }
        else if(UIButton != null){
            UIButton.Select();
        }
    }
}

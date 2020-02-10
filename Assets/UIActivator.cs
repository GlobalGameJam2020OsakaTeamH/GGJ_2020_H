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

    private ShopItem CustomShopItem;
    private Button UIButton;

    private void Start() {
        CustomShopItem = GetComponent<ShopItem>();
        UIButton = GetComponent<Button>();
    }


    public void ActivateButton(){
        if(CustomShopItem){
            CustomShopItem.Activate();
        }
        else if(UIButton != null){
            UIButton.Select();
        }
    }
}

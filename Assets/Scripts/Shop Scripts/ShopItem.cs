using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour, IPointerClickHandler
{
    public ItemData Item;
    [HideInInspector]
    public PlayerStats PlayerStats;
    [HideInInspector]
    public PlayerInventory PlayerInventory;


    private Image DisplayPicture;
    public IntegerMediator GearMediator;
    public IntegerMediator ScrewMediator;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Item != null)
        {
            if (!Item.UseItem()) {
                return;
            }
            if (Item.ConsumeOnUse)
            {
                this.Item = Item.NextItem;
                if (Item == null)
                    GameObject.Destroy(this.gameObject);
                else
                    InitializeDisplay();
            }
        }
    }


    private void OnEnable()
    {
        DisplayPicture = GetComponentInChildren<Image>();
        InitializeDisplay();
    }


    private void InitializeDisplay()
    {
        DisplayPicture.sprite = Item.ItemImageSource;
        GearMediator.Value = Item.GearCost;
        ScrewMediator.Value = Item.ScrewCost;
    }

}

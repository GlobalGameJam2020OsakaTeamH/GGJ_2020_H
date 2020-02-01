using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ItemData : ScriptableObject
{
    public Sprite ItemImageSource;
 
    public bool ConsumeOnUse = true;
    public ItemData NextItem;

    public int GearCost;
    public int ScrewCost;
    public IntegerBindingVariable gears;
    public IntegerBindingVariable screws;


    public void UseItem()
    {
        if (gears.Value >= GearCost && screws.Value >= ScrewCost)
        {
            gears.Value -= GearCost;
            screws.Value -= ScrewCost;
            DoItemAction();
        }

    }


    protected abstract void DoItemAction();
}

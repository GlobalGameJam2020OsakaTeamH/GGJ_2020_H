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


    public bool UseItem()
    {
        if (CanUse() && gears.Value >= GearCost && screws.Value >= ScrewCost)
        {
            gears.Value -= GearCost;
            screws.Value -= ScrewCost;
            DoItemAction();
            return true;
        }
        else
        {
            return false;
        }

    }


    protected virtual bool CanUse()
    {
        return true;
    }

    protected abstract void DoItemAction();
}

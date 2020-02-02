﻿using System.Collections;
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
        if (CanUse() && gears.Value >= GearCost && screws.Value >= ScrewCost)
        {
            gears.Value -= GearCost;
            screws.Value -= ScrewCost;
            DoItemAction();
        }
        else
        {
            Debug.Log("Can't use this right now");
        }

    }


    protected virtual bool CanUse()
    {
        return true;
    }

    protected abstract void DoItemAction();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FixSelf", menuName = "Items/FixSelf")]
public class FixSelf : ItemData
{
    public int amount;
    public IntegerBindingVariable UnitHealth;
    public IntegerBindingVariable UnitMaxHealth;
    protected override void DoItemAction()
    {
        UnitHealth.Value = Mathf.Min(UnitHealth.Value + amount, UnitMaxHealth.Value);
    }

    protected override bool CanUse()
    {
        return UnitHealth.Value < UnitMaxHealth.Value;
    }
}

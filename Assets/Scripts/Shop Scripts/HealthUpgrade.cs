using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HealthUpgrade", menuName = "Items/HealthUpgrade")]
public class HealthUpgrade : ItemData
{
    public int amount;
    public IntegerBindingVariable UnitMaxHealth;
    protected override void DoItemAction()
    {
        UnitMaxHealth.Value += amount;
    }
}

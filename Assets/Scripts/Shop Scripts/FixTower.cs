using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FixTower", menuName = "Items/FixTower")]
public class FixTower : ItemData, IObservable
{
    private List<IListener> listeners = new List<IListener>();
    public int HealAmount;
    public IntegerBindingVariable TowerHealth;
    protected override void DoItemAction()
    {
        TowerHealth.Value =  Mathf.Min( TowerHealth.Value + HealAmount, 100);
        if(TowerHealth.Value == 100)
        {
            NotifyChange();
        }
    }

    protected override bool CanUse()
    {
        return TowerHealth.Value < 100;
    }

    public void NotifyChange()
    {
        foreach(IListener listener in listeners)
        {
            listener.Notify();
        }
    }

    public void AddListener(IListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }

    public void RemoveListener(IListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }
}

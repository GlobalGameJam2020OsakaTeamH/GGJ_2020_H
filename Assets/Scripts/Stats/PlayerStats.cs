using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private IntegerBindingVariable MaxHPRef;
    public int MaxHP{
        get => MaxHPRef.Value;
        set => MaxHPRef.Value = value;
    } 

    [SerializeField]
    private IntegerBindingVariable HPRef;
    public int HP{
        get => HPRef.Value;
        set => HPRef.Value = value;
    } 

    [SerializeField]
    private IntegerBindingVariable ArmorRef;
    public int Armor{
        get => ArmorRef.Value;
        set => ArmorRef.Value = value;
    }  


}

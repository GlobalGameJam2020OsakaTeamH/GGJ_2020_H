using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField]
    private IntegerBindingVariable GearsRef;
    public int Gears{
        get => GearsRef.Value;
        set => GearsRef.Value = value;
    } 

    [SerializeField]
    private IntegerBindingVariable ScrewsRef;
    public int Screws{
        get => ScrewsRef.Value;
        set => ScrewsRef.Value = value;
    } 
}

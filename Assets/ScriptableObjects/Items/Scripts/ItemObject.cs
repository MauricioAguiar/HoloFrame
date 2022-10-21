using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemObject : ScriptableObject { 
    public enum ItemType
    {

        Paint,
        HomeBasic,
        Sculture,
        Other
    }
    public enum ItemRarity
    {
        Commom,
        Superb,
        Rare,
        Masterpiece,
        Exclusive
    }

    public int ID, creationYear;

    public string _title, _author1, _author2, _signature;

    [TextArea(20,30)]
    public string _gratitude;

    public ItemType typeItem;
    public ItemRarity rarity;
    public GameObject objectModel;


}
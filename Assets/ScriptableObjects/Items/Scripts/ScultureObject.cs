using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ScultureTheme
{
    Nature,
    City,
    Classic,
    Outerspace,
    Abstract,
    Horror,
    Simplist
}

[CreateAssetMenu(fileName = "New Sculture Object", menuName = "Inventory/Items/Sculture")]
public class ScultureObject : ItemObject
{
    public ScultureTheme scultureTheme;
    private void Awake()
    {
        typeItem = ItemType.Sculture;
    }
}

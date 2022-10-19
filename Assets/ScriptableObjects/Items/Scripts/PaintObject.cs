using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum PaintTheme
{
    Nature,
    City,
    Classic,
    Outerspace,
    Abstract,
    Horror,
    Simplist
}
[CreateAssetMenu(fileName = "New Food Object", menuName = "Inventory/Items/Paint")]
public class PaintObject : ItemObject
{
    public PaintTheme paintTheme;
    private void Awake()
    {
        typeItem = ItemType.Paint;
    }

}

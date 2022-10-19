using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Inventory Database", menuName = "Inventory/Items/Inventorydatabase")]
public class InventoryDataBase : ScriptableObject, ISerializationCallbackReceiver
{

    public ItemObject[] Items;
    public Dictionary<ItemObject, int> GetId = new();
    public Dictionary<int, ItemObject> GetItem = new();

    public void OnAfterDeserialize()
    {
        GetId = new Dictionary<ItemObject, int>();
        GetItem = new Dictionary<int, ItemObject>();
        for (int i = 0; i < Items.Length; i++)
        {
            GetId.Add(Items[i], i);
            GetItem.Add(i, Items[i]);
        }
    }

    public void OnBeforeSerialize()
    {
        
    }
}

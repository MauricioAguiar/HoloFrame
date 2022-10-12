using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_prefab : MonoBehaviour
{

    [SerializeField]
    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        SetInstance(GetPrefab());
    }

    internal void SetInstance(GameObject newPrefab)
     {
        GameObject prefabChildSetter = GameObject.Find("Prop_Reciever/Scale");

        GameObject childSetter = Instantiate(newPrefab, prefabChildSetter.transform);

        Debug.Log(prefabChildSetter.name);
        Debug.Log(newPrefab.name);

        childSetter.transform.SetParent(prefabChildSetter.transform);
    }
    
    public void SetPrefab(GameObject pref)
    {
        this.prefab = pref;
    }

    public GameObject GetPrefab()
    {
        return this.prefab;
    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_prefab : MonoBehaviour
{

    [SerializeField]
    private GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        prefab = GetComponent<PaintScript>().GetInfo().objectModel;
        SetInstance();
    }

    internal void SetInstance()
     {
        GameObject prefabChildSetter = GameObject.Find("Prop_Reciever/Scale");

        GameObject childSetter = Instantiate(prefab, prefabChildSetter.transform);

        Debug.Log(prefabChildSetter.name);
        Debug.Log(prefab.name);

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

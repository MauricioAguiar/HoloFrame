using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_prefab : MonoBehaviour
{

    public GameObject Prefab;
        
    private GameObject PrefabChildSetter;

    // Start is called before the first frame update
    void Start()
    {
        PrefabChildSetter = GameObject.Find("Prop_Reciever/Scale");
        PrefabChildSetter = Instantiate(Prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

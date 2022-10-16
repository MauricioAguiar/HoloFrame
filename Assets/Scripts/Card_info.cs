using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


[CreateAssetMenu(fileName = "cardInfo", menuName ="Card/New Card") ]
public class Card_info : ScriptableObject
{
    public string _title, _author1, _author2, _gratitude, _signature = "Default";

    public GameObject artObject;

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card_info : MonoBehaviour
{

    [SerializeField]
    protected string _title, _author1, _author2, _gratitude, _signature = "Default";

    private TMP_Text _titleInput, _author1Input, _author2Input, _gratitudeInput, _signatureInput;

    



    // Start is called before the first frame update
    void Start(){

        _titleInput = GameObject.Find("Card/TextBoxes/_title").GetComponent<TMP_Text>();
        _author1Input = GameObject.Find("Card/TextBoxes/_author1").GetComponent<TMP_Text>();
        _author2Input = GameObject.Find("Card/TextBoxes/_author2").GetComponent<TMP_Text>();
        _gratitudeInput = GameObject.Find("Card/TextBoxes/_gratitude").GetComponent<TMP_Text>();
        _signatureInput = GameObject.Find("Card/TextBoxes/_signature").GetComponent<TMP_Text>();


        SetStrings(_titleInput, _title);
        SetStrings(_author1Input, _author1);
        SetStrings(_author2Input, _author2);
        SetStrings(_gratitudeInput, _gratitude);
        SetStrings(_signatureInput, _signature);
    }

    void SetStrings(TMP_Text tmp_text, string text)
    {
        if (text.Length == 0){
            text = "Default";
        }
        tmp_text.text = text;

    }


    // Update is called once per frame
    void Update()
    {

    }
}

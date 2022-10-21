using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PaintScript : MonoBehaviour{

    public ItemObject paint;

    public string _title, _author1, _author2, _gratitude, _signature = "Default";

    public GameObject artObject;

    private TMP_Text _titleInput, _author1Input;
    private TMP_Text _author2Input, _gratitudeInput, _signatureInput;

    void Start(){

    SetValues();
    _titleInput = GameObject.Find("Model_Info/_title").GetComponent<TMP_Text>();
    _author1Input = GameObject.Find("Model_Info/_author1").GetComponent<TMP_Text>();
    //_author2Input = GameObject.Find("Model_Info/_author2").GetComponent<TMP_Text>();
    //_gratitudeInput = GameObject.Find("Model_Info/_gratitude").GetComponent<TMP_Text>();
    //_signatureInput = GameObject.Find("Model_Info/_signature").GetComponent<TMP_Text>();    


    SetStrings(_titleInput, _title);
    SetStrings(_author1Input, _author1);
    //SetStrings(_author2Input, _author2);
    //SetStrings(_gratitudeInput, _gratitude);
    //SetStrings(_signatureInput, _signature);
    }


    private void SetValues()
    {
        this._title = paint._title;
        this._author1 = paint._author1;
        this._author2 = paint._author2;
        this._gratitude = paint._gratitude;
        this._signature = paint._signature;
    }

    void SetStrings(TMP_Text tmp_text, string text) {
        if (text.Length <= 0 || text == null) {
            tmp_text.text = "Desconhecido"; 
        }else
        tmp_text.text = text;
    }

    public ItemObject GetInfo()
    {
        return this.paint;
    }

    public void SetInfo(ItemObject paint)
    {
        this.paint = paint;
    }

}

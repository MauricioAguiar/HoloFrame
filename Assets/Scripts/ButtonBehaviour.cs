using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{

    [SerializeField]
    private string newGameLevel = "ARScene";

    public void NewSceneSelector()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}

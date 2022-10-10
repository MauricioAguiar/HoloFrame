using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet_spawn : MonoBehaviour
{

    public GameObject[] objectsToSpawn;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) | AndroidInput.touchCountSecondary == 2)
        {
            int randomIndex = Random.Range(0, objectsToSpawn.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,11),5,Random.Range(-10, 11));

            Instantiate(objectsToSpawn[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}

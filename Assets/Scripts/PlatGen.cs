using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatGen : MonoBehaviour
{

    public GameObject platformPrefab;




    // Start is called before the first frame update
    void Start()
    {
        Vector3 SpawnPosition = new Vector3();
        for (int i = 0; i < 14; i++)
        {
            SpawnPosition.x = Random.Range(-65f, 65f);
            SpawnPosition.y += Random.Range(10f, 100f);

            Instantiate(platformPrefab, SpawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

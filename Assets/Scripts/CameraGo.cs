using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGo : MonoBehaviour
{

    public Transform ShlepaPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShlepaPos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, ShlepaPos.position.y, transform.position.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    float timer = 0;
    private bool go = false;
    public GameObject cut;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        go = true;
        cut.SetActive(false);
        cut.SetActive(true);
    }

    void Update()
    {
        if (go == true)
        {
            timer += Time.deltaTime;
        }

        if (timer >= 0.3f)
        {
            
            go = false;
            timer = 0;
            float RandX = Random.Range(-65f, 65f);
            float RandY = Random.Range(transform.position.y + 300f, transform.position.y + 500f);
            transform.position = new Vector3(RandX, RandY, 0);

        }
    }
}

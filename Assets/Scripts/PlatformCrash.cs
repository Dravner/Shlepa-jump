using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCrash : MonoBehaviour
{
    public float forceJump;
    int CrashCount = 0;
    public GameObject platformCrashPrefab;
    Vector3 SpawnPos = new Vector3();
    public Shlep poop;

    void Start()
    {

    }

    void FixedUpdate()
    {

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.relativeVelocity.y < 0)
        {
            Shlep.instance.Shlepa.velocity = Vector2.up * forceJump;
        }

    }



    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Dead")
        {

            if ((CrashCount < 3) && (poop.score >= 200))
            {
                
                CrashCount++;
                SpawnPos.x = Random.Range(34f, 168f);
                SpawnPos.y += Random.Range(500f, 800f);
                SpawnPos.z = 0;

                Instantiate(platformCrashPrefab, SpawnPos, Quaternion.identity);

            }
            else
            {
                float RandX = Random.Range(34f, 168f);
                float RandY = Random.Range(transform.position.y + 450f, transform.position.y + 650f);

                transform.position = new Vector3(RandX, RandY, 0);
            }
        }
    }



    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.name == "DeadInside1")
        {
            float RandX = Random.Range(34f, 168f);
            float RandY = Random.Range(transform.position.y - 30f, transform.position.y + 30f);


            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (collider.name == "DeadInside2")
        {
            float RandX = Random.Range(34f, 168f);
            float RandY = Random.Range(transform.position.y - 30f, transform.position.y + 30f);


            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (collider.name == "DeadInside3")
        {
            float RandX = Random.Range(34f, 168f);
            float RandY = Random.Range(transform.position.y - 30f, transform.position.y + 30f);


            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (collider.name == "DeadInside4")
        {
            float RandX = Random.Range(34f, 168f);
            float RandY = Random.Range(transform.position.y - 30f, transform.position.y + 30f);


            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}

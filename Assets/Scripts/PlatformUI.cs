using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUI : MonoBehaviour
{
    public float forceJump;
    public Rigidbody2D Shlepender;



    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.relativeVelocity.y < 0)
        {
            Shlepender.velocity = Vector2.up * forceJump;
        }

    }



    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Dead")
        {
            float RandX = Random.Range(-65f, 65f);
            float RandY = Random.Range(transform.position.y + 450f, transform.position.y + 650f);


            transform.position = new Vector3(RandX, RandY, 0);
        }
    }



    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.name == "DeadInside1")
        {
            float RandX = Random.Range(-65f, 65f);
            float RandY = Random.Range(transform.position.y - 30f, transform.position.y + 30f);


            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (collider.name == "DeadInside2")
        {
            float RandX = Random.Range(-65f, 65f);
            float RandY = Random.Range(transform.position.y - 30f, transform.position.y + 30f);


            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (collider.name == "DeadInside3")
        {
            float RandX = Random.Range(-65f, 65f);
            float RandY = Random.Range(transform.position.y - 30f, transform.position.y + 30f);


            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (collider.name == "DeadInside4")
        {
            float RandX = Random.Range(-65f, 65f);
            float RandY = Random.Range(transform.position.y - 30f, transform.position.y + 30f);


            transform.position = new Vector3(RandX, RandY, 0);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

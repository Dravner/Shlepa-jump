using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShlepaUI : MonoBehaviour
{
    float horizontal;
    public Rigidbody2D Shlepa;
    public static Shlep instance;
    public Transform ShlepaPos;
    public float score = 0;
    public Transform CameraPos;
    public GameObject Lose;
    public GameObject Shlepecki;
    public float HighScoreInt, HS;
    public GameObject NewRecord;

    void Start()
    {

    }


    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }

        Shlepa.velocity = new Vector2(Input.acceleration.x * 500f, Shlepa.velocity.y);

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.collider.name == "SwapL")
        {
            transform.position = new Vector3(87, ShlepaPos.position.y, ShlepaPos.position.z);
        }

        if (collision.collider.name == "SwapR")
        {
            transform.position = new Vector3(-87, ShlepaPos.position.y, ShlepaPos.position.z);
        }
    }





    public void Update()
    {

    }
}

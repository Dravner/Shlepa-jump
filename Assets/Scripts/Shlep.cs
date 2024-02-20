using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shlep : MonoBehaviour
{
    float horizontal;
    public Rigidbody2D Shlepa;
    public static Shlep instance;
    public Transform ShlepaPos;
    public Text ScoreText, Score2Text, HighScore;
    public float score = 0;
    public Transform CameraPos;
    public GameObject Lose;
    public GameObject Shlepecki;
    public float HighScoreInt, HS;
    public GameObject NewRecord;
    public GameObject pauseButton;

    void Start()
    {
        
        HighScoreInt = PlayerPrefs.GetFloat("HS");

        HS = HighScoreInt;

        if (instance == null)
        {
            instance = this;
        }
    }


    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }


        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        score = Mathf.Round(CameraPos.position.y) - 116;

        Shlepa.velocity = new Vector2(Input.acceleration.x * 500f, Shlepa.velocity.y);

        if (score > HighScoreInt)
        {
            HighScoreInt = score;
        }

        HighScore.text = HighScoreInt.ToString();

        PlayerPrefs.SetFloat("HS", HighScoreInt);

        ScoreText.text = score.ToString();

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Dead")
        {

            pauseButton.SetActive(false);
            Lose.SetActive(true);
            Shlepecki.SetActive(false);
            Score2Text.text = score.ToString();



            if (score <= HS)
            {
                NewRecord.SetActive(false);
            }
        }

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

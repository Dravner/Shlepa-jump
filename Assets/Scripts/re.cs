using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class re : MonoBehaviour
{
    public void restarLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

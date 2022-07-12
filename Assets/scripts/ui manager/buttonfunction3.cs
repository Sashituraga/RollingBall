using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonfunction3 : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

    }
    public void Back()
    {
        Debug.Log("EXIT button pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }

    public void Test()
    {
        Debug.Log("BT_A1");
    }
}

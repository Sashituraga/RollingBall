using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonfunction2 : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
    public void Back()
    {
        Debug.Log("EXIT button pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }

    public void Test()
    {
        Debug.Log("BT_A1");
    }

}

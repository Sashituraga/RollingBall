using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton3 : MonoBehaviour
{
    public void Back()
    {
        Debug.Log("quit button pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }

}

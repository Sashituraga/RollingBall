using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void Back()
    {
        Debug.Log("RESTART button pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //Array
    public int[] ages;
    //when you  press space key,debug.log all(for) in inspector.

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < ages.Length; i++)
            {
                Debug.Log(ages[i]);
            }
        }
    }
}

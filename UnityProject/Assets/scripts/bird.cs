using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public int jump = 100;
    public bool dead = false;

    public GameObject Score ,GameManager;

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Score.SetActive(true);
            GameManager.SetActive(true);
        }
    }
    void Dead()
    {

    }
    void Pass()
    {

    }

    private void Update()
    {
        Jump();
    }
}

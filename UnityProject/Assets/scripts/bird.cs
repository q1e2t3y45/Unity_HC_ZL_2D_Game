using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public int jump = 600;
    public bool dead = false;

    public GameObject Score ,GameManager;
    public Rigidbody2D Rigidbody2D;
    public gamemanager gamemanager;

    void Jump()
    {
        if (dead) return;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Score.SetActive(true);
            GameManager.SetActive(true);
            Rigidbody2D.Sleep();
            Rigidbody2D.AddForce(new Vector2(0, jump));
            Rigidbody2D.gravityScale = 6;
        }
        Rigidbody2D.SetRotation(3 * Rigidbody2D.velocity.y);
    }
    void Dead()
    {
        dead = true;
        gamemanager.GameOver();
    }
    void Pass()
    {

    }
    private void Update()
    {
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Dead();
    }
}

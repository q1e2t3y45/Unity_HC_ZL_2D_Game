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
    public AudioSource AudioSource;
    public AudioClip audiojump, audiohit, audioadd;

    void Jump()
    {
        if (dead) return;
        if (Input.GetKeyDown(KeyCode.Mouse0) && gamemanager.nightmare)
        {
            Score.SetActive(true);
            GameManager.SetActive(true);
            AudioSource.PlayOneShot(audiojump);
            Rigidbody2D.Sleep();
            Rigidbody2D.AddForce(new Vector2(0, jump));
            Rigidbody2D.gravityScale = 6;
        }
        Rigidbody2D.SetRotation(3 * Rigidbody2D.velocity.y);
    }
    void Dead()
    {
        dead = true;
        AudioSource.PlayOneShot(audiohit);
        gamemanager.GameOver();
    }
    void Pass()
    {
        gamemanager.GetPoint();
    }
    private void Update()
    {
        Jump();
    }

    private void Start()
    {
        Screen.SetResolution(720, 1280, false);
        gamemanager.buttonbasic.SetActive(true);
        gamemanager.buttonadvance.SetActive(true);
        gamemanager.buttonnightmare.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Dead();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "04_水管" || collision.gameObject.name == "04_水管 (1)")
        {
            Dead();
        }
        else
        {
            Pass();
        }
    }
}

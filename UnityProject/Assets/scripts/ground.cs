using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public float speed = 10f;
    public Transform trans;
    public bird bird;
    void Move()
    {
        if (bird.dead) return;
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
    private void Update()
    {
        Move();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public float speed = 3f;
    public Transform trans;
    void Move()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
    private void Update()
    {
        Move();
    }
}

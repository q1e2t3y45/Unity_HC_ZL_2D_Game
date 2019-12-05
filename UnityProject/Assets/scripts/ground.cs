using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public static float speed = 10f;
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

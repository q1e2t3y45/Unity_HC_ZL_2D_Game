using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public int score;
    public int bestscore;
    public GameObject pipe;

    void ClonePipe()
    {
        Vector3 PipePosition = new Vector3(2, Random.Range(1,-3), 0);
        Quaternion PipeQuaternion = new Quaternion(0, 0, 0, 0);
        Instantiate(pipe, PipePosition, PipeQuaternion);
    }

    void GetPoint()
    {

    }
    void BestScoreSet()
    {

    }
    void GameOver()
    {

    }

    private void Start()
    {
        InvokeRepeating("ClonePipe", 0 ,0.5f);
    }
}

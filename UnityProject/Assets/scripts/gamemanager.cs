using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public int score;
    public int bestscore;
    public GameObject pipe ,UI ,buttonbasic ,buttonadvance ,buttonnightmare;
    public Text scoretext ,bestscoretext;
    public ground ground;
    public bool basic = false, advance = false, nightmare = false;

    void ClonePipe()
    {
        Vector3 PipePosition = new Vector3(2, Random.Range(1,-3), 0);
        Quaternion PipeQuaternion = new Quaternion(0, 0, 0, 0);
        Instantiate(pipe, PipePosition, PipeQuaternion);
    }

    public void GetPoint()
    {
        score++;
        scoretext.text = score.ToString();
    }
    void BestScoreSet()
    {
        if (score > bestscore)
        {
            bestscore = score;
            PlayerPrefs.SetInt("Bestscore" ,bestscore);
        }
        bestscoretext.text = bestscore.ToString();
    }
    public void GameOver()
    {
        ground.speed = 0;
        UI.SetActive(true);
        BestScoreSet();
    }

    public void Replay()
    {
        Application.LoadLevel("123");
        ground.speed = 10f;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void choosenightmare()
    {
        nightmare = true;
        buttonbasic.SetActive(false);
        buttonadvance.SetActive(false);
        buttonnightmare.SetActive(false);
    }
    private void Start()
    {
        InvokeRepeating("ClonePipe", 0.5f ,0.5f);
        bestscore = PlayerPrefs.GetInt("Bestscore");
    }
}

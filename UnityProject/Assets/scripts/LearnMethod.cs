using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    void Drive(int speed = 0, string direction = "北", string gear = "D")
    {
        print("車子正在往" + direction + "開，時速:" + speed + "，" + gear + "檔");
    }

    private void Start()
    {
        Drive();
        Drive(10, "東");
        Drive(20, gear: "R");
    }
}

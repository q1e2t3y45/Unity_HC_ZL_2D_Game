using UnityEngine;

public class learnif : MonoBehaviour
{
    public int combo = 0;

    private void Update()
    {
        if (combo >= 150)
        {
            print("attack * 10");
        }
        else if (combo >= 100)
        {
            print("attack * 5");
        }
        else if(combo >= 50)
        {
            print("attack * 2");
        }
    }
}

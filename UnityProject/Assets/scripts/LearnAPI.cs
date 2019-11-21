using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("123");
        print("123");
        print(Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.inputString);
        print(Input.GetKeyDown("s"));
    }
}

using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform TestTransform;
    public SpriteRenderer TestSprite;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("123");
        print("123");
        print(Random.value);
        print(TestTransform.position);
        TestTransform.position = new Vector3(0, 0, 0);
        TestTransform.Rotate(0, 0, 0);
        TestTransform.localScale = new Vector3(0, 0, 0);
        TestSprite.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.inputString);
        print(Input.GetKeyDown("s"));
    }
}

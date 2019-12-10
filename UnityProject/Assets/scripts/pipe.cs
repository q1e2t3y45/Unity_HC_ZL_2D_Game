
public class pipe : ground
{
    void OnBecameInvisible()
    {
        Destroy(gameObject, 1);
    }
}

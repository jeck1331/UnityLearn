using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowBound = -10.0f;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowBound)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }
}

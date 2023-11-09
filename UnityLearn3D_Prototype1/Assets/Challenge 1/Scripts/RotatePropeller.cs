
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private float speedRotate = 360.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speedRotate);
    }
}

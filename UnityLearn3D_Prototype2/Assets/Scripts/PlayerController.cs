using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;

    private float speed = 20.0f;
    private float xRange = 20.0f;

    public GameObject projectablePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectablePrefab, transform.position, projectablePrefab.transform.rotation);
        }
    }
}

using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float horizontalInputSpeed = 10f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!Manager.isGameStarted)
            return;

        float xMovement = Input.GetAxis("Horizontal") * horizontalInputSpeed * Time.deltaTime;
        float newXPos = Mathf.Clamp(transform.position.x + xMovement, Constants.LEFT_BOUNDARY, Constants.RIGHT_BOUNDARY);
        transform.position = new Vector3(newXPos, transform.position.y, transform.position.z);

        rb.velocity = new Vector3(0, 0, movementSpeed);

        
    }
}

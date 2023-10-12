using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float moveDistance = 2.0f; 
    private Vector3 initialPosition;
    private float direction = 1;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float newY = initialPosition.y + direction * Mathf.PingPong(Time.time * moveSpeed, moveDistance);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}

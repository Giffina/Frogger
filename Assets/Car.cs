using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    float speed = 1f;
    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.up.x, transform.up.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
}

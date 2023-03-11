using UnityEngine;

public class car : MonoBehaviour
{
    public Rigidbody2D rb;
   public float speed;

    void start()
    {
        speed = KeepData.carSpeed;
    }
    void FixedUpdate()
    {
       Vector2 forward = new Vector2 (transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * KeepData.carSpeed);
    }
}

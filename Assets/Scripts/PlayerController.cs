using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * move * speed * Time.deltaTime);

        float clampedX = Mathf.Clamp(transform.position.x, -7f, 7f);

        transform.position = new Vector2(clampedX, transform.position.y);
    }
}

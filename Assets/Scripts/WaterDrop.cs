using UnityEngine;

public class WaterDrop : MonoBehaviour
{
    public float fallSpeed = 4f;

    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < -6f)
        {
            ResetPosition();
        }
    }

    void ResetPosition()
    {
        float randomX = Random.Range(-7f, 7f);

        transform.position = new Vector2(randomX, 6f);
    }
}

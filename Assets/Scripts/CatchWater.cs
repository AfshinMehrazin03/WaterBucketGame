using UnityEngine;

public class CatchWater : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            score++;

            collision.transform.position = new Vector2(Random.Range(-7f, 7f), 6f);
        }
    }
}

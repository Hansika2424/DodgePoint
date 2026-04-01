using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Debug.Log("Player died!");
            Destroy(gameObject);
        }
    }
}
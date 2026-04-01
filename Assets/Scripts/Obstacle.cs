using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Collided with: {collision.gameObject.name}, Tag: {collision.tag}");
        
        if (collision.CompareTag("Border"))
        {
            Debug.Log("Destroying obstacle!");
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Player"))
        {   
            Debug.Log("Player collision detected! Starting destruction...");
            Destroy(collision.gameObject); // This should work
            Debug.Log("Destroy command sent with 1 second delay");
        }
    }
}
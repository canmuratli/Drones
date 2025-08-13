using UnityEngine;
using UnityEngine.Audio;

public class DroneManager : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager.playerHealth = 100; // Initialize player health
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Logo"))
        {
            gameManager.playerPoints += 10; // Increment player points by 10
            Destroy(other.gameObject); // Destroy the logo object
        }
        else if (other.CompareTag("Ring"))
        {
            gameManager.playerPoints += 5; 
        }   
        else if (other.CompareTag("Health"))
        {
            gameManager.playerHealth += 10; // Decrement player health by 10
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ring"))
        {
            Destroy(other.gameObject);
            gameManager.RingCount--; // Decrement the ring count when a ring is exited
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Buildings"))
        {
            gameManager.playerHealth -= 10; // Decrement player health by 10
        }   
    }
}

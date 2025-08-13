using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerPoints = 0;
    public int playerHealth = 100;
    public int RingCount;
    public Text pointsText;
    public Text healthText;
    void Start()
    {
        GameObject[] Rings;
        Rings = GameObject.FindGameObjectsWithTag("Ring");
       
        if (Rings.Length == 0)
        {
            Debug.Log("No GameObjects are tagged with 'Enemy'");
        }
        else {
            RingCount = Rings.Length;
            Debug.Log("There are " + RingCount + " GameObjects tagged with 'Ring'");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Update the UI text elements with the current player points and health
        pointsText.text = "Points: " + playerPoints.ToString();
        healthText.text = "Health: " + playerHealth.ToString();
        // Example of modifying player points and health
        if (playerHealth <= 0 || Input.GetKeyDown(KeyCode.R) || RingCount <= 0)
        {
            SceneManager.LoadScene("level"); // Load the Game Over scene if health is 0 or less
        }

    }
}

using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerPoints = 0;
    public int playerHealth = 100;
    public Text pointsText;
    public Text healthText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update the UI text elements with the current player points and health
        pointsText.text = "Points: " + playerPoints.ToString();
        healthText.text = "Health: " + playerHealth.ToString();
        // Example of modifying player points and health
       

    }
}

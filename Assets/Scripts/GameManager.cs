using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameEnded;

    public GameObject gameOverUI;
    public GameObject gameWonUI;


    void Start()
    {
        GameEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameEnded)
            return;

        if(PlayerStats.Rounds <= 0)
        {
            EndGame();
        }
        
        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameEnded = true;

        if (PlayerStats.Lives <= 0)
        {
            gameOverUI.SetActive(true);
        }
        else
        {
            gameWonUI.SetActive(true);
        }

        
    }
}

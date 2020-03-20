using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Retry()
    {
        SoundEffect.KillEffect = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SoundEffect.KillEffect = true;
        SceneManager.LoadScene(0);
    }
}

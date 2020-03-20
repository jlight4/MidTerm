using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SoundEffect.KillEffect = true;
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        SoundEffect.KillEffect = true;
        Application.Quit();
    }
}

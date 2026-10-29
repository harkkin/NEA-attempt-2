using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}

public class settings : MonoBehaviour
{
    public void SettingsMenu()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
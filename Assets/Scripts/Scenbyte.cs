using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmeny : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Game_a25kevja");
    }

    public void Quitgame()
    {
        Application.Quit();
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("Startmeny");
    }

    public void Bakgrundscene()
    {
        SceneManager.LoadScene("Bakgrund");
    }
}


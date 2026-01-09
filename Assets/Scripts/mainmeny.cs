using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmeny : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Game_a25kevja");
    }
    
    public void Quitgame()
        {
        Application.Quit();
        }
}

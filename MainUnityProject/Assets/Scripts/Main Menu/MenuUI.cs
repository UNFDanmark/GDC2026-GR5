using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Manor Room 1");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
    
}

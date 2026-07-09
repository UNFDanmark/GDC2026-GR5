using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMainMenu : MonoBehaviour
{
    public void QuitToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

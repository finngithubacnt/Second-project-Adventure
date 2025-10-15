using UnityEngine;
using UnityEngine.SceneManagement;

public class startscreen : MonoBehaviour
{
  
    public void swapSceens()
    {
        SceneManager.LoadScene("Dialog");
        Debug.Log("Swapping Scenes");
    }


    public void QuitButton()
    {
        Debug.Log("Quit the game!");
        Application.Quit();

    }
}

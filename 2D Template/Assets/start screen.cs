using UnityEngine;
using UnityEngine.SceneManagement;

public class startscreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void swapSceens()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Swapping Scenes");
    }


    public void QuitButton()
    {
        Debug.Log("Quit the game!");
        Application.Quit();

    }
}

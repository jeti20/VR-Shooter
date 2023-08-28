using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Ta metoda bêdzie wywo³ywana po klikniêciu przycisku
    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Website()
    {
        Application.OpenURL("https://github.com/jeti20");
    }

    public void Exit()
    {
        Application.Quit();
    }

}

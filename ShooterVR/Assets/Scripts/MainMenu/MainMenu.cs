using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //bool gameON = GameManager.instance.gameON;

    // Ta metoda bêdzie wywo³ywana po klikniêciu przycisku
    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public GameObject menu;
    public void StartRound()
    {
        GameManager.instance.timeLeft = 10;
        menu.SetActive(false);
        Debug.Log("StartRound: 10");
    }

    /*private void Update()
    {
        if (gameON == true)
        {
            
        }
        else
        {
            menu.SetActive(true);
        }
    }*/

}

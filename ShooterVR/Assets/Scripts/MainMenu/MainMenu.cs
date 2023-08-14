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

    public GameObject menu;
    public void StartRound()
    {
        GameManager.instance.timeLeft = 10;    
        Debug.Log("StartRound: 10");
        GameManager.instance.amoutOfBullets = 0;
        GameManager.instance.score = 0;
    }

    private void Update()
    {
        if (GameManager.instance.timeLeft != 0)
        {
            menu.SetActive(false);
        }
        else
        {
            menu.SetActive(true);
            Debug.Log("KoniecGryMenuSiePojawia");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuInGame : MonoBehaviour
{
    public GameObject menu;
    public InputActionProperty showButton;
    public Transform head;
    public float spawnDistance = 2f;

    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    void Update()
    {
        if  (showButton.action.WasPressedThisFrame())
        {
            Debug.Log("MenuOpen");
            menu.SetActive(!menu.activeSelf);

            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;

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

    public void StartRound()
    {
        GameManager.instance.timeLeft = 60;
        Debug.Log("StartRound: 10");
        GameManager.instance.amoutOfBullets = 0;
        GameManager.instance.score = 0;
    }

}

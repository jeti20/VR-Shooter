using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set; }

    public float score;
    public float amoutOfBullets;
    public int timeLeft = 0;
    //public bool gameON = false;
    
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {

            instance = this;
        }
    }
}

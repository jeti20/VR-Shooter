using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float score;
    public float amoutOfBullets;
    public int timeLeft = 10;
    public bool timeOver = false;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    
    
}

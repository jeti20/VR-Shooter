using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;
    public int amoutOfBullets;

    private void Awake()
    {
        instance = this;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float score;
    public float amoutOfBullets;

    private void Awake()
    {
        instance = this;
    }

    
    
}

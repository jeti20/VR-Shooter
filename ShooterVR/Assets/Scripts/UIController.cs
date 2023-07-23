using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIController : MonoBehaviour
{//VR
    
    public GameObject scoreText;
    public GameObject bulletsText;
    public TextMeshProUGUI accuracyText;
    public float accuracy;

    private void Start()
    {
        
    }

    private void Update()
    {
        
        accuracy = GameManager.instance.score / GameManager.instance.amoutOfBullets;
        ScoreManager();
        Debug.Log(accuracy);
    }

    public void ScoreManager()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.instance.score;
        bulletsText.GetComponent<TextMeshProUGUI>().text = "Bullets: " + GameManager.instance.amoutOfBullets;
        
        accuracyText.GetComponent<TextMeshProUGUI>().text = accuracy.ToString("Accuracy: " + accuracy);
    }

    public void BulletsAmount()
    {
        bulletsText.GetComponent<TextMeshProUGUI>().text = "Bullets: " + GameManager.instance.amoutOfBullets;
    }
}

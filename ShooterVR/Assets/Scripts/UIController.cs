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
    public TextMeshProUGUI timeText;
    private float accuracy;

    private void Update()
    {
        accuracy = GameManager.instance.score / GameManager.instance.amoutOfBullets;
        ScoreManager();
        Timer();


    }

    public void ScoreManager()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.instance.score.ToString();
        bulletsText.GetComponent<TextMeshProUGUI>().text = "Bullets: " + GameManager.instance.amoutOfBullets.ToString();
        accuracyText.GetComponent<TextMeshProUGUI>().text = "Accuracy: " + accuracy.ToString("F2");
    }

    public void Timer()
    {
        timeText.GetComponent<TextMeshProUGUI>().text = "Time: " + GameManager.instance.timeLeft.ToString();
    }

}

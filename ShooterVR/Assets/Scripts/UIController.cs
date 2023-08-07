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

    private void Update()
    {
        accuracy = GameManager.instance.score / GameManager.instance.amoutOfBullets;
        ScoreManager();
        Debug.Log(accuracy);
    }

    public void ScoreManager()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.instance.score.ToString("F2");
        bulletsText.GetComponent<TextMeshProUGUI>().text = "Bullets: " + GameManager.instance.amoutOfBullets.ToString("F2");
        accuracyText.GetComponent<TextMeshProUGUI>().text = "Accuracy: " + accuracy.ToString("F2");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    //public Button scoreText;
    public Canvas scoreManage;
    public GameObject scoreText;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        score = 0;
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        score += 50; //add 100 to score
        scoreText.GetComponentInChildren<TextMeshProUGUI>().text = "Score: " + score; 
        Debug.Log("Score: " + score);
    }
}

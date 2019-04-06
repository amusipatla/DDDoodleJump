using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayHighScore : MonoBehaviour
{
    TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText = GetComponent<TextMeshProUGUI>();

        int currHighScore = initializeHighScore.highScore;
        int yourScore = scoreScript.currentScore;

        if (currHighScore < yourScore)
        {
            initializeHighScore.highScore = yourScore;
            currHighScore = yourScore;
            highScoreText.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            highScoreText.color = new Color32(0, 0, 0, 255);
        }
        highScoreText.SetText("{0}", currHighScore);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

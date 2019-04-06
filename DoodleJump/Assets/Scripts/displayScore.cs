using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayScore : MonoBehaviour
{
    TextMeshProUGUI yourScoreText;

    // Start is called before the first frame update
    void Start()
    {
        yourScoreText = GetComponent<TextMeshProUGUI>();

        int currHighScore = initializeHighScore.highScore;
        int yourScore = scoreScript.currentScore;

        if (currHighScore < yourScore)
        {
            yourScoreText.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            yourScoreText.color = new Color32(0, 0, 0, 255);
        }

        yourScoreText.SetText("{0}", yourScore);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

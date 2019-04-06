using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreScript : MonoBehaviour
{

    public static int currentScore = 0;
    TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.SetText("Current Score: {0}", currentScore);
    }
}

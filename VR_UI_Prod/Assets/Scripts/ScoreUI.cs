using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreTxt.text = "Score: 0";
    }

    private void Update()
    {
        scoreTxt.text = "Score: " + score;
    }
}

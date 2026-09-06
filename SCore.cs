using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SCore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
    public TMP_Text scoreText;
    private void Start()
    {
        score = 0;  
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}

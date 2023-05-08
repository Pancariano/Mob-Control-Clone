using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public TMP_Text scoreText;
    public static int score;

    void Update()
    {
        scoreText.text = score.ToString();
    }
}

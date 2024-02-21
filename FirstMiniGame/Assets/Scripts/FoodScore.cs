using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodScore : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public int score = 0;

    private void FixedUpdate()
    {
        scoretext.text = "Food: " + score.ToString();
    }
}

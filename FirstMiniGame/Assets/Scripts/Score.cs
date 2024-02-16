using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI score;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");
    }
}

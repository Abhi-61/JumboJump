using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: \n" + player.position.z.ToString("0");
        
    }
}

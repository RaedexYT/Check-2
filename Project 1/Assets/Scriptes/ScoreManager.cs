using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    public TextMeshProUGUI scoretext;
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag=="Coin")
        {
            score++;
            Destroy(col.gameObject);
            scoretext.text = score.ToString();
            PlayerPrefs.SetInt("savedscore", score);
            if(score> PlayerPrefs.GetInt("Highscore"))
            {
                PlayerPrefs.SetInt("Highscore", score);
            }

        }

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

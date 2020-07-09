using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Getscore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI Highscore;
    void Update()
    {
        score.text = PlayerPrefs.GetInt("savedscore").ToString();
        Highscore.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
}

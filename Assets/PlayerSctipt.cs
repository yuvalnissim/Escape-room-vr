using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerSctipt : MonoBehaviour
{
    public int count;
    public Text countText;

    public float highScore;
    public Text highScoreText;
    public Text menuScore;
    //public GameObject menuPlayerName;



    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
        this.count = 0;
        highScore = PlayerPrefs.GetInt("High Score", 0);
        //highScoreText.text = "Highest score is: " + highScore.ToString();
        Debug.Log("High Score =" + highScore);
        
    }

    // Increase by 1 every time the user hit space
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            count++;
        }
        if (highScore < count)
        {
            PlayerPrefs.SetInt("Highest Score:", count);
            PlayerPrefs.Save();
        }
    }

    void SetCountText() 
    {
        //countText.text = "Count: " + count.ToString();
        Debug.Log(countText);
        //highScoreText.text = "Highest Score Is " + highScore.ToString();
        Debug.Log(highScoreText);
        
    }

}

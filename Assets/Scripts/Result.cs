using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {

    private int score;
    private float avgScore;
    private Text scoreText;
    private Text avgScoreText;


    void Start () {
        DontDestroyOnLoad(gameObject);
        score = Score.score;
        avgScore = score / (Score.sekundy + Score.minuty * 60);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	void Update () {
        if(scoreText == null)
        {
            scoreText = GameObject.Find("scoreText").GetComponent<Text>();
        }
        else
        {
            scoreText.text = "Score: " + score.ToString();
        }
        if (avgScoreText == null)
        {
            avgScoreText = GameObject.Find("avgScoreText").GetComponent<Text>();
        }
        else
        {
            avgScoreText.text = "AVG FPS: " + avgScore.ToString();
        }
    }
}

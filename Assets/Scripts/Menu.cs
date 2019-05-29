using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    [Header("Menu Główne")]
    public Text start;
    public Text exit;
    public Text pl;
    public Text en;

    [Header("Wyniki")]
    public Text result;
    public Text score;
    public Text avg_fps;
    
    void Start()
    {
        Cursor.visible = true;
    }

	void Update () {
		start.text = GUIStrings.START;
		exit.text = GUIStrings.EXIT;
		pl.text = GUIStrings.POLISH;
		en.text = GUIStrings.ENGLISH;

        result.text = GUIStrings.RESULT;

        if (PlayerPrefs.HasKey("Score"))
        {
            score.text = GUIStrings.SCORE + PlayerPrefs.GetInt("Score").ToString();
            avg_fps.text = GUIStrings.AVG_FPS + PlayerPrefs.GetFloat("AVG_FPS").ToString();
        }
        else
        {
            score.text = GUIStrings.RESULT_NULL;
            avg_fps.text = GUIStrings.RESULT_NULL2;
        }
    }

	public void RunBenchmark () {
		SceneManager.LoadScene ("Benchmark");
	}
    
	public void Exit () {
		Application.Quit ();
		Debug.Log ("Wyjście z gry");
	}
}

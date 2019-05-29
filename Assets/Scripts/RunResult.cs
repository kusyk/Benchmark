using UnityEngine;
using System.Collections;

public class RunResult : MonoBehaviour {

    public GameObject result;
    
	void Start () {
        PlayerPrefs.SetInt("Score", Score.score);
        PlayerPrefs.SetFloat("AVG_FPS", (Score.score / (Score.sekundy + Score.minuty * 60)));
        PlayerPrefs.Save();
        Application.LoadLevel(0);
    }
	
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public static int score = 0;
	public Text scoreText;

	public static float sekundy = 0;
	public static int minuty = 0;
	public Text timeText;

	private string dwukropek = ":";

	void Start(){
		Cursor.visible = false;
        score = 0;
        minuty = 0;
        sekundy = 0;
	}

    void FixedUpdate()
    {
        sekundy += Time.deltaTime;
    }


	void Update () {
		score++;

		if (sekundy >= 60) {
			minuty++;
			sekundy = 0;
		}

		if (sekundy < 10) {
			dwukropek = ":0";
		} else {
			dwukropek = ":";
		}

		scoreText.text = GUIStrings.SCORE + score;

		if (minuty == 0) {
			if (sekundy < 10) {
				timeText.text = GUIStrings.TIME + "0" + dwukropek + (int)(sekundy);			
			} else {
				timeText.text = GUIStrings.TIME + "0:" + (int)(sekundy);
			}
		} else {
			timeText.text = GUIStrings.TIME + minuty + dwukropek + (int)(sekundy);
		}
	}
}
